

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7544965130986554d, b: 0.21250293359837624d, c: 0.6928383924424569d),

new NpgsqlTypes.NpgsqlLine(a: 0.19545772541858586d, b: 0.8288379145771797d, c: 0.7535674557122904d),

new NpgsqlTypes.NpgsqlLine(a: 0.9497298991725605d, b: 0.2536602177473427d, c: 0.4266940520704986d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18015790698748857d, b: 0.10052415545195326d, c: 0.2975749314296008d),

new NpgsqlTypes.NpgsqlLine(a: 0.5866941687075793d, b: 0.6102487847849645d, c: 0.1319371686937305d),

new NpgsqlTypes.NpgsqlLine(a: 0.90364633612368d, b: 0.7628210643050041d, c: 0.438723606189954d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8332249959733476d, b: 0.7492178549371172d, c: 0.5576600386677888d),

new NpgsqlTypes.NpgsqlLine(a: 0.9017802178751517d, b: 0.8585585188565454d, c: 0.3392246792559893d),

new NpgsqlTypes.NpgsqlLine(a: 0.8647939352781391d, b: 0.09338613946436958d, c: 0.8101732877959087d),

new NpgsqlTypes.NpgsqlLine(a: 0.37233985283189763d, b: 0.7942032433032461d, c: 0.8647023931620151d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06447037421278412d, b: 0.7453572111395221d, c: 0.8124956729052671d),

new NpgsqlTypes.NpgsqlLine(a: 0.7301126775291917d, b: 0.8310993555128569d, c: 0.3497689548495786d),

new NpgsqlTypes.NpgsqlLine(a: 0.005279841106264227d, b: 0.1642654622285339d, c: 0.9288038608030069d),

new NpgsqlTypes.NpgsqlLine(a: 0.963350480782402d, b: 0.2730751624382981d, c: 0.8954477689405788d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4339442672964223d, b: 0.5539446677488995d, c: 0.7057620473797745d),

new NpgsqlTypes.NpgsqlLine(a: 0.5570954443168926d, b: 0.7515930641860465d, c: 0.06263728265146329d),

new NpgsqlTypes.NpgsqlLine(a: 0.5142348745430515d, b: 0.08564627715654138d, c: 0.6308913600500533d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7034467505884713d, b: 0.29515487807908525d, c: 0.15918659153207015d),

new NpgsqlTypes.NpgsqlLine(a: 0.5478832005641714d, b: 0.07155032169824627d, c: 0.07368154880991218d),

new NpgsqlTypes.NpgsqlLine(a: 0.24878227629169558d, b: 0.03036387922631245d, c: 0.17181219605788045d),

new NpgsqlTypes.NpgsqlLine(a: 0.15087825729518722d, b: 0.16409356755640359d, c: 0.46631393537571286d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9460085240015985d, b: 0.15530390786804216d, c: 0.7103321352389437d),

new NpgsqlTypes.NpgsqlLine(a: 0.005998198365188556d, b: 0.9714865743145139d, c: 0.35791114910579835d),

new NpgsqlTypes.NpgsqlLine(a: 0.6772272099683149d, b: 0.804173995327376d, c: 0.9417967029197842d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5066378486121864d, b: 0.6609939557654377d, c: 0.9645678215725413d),

new NpgsqlTypes.NpgsqlLine(a: 0.5838781134737431d, b: 0.20465465021075435d, c: 0.5972637479958667d),

new NpgsqlTypes.NpgsqlLine(a: 0.3195943380655194d, b: 0.5238105311897259d, c: 0.6094778276654753d),

new NpgsqlTypes.NpgsqlLine(a: 0.2461618504500367d, b: 0.4209950344773643d, c: 0.2470936833659908d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32605983115488224d, b: 0.26868584287162145d, c: 0.5036052600894356d),

new NpgsqlTypes.NpgsqlLine(a: 0.14476327670274935d, b: 0.7230275569446876d, c: 0.8223837729241946d),

new NpgsqlTypes.NpgsqlLine(a: 0.04823253419807105d, b: 0.7253923339525188d, c: 0.7848169279613288d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39782861024124017d, b: 0.5158843446684732d, c: 0.1000643502292129d),

new NpgsqlTypes.NpgsqlLine(a: 0.3321801459055377d, b: 0.20349366866607754d, c: 0.5971299479723544d),

new NpgsqlTypes.NpgsqlLine(a: 0.20055011018343027d, b: 0.8302461007236408d, c: 0.016633667026297205d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5213534768634175d, b: 0.9524322399759927d, c: 0.7920206168487532d),

