

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IUInt64MArrayMArrayD2
    {
    }
    
    internal partial class UInt64MArrayMArrayD2 : IUInt64MArrayMArrayD2
    {


#region TestData

        private readonly UInt64MArrayD2E1M[] _testData = new UInt64MArrayD2E1M[]
        {
            new UInt64MArrayD2E1M
{
    Id = 2,
    Value = 
new System.UInt64[,] { { 4068836072219617556L, 6374088622057294396L, }, { 1913602224782999403L, 5684932781505902117L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 1,
    Value = 
new System.UInt64[,] { { 7247301409936687406L, 4330490509933469623L, }, { 593262138431972211L, 6280426352168248025L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2417301481426882887L, 4742424972048516346L, }, { 3950615167150554760L, 9121398535248531063L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 5,
    Value = 
new System.UInt64[,] { { 6637133510352237798L, 5554709118989144733L, }, { 3803632426288911985L, 4417721914760942024L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.UInt64[,] { { 6158719341885831117L, 4218447464916316651L, }, { 5628219394513092882L, 8904618880829920220L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6951886992658102959L, 8584680397610103912L, }, { 3256892493000665712L, 1033252152372320301L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 8,
    Value = 
new System.UInt64[,] { { 9209066656666927873L, 7636088974932467389L, }, { 4056198113635138670L, 3940225493487886493L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.UInt64[,] { { 2770075653928079716L, 3581177402762432364L, }, { 5096216728897852098L, 48366782890649056L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 11,
    Value = 
new System.UInt64[,] { { 6975320537882832700L, 4447288866665053557L, }, { 2636937136256273700L, 4024953626072063909L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.UInt64[,] { { 1178869418681227649L, 3392240980417841125L, }, { 1516533060022601215L, 6868528739322948376L, }, },
    NullableValue = 
new System.UInt64[,] { { 2905803110513214625L, 9093273734007523130L, }, { 5435360709829134356L, 3164254877080826311L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 18,
    Value = 
new System.UInt64[,] { { 1959745345824731542L, 4320811466735123979L, }, { 7698862345654504466L, 5283205883599328158L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 22,
    Value = 
new System.UInt64[,] { { 3117453302341912710L, 1213502536164166355L, }, { 2728471394242475386L, 5796147626325212736L, }, },
    NullableValue = 
new System.UInt64[,] { { 4879520410221088159L, 1378579642691607236L, }, { 5605076844480410602L, 3339872117164084697L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 26,
    Value = 
new System.UInt64[,] { { 3430165060020535722L, 1526610612702200311L, }, { 6529308590495456899L, 3508468921329349322L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt64[,] { { 9205780844250084684L, 6834376289656959492L, }, { 8270753452485070733L, 3395989836225437896L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 34,
    Value = 
new System.UInt64[,] { { 8222672066690392964L, 9044898836294793955L, }, { 5852710803348649424L, 446947593078656906L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.UInt64[,] { { 1227630881680586273L, 7755160640801435271L, }, { 6946236469596180705L, 8469892539527635475L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt64[,] { { 5264017280335053998L, 2672312589409573303L, }, { 2829213185610572533L, 2283528209066009578L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.UInt64[,] { { 4943454087118411388L, 8492642598486790725L, }, { 1623510290279398003L, 3389457013292663739L, }, },
    NullableValue = 
new System.UInt64[,] { { 3089033690207498561L, 7018197263415002489L, }, { 3682221082827917740L, 6272196130381851463L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2475495801152360516L, 8967574713278450090L, }, { 3337493910353935907L, 2273488636336861485L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 44,
    Value = 
new System.UInt64[,] { { 2931984589148563301L, 222748505425838009L, }, { 4680668097952712807L, 3052701298138915528L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.UInt64[,] { { 1103297171307967043L, 6963561528414076217L, }, { 487433109722651205L, 6065752125336935400L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 59102840617586839L, 5416204289948928853L, }, { 5759112279085849348L, 1160010222879451281L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 51,
    Value = 
new System.UInt64[,] { { 1527050788585732040L, 8563911000689653201L, }, { 8278126424067184572L, 7210964491904267853L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.UInt64[,] { { 8442640326439338723L, 1422327881693991997L, }, { 6164100939761069463L, 742337679567077014L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 52,
    Value = 
new System.UInt64[,] { { 5980765193597834626L, 8282439174827454082L, }, { 6749837684850477370L, 6184007548948555798L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.UInt64[,] { { 2188179093641365913L, 7653956802353311171L, }, { 6169529442080647386L, 6888631039594392533L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt64[,] { { 2930645958099349619L, 7932913179414496520L, }, { 6680872184764859124L, 5108754025902343660L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.UInt64[,] { { 2583436537007490119L, 6755568282938342709L, }, { 5810052097371256000L, 2633934634497846161L, }, },
    NullableValue = 
new System.UInt64[,] { { 7066483967742059334L, 9042759729339371283L, }, { 3013381763026445812L, 7967759924760384600L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 6094978690764551461L, 1655714788707766992L, }, { 1151177106053835139L, 1216703903565105042L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 65,
    Value = 
new System.UInt64[,] { { 8316057054884885954L, 2469737458269913876L, }, { 2768104117066388760L, 7986403171726813699L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt64[,] { { 8966951537253861092L, 4550950725849036589L, }, { 2374173994940288591L, 8349142829778341041L, }, },
    NullableValue = 
new System.UInt64[,] { { 4919406666116248000L, 3729145327822184399L, }, { 3814180348939530771L, 748620666117416248L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2454771624759361732L, 5113626632210154868L, }, { 8827295438825973492L, 2195962853494156499L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt64[,] { { 5808782896992653682L, 1939149643117979146L, }, { 1313920356741506459L, 5831088428004568835L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt64[,] { { 2658327804286904656L, 2862601840240895704L, }, { 1109058109908496831L, 9103500576796661462L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 70,
    Value = 
new System.UInt64[,] { { 9173793200884727090L, 2510517289094806077L, }, { 2452232120165987656L, 5794691638188745131L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 88,
    Value = 
new System.UInt64[,] { { 3794975736351708592L, 7645349154054227970L, }, { 8555694349383453995L, 3006824836406773391L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 77,
    Value = 
new System.UInt64[,] { { 1775904876069722698L, 9082798638352024380L, }, { 1411856084328883248L, 4244312637654526971L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 95,
    Value = 
new System.UInt64[,] { { 4598498803727068238L, 2393414050882389266L, }, { 3571339330464384543L, 7197619953098325717L, }, },
    NullableValue = 
new System.UInt64[,] { { 2296244124829871089L, 5996718363498623552L, }, { 3459360523374472137L, 9141812733115560271L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 9206862536193169099L, 5631201586223269335L, }, { 2987836542226431019L, 1113018114644333453L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 85,
    Value = 
new System.UInt64[,] { { 6026040701145310677L, 7083250468690394760L, }, { 6388612829342222422L, 7687066714559161252L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.UInt64[,] { { 6447570613535339648L, 6956736642680319025L, }, { 8544155910516705119L, 2490627592730614131L, }, },
    NullableValue = 
new System.UInt64[,] { { 5486025247105757816L, 5369927361420218585L, }, { 3986660344059701801L, 3563322426122845951L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 8518342769583204747L, 6045098365281047035L, }, { 5161817404682962468L, 3309752148160277447L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt64[,] { { 6023535023923944472L, 18884436618860336L, }, { 8215638341889166442L, 2800617705457117439L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.UInt64[,] { { 3189032322274024666L, 4336354420759689749L, }, { 692652726875104880L, 5375681806157623127L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 3524346557330229697L, 3430600513967404348L, }, { 1730092535342729197L, 239702389309088353L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 93,
    Value = 
new System.UInt64[,] { { 4763444010550770069L, 51012032167331273L, }, { 2808463788687405225L, 1982590901903471218L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.UInt64[,] { { 2946987043700356632L, 8216300663415832945L, }, { 2179588058239844690L, 4186321195504133326L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 3006988412002278803L, 3716181865296102777L, }, { 2595038375818798517L, 6113066082249758136L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 100,
    Value = 
new System.UInt64[,] { { 3073638910101318236L, 5899197370975185305L, }, { 2347702593413289796L, 4136517384276137650L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 113,
    Value = 
new System.UInt64[,] { { 4054799367320097667L, 5666243670053126275L, }, { 5856432756872094772L, 2280533934669702361L, }, },
    NullableValue = 
new System.UInt64[,] { { 5505170474401425013L, 5792426885449403455L, }, { 33613759260005827L, 9175434971878298575L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt64[,] { { 7610329787683215211L, 8532914779795898784L, }, { 4772352084058374958L, 5332495196752161029L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 114,
    Value = 
new System.UInt64[,] { { 6080350718707177475L, 3486719391383011326L, }, { 4200195101136526081L, 2387375195577650313L, }, },
    NullableValue = 
new System.UInt64[,] { { 4371368802733149893L, 8322028308630346889L, }, { 7393091095782610017L, 5159140406877344940L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 111,
    Value = 
new System.UInt64[,] { { 3040865737421355427L, 4957791875411113502L, }, { 7738294033498046747L, 1233355004965065269L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 121,
    Value = 
new System.UInt64[,] { { 3646527359914691357L, 4890634444695726947L, }, { 358455471947295657L, 3243416822793992115L, }, },
    NullableValue = 
new System.UInt64[,] { { 2477272711975059493L, 6843138294227658014L, }, { 6150524507758767791L, 1293610947432364587L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 7362862290358642170L, 4285533494206788911L, }, { 4176980762420670637L, 496616175009141924L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 112,
    Value = 
new System.UInt64[,] { { 5680066321411381558L, 9151897541124390175L, }, { 5184275707897550353L, 5053580167804620873L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.UInt64[,] { { 2436702547775423504L, 5105383657734573072L, }, { 7525137852266213527L, 7948432037438900537L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 8987708084326248310L, 6089971238217632501L, }, { 2482494584325993163L, 3464139002911917528L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 121,
    Value = 
new System.UInt64[,] { { 6792098613301173968L, 4983233476683472794L, }, { 5921829771583208982L, 7540131096692623592L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 131,
    Value = 
new System.UInt64[,] { { 8254709823710229755L, 5292257397554775429L, }, { 1276574850459757077L, 110563234131663313L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 129,
    Value = 
new System.UInt64[,] { { 5097457340471826198L, 2785934813268235368L, }, { 2099245420338565375L, 4522435536861494810L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 137,
    Value = 
new System.UInt64[,] { { 8829782900599400152L, 5172416077509369057L, }, { 7312349365401802709L, 6315133158683208943L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 131,
    Value = 
new System.UInt64[,] { { 9179182258934188000L, 8129488243355635019L, }, { 704717366518693950L, 3635785882319125187L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 140,
    Value = 
new System.UInt64[,] { { 1648370730603667265L, 4801223388369772823L, }, { 4414461603828810412L, 7093882230804066416L, }, },
    NullableValue = 
new System.UInt64[,] { { 1820246649519574712L, 3247888514841242564L, }, { 2533030727810134392L, 7687672758352995804L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2947456690035744429L, 4681284966482504482L, }, { 4989609976450243269L, 4727477693985047091L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 140,
    Value = 
new System.UInt64[,] { { 7273672389985956791L, 5280402701673860763L, }, { 5143023489465062235L, 1847946172420316821L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.UInt64[,] { { 3493064834930070590L, 8279852044489487914L, }, { 1495540264585971018L, 223713101903929810L, }, },
    NullableValue = 
new System.UInt64[,] { { 4711392796112077435L, 6499944437905927908L, }, { 191113813344403026L, 7461726985695407609L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2724073048229410359L, 4834885965865544392L, }, { 4397825438823598434L, 1067064453881231843L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 143,
    Value = 
new System.UInt64[,] { { 6080728713836771988L, 3000404607709394621L, }, { 6762983389234944853L, 6641000687321183373L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 146,
    Value = 
new System.UInt64[,] { { 1317542868121261026L, 288285885997126131L, }, { 8106748793101482132L, 1732118051419087980L, }, },
    NullableValue = 
new System.UInt64[,] { { 6344816539308825382L, 151641301592965994L, }, { 7917230228072597204L, 5123677977829237003L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 147,
    Value = 
new System.UInt64[,] { { 415197118983146731L, 480129758679242314L, }, { 857408577887417607L, 4530515151399896098L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 150,
    Value = 
new System.UInt64[,] { { 7539015025086589669L, 271225165275276233L, }, { 2308187035817344231L, 4306486597229160141L, }, },
    NullableValue = 
new System.UInt64[,] { { 740804496891951816L, 1627440990859015777L, }, { 4517611784505510176L, 8608660407741286727L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2443496832387422172L, 1554251003168826387L, }, { 2530841843467742127L, 2342391825523909454L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 153,
    Value = 
new System.UInt64[,] { { 8210222877524502668L, 1577589642146492019L, }, { 1064247662689402374L, 2730579699108344921L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.UInt64[,] { { 1900718884167066153L, 4317505195393309437L, }, { 3551480205928534279L, 7325882396291454646L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 156,
    Value = 
new System.UInt64[,] { { 8547703802726933898L, 4706749916984707728L, }, { 3683461204263217545L, 5784957160732114925L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.UInt64[,] { { 1181338549517546314L, 2078061088283700577L, }, { 6642056036971790094L, 8989007863884143398L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 161,
    Value = 
new System.UInt64[,] { { 7751623659348174383L, 7078493273614330104L, }, { 2001731519535538031L, 6311239948525826817L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 169,
    Value = 
new System.UInt64[,] { { 899378253495852201L, 1518100694438314611L, }, { 1538447200008265500L, 4630343854671481269L, }, },
    NullableValue = 
new System.UInt64[,] { { 4505650586603277981L, 8378490236928606004L, }, { 4083169118548835012L, 3139784672773346873L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 7205042623110263982L, 3028506763392493622L, }, { 4706866925928978037L, 3734670089086057697L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 167,
    Value = 
new System.UInt64[,] { { 9178104737716397779L, 1015851217001991044L, }, { 1428389511407365946L, 6967167755287771271L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 171,
    Value = 
new System.UInt64[,] { { 306731693731434770L, 7807894738579573180L, }, { 819818896297803183L, 7132729803274078849L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 670849427392628116L, 1959781961042388079L, }, { 4784654572050699410L, 7688743290580724782L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 176,
    Value = 
new System.UInt64[,] { { 6799944607278087822L, 2529962985341980630L, }, { 2747011494723818053L, 8336288223661271251L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.UInt64[,] { { 2681537374599508091L, 4457606712818354699L, }, { 2010958598004448006L, 7218313762410502279L, }, },
    NullableValue = 
new System.UInt64[,] { { 8931004284172937317L, 3135823182424703142L, }, { 6888608762771259827L, 8054390207582559211L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 8407291560990509994L, 4443592511285220677L, }, { 4374932386345568549L, 6840878267158864804L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 177,
    Value = 
new System.UInt64[,] { { 3550509602927751405L, 547151254510251693L, }, { 52247249739278872L, 9217920847680933691L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 181,
    Value = 
new System.UInt64[,] { { 3274458072416648456L, 6427243071362177520L, }, { 8598646471385202316L, 2630803760762521732L, }, },
    NullableValue = 
new System.UInt64[,] { { 7172079105205230692L, 3473806052502856074L, }, { 7908038271574213726L, 2280396336047631496L, }, },
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IUInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IUInt64MArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.uint64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IUInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IUInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

