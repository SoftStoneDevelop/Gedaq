

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
    internal partial interface INpgsqlPathListpathListD1
    {
    }
    
    internal partial class NpgsqlPathListpathListD1 : INpgsqlPathListpathListD1
    {


#region TestData

        private readonly NpgsqlPathpathListD1E2M[] _testData = new NpgsqlPathpathListD1E2M[]
        {
            new NpgsqlPathpathListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5657413981441404d, y: 0.205814630188196d), new NpgsqlTypes.NpgsqlPoint(x: 0.24586167664601455d, y: 0.7145572616062995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911152467689244d, y: 0.052445982867998286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2984092304606465d, y: 0.5748764430855803d), new NpgsqlTypes.NpgsqlPoint(x: 0.3707974991502212d, y: 0.1210401645557505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571504951529232d, y: 0.8178115060629055d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6969896774477617d, y: 0.9278725139789142d), new NpgsqlTypes.NpgsqlPoint(x: 0.2941793576224502d, y: 0.75085073968679d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381210530832792d, y: 0.28476372417626883d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9204833483791255d, y: 0.5310235200129102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6950547931898167d, y: 0.5741465080044899d), new NpgsqlTypes.NpgsqlPoint(x: 0.2825840491820194d, y: 0.6145626372876092d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6717189519010267d, y: 0.5907412771958263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547175547873916d, y: 0.4718477581927213d), new NpgsqlTypes.NpgsqlPoint(x: 0.19016269977951372d, y: 0.6220577393152598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29995676858623255d, y: 0.14418694197193715d), new NpgsqlTypes.NpgsqlPoint(x: 0.06420469992345201d, y: 0.6042715199259892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221763584601185d, y: 0.8237231180406616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9167982619007338d, y: 0.813449034434384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229163476021514d, y: 0.12978367051700657d), new NpgsqlTypes.NpgsqlPoint(x: 0.053909152009417816d, y: 0.21254405040720048d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03160349520084882d, y: 0.8744270646455133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8050452937814006d, y: 0.025293618451568967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002984844734491d, y: 0.407200308424028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7727850677964789d, y: 0.7722464892312831d), new NpgsqlTypes.NpgsqlPoint(x: 0.3854272496183745d, y: 0.24545438785025264d), new NpgsqlTypes.NpgsqlPoint(x: 0.435370583873687d, y: 0.7958602017423008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6106079256585609d, y: 0.6320542051206659d), new NpgsqlTypes.NpgsqlPoint(x: 0.49800166848507743d, y: 0.2244214798905938d), new NpgsqlTypes.NpgsqlPoint(x: 0.26588709049528014d, y: 0.11751950837459191d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.279656514182017d, y: 0.3744446442691658d), new NpgsqlTypes.NpgsqlPoint(x: 0.07527420885575953d, y: 0.34715045737649497d), new NpgsqlTypes.NpgsqlPoint(x: 0.4854783445294094d, y: 0.015445331156527353d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12170129893199133d, y: 0.9229013941853723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807689541021029d, y: 0.5407782419239475d), new NpgsqlTypes.NpgsqlPoint(x: 0.752052273200321d, y: 0.6423539391155144d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7398499587758843d, y: 0.6904674307432268d), new NpgsqlTypes.NpgsqlPoint(x: 0.1477457729046766d, y: 0.6359111864116469d), new NpgsqlTypes.NpgsqlPoint(x: 0.6790965451466634d, y: 0.07547981510800772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4486308898936271d, y: 0.6183950857172763d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041642446667621d, y: 0.9743514930600411d), new NpgsqlTypes.NpgsqlPoint(x: 0.44773918894613496d, y: 0.22960410193416314d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6633158778583338d, y: 0.5560745809057636d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672090698930101d, y: 0.2762508537797934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8582912346393067d, y: 0.9158265938560886d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10582476983556788d, y: 0.618774981564244d), new NpgsqlTypes.NpgsqlPoint(x: 0.34835024420109584d, y: 0.5526201594306386d), new NpgsqlTypes.NpgsqlPoint(x: 0.4442796559310209d, y: 0.6533280310455513d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8516233971719755d, y: 0.09837410180758355d), new NpgsqlTypes.NpgsqlPoint(x: 0.36199126149950744d, y: 0.5787930576397657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827755639463278d, y: 0.3293591140785911d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12713407399365684d, y: 0.7411815735907372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424973021561298d, y: 0.9294348241418577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3837091652462935d, y: 0.9950764146552902d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25299838991503865d, y: 0.3143112290846761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8110899401393165d, y: 0.13137852988667087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563735747261253d, y: 0.8099349684435573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20730878798588948d, y: 0.2745138995270934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5612993059013022d, y: 0.4784221044387075d), new NpgsqlTypes.NpgsqlPoint(x: 0.771562623278344d, y: 0.46753637965431893d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17191761393616822d, y: 0.40703392573959196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211293235340875d, y: 0.44095717392711675d), new NpgsqlTypes.NpgsqlPoint(x: 0.45650409905529543d, y: 0.814489972485382d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9234012863231595d, y: 0.12000682836974153d), new NpgsqlTypes.NpgsqlPoint(x: 0.7057398609976508d, y: 0.1132464276752968d), new NpgsqlTypes.NpgsqlPoint(x: 0.19764835817783d, y: 0.026292353193818174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34293174304588736d, y: 0.35087173551866346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6601981649982633d, y: 0.948555853343653d), new NpgsqlTypes.NpgsqlPoint(x: 0.04892074891972087d, y: 0.22709092461571434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07848782864252557d, y: 0.03580263496318048d), new NpgsqlTypes.NpgsqlPoint(x: 0.33308768934782274d, y: 0.6956270184765483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875767534613129d, y: 0.5821580854323082d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33882917321959327d, y: 0.784656039834782d), new NpgsqlTypes.NpgsqlPoint(x: 0.327736253555294d, y: 0.846742462092269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8452793358099358d, y: 0.4392736852731236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35483076595985075d, y: 0.697311655922352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5493014758825258d, y: 0.6522555810061197d), new NpgsqlTypes.NpgsqlPoint(x: 0.2933539656078099d, y: 0.8400499374433571d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4835350610578599d, y: 0.8687498813175022d), new NpgsqlTypes.NpgsqlPoint(x: 0.6921246301262375d, y: 0.2938137005519883d), new NpgsqlTypes.NpgsqlPoint(x: 0.07904116952982376d, y: 0.314581551592789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6280365453825016d, y: 0.9107689078725169d), new NpgsqlTypes.NpgsqlPoint(x: 0.7348999107260087d, y: 0.6242334151017179d), new NpgsqlTypes.NpgsqlPoint(x: 0.264262241992247d, y: 0.7782981731400467d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8675434370718094d, y: 0.2576354718436994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457999432922119d, y: 0.9109858825947688d), new NpgsqlTypes.NpgsqlPoint(x: 0.07987736699224701d, y: 0.4663684205918587d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8645499062802946d, y: 0.43558243461140655d), new NpgsqlTypes.NpgsqlPoint(x: 0.16242665122810063d, y: 0.8276504112431499d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496753125876147d, y: 0.22715595846164272d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5582286555528417d, y: 0.3471109358159691d), new NpgsqlTypes.NpgsqlPoint(x: 0.46724085863961584d, y: 0.7449159999970201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797197193434668d, y: 0.562217816600702d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19067329892609286d, y: 0.5687012667224413d), new NpgsqlTypes.NpgsqlPoint(x: 0.602739922748604d, y: 0.45061734586243596d), new NpgsqlTypes.NpgsqlPoint(x: 0.2904247541830782d, y: 0.4739569273875228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44636628439578685d, y: 0.8330681506079217d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945601074588854d, y: 0.5049873220972879d), new NpgsqlTypes.NpgsqlPoint(x: 0.44024101150033157d, y: 0.6344836222360359d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7326497215949332d, y: 0.16660606355167118d), new NpgsqlTypes.NpgsqlPoint(x: 0.14540802463402225d, y: 0.014387934729999663d), new NpgsqlTypes.NpgsqlPoint(x: 0.29301384665301866d, y: 0.9422631252080086d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20512190258839424d, y: 0.49490476717505405d), new NpgsqlTypes.NpgsqlPoint(x: 0.15389497854062995d, y: 0.78049240235192d), new NpgsqlTypes.NpgsqlPoint(x: 0.9960565549542423d, y: 0.7173228152999366d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.642073055508632d, y: 0.5847384741137537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304664047694822d, y: 0.8854630735005552d), new NpgsqlTypes.NpgsqlPoint(x: 0.30369479709116387d, y: 0.6045303721113325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.131894926681265d, y: 0.6922313663873654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022232643025043d, y: 0.5959742266612944d), new NpgsqlTypes.NpgsqlPoint(x: 0.04899321289881142d, y: 0.2610682285235374d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36733516260130716d, y: 0.933075141130843d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786586985127858d, y: 0.2535082219792695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014582111436532d, y: 0.6031924742630053d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9233160647632399d, y: 0.4454736530600675d), new NpgsqlTypes.NpgsqlPoint(x: 0.11928244981434488d, y: 0.8462785889881265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988819481388337d, y: 0.22523799604085393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.57712983131187d, y: 0.5599296020495427d), new NpgsqlTypes.NpgsqlPoint(x: 0.07618509916703664d, y: 0.6393216132641812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3229277960457645d, y: 0.4826372221938404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8156060575799033d, y: 0.4672261498167788d), new NpgsqlTypes.NpgsqlPoint(x: 0.8603379479104679d, y: 0.4673796437810339d), new NpgsqlTypes.NpgsqlPoint(x: 0.1827997740050823d, y: 0.3994814154429751d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5319170885008747d, y: 0.6025569691625733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4318449139244236d, y: 0.4983435101511846d), new NpgsqlTypes.NpgsqlPoint(x: 0.4924233695641569d, y: 0.21691988980341115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8655092534394222d, y: 0.3981943709478455d), new NpgsqlTypes.NpgsqlPoint(x: 0.11313305601992973d, y: 0.24273918837098218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9296357268015719d, y: 0.1801670900792064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7533862173355045d, y: 0.783812371259572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899086171535153d, y: 0.7298859258785718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4117239953606854d, y: 0.11185426641662688d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8070562687292404d, y: 0.7759835815248831d), new NpgsqlTypes.NpgsqlPoint(x: 0.25456670464432385d, y: 0.08436831736511163d), new NpgsqlTypes.NpgsqlPoint(x: 0.03691434528292903d, y: 0.11362456170414836d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311554833395575d, y: 0.1914573026271219d), new NpgsqlTypes.NpgsqlPoint(x: 0.28916636701967047d, y: 0.7198140732820878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146491201104454d, y: 0.4226074684230491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4594952799978329d, y: 0.9483660856944336d), new NpgsqlTypes.NpgsqlPoint(x: 0.46259687454932596d, y: 0.9611303713470368d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154009011100822d, y: 0.23349340945312191d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9660842552549274d, y: 0.7017997714597412d), new NpgsqlTypes.NpgsqlPoint(x: 0.13289594176016517d, y: 0.9688184778330827d), new NpgsqlTypes.NpgsqlPoint(x: 0.8232726155119398d, y: 0.8885838507062686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754284578877038d, y: 0.44117143857716135d), new NpgsqlTypes.NpgsqlPoint(x: 0.17862390304685039d, y: 0.9415165588858854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8170328838778397d, y: 0.33138562462104926d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015551573669249086d, y: 0.45492977503106447d), new NpgsqlTypes.NpgsqlPoint(x: 0.34003476821157763d, y: 0.24762778948868758d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512413212140201d, y: 0.8065047730851626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7529733191154528d, y: 0.8314517288227392d), new NpgsqlTypes.NpgsqlPoint(x: 0.07773112031391038d, y: 0.22242774507286467d), new NpgsqlTypes.NpgsqlPoint(x: 0.42447084111712086d, y: 0.9406784069483253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6630939515565625d, y: 0.7841658439109873d), new NpgsqlTypes.NpgsqlPoint(x: 0.038783754823732086d, y: 0.499486301747878d), new NpgsqlTypes.NpgsqlPoint(x: 0.5569497506740082d, y: 0.21910128355951275d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37603281748877015d, y: 0.9331468619731912d), new NpgsqlTypes.NpgsqlPoint(x: 0.17147419235594197d, y: 0.9012863393089869d), new NpgsqlTypes.NpgsqlPoint(x: 0.04333762821384801d, y: 0.03795465220816241d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08546674853087188d, y: 0.7687030212028263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668531766750367d, y: 0.6641541290652849d), new NpgsqlTypes.NpgsqlPoint(x: 0.5927812503325675d, y: 0.9197774698830188d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07515453834644259d, y: 0.5038847530090357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604564323199297d, y: 0.2696017246694412d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470061056730023d, y: 0.08479743601611511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.535567644396764d, y: 0.5827484040229155d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642282500288285d, y: 0.8650409708415104d), new NpgsqlTypes.NpgsqlPoint(x: 0.23242972201652368d, y: 0.10821877391691592d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.827981626085602d, y: 0.15083868976693116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459995999044904d, y: 0.5986292144785101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051334189423597d, y: 0.5827302375939869d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8936302437729914d, y: 0.6874606852031617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515592959001514d, y: 0.37083992630899265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923035158080368d, y: 0.5576580584134967d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8906941076923343d, y: 0.6572120383969692d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652829214270926d, y: 0.37259943691817177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3873162809289469d, y: 0.9726732604670614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7475506937668436d, y: 0.9892883279550092d), new NpgsqlTypes.NpgsqlPoint(x: 0.49787887900317385d, y: 0.14536402084789035d), new NpgsqlTypes.NpgsqlPoint(x: 0.2637537249265871d, y: 0.9290950664822016d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23631578236794826d, y: 0.9243047670969838d), new NpgsqlTypes.NpgsqlPoint(x: 0.3264454871708584d, y: 0.4460751019309096d), new NpgsqlTypes.NpgsqlPoint(x: 0.4926174455553527d, y: 0.40636400577337906d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5187418914298327d, y: 0.34241665367769003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143992675399782d, y: 0.0302666212565309d), new NpgsqlTypes.NpgsqlPoint(x: 0.042245617239331845d, y: 0.9559699727269926d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6707087176862797d, y: 0.20724301090075004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6525898696271942d, y: 0.38421598819241876d), new NpgsqlTypes.NpgsqlPoint(x: 0.533063226189909d, y: 0.9221342969804504d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14317386528098608d, y: 0.06202397370524415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8703297772813291d, y: 0.17876053894475097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388646411020478d, y: 0.22401118584728386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49149921086701154d, y: 0.046944387136630294d), new NpgsqlTypes.NpgsqlPoint(x: 0.749894745951914d, y: 0.2807503334445941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7176158617482128d, y: 0.10904218615127537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7473483159061788d, y: 0.38512211407255825d), new NpgsqlTypes.NpgsqlPoint(x: 0.2997433586889875d, y: 0.6068153698239266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026847985384324d, y: 0.9730603030328756d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7495958172071877d, y: 0.4293814737693218d), new NpgsqlTypes.NpgsqlPoint(x: 0.06005015308759687d, y: 0.28934934523780376d), new NpgsqlTypes.NpgsqlPoint(x: 0.266453019590564d, y: 0.3327514147400251d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28752707211570283d, y: 0.6695331192143774d), new NpgsqlTypes.NpgsqlPoint(x: 0.10228998967161407d, y: 0.31731481463382094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382125008317511d, y: 0.308398287637378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40114532266043657d, y: 0.3439763659087617d), new NpgsqlTypes.NpgsqlPoint(x: 0.27643677629258356d, y: 0.9764895193265114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9986207383797093d, y: 0.8865401057531673d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5979621989280969d, y: 0.7880212883411064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7681896190542953d, y: 0.2561922337142932d), new NpgsqlTypes.NpgsqlPoint(x: 0.11686054327650852d, y: 0.07370221383124154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9993189324392477d, y: 0.18053896405785497d), new NpgsqlTypes.NpgsqlPoint(x: 0.11531301434637864d, y: 0.25664238551950147d), new NpgsqlTypes.NpgsqlPoint(x: 0.42900502425389586d, y: 0.786969279334902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.411293278080053d, y: 0.4364322305305083d), new NpgsqlTypes.NpgsqlPoint(x: 0.2374269303657467d, y: 0.17183573830863974d), new NpgsqlTypes.NpgsqlPoint(x: 0.08981867058785564d, y: 0.784163366382172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7022395618799686d, y: 0.8328920970210238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8521904235196767d, y: 0.35715216847388587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5144109208505253d, y: 0.6587575937602536d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5331974340500096d, y: 0.6762568534085733d), new NpgsqlTypes.NpgsqlPoint(x: 0.13366807775294376d, y: 0.2926299919920803d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203809099429323d, y: 0.5182516170402827d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5958489728414731d, y: 0.45744834576522797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5771161768364773d, y: 0.12278092555429942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8553002204555865d, y: 0.6595215841896104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7374594210398143d, y: 0.4430980844341613d), new NpgsqlTypes.NpgsqlPoint(x: 0.29357218832864584d, y: 0.3077223214506437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488076803876699d, y: 0.5804639512391582d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005472942585550644d, y: 0.5138521555255827d), new NpgsqlTypes.NpgsqlPoint(x: 0.18829097137130668d, y: 0.8425562926722971d), new NpgsqlTypes.NpgsqlPoint(x: 0.8434030689265345d, y: 0.36562728394936594d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12363780322635276d, y: 0.9923319943454612d), new NpgsqlTypes.NpgsqlPoint(x: 0.06772851177279904d, y: 0.588880458501414d), new NpgsqlTypes.NpgsqlPoint(x: 0.2742168469874666d, y: 0.11726374906951598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43376405349947544d, y: 0.705883513126505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7790060466104025d, y: 0.0471381401596237d), new NpgsqlTypes.NpgsqlPoint(x: 0.6368828541384622d, y: 0.10952546428647991d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9323157203302703d, y: 0.4839446108425971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047113032140778d, y: 0.37207923765663364d), new NpgsqlTypes.NpgsqlPoint(x: 0.09048347609034546d, y: 0.8440460038332537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7248980215114461d, y: 0.8913595340633733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225291759204643d, y: 0.4264603058146169d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818989207349298d, y: 0.7314521141490529d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.507671342534117d, y: 0.05666959896609147d), new NpgsqlTypes.NpgsqlPoint(x: 0.3700022327224871d, y: 0.9399591092216164d), new NpgsqlTypes.NpgsqlPoint(x: 0.33678966499673413d, y: 0.903477623391545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8827554286025573d, y: 0.2803150709648813d), new NpgsqlTypes.NpgsqlPoint(x: 0.266534838490057d, y: 0.04991881156102462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533002100562d, y: 0.49737790943760907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22721560533636354d, y: 0.037043435030340244d), new NpgsqlTypes.NpgsqlPoint(x: 0.1740301482233243d, y: 0.553902210317992d), new NpgsqlTypes.NpgsqlPoint(x: 0.07750402467442497d, y: 0.807628331266483d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13271170045904823d, y: 0.948813898845525d), new NpgsqlTypes.NpgsqlPoint(x: 0.12215514484693135d, y: 0.7643500794552892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203128388537253d, y: 0.5832582038205274d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6572976669728572d, y: 0.18111917305268066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851761090164008d, y: 0.7414797826837616d), new NpgsqlTypes.NpgsqlPoint(x: 0.05216831329401217d, y: 0.5255575604991617d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7208880363812676d, y: 0.6667205268843854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843696860422134d, y: 0.8420560626044621d), new NpgsqlTypes.NpgsqlPoint(x: 0.2514609214568584d, y: 0.06995883034651418d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02987543069360532d, y: 0.9065375742500583d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374511072483365d, y: 0.20367570571956917d), new NpgsqlTypes.NpgsqlPoint(x: 0.038673142197398924d, y: 0.8698207267480283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08319372478378073d, y: 0.252100295497499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5055583674560806d, y: 0.07710387377191408d), new NpgsqlTypes.NpgsqlPoint(x: 0.604037157610502d, y: 0.17116196113501958d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27178959243840095d, y: 0.1378582741773764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484594096062796d, y: 0.7861121938180229d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559140026964686d, y: 0.00438770821050527d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9016983971974083d, y: 0.6355099374385353d), new NpgsqlTypes.NpgsqlPoint(x: 0.49702259398726556d, y: 0.36998064322637925d), new NpgsqlTypes.NpgsqlPoint(x: 0.15985815063951647d, y: 0.8776614533946808d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3731996522570955d, y: 0.48551514623396375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639789515003339d, y: 0.4271758087733908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250008495828298d, y: 0.8746833541379616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8831439532273546d, y: 0.48318468434618056d), new NpgsqlTypes.NpgsqlPoint(x: 0.1137283738060455d, y: 0.1056329599140362d), new NpgsqlTypes.NpgsqlPoint(x: 0.2992727465528663d, y: 0.7163295858976281d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6878478474299958d, y: 0.7626120923450481d), new NpgsqlTypes.NpgsqlPoint(x: 0.7690483144588557d, y: 0.2134851408112931d), new NpgsqlTypes.NpgsqlPoint(x: 0.2254292051669884d, y: 0.1132932454998643d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2755531306894311d, y: 0.6830246181134303d), new NpgsqlTypes.NpgsqlPoint(x: 0.2363101808495056d, y: 0.3159612581317265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7472587004905715d, y: 0.6531485319027339d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9249342819565282d, y: 0.2837775596510199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344182648815831d, y: 0.8801732174061968d), new NpgsqlTypes.NpgsqlPoint(x: 0.35189472946859157d, y: 0.37522101211537817d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7910156037075441d, y: 0.666215050570272d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341890341267974d, y: 0.27114873563597586d), new NpgsqlTypes.NpgsqlPoint(x: 0.40450087566153914d, y: 0.4716015399078166d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9492745107578303d, y: 0.021312537211844784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752224630483875d, y: 0.5620398817877339d), new NpgsqlTypes.NpgsqlPoint(x: 0.2599285221266967d, y: 0.6883405595222573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8488660913140847d, y: 0.0847057455468122d), new NpgsqlTypes.NpgsqlPoint(x: 0.12491837266705297d, y: 0.35586146506575966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477703350728272d, y: 0.14134422319444007d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6359187826918087d, y: 0.6111963083841635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7211323454540414d, y: 0.12108594076978452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777203710469173d, y: 0.8678036954859214d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8526237292545489d, y: 0.8362162708998045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6446726251602934d, y: 0.4934069639315587d), new NpgsqlTypes.NpgsqlPoint(x: 0.35000284995977937d, y: 0.44457324857876557d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6275839774140022d, y: 0.864249090590995d), new NpgsqlTypes.NpgsqlPoint(x: 0.16574246141855165d, y: 0.3547076748573357d), new NpgsqlTypes.NpgsqlPoint(x: 0.3883552853776384d, y: 0.790084503692654d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9247526774094239d, y: 0.723653623247305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967565966369354d, y: 0.520167594885012d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410285502467195d, y: 0.9934182100262327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6366879408148941d, y: 0.7160206408806935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5436859007713769d, y: 0.22644029707036228d), new NpgsqlTypes.NpgsqlPoint(x: 0.019220290396423145d, y: 0.6719570647683738d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.312743055508649d, y: 0.9476184044764868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6025408666090146d, y: 0.15589397870190602d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792527941982246d, y: 0.7508291604318805d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.062191439126642156d, y: 0.24453634591359352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990559316480591d, y: 0.6312476953027654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233455509682177d, y: 0.6974889497751221d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3664438353377173d, y: 0.6126650733315269d), new NpgsqlTypes.NpgsqlPoint(x: 0.738268563272773d, y: 0.530417056122648d), new NpgsqlTypes.NpgsqlPoint(x: 0.660957619481288d, y: 0.4214750333606996d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32150138309857934d, y: 0.9575379856923708d), new NpgsqlTypes.NpgsqlPoint(x: 0.4949313989403824d, y: 0.025695596551729705d), new NpgsqlTypes.NpgsqlPoint(x: 0.09298247958087003d, y: 0.4052667893937324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16381837271605093d, y: 0.8738213869202678d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711541356325077d, y: 0.5729488297402663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7182205010071634d, y: 0.543646224062196d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6349252866937097d, y: 0.3176731805077687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6309921812787037d, y: 0.817486243137544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468045102745433d, y: 0.6903200908304856d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14437038236853195d, y: 0.600198617436156d), new NpgsqlTypes.NpgsqlPoint(x: 0.43678956411937075d, y: 0.15252571000774962d), new NpgsqlTypes.NpgsqlPoint(x: 0.14356713765230278d, y: 0.043661328696575574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6163215930672509d, y: 0.7765974215204434d), new NpgsqlTypes.NpgsqlPoint(x: 0.13365138667821075d, y: 0.06219174023506868d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874003202719688d, y: 0.908307313674655d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5219373750350907d, y: 0.7028753776337001d), new NpgsqlTypes.NpgsqlPoint(x: 0.013187991768420448d, y: 0.4039689315450844d), new NpgsqlTypes.NpgsqlPoint(x: 0.1773973860382161d, y: 0.8515940628802151d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774012086729496d, y: 0.5117310514982226d), new NpgsqlTypes.NpgsqlPoint(x: 0.16131655358669506d, y: 0.15931521591537612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7041316471825582d, y: 0.3392831575906583d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9607983629221243d, y: 0.7697950279338681d), new NpgsqlTypes.NpgsqlPoint(x: 0.25803329648763984d, y: 0.12094930073087773d), new NpgsqlTypes.NpgsqlPoint(x: 0.05330741950171447d, y: 0.5950132148003346d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033619168135341826d, y: 0.7573697539491795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5455762151498389d, y: 0.8697664736853459d), new NpgsqlTypes.NpgsqlPoint(x: 0.30815892157826397d, y: 0.1355348644887061d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4733792968297347d, y: 0.9655343499502284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3955893678889687d, y: 0.43185048267667303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8234745480746062d, y: 0.2016822851935317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9436354785442886d, y: 0.8277454144847572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708021188048982d, y: 0.08737709165342589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601442270450382d, y: 0.5928535349285998d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6012037287131957d, y: 0.7379111909374173d), new NpgsqlTypes.NpgsqlPoint(x: 0.685987343605785d, y: 0.8478519868237107d), new NpgsqlTypes.NpgsqlPoint(x: 0.4041794075015851d, y: 0.9371984550349856d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4043857244091634d, y: 0.9444844086575493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809838388910296d, y: 0.47040048571801873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607149424585212d, y: 0.18610483067553074d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.271373998409958d, y: 0.339408861647575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431604295232168d, y: 0.29710655456509005d), new NpgsqlTypes.NpgsqlPoint(x: 0.983883501968424d, y: 0.9086773367981452d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6716676264230768d, y: 0.7243326514963635d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559470038814778d, y: 0.824262039944262d), new NpgsqlTypes.NpgsqlPoint(x: 0.0059071953245962705d, y: 0.2269429929161071d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9273624608351213d, y: 0.636093544519205d), new NpgsqlTypes.NpgsqlPoint(x: 0.2125555310663918d, y: 0.31089107276710426d), new NpgsqlTypes.NpgsqlPoint(x: 0.052561697350829606d, y: 0.8776818882905932d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004964444176925764d, y: 0.0015517607285694401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6409844357323202d, y: 0.0719122225865011d), new NpgsqlTypes.NpgsqlPoint(x: 0.02868125597572635d, y: 0.15896609221411295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19440994795828992d, y: 0.2863274030147567d), new NpgsqlTypes.NpgsqlPoint(x: 0.33850430912749285d, y: 0.3371914713981492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8996770770184891d, y: 0.4766040131512467d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2449667563135004d, y: 0.6320985537715953d), new NpgsqlTypes.NpgsqlPoint(x: 0.8421891211520226d, y: 0.7077422176447838d), new NpgsqlTypes.NpgsqlPoint(x: 0.007593524351080738d, y: 0.4471385387580673d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.358999028715705d, y: 0.18492253162055994d), new NpgsqlTypes.NpgsqlPoint(x: 0.10519973280822048d, y: 0.2499796674898972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3301109101733134d, y: 0.6989684473686124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045849931794240684d, y: 0.20518869579972554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971075516299214d, y: 0.5031085858344717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557669139472526d, y: 0.6325354928898165d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13412795144057343d, y: 0.06382840551376778d), new NpgsqlTypes.NpgsqlPoint(x: 0.007645604402303996d, y: 0.3899890615222147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6680904636401537d, y: 0.6773472387156841d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29282056829349556d, y: 0.24057344900379773d), new NpgsqlTypes.NpgsqlPoint(x: 0.1843369679164374d, y: 0.3388572718881492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363659760368155d, y: 0.019242070758531016d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005963316532240248d, y: 0.7714017565521074d), new NpgsqlTypes.NpgsqlPoint(x: 0.32741795415990294d, y: 0.7357093528604569d), new NpgsqlTypes.NpgsqlPoint(x: 0.56713012119737d, y: 0.38136741177834177d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.806364086596207d, y: 0.9101148108149855d), new NpgsqlTypes.NpgsqlPoint(x: 0.1276132172390102d, y: 0.5209738695867264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8931628862378783d, y: 0.1412891688520933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04912748782826226d, y: 0.13745900426201507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875802396906844d, y: 0.3456794005982593d), new NpgsqlTypes.NpgsqlPoint(x: 0.10814413911241116d, y: 0.013406991665058432d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4759825217546323d, y: 0.6273790729860692d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691927771055787d, y: 0.8285859676595645d), new NpgsqlTypes.NpgsqlPoint(x: 0.15991305500709696d, y: 0.2383367970965634d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7958337268946751d, y: 0.07629302971565433d), new NpgsqlTypes.NpgsqlPoint(x: 0.0586913333892809d, y: 0.3784214481242577d), new NpgsqlTypes.NpgsqlPoint(x: 0.08707763302279448d, y: 0.21180624852162944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4030284977877372d, y: 0.9789577911867144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5183575477275453d, y: 0.9659373533059437d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865297902068231d, y: 0.7443508551030206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8037208702632392d, y: 0.44194042882397666d), new NpgsqlTypes.NpgsqlPoint(x: 0.03352345129634349d, y: 0.751030822393137d), new NpgsqlTypes.NpgsqlPoint(x: 0.38503432297688645d, y: 0.8396285830340163d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12986349789177098d, y: 0.8133538532336755d), new NpgsqlTypes.NpgsqlPoint(x: 0.8435890031551387d, y: 0.5617852451753103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805945590979941d, y: 0.6919678808905579d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027700394191548905d, y: 0.3810368746994579d), new NpgsqlTypes.NpgsqlPoint(x: 0.9666181834318942d, y: 0.6318419973030324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035670606677088d, y: 0.20338087232413238d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27212749426067995d, y: 0.9397263999463824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609312036035621d, y: 0.8797828586596242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395963878967941d, y: 0.1919084418195265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9068155690488251d, y: 0.08124993061325547d), new NpgsqlTypes.NpgsqlPoint(x: 0.37309002724672136d, y: 0.29940852395310413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506981430615707d, y: 0.5159038557273614d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7449032321660449d, y: 0.867179565008013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7019831047177136d, y: 0.5028367081183137d), new NpgsqlTypes.NpgsqlPoint(x: 0.29167742973315225d, y: 0.6285318420173389d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9865029970382604d, y: 0.4799322643630799d), new NpgsqlTypes.NpgsqlPoint(x: 0.05083488961319582d, y: 0.554250361311751d), new NpgsqlTypes.NpgsqlPoint(x: 0.29884685899958363d, y: 0.7098771690364077d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4037815356215805d, y: 0.9857287498831119d), new NpgsqlTypes.NpgsqlPoint(x: 0.887618406830557d, y: 0.922210735136471d), new NpgsqlTypes.NpgsqlPoint(x: 0.285832180220429d, y: 0.3214581741890996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48067959081362643d, y: 0.49290762432216173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9336609536018182d, y: 0.7087570815096619d), new NpgsqlTypes.NpgsqlPoint(x: 0.036693594297904863d, y: 0.6981986111702785d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006528556431673d, y: 0.8293344134472976d), new NpgsqlTypes.NpgsqlPoint(x: 0.025366773457504044d, y: 0.7274796620206917d), new NpgsqlTypes.NpgsqlPoint(x: 0.36955610614704215d, y: 0.47429585302789523d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49944576670214635d, y: 0.7552671971181277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288492809691363d, y: 0.24655906894407376d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374826756904772d, y: 0.005591446292222524d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37048668386333117d, y: 0.4981118058387791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353872495804767d, y: 0.515498687444401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6538208831125423d, y: 0.9370852401975215d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4137470944266348d, y: 0.6255823975314907d), new NpgsqlTypes.NpgsqlPoint(x: 0.30255399059299215d, y: 0.35366904624980855d), new NpgsqlTypes.NpgsqlPoint(x: 0.44914905597470633d, y: 0.5592892429474843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6333536108731711d, y: 0.2682589570903601d), new NpgsqlTypes.NpgsqlPoint(x: 0.060172170056806196d, y: 0.4099916888898274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976947129505546d, y: 0.24667611906110098d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3757496009077932d, y: 0.9474173541189099d), new NpgsqlTypes.NpgsqlPoint(x: 0.3070796852252562d, y: 0.7034383005741331d), new NpgsqlTypes.NpgsqlPoint(x: 0.12664896111617108d, y: 0.28763412591799564d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36492788554281985d, y: 0.7697150679038252d), new NpgsqlTypes.NpgsqlPoint(x: 0.4372562181699924d, y: 0.5434594865657352d), new NpgsqlTypes.NpgsqlPoint(x: 0.8950298399086095d, y: 0.7253784254414816d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8766068870915019d, y: 0.15860643825671872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075290042898325d, y: 0.9635882846040009d), new NpgsqlTypes.NpgsqlPoint(x: 0.07044636552593664d, y: 0.8324052103536067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19715498192556669d, y: 0.3478659474077942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5767527449403425d, y: 0.4113400308845554d), new NpgsqlTypes.NpgsqlPoint(x: 0.18329271317358686d, y: 0.15794489614534424d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5692914510557421d, y: 0.20711117181596972d), new NpgsqlTypes.NpgsqlPoint(x: 0.04360863938778836d, y: 0.021229197971223135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854617044815205d, y: 0.9698180875791117d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39336760514014746d, y: 0.9573017792031537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9772302956885104d, y: 0.5949984946078734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8041788148269732d, y: 0.28437075777042775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.434609798793287d, y: 0.5647540834904187d), new NpgsqlTypes.NpgsqlPoint(x: 0.45271887618754003d, y: 0.79151657644136d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880862132775218d, y: 0.4489227832512608d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09967637431738774d, y: 0.671081922992964d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243023318511599d, y: 0.12013084344695313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3620854850548364d, y: 0.743906991769455d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7850243006311275d, y: 0.31749608496905846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9901067963589819d, y: 0.41778369255033765d), new NpgsqlTypes.NpgsqlPoint(x: 0.09671785395136123d, y: 0.993428139271638d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7430786448848137d, y: 0.6202059656229554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905943719200904d, y: 0.24617631041206112d), new NpgsqlTypes.NpgsqlPoint(x: 0.09665567811334785d, y: 0.9126904436461087d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7403224202388938d, y: 0.40672909888738873d), new NpgsqlTypes.NpgsqlPoint(x: 0.44982143716330336d, y: 0.2080019715373873d), new NpgsqlTypes.NpgsqlPoint(x: 0.005326930713266953d, y: 0.3421138144576671d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3471042449131855d, y: 0.6931503937747112d), new NpgsqlTypes.NpgsqlPoint(x: 0.48774985344559996d, y: 0.2506865703717671d), new NpgsqlTypes.NpgsqlPoint(x: 0.8191385557534404d, y: 0.22463108497249917d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1999398949658847d, y: 0.9554340313846189d), new NpgsqlTypes.NpgsqlPoint(x: 0.519339677638764d, y: 0.3722405477230578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108710505701995d, y: 0.8506292975030935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.670295916047118d, y: 0.14019891149794717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932721156840187d, y: 0.9764651817405149d), new NpgsqlTypes.NpgsqlPoint(x: 0.6091532062043777d, y: 0.9771293155689984d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9699820733726539d, y: 0.7286841786644848d), new NpgsqlTypes.NpgsqlPoint(x: 0.154461720163528d, y: 0.7974796455250314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6484550392811971d, y: 0.5487138012694045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5117558087336765d, y: 0.7108892855053387d), new NpgsqlTypes.NpgsqlPoint(x: 0.12389628482922954d, y: 0.8954463538060081d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502534031318299d, y: 0.8599997414823084d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6287291310252537d, y: 0.29519262694730064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8254558379314412d, y: 0.8693805248824249d), new NpgsqlTypes.NpgsqlPoint(x: 0.42578017988986194d, y: 0.8686201657141338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33552041628842544d, y: 0.04542749804625046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8263856784337017d, y: 0.4849944811244329d), new NpgsqlTypes.NpgsqlPoint(x: 0.20892747231786002d, y: 0.6895036691048708d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5445317553563072d, y: 0.19150805950902883d), new NpgsqlTypes.NpgsqlPoint(x: 0.008503725044986199d, y: 0.7736533179550787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914806303916896d, y: 0.11602996719385916d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016068327610393784d, y: 0.3283809635504511d), new NpgsqlTypes.NpgsqlPoint(x: 0.726709527960597d, y: 0.45317232956686426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4459800214897519d, y: 0.020813544565113085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3889471983497359d, y: 0.9981318427089447d), new NpgsqlTypes.NpgsqlPoint(x: 0.2954293219675219d, y: 0.6775798093452161d), new NpgsqlTypes.NpgsqlPoint(x: 0.6783459173679568d, y: 0.25135084126065743d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5828126800020993d, y: 0.7059517833575827d), new NpgsqlTypes.NpgsqlPoint(x: 0.11429966245139223d, y: 0.4084292036525091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8001228920076875d, y: 0.3015480227480678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5092377842950464d, y: 0.5156153981300842d), new NpgsqlTypes.NpgsqlPoint(x: 0.43593913043537913d, y: 0.8564740848989768d), new NpgsqlTypes.NpgsqlPoint(x: 0.641750773446297d, y: 0.18815731692822701d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15627962463261535d, y: 0.5900746265509245d), new NpgsqlTypes.NpgsqlPoint(x: 0.48904918946713594d, y: 0.6617455434590845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354373408543255d, y: 0.30867429880686525d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6089160824480813d, y: 0.19091519997296136d), new NpgsqlTypes.NpgsqlPoint(x: 0.1716698138440338d, y: 0.5596985287307626d), new NpgsqlTypes.NpgsqlPoint(x: 0.2961900630591423d, y: 0.017737565975112668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5290045929768897d, y: 0.6082792606556013d), new NpgsqlTypes.NpgsqlPoint(x: 0.972958441136285d, y: 0.09823278139288516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9034864758706009d, y: 0.5872292904445109d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007262557813540127d, y: 0.5535339239633852d), new NpgsqlTypes.NpgsqlPoint(x: 0.11684187439350546d, y: 0.9844585584504293d), new NpgsqlTypes.NpgsqlPoint(x: 0.2242261455192579d, y: 0.7154711932422436d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37166332166519134d, y: 0.026445109365699326d), new NpgsqlTypes.NpgsqlPoint(x: 0.06286073296423278d, y: 0.49814627808133083d), new NpgsqlTypes.NpgsqlPoint(x: 0.11731094078664428d, y: 0.9609386650111595d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1699385013790542d, y: 0.9073407791006354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5928053166481227d, y: 0.9887585543572448d), new NpgsqlTypes.NpgsqlPoint(x: 0.18537762606469832d, y: 0.6110246194968459d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16791920105399283d, y: 0.1774854010733079d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740502177894052d, y: 0.32267780617534303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571131967050886d, y: 0.1850589586413649d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6496980479284753d, y: 0.3734261091110447d), new NpgsqlTypes.NpgsqlPoint(x: 0.23656849377709344d, y: 0.9047921046558157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8803024273148674d, y: 0.04876458448223675d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6193283860274044d, y: 0.34065699201900035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132523875668961d, y: 0.3976182080805132d), new NpgsqlTypes.NpgsqlPoint(x: 0.4089484370395563d, y: 0.5585126407431498d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00030718264050022537d, y: 0.054075327858185585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420323673824312d, y: 0.6922909299633953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279635155756872d, y: 0.8101060457542564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9710166124573167d, y: 0.3301993685915373d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761159191382853d, y: 0.41073868531031676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345646837175978d, y: 0.5824126665599353d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3570582363752526d, y: 0.7028726941678939d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711271650919634d, y: 0.6467938674305218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9634583005249041d, y: 0.3151547985203357d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47530753165804085d, y: 0.9931652092684063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594042101859453d, y: 0.5716622417777879d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433781880937582d, y: 0.5308059142271598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618462640159878d, y: 0.3422664795175795d), new NpgsqlTypes.NpgsqlPoint(x: 0.3248343165895111d, y: 0.6002071662483646d), new NpgsqlTypes.NpgsqlPoint(x: 0.280747803987908d, y: 0.24956871071660047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2829830475796907d, y: 0.6019780736929374d), new NpgsqlTypes.NpgsqlPoint(x: 0.659672521959617d, y: 0.8705752698942051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5695145020881656d, y: 0.19336739610714548d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07887364139367514d, y: 0.32267836322446297d), new NpgsqlTypes.NpgsqlPoint(x: 0.06792520986184114d, y: 0.6066948335459335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4628017295358312d, y: 0.2142473851889356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03431769234772841d, y: 0.20645367144888738d), new NpgsqlTypes.NpgsqlPoint(x: 0.8986435879361252d, y: 0.9198574022532534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278796881235827d, y: 0.013976001953435624d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7494221807004263d, y: 0.14480390974612112d), new NpgsqlTypes.NpgsqlPoint(x: 0.3171855669259893d, y: 0.6658588497029794d), new NpgsqlTypes.NpgsqlPoint(x: 0.761777092910497d, y: 0.034864323913411766d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5460715025432974d, y: 0.6392846936340576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4678729737626516d, y: 0.027401407099624797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486401418674262d, y: 0.4856236314275698d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11281664561776994d, y: 0.7413364081305396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7915648247762457d, y: 0.6370526457638368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938728336805774d, y: 0.21389244899586002d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7384833496822137d, y: 0.366265360207099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998259884297418d, y: 0.23773647081419014d), new NpgsqlTypes.NpgsqlPoint(x: 0.2564724397935584d, y: 0.16588157123591774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7779012277763537d, y: 0.5501599166861895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653699858992659d, y: 0.37081103559813244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9005003809887747d, y: 0.43352226177996755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9133413313678602d, y: 0.18376188786796743d), new NpgsqlTypes.NpgsqlPoint(x: 0.342336997252618d, y: 0.25116306334669647d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629122809932219d, y: 0.4446895414776352d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25211714692776843d, y: 0.8921378903790922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439206703519255d, y: 0.15379477539700548d), new NpgsqlTypes.NpgsqlPoint(x: 0.09624757974207532d, y: 0.5167546131118447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15252982777829538d, y: 0.6110046260061507d), new NpgsqlTypes.NpgsqlPoint(x: 0.43602113641000306d, y: 0.8647840568441005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323077977605581d, y: 0.4431892362587977d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6113975048093073d, y: 0.21808811557071595d), new NpgsqlTypes.NpgsqlPoint(x: 0.40527175552495687d, y: 0.837296246998616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148639186245581d, y: 0.9525110504539576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5853989149794372d, y: 0.5921001716956451d), new NpgsqlTypes.NpgsqlPoint(x: 0.2252306456033688d, y: 0.790917953929729d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193123532448485d, y: 0.3343566382937547d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7337313016352982d, y: 0.7128872218715444d), new NpgsqlTypes.NpgsqlPoint(x: 0.2628871781996944d, y: 0.031131357654180625d), new NpgsqlTypes.NpgsqlPoint(x: 0.0032871841621068265d, y: 0.7199343599879877d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008574383439285294d, y: 0.9503595134583198d), new NpgsqlTypes.NpgsqlPoint(x: 0.7202348406370742d, y: 0.7590617516360759d), new NpgsqlTypes.NpgsqlPoint(x: 0.44388860169102706d, y: 0.780286410781876d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6365321370878849d, y: 0.31157311165482926d), new NpgsqlTypes.NpgsqlPoint(x: 0.03948866632304748d, y: 0.6781425624766606d), new NpgsqlTypes.NpgsqlPoint(x: 0.179604969494214d, y: 0.7067080650974257d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3965422497778187d, y: 0.3139822249765907d), new NpgsqlTypes.NpgsqlPoint(x: 0.43770965328980305d, y: 0.034101184816741625d), new NpgsqlTypes.NpgsqlPoint(x: 0.09065750346423584d, y: 0.9790175033508608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16435054294075202d, y: 0.21678413092506932d), new NpgsqlTypes.NpgsqlPoint(x: 0.30594507394771253d, y: 0.9527603701188031d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541833899569621d, y: 0.17765279352931473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.685615323315317d, y: 0.6249222438549438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440993448651804d, y: 0.38827331337590354d), new NpgsqlTypes.NpgsqlPoint(x: 0.31912493081564186d, y: 0.7806911321834076d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.204022339968146d, y: 0.9628460204828746d), new NpgsqlTypes.NpgsqlPoint(x: 0.006224834062173112d, y: 0.49914608291829965d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743442104811022d, y: 0.08180285403285226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.303162002625062d, y: 0.4069658295409483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328746403574534d, y: 0.7064153729049729d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937257207946537d, y: 0.2415314613413162d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8001061121292339d, y: 0.20836164750646946d), new NpgsqlTypes.NpgsqlPoint(x: 0.3863756909524658d, y: 0.43403880910152104d), new NpgsqlTypes.NpgsqlPoint(x: 0.39417842925860413d, y: 0.9651774739796729d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13676571642393176d, y: 0.17815632276405602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4378653207977824d, y: 0.31972635347275513d), new NpgsqlTypes.NpgsqlPoint(x: 0.38457093408839726d, y: 0.3121014410467361d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.916965076823728d, y: 0.22480335520849382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852982931346702d, y: 0.12425014801290946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5058172639974544d, y: 0.6227470638287561d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46965307128290446d, y: 0.4694456116944188d), new NpgsqlTypes.NpgsqlPoint(x: 0.44899807461746555d, y: 0.5739395404082561d), new NpgsqlTypes.NpgsqlPoint(x: 0.1888132991906134d, y: 0.9031713795588687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5798959641563d, y: 0.8320030001749871d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620902398723389d, y: 0.1471443537226209d), new NpgsqlTypes.NpgsqlPoint(x: 0.946905786930649d, y: 0.7309229270672783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9212280409477156d, y: 0.8502495934432666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260135814364517d, y: 0.8732213680318978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9911969410751069d, y: 0.4250094957856647d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6624739972421377d, y: 0.3654260711185522d), new NpgsqlTypes.NpgsqlPoint(x: 0.30048040726022607d, y: 0.9948664081258048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894573696834702d, y: 0.687751483012115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3321176021223624d, y: 0.43408201634443866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657108457583079d, y: 0.15465979672233832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371988301924288d, y: 0.47744770067446807d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9615767031215199d, y: 0.606162787647614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7344221853525451d, y: 0.5018669448619316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026006334905423d, y: 0.5293762942902043d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9641863607194128d, y: 0.8139195083791895d), new NpgsqlTypes.NpgsqlPoint(x: 0.03700121458505612d, y: 0.6401896587951919d), new NpgsqlTypes.NpgsqlPoint(x: 0.35338821497791906d, y: 0.29027968965448037d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20473722108632963d, y: 0.5422434756395118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083419076051966d, y: 0.18704901089357773d), new NpgsqlTypes.NpgsqlPoint(x: 0.13898042643134767d, y: 0.34016473286513516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7286265744826941d, y: 0.7905695215079258d), new NpgsqlTypes.NpgsqlPoint(x: 0.695775046215789d, y: 0.6105082693714168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070331622139594d, y: 0.865134032661078d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220253278416803d, y: 0.8739139341449254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6611700871250437d, y: 0.6614027035747388d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945912781021499d, y: 0.8218675101978555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2516131075686179d, y: 0.906797926696371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8466858887218761d, y: 0.3029266585101579d), new NpgsqlTypes.NpgsqlPoint(x: 0.10135211475248518d, y: 0.7338530377059873d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8837899178415279d, y: 0.8997233065355003d), new NpgsqlTypes.NpgsqlPoint(x: 0.34712238229760684d, y: 0.468306507588912d), new NpgsqlTypes.NpgsqlPoint(x: 0.10780907286623387d, y: 0.773977320937319d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3048530416150613d, y: 0.9754582181479229d), new NpgsqlTypes.NpgsqlPoint(x: 0.10996824375141545d, y: 0.954855555848594d), new NpgsqlTypes.NpgsqlPoint(x: 0.21814204352562672d, y: 0.514398170989879d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9633292354573004d, y: 0.390989434783242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147266287575296d, y: 0.9232514892791901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844647863320745d, y: 0.03848712061994852d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2577237197912091d, y: 0.10887829830269902d), new NpgsqlTypes.NpgsqlPoint(x: 0.19946871699720314d, y: 0.7880131903672452d), new NpgsqlTypes.NpgsqlPoint(x: 0.23208956302603057d, y: 0.3643020792630296d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699034440623976d, y: 0.6709902663897346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121956008487325d, y: 0.7175695873953158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4383929686280724d, y: 0.5251002668850228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6068272209803599d, y: 0.8619923991513955d), new NpgsqlTypes.NpgsqlPoint(x: 0.1291369855872565d, y: 0.5395365749203687d), new NpgsqlTypes.NpgsqlPoint(x: 0.38974771822989585d, y: 0.5645423465606699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04330824235640396d, y: 0.13959711179455425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8963559690281178d, y: 0.09809627171883273d), new NpgsqlTypes.NpgsqlPoint(x: 0.7374539299597037d, y: 0.5489826161865978d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5068848358845005d, y: 0.8187544621752957d), new NpgsqlTypes.NpgsqlPoint(x: 0.9542186817996543d, y: 0.4449244056412869d), new NpgsqlTypes.NpgsqlPoint(x: 0.374512271671268d, y: 0.4038388592521356d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22379390654182207d, y: 0.7726567020279442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7799150071115314d, y: 0.7794180040174054d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677052038016731d, y: 0.5493079503242858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20531216581401113d, y: 0.8853091894328367d), new NpgsqlTypes.NpgsqlPoint(x: 0.4848964951659567d, y: 0.1814169999217572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3594958156533483d, y: 0.9481303219721576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5261185542551925d, y: 0.9581180934957001d), new NpgsqlTypes.NpgsqlPoint(x: 0.15731435871060517d, y: 0.8744295863008212d), new NpgsqlTypes.NpgsqlPoint(x: 0.43128335051181177d, y: 0.0027636321384898466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03795656860053109d, y: 0.7093484773071257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303261708047583d, y: 0.4410231881337846d), new NpgsqlTypes.NpgsqlPoint(x: 0.3120351571790396d, y: 0.4766513294221493d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009185728821016759d, y: 0.6953398715170418d), new NpgsqlTypes.NpgsqlPoint(x: 0.11584937195763778d, y: 0.7968117009900199d), new NpgsqlTypes.NpgsqlPoint(x: 0.035561594155840925d, y: 0.22116068764440933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957977701062289d, y: 0.16072524519664178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739492091752214d, y: 0.9017232667335091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4995479643345755d, y: 0.16152720557828038d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22014491481641063d, y: 0.2435529987885262d), new NpgsqlTypes.NpgsqlPoint(x: 0.37698544691193103d, y: 0.6047698279269136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7564652338365548d, y: 0.6110547223054048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22361531441773752d, y: 0.7259959954658122d), new NpgsqlTypes.NpgsqlPoint(x: 0.00695393922198706d, y: 0.3367820968157168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411678339169729d, y: 0.3325748427425561d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41893631928928177d, y: 0.6579210305791345d), new NpgsqlTypes.NpgsqlPoint(x: 0.11567642481512841d, y: 0.01819313153138835d), new NpgsqlTypes.NpgsqlPoint(x: 0.23811551911174123d, y: 0.09410524945090804d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5714317370162287d, y: 0.09290128761418437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296482226885506d, y: 0.49003619586762703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8232485461540507d, y: 0.22976126416177822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7486643515268812d, y: 0.7011140715828476d), new NpgsqlTypes.NpgsqlPoint(x: 0.45044475938772144d, y: 0.9969734314141094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628063621089008d, y: 0.6550186403018998d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2374801863173156d, y: 0.35653683179346374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7267273304423462d, y: 0.9451827164726889d), new NpgsqlTypes.NpgsqlPoint(x: 0.35937735206679644d, y: 0.5394437555987636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38509150080583954d, y: 0.5348211235924708d), new NpgsqlTypes.NpgsqlPoint(x: 0.07809641473124063d, y: 0.9720761832032586d), new NpgsqlTypes.NpgsqlPoint(x: 0.21160476509128923d, y: 0.19435072354949623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7692323606135962d, y: 0.3595774768624467d), new NpgsqlTypes.NpgsqlPoint(x: 0.1905755820703201d, y: 0.08127190043261767d), new NpgsqlTypes.NpgsqlPoint(x: 0.30922751052932695d, y: 0.003759181799571132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7092013025203395d, y: 0.9885111803180284d), new NpgsqlTypes.NpgsqlPoint(x: 0.26356311941311417d, y: 0.8856462688668927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8157690478029573d, y: 0.9188569222295598d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7738886503770013d, y: 0.8593773205899631d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068260406755633d, y: 0.6075633687958918d), new NpgsqlTypes.NpgsqlPoint(x: 0.3059515498516061d, y: 0.1566654211235755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13147604882368924d, y: 0.3183978795785217d), new NpgsqlTypes.NpgsqlPoint(x: 0.525654319572127d, y: 0.11172232800485149d), new NpgsqlTypes.NpgsqlPoint(x: 0.09553861645300865d, y: 0.9176609513496226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06955922064086817d, y: 0.6059167775604947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8483981755340576d, y: 0.3733594949471447d), new NpgsqlTypes.NpgsqlPoint(x: 0.47537358046583966d, y: 0.7300988152045461d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36889602564894475d, y: 0.8973992244615514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967637672619595d, y: 0.617644730109752d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701809251909145d, y: 0.2849156113882484d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4856977179035987d, y: 0.5791006166810334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880915244449506d, y: 0.2519736682318231d), new NpgsqlTypes.NpgsqlPoint(x: 0.596230888501554d, y: 0.054488722262564626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7263065070884648d, y: 0.6276549739491946d), new NpgsqlTypes.NpgsqlPoint(x: 0.11218003789204511d, y: 0.5282486845296752d), new NpgsqlTypes.NpgsqlPoint(x: 0.2539989816716529d, y: 0.02998128641047093d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2255628093335904d, y: 0.5385363758574225d), new NpgsqlTypes.NpgsqlPoint(x: 0.023507019560817355d, y: 0.054076662566062916d), new NpgsqlTypes.NpgsqlPoint(x: 0.36557937711988364d, y: 0.44472233277198736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.429987644948709d, y: 0.6091048160181025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662472402840846d, y: 0.864577886538279d), new NpgsqlTypes.NpgsqlPoint(x: 0.14711820286067911d, y: 0.7273499239273413d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010951597014366765d, y: 0.6971210388983529d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249752187863316d, y: 0.05386148336542962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827860835838336d, y: 0.2055067025417231d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8122271139423886d, y: 0.9854611169531816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992100773242463d, y: 0.27268929680163667d), new NpgsqlTypes.NpgsqlPoint(x: 0.23611461752839769d, y: 0.6214087268679129d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9737681831021702d, y: 0.3096024720286349d), new NpgsqlTypes.NpgsqlPoint(x: 0.21310154906176215d, y: 0.7101162879042394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374569687410229d, y: 0.9869714594526332d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7183531188325248d, y: 0.8716867672499544d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789955547065731d, y: 0.7788905809859102d), new NpgsqlTypes.NpgsqlPoint(x: 0.615725602682286d, y: 0.9517277296913195d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3735071417883472d, y: 0.2863664385604475d), new NpgsqlTypes.NpgsqlPoint(x: 0.641600814282342d, y: 0.12706343713104362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316557156537484d, y: 0.6423345181412964d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2716862343641221d, y: 0.9007339576336302d), new NpgsqlTypes.NpgsqlPoint(x: 0.29223405800049995d, y: 0.5732533491641448d), new NpgsqlTypes.NpgsqlPoint(x: 0.15726878161955593d, y: 0.9134963916528508d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46579323195366973d, y: 0.9987616808391386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761064089050725d, y: 0.9486644515528955d), new NpgsqlTypes.NpgsqlPoint(x: 0.39345336545527265d, y: 0.3407133950309794d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6892266946764366d, y: 0.8438102031120407d), new NpgsqlTypes.NpgsqlPoint(x: 0.008865379775720994d, y: 0.4869405464198463d), new NpgsqlTypes.NpgsqlPoint(x: 0.21751595781575594d, y: 0.18983417835258476d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24300687124521536d, y: 0.7116644143532135d), new NpgsqlTypes.NpgsqlPoint(x: 0.06775601548033394d, y: 0.6994760666698042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840686015756775d, y: 0.7473588762454284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9925448477066195d, y: 0.11849367401816857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948827507411696d, y: 0.9172678837683886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006755798611159d, y: 0.45619582954155147d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3926078998235304d, y: 0.7521437525740496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5900576604073157d, y: 0.38098570235485263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903763007516784d, y: 0.7956764773547409d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9092265626730386d, y: 0.4490594934085633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8135853650658772d, y: 0.4072109417954278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6799672738945801d, y: 0.5762013905753867d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26427531163143914d, y: 0.6407474069969027d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524542944287635d, y: 0.908315438770705d), new NpgsqlTypes.NpgsqlPoint(x: 0.6586738984825985d, y: 0.30419695455089935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45084611688276277d, y: 0.8998577699908296d), new NpgsqlTypes.NpgsqlPoint(x: 0.7429859236694022d, y: 0.9670818543256959d), new NpgsqlTypes.NpgsqlPoint(x: 0.04056040023172669d, y: 0.3802624891441958d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7139874616884156d, y: 0.2732666666326674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3823041154510586d, y: 0.5757525923476122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499764535387859d, y: 0.7898050577631522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5756474957587623d, y: 0.600912377247677d), new NpgsqlTypes.NpgsqlPoint(x: 0.38070894713540604d, y: 0.7162119502649034d), new NpgsqlTypes.NpgsqlPoint(x: 0.0003603021657103689d, y: 0.3786587476992628d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8300231084811678d, y: 0.08595896334789854d), new NpgsqlTypes.NpgsqlPoint(x: 0.46978147993746233d, y: 0.5016468215465347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314703421327193d, y: 0.38653052520727593d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6643713461193707d, y: 0.14729896678697807d), new NpgsqlTypes.NpgsqlPoint(x: 0.780662302312025d, y: 0.4637929547565848d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451064065634824d, y: 0.4542315731662683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5963703067067121d, y: 0.5770189004334173d), new NpgsqlTypes.NpgsqlPoint(x: 0.3354281902622993d, y: 0.357852694895494d), new NpgsqlTypes.NpgsqlPoint(x: 0.2250066581527892d, y: 0.05552598764606842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013747292130958932d, y: 0.14532688907138636d), new NpgsqlTypes.NpgsqlPoint(x: 0.557013176764528d, y: 0.7180721716126918d), new NpgsqlTypes.NpgsqlPoint(x: 0.11386193264636402d, y: 0.4133585486191552d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1727211842832188d, y: 0.8950461762484602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4618482634654214d, y: 0.6697245201017173d), new NpgsqlTypes.NpgsqlPoint(x: 0.7595864997262719d, y: 0.8066306105836789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.640113915630981d, y: 0.5516627247065883d), new NpgsqlTypes.NpgsqlPoint(x: 0.4579965689774549d, y: 0.04265923434407515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6309598776618122d, y: 0.2960958724042506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043249085134058896d, y: 0.2935288681828724d), new NpgsqlTypes.NpgsqlPoint(x: 0.07949913645358442d, y: 0.6429916430703435d), new NpgsqlTypes.NpgsqlPoint(x: 0.32737796405394315d, y: 0.41341029719789146d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8615829453171681d, y: 0.8411992448498055d), new NpgsqlTypes.NpgsqlPoint(x: 0.22650980250224628d, y: 0.35384461362294506d), new NpgsqlTypes.NpgsqlPoint(x: 0.17519750094710707d, y: 0.25237460319955396d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)), 
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
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                List<NpgsqlPathpathListD1E2M> models = null;

                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathListD1E2M> models = null;

                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 169;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 143, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 128, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 53, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 68, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 163, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 33, query1, 66, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 29, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 49, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 10, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 137);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[34], false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathListD1E2M),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
FROM public.binary_npgsqlpathpathlistd1e2m m
LEFT JOIN public.binary_npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models =  ((INpgsqlPathListpathListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI), typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                await ((INpgsqlPathListpathListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                ((INpgsqlPathListpathListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