new NpgsqlTypes.NpgsqlLine(a: 0.08840939286107308d, b: 0.8049751998615476d, c: 0.43279269683100174d),

new NpgsqlTypes.NpgsqlLine(a: 0.8666123439397868d, b: 0.5360636013689767d, c: 0.7086364158168794d),

new NpgsqlTypes.NpgsqlLine(a: 0.5326703191652544d, b: 0.9289393687518693d, c: 0.23776656224485704d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6087376245577846d, b: 0.5967722854865984d, c: 0.8398042942058722d),

new NpgsqlTypes.NpgsqlLine(a: 0.3881815666640901d, b: 0.12717582640254554d, c: 0.4111170467720031d),

new NpgsqlTypes.NpgsqlLine(a: 0.38961122216551014d, b: 0.06252211285429177d, c: 0.4890180152704692d),

new NpgsqlTypes.NpgsqlLine(a: 0.9102264148204209d, b: 0.05018379470684242d, c: 0.14084723795890286d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32037370746466554d, b: 0.12442496506504264d, c: 0.5720635760016219d),

new NpgsqlTypes.NpgsqlLine(a: 0.5403582196756135d, b: 0.46260173885231115d, c: 0.6799593919808188d),

new NpgsqlTypes.NpgsqlLine(a: 0.3505364292597025d, b: 0.8524280773973796d, c: 0.9264811119253733d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3027812722248885d, b: 0.6683706301344297d, c: 0.10940039292221493d),

new NpgsqlTypes.NpgsqlLine(a: 0.008188597221041372d, b: 0.6795340582521991d, c: 0.5726533436119893d),

new NpgsqlTypes.NpgsqlLine(a: 0.20955955353892974d, b: 0.7072957482773172d, c: 0.5315257523876392d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20229164221470142d, b: 0.231070328233263d, c: 0.8137543162210469d),

new NpgsqlTypes.NpgsqlLine(a: 0.6638856351295068d, b: 0.8541924058996135d, c: 0.06334337993230466d),

new NpgsqlTypes.NpgsqlLine(a: 0.9468131984061721d, b: 0.13810230585034622d, c: 0.9726865888153886d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5669007876079263d, b: 0.5209338232799763d, c: 0.07374072117815256d),

new NpgsqlTypes.NpgsqlLine(a: 0.5918704909399966d, b: 0.33477029864933416d, c: 0.5586177631276515d),

new NpgsqlTypes.NpgsqlLine(a: 0.8766928720514108d, b: 0.44453782176052525d, c: 0.8220165355603974d),

new NpgsqlTypes.NpgsqlLine(a: 0.7420115748730052d, b: 0.7884667777104432d, c: 0.48026437912840536d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5844567946813111d, b: 0.896442658428867d, c: 0.2594805905362303d),

new NpgsqlTypes.NpgsqlLine(a: 0.21569009425079566d, b: 0.4532780765057347d, c: 0.13797317809881926d),

new NpgsqlTypes.NpgsqlLine(a: 0.9733613109713235d, b: 0.22583447904925835d, c: 0.9235517130888073d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6022984003962476d, b: 0.45180030559283d, c: 0.5619473875800255d),

new NpgsqlTypes.NpgsqlLine(a: 0.8770473268531531d, b: 0.8961562139431595d, c: 0.6915442631342408d),

new NpgsqlTypes.NpgsqlLine(a: 0.6608475834711081d, b: 0.5565238686906938d, c: 0.4182182172885055d),

new NpgsqlTypes.NpgsqlLine(a: 0.6188046232061754d, b: 0.5875039261783452d, c: 0.1390488825349071d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41841657306688596d, b: 0.4278524844554715d, c: 0.8437392189532931d),

new NpgsqlTypes.NpgsqlLine(a: 0.22400398135815192d, b: 0.3582119671555135d, c: 0.7249317055111225d),

new NpgsqlTypes.NpgsqlLine(a: 0.8820901269337997d, b: 0.5250642865454845d, c: 0.897145880796054d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9573379183350337d, b: 0.445765177451636d, c: 0.08281541035139206d),

new NpgsqlTypes.NpgsqlLine(a: 0.29640863241006554d, b: 0.6269676037444198d, c: 0.06224659773281471d),

new NpgsqlTypes.NpgsqlLine(a: 0.23543976200208105d, b: 0.07188556280338076d, c: 0.6966654980733076d),

new NpgsqlTypes.NpgsqlLine(a: 0.7028037952111197d, b: 0.6110675487059658d, c: 0.13966200327729428d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22320038727624636d, b: 0.8569288075922009d, c: 0.6794446755304014d),

new NpgsqlTypes.NpgsqlLine(a: 0.7839576661936672d, b: 0.9324975186783365d, c: 0.501037860585769d),

new NpgsqlTypes.NpgsqlLine(a: 0.7633704167946264d, b: 0.5143458524064128d, c: 0.6346193807366441d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4198302560506153d, b: 0.7161282819919292d, c: 0.03388044184489525d),

new NpgsqlTypes.NpgsqlLine(a: 0.2728279255464475d, b: 0.26559105246477044d, c: 0.7458448846161984d),

new NpgsqlTypes.NpgsqlLine(a: 0.6062658448444976d, b: 0.2881857798611577d, c: 0.6836065319935182d),

new NpgsqlTypes.NpgsqlLine(a: 0.905326982906655d, b: 0.5243333965785587d, c: 0.4954596780997442d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16845034188684893d, b: 0.06101440107449052d, c: 0.8263197057822095d),

new NpgsqlTypes.NpgsqlLine(a: 0.9678959930718114d, b: 0.478166295877833d, c: 0.8120376422442502d),

new NpgsqlTypes.NpgsqlLine(a: 0.719799635010538d, b: 0.24749772432663297d, c: 0.30450821917463355d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4808098916824112d, b: 0.8330230020538149d, c: 0.12625926276687816d),

new NpgsqlTypes.NpgsqlLine(a: 0.000719772526825424d, b: 0.8676807118920871d, c: 0.6086613787974952d),

new NpgsqlTypes.NpgsqlLine(a: 0.37061829594607276d, b: 0.7075707391422131d, c: 0.09791733858577023d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22392573098000135d, b: 0.682712636520589d, c: 0.05413036678593086d),

new NpgsqlTypes.NpgsqlLine(a: 0.9736425322672239d, b: 0.7700705705209682d, c: 0.7541503890604601d),

new NpgsqlTypes.NpgsqlLine(a: 0.11882188486947354d, b: 0.859813610124821d, c: 0.5294674388513347d),

new NpgsqlTypes.NpgsqlLine(a: 0.4771852808243029d, b: 0.13865792630988516d, c: 0.8006171298683783d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4146455170271266d, b: 0.753162603786283d, c: 0.6005477831208288d),

new NpgsqlTypes.NpgsqlLine(a: 0.9291928239109116d, b: 0.725170553424454d, c: 0.7860626358390891d),

new NpgsqlTypes.NpgsqlLine(a: 0.1563169091563601d, b: 0.9627212352388688d, c: 0.18719997215996342d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9280920384121835d, b: 0.7617767934377255d, c: 0.019229646326116123d),

new NpgsqlTypes.NpgsqlLine(a: 0.3661194529711592d, b: 0.06422626511082363d, c: 0.06271381009388133d),

new NpgsqlTypes.NpgsqlLine(a: 0.7979778537773201d, b: 0.3746025927914919d, c: 0.5938929310408723d),

new NpgsqlTypes.NpgsqlLine(a: 0.47611793746957276d, b: 0.9390684289364346d, c: 0.6502445635380141d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8658360884759617d, b: 0.9279103424641715d, c: 0.4519850694536224d),

new NpgsqlTypes.NpgsqlLine(a: 0.04295594353066534d, b: 0.2053868305805594d, c: 0.11960219455128274d),

new NpgsqlTypes.NpgsqlLine(a: 0.4607761808888058d, b: 0.7832972454873914d, c: 0.10642822192881829d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07903958131473232d, b: 0.0134228739419745d, c: 0.47147103351425734d),

new NpgsqlTypes.NpgsqlLine(a: 0.35768508465876625d, b: 0.9148313776968565d, c: 0.3557779090534572d),

new NpgsqlTypes.NpgsqlLine(a: 0.14067726586478935d, b: 0.5647438525868687d, c: 0.9991419434427066d),

new NpgsqlTypes.NpgsqlLine(a: 0.45868799487690415d, b: 0.04293354446450559d, c: 0.13798360692082168d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.003951967861483885d, b: 0.4113858923497212d, c: 0.06407437951247175d),

new NpgsqlTypes.NpgsqlLine(a: 0.5497210742220524d, b: 0.32735279188446886d, c: 0.8005942215733673d),

new NpgsqlTypes.NpgsqlLine(a: 0.3051246494931015d, b: 0.26517414681408025d, c: 0.8785860802733234d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.481926900520132d, b: 0.7221764881372552d, c: 0.5938963899460022d),

new NpgsqlTypes.NpgsqlLine(a: 0.6772247367845562d, b: 0.3366737747054601d, c: 0.12588684198339406d),

new NpgsqlTypes.NpgsqlLine(a: 0.39768633565843936d, b: 0.8375526517745241d, c: 0.7719881475249614d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8440330002742302d, b: 0.11326492560068213d, c: 0.6207268114765927d),

new NpgsqlTypes.NpgsqlLine(a: 0.3801019235914168d, b: 0.2782400239532479d, c: 0.7495886002237039d),

new NpgsqlTypes.NpgsqlLine(a: 0.9035178512767662d, b: 0.12252099838514052d, c: 0.9401659957865557d),

new NpgsqlTypes.NpgsqlLine(a: 0.3275515240810575d, b: 0.876768315700191d, c: 0.1534468093692275d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09827358091470861d, b: 0.6800951071481386d, c: 0.6691996551488293d),

new NpgsqlTypes.NpgsqlLine(a: 0.6027205074247372d, b: 0.8528029444929077d, c: 0.719591047812641d),

new NpgsqlTypes.NpgsqlLine(a: 0.7818868695576106d, b: 0.2271556534338124d, c: 0.10613250131771956d),

new NpgsqlTypes.NpgsqlLine(a: 0.5017858486046861d, b: 0.2701458024666389d, c: 0.13870058331544033d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7284828082759144d, b: 0.9214393585490057d, c: 0.7160188987865939d),

new NpgsqlTypes.NpgsqlLine(a: 0.3307791316124735d, b: 0.9146319967869487d, c: 0.9855968487794567d),

new NpgsqlTypes.NpgsqlLine(a: 0.3776476370480276d, b: 0.24506191500868235d, c: 0.6344457768159436d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7698062971194592d, b: 0.11385191027364017d, c: 0.1623953566316635d),

new NpgsqlTypes.NpgsqlLine(a: 0.44231318104568373d, b: 0.24028444623026002d, c: 0.5837141317918177d),

new NpgsqlTypes.NpgsqlLine(a: 0.4073075041372003d, b: 0.6839885879316115d, c: 0.9046711910284112d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6176196445999494d, b: 0.47276908059939593d, c: 0.5537512931587433d),

new NpgsqlTypes.NpgsqlLine(a: 0.8556919005111656d, b: 0.9127303365107258d, c: 0.7156910825874433d),

new NpgsqlTypes.NpgsqlLine(a: 0.4464042909768915d, b: 0.5086110239236399d, c: 0.09008661084384373d),

new NpgsqlTypes.NpgsqlLine(a: 0.6610134194018048d, b: 0.09572480804091377d, c: 0.31878070636420486d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9549599631294009d, b: 0.8785287485162008d, c: 0.28498572729419513d),

new NpgsqlTypes.NpgsqlLine(a: 0.05409937934475417d, b: 0.6942060558706656d, c: 0.030678192593676434d),

new NpgsqlTypes.NpgsqlLine(a: 0.6066811977519417d, b: 0.6559303221001724d, c: 0.7228499918272375d),

new NpgsqlTypes.NpgsqlLine(a: 0.40102310544274355d, b: 0.14529958600481208d, c: 0.5955782242379765d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4679612004478435d, b: 0.8626007356741385d, c: 0.5217421574696973d),

new NpgsqlTypes.NpgsqlLine(a: 0.1342954169597299d, b: 0.060950444147675475d, c: 0.42256759110015996d),

new NpgsqlTypes.NpgsqlLine(a: 0.5162316890190454d, b: 0.9353665779937476d, c: 0.15203519799616882d),

new NpgsqlTypes.NpgsqlLine(a: 0.17518928440773096d, b: 0.13864242986292818d, c: 0.27746600749190264d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9651609580184198d, b: 0.15968757207315598d, c: 0.7327353939140329d),

new NpgsqlTypes.NpgsqlLine(a: 0.06305397659426804d, b: 0.3757878006190679d, c: 0.05262653913961546d),

new NpgsqlTypes.NpgsqlLine(a: 0.1998497294026539d, b: 0.432377040314331d, c: 0.25825741970568705d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.726832075746296d, b: 0.41270990537952545d, c: 0.5473186424481703d),

new NpgsqlTypes.NpgsqlLine(a: 0.028352235305276974d, b: 0.4178479251251884d, c: 0.7199399154340642d),

new NpgsqlTypes.NpgsqlLine(a: 0.3007694802480372d, b: 0.8775128216493702d, c: 0.14291995849481764d),

new NpgsqlTypes.NpgsqlLine(a: 0.26393009750358465d, b: 0.5114176128105188d, c: 0.8046656472302682d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8942681977676284d, b: 0.6868031193022366d, c: 0.5159911741697956d),

new NpgsqlTypes.NpgsqlLine(a: 0.8484909368399584d, b: 0.214718846664827d, c: 0.0747043472791441d),

new NpgsqlTypes.NpgsqlLine(a: 0.9222832321248845d, b: 0.847059158994271d, c: 0.08939863853221819d),

new NpgsqlTypes.NpgsqlLine(a: 0.5473260382746666d, b: 0.6572361346760387d, c: 0.5204967189462898d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6530570833393853d, b: 0.3847732132166579d, c: 0.6856724483284654d),

new NpgsqlTypes.NpgsqlLine(a: 0.535805168126458d, b: 0.942584761312615d, c: 0.06275261275256072d),

new NpgsqlTypes.NpgsqlLine(a: 0.4683639605031208d, b: 0.8516595640335405d, c: 0.6452681589232551d),

new NpgsqlTypes.NpgsqlLine(a: 0.84669325461829d, b: 0.13816036839508306d, c: 0.38290062200154906d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1926856398226351d, b: 0.7931609457932515d, c: 0.8402358454843952d),

new NpgsqlTypes.NpgsqlLine(a: 0.6595203542083093d, b: 0.1912357113474541d, c: 0.9136224624184377d),

new NpgsqlTypes.NpgsqlLine(a: 0.7462312684762894d, b: 0.7595648178761167d, c: 0.33750183109316445d),

new NpgsqlTypes.NpgsqlLine(a: 0.22914626510586522d, b: 0.7984273464878806d, c: 0.15591248507806643d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15578249719616322d, b: 0.694610427445296d, c: 0.5309024035205496d),

new NpgsqlTypes.NpgsqlLine(a: 0.31044643039875053d, b: 0.8288992793571622d, c: 0.9808054329362779d),

new NpgsqlTypes.NpgsqlLine(a: 0.9417224372038295d, b: 0.9472099747165881d, c: 0.7007630522082932d),

new NpgsqlTypes.NpgsqlLine(a: 0.676846070387824d, b: 0.23452159989790688d, c: 0.003781431458057871d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.530343858311132d, b: 0.06542210535640347d, c: 0.8635983877134532d),

new NpgsqlTypes.NpgsqlLine(a: 0.5598720697967211d, b: 0.45314024343109827d, c: 0.44944320284870853d),

new NpgsqlTypes.NpgsqlLine(a: 0.5052682587935349d, b: 0.3661540972123296d, c: 0.868663017466715d),

new NpgsqlTypes.NpgsqlLine(a: 0.34973823060200615d, b: 0.009515141351434275d, c: 0.03739712450769617d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6106516807877018d, b: 0.4378644428099804d, c: 0.5073909676206377d),

new NpgsqlTypes.NpgsqlLine(a: 0.3331495136623044d, b: 0.5805387986737363d, c: 0.8268439461348398d),

new NpgsqlTypes.NpgsqlLine(a: 0.6888481741398145d, b: 0.28395488611943887d, c: 0.6011410561101971d),

new NpgsqlTypes.NpgsqlLine(a: 0.1411382156584725d, b: 0.8152754340104923d, c: 0.06888039687186975d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7366378201103724d, b: 0.3135851988157302d, c: 0.8864617477312121d),

new NpgsqlTypes.NpgsqlLine(a: 0.7609370867697168d, b: 0.12761478287056216d, c: 0.8953168249905641d),

new NpgsqlTypes.NpgsqlLine(a: 0.1803328814736782d, b: 0.32206691915786834d, c: 0.8678344154606354d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3833922100027386d, b: 0.3246853784525212d, c: 0.1288416482932604d),

new NpgsqlTypes.NpgsqlLine(a: 0.5834275354068071d, b: 0.10402867199712618d, c: 0.15987854290148107d),

new NpgsqlTypes.NpgsqlLine(a: 0.8331560796477273d, b: 0.840876311715433d, c: 0.11319468499049445d),

new NpgsqlTypes.NpgsqlLine(a: 0.13455461386626644d, b: 0.7046660021127343d, c: 0.2061060849084475d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3616361465695761d, b: 0.006067974647745444d, c: 0.7549340895752841d),

new NpgsqlTypes.NpgsqlLine(a: 0.06759573092692917d, b: 0.7326747623595937d, c: 0.4570618499988982d),

new NpgsqlTypes.NpgsqlLine(a: 0.7734841222134327d, b: 0.4511793949511502d, c: 0.8643840274612411d),

new NpgsqlTypes.NpgsqlLine(a: 0.32838787143290227d, b: 0.9988682816266937d, c: 0.5396736402594874d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6256144326148118d, b: 0.2969162440216857d, c: 0.46989545277448075d),

new NpgsqlTypes.NpgsqlLine(a: 0.23512432896264357d, b: 0.07192587657341731d, c: 0.7127404782934945d),

new NpgsqlTypes.NpgsqlLine(a: 0.910191543441165d, b: 0.27036159525796843d, c: 0.8522243096581186d),

new NpgsqlTypes.NpgsqlLine(a: 0.20674778802532257d, b: 0.26892488463470143d, c: 0.07226509134774373d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1593140686302894d, b: 0.5411877436134482d, c: 0.130146520100619d),

new NpgsqlTypes.NpgsqlLine(a: 0.9527081194608287d, b: 0.9354158503735106d, c: 0.30388410379532715d),

new NpgsqlTypes.NpgsqlLine(a: 0.8169485974278566d, b: 0.7941608641843081d, c: 0.77438233848111d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.989571713613822d, b: 0.2017618038061746d, c: 0.5651223272323637d),

new NpgsqlTypes.NpgsqlLine(a: 0.9388298177986977d, b: 0.3104604611969052d, c: 0.7959619435289786d),

new NpgsqlTypes.NpgsqlLine(a: 0.0361605629836641d, b: 0.8996735763574742d, c: 0.8701493335460194d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1727317229167652d, b: 0.5017289715178734d, c: 0.3620544077868916d),

new NpgsqlTypes.NpgsqlLine(a: 0.8020761978618712d, b: 0.9129204018566931d, c: 0.2811056719453918d),

new NpgsqlTypes.NpgsqlLine(a: 0.02056463321047164d, b: 0.9519321060806587d, c: 0.8521516280161711d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.636647089736173d, b: 0.2795730448988115d, c: 0.4686423007096d),

new NpgsqlTypes.NpgsqlLine(a: 0.4720684375404409d, b: 0.6657952740256111d, c: 0.6379232696329475d),

new NpgsqlTypes.NpgsqlLine(a: 0.044168531025130076d, b: 0.4238430863005943d, c: 0.08132489069023652d),

new NpgsqlTypes.NpgsqlLine(a: 0.8334172504696676d, b: 0.19905912964444383d, c: 0.42248097398218676d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16432074197127333d, b: 0.20066636593340914d, c: 0.2929489880277628d),

new NpgsqlTypes.NpgsqlLine(a: 0.11948847766664872d, b: 0.8231736960276902d, c: 0.839442994379941d),

new NpgsqlTypes.NpgsqlLine(a: 0.683157113501792d, b: 0.6358225258681192d, c: 0.9353787607627595d),

new NpgsqlTypes.NpgsqlLine(a: 0.7001175174887515d, b: 0.7757955900045498d, c: 0.6696818658447752d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.475354807004697d, b: 0.9562597230874916d, c: 0.3984912986432442d),

new NpgsqlTypes.NpgsqlLine(a: 0.4042482107601669d, b: 0.5043440916099419d, c: 0.3632686708998971d),

new NpgsqlTypes.NpgsqlLine(a: 0.9335314828716526d, b: 0.45490272687286526d, c: 0.7061819364669987d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4679176226095215d, b: 0.6474354838632629d, c: 0.1034118933462026d),

new NpgsqlTypes.NpgsqlLine(a: 0.9249382826176935d, b: 0.1264437574434668d, c: 0.7198849177904425d),

new NpgsqlTypes.NpgsqlLine(a: 0.27630818015477343d, b: 0.6317858537966715d, c: 0.8975112896490487d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15494249480808342d, b: 0.9811033374359031d, c: 0.5480231818719487d),

new NpgsqlTypes.NpgsqlLine(a: 0.0874979615069027d, b: 0.622842021128969d, c: 0.8917109906635633d),

new NpgsqlTypes.NpgsqlLine(a: 0.8905967266417008d, b: 0.22144582761129117d, c: 0.5116174637817318d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6612589476170333d, b: 0.2694879187112055d, c: 0.022155398227893586d),

new NpgsqlTypes.NpgsqlLine(a: 0.9074912395419535d, b: 0.477973669205234d, c: 0.5348496397812554d),

new NpgsqlTypes.NpgsqlLine(a: 0.6177443391018713d, b: 0.6970773202266742d, c: 0.7550000683123922d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8092331147244294d, b: 0.48487516519801344d, c: 0.8232918859009193d),

new NpgsqlTypes.NpgsqlLine(a: 0.31397673419305405d, b: 0.8259534130425003d, c: 0.3757746910114067d),

new NpgsqlTypes.NpgsqlLine(a: 0.5846913736833322d, b: 0.7967314986086433d, c: 0.0223108254984119d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.007171648081463644d, b: 0.17371880435224862d, c: 0.3770039416746708d),

new NpgsqlTypes.NpgsqlLine(a: 0.33215229998510043d, b: 0.5151373551488445d, c: 0.36929114420983566d),

new NpgsqlTypes.NpgsqlLine(a: 0.34988380239568817d, b: 0.38947869092598475d, c: 0.47816825246928363d),

new NpgsqlTypes.NpgsqlLine(a: 0.25253935950235673d, b: 0.6428668283463671d, c: 0.2090504892163274d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3923446569199379d, b: 0.8860843368786477d, c: 0.057610637356165784d),

new NpgsqlTypes.NpgsqlLine(a: 0.845789233780903d, b: 0.7421974956067178d, c: 0.24172951457375358d),

new NpgsqlTypes.NpgsqlLine(a: 0.41554942517116866d, b: 0.8446771746555614d, c: 0.694946718361797d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8918585823800782d, b: 0.0417741488228186d, c: 0.009274590289791051d),

new NpgsqlTypes.NpgsqlLine(a: 0.6624301662276161d, b: 0.6281557140350967d, c: 0.8575512987275774d),

new NpgsqlTypes.NpgsqlLine(a: 0.07453856872870424d, b: 0.6425515834911908d, c: 0.8863694320560197d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7956816528996193d, b: 0.9002182892536694d, c: 0.683498619484798d),

new NpgsqlTypes.NpgsqlLine(a: 0.6144999982748506d, b: 0.24280801046399836d, c: 0.7139475504006465d),

new NpgsqlTypes.NpgsqlLine(a: 0.9006711501122656d, b: 0.6659952756538907d, c: 0.445650781998975d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19360892231118698d, b: 0.22670579534388713d, c: 0.37188842527461374d),

new NpgsqlTypes.NpgsqlLine(a: 0.7897215169091979d, b: 0.5772290716883303d, c: 0.27354064570846204d),

new NpgsqlTypes.NpgsqlLine(a: 0.2991589405974302d, b: 0.6291291331235491d, c: 0.6048789597963136d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18602491285560996d, b: 0.764398757155214d, c: 0.43587815678541875d),

new NpgsqlTypes.NpgsqlLine(a: 0.5160504042184593d, b: 0.8187390020161623d, c: 0.2811454999284546d),

new NpgsqlTypes.NpgsqlLine(a: 0.463977007377841d, b: 0.9237418119695465d, c: 0.9204653252543711d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4524224133715069d, b: 0.5048874764774877d, c: 0.9661004049232981d),

new NpgsqlTypes.NpgsqlLine(a: 0.37580760390075874d, b: 0.37822684439454546d, c: 0.4021414199620179d),

new NpgsqlTypes.NpgsqlLine(a: 0.8376658249131115d, b: 0.3334199005596181d, c: 0.3480804731175514d),

new NpgsqlTypes.NpgsqlLine(a: 0.6474059302716133d, b: 0.4308914191466968d, c: 0.18169163301972402d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43306471183939843d, b: 0.24256679877405796d, c: 0.2241304709843387d),

new NpgsqlTypes.NpgsqlLine(a: 0.20831860469063979d, b: 0.419983225219401d, c: 0.9463999459788768d),

new NpgsqlTypes.NpgsqlLine(a: 0.17145792688120365d, b: 0.4709709688496687d, c: 0.16191318530957755d),

new NpgsqlTypes.NpgsqlLine(a: 0.9383743214283313d, b: 0.030131959282929666d, c: 0.8188151233993157d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04097135186109069d, b: 0.7628528515368158d, c: 0.21869925985023297d),

new NpgsqlTypes.NpgsqlLine(a: 0.3664991151788992d, b: 0.47119029250810374d, c: 0.26672809060594127d),

new NpgsqlTypes.NpgsqlLine(a: 0.7103825409606198d, b: 0.25419144019405804d, c: 0.6496853845909929d),

new NpgsqlTypes.NpgsqlLine(a: 0.04973586338989666d, b: 0.5941737502468188d, c: 0.4438913803922123d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12810413260929665d, b: 0.7494188795547463d, c: 0.591190834321764d),

new NpgsqlTypes.NpgsqlLine(a: 0.9999767519281824d, b: 0.07551064990088652d, c: 0.7180380968721216d),

new NpgsqlTypes.NpgsqlLine(a: 0.33093951492609175d, b: 0.4858425795243688d, c: 0.33848641631319476d),

new NpgsqlTypes.NpgsqlLine(a: 0.872874628692909d, b: 0.40275741309290125d, c: 0.8526238673348882d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9737908010747727d, b: 0.936719268506104d, c: 0.8863239006390126d),

new NpgsqlTypes.NpgsqlLine(a: 0.4509955645062905d, b: 0.6003655801675424d, c: 0.9849172821015535d),

new NpgsqlTypes.NpgsqlLine(a: 0.7610909537845943d, b: 0.5501293534809578d, c: 0.3080654657364429d),

new NpgsqlTypes.NpgsqlLine(a: 0.32017348320976047d, b: 0.23047471652641727d, c: 0.35538283266893733d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.777431123796266d, b: 0.6621832977729171d, c: 0.3308039035289826d),

new NpgsqlTypes.NpgsqlLine(a: 0.7439229726932551d, b: 0.9328216958182568d, c: 0.6804690949985585d),

new NpgsqlTypes.NpgsqlLine(a: 0.9925569040518432d, b: 0.4005971563307812d, c: 0.8388505253382986d),

new NpgsqlTypes.NpgsqlLine(a: 0.7659475711246644d, b: 0.25110965583102496d, c: 0.14660761983687587d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3127034627844598d, b: 0.7630365901129877d, c: 0.03551741731445046d),

new NpgsqlTypes.NpgsqlLine(a: 0.6930778898915685d, b: 0.8088042027526452d, c: 0.7405521864950854d),

new NpgsqlTypes.NpgsqlLine(a: 0.04785545569372862d, b: 0.539513827521744d, c: 0.5030740819072388d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6853183605112192d, b: 0.7976205594854798d, c: 0.467779716415229d),

new NpgsqlTypes.NpgsqlLine(a: 0.005434521704595019d, b: 0.816980032194418d, c: 0.17092723962678213d),

new NpgsqlTypes.NpgsqlLine(a: 0.28550937380232666d, b: 0.5933138435467139d, c: 0.22795519540669928d),

new NpgsqlTypes.NpgsqlLine(a: 0.29630345388158563d, b: 0.15007997147316643d, c: 0.16211010624295297d),

},
    ModelInner = new NpgsqlLinelineListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5606031768372451d, b: 0.4310465844589414d, c: 0.05156322584439399d),

new NpgsqlTypes.NpgsqlLine(a: 0.2901201473687396d, b: 0.5663334686700364d, c: 0.5254969264157787d),

new NpgsqlTypes.NpgsqlLine(a: 0.1168949956086891d, b: 0.4977701310186551d, c: 0.4834623341274634d),

new NpgsqlTypes.NpgsqlLine(a: 0.3959943845424737d, b: 0.8926389129804287d, c: 0.27822620231809203d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.378962824740844d, b: 0.061705138703746054d, c: 0.004698236637892483d),

new NpgsqlTypes.NpgsqlLine(a: 0.3664818109543486d, b: 0.604584913021791d, c: 0.327336945008494d),

new NpgsqlTypes.NpgsqlLine(a: 0.4700972864007612d, b: 0.9397500638705614d, c: 0.34836732085428934d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.606635323868513d, b: 0.20116283139732205d, c: 0.1750422879338671d),

new NpgsqlTypes.NpgsqlLine(a: 0.9262497349932326d, b: 0.746439674984646d, c: 0.905218793684822d),

new NpgsqlTypes.NpgsqlLine(a: 0.8558161916718016d, b: 0.10955063323789804d, c: 0.6291441977457023d),

new NpgsqlTypes.NpgsqlLine(a: 0.9442820136080786d, b: 0.3752842908289611d, c: 0.6220343658663651d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2456926156455056d, b: 0.7794477096684751d, c: 0.5324292985871762d),

new NpgsqlTypes.NpgsqlLine(a: 0.3139192569143726d, b: 0.9120320390082368d, c: 0.17309046590060395d),

new NpgsqlTypes.NpgsqlLine(a: 0.8684983990116377d, b: 0.040300822029811d, c: 0.6332453167177666d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd1e2mi_id
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
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinelistd1e2mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 124, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 149, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 85, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 75, query1, 168, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 149, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 2, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 24, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd1e2mi mi ON mi.id = m.npgsqllinelinelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd1e2mi
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
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI), typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MI>();
                var models2 = new List<NpgsqlLinelineListD1E2MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA), typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD1E2MIWA>();
                var models2 = new List<NpgsqlLinelineListD1E2MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

