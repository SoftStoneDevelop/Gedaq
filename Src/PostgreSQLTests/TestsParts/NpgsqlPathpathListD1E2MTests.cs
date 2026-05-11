

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8366155909721008d, y: 0.9861746103475424d), new NpgsqlTypes.NpgsqlPoint(x: 0.39531361306906443d, y: 0.05264860583262454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169394742777451d, y: 0.7994471739465504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8861727612640479d, y: 0.4750235493070054d), new NpgsqlTypes.NpgsqlPoint(x: 0.389936058583927d, y: 0.14094981708003518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8939227567236636d, y: 0.6984641531274157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.87244064255004d, y: 0.11369867325922689d), new NpgsqlTypes.NpgsqlPoint(x: 0.7391794228566003d, y: 0.7518179734179543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550133978866382d, y: 0.6599768011094528d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2030184865802207d, y: 0.8228424666574946d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531735417462295d, y: 0.1188281566153222d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209287341418618d, y: 0.9157852659031933d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.771066020102143d, y: 0.9025220547397896d), new NpgsqlTypes.NpgsqlPoint(x: 0.2851634714266804d, y: 0.2707162338870306d), new NpgsqlTypes.NpgsqlPoint(x: 0.24882554746971397d, y: 0.6959586685417811d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16842381350387847d, y: 0.6605348406211835d), new NpgsqlTypes.NpgsqlPoint(x: 0.4017064392628983d, y: 0.4719366503895934d), new NpgsqlTypes.NpgsqlPoint(x: 0.14600835182955063d, y: 0.9052117587662653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13131948479052546d, y: 0.08598573145060817d), new NpgsqlTypes.NpgsqlPoint(x: 0.015144749921273237d, y: 0.767309188304811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7216852668728737d, y: 0.7935002234786204d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3419453560443523d, y: 0.0731251994162585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219125585316883d, y: 0.4462262788182638d), new NpgsqlTypes.NpgsqlPoint(x: 0.41844703867893374d, y: 0.38144279058576813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8910617405120428d, y: 0.9272738454875686d), new NpgsqlTypes.NpgsqlPoint(x: 0.7937970591772944d, y: 0.2185280319964662d), new NpgsqlTypes.NpgsqlPoint(x: 0.1815674710350077d, y: 0.9257817679614483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12660838974467192d, y: 0.14621553095245088d), new NpgsqlTypes.NpgsqlPoint(x: 0.1984502887745312d, y: 0.36842821525666036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9214292686091429d, y: 0.12839663958557712d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8917824501290652d, y: 0.5334340449737653d), new NpgsqlTypes.NpgsqlPoint(x: 0.12231802505909894d, y: 0.6601504519875083d), new NpgsqlTypes.NpgsqlPoint(x: 0.621478079016288d, y: 0.52161347166851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7027539011838427d, y: 0.66089204182534d), new NpgsqlTypes.NpgsqlPoint(x: 0.43941878156663483d, y: 0.14610805205002841d), new NpgsqlTypes.NpgsqlPoint(x: 0.44544867366581387d, y: 0.2508616465397614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2753891041079338d, y: 0.3072677924342214d), new NpgsqlTypes.NpgsqlPoint(x: 0.015963176465352502d, y: 0.8596000890843888d), new NpgsqlTypes.NpgsqlPoint(x: 0.341760851187621d, y: 0.29637681819064554d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3114011047901656d, y: 0.31952320580996885d), new NpgsqlTypes.NpgsqlPoint(x: 0.29670398684983057d, y: 0.020069230721936115d), new NpgsqlTypes.NpgsqlPoint(x: 0.15261196557855228d, y: 0.6661950506480165d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5126488950213682d, y: 0.5379555796459177d), new NpgsqlTypes.NpgsqlPoint(x: 0.4650695041011711d, y: 0.018804300578685873d), new NpgsqlTypes.NpgsqlPoint(x: 0.597777116536229d, y: 0.5867017594153949d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15219403800982478d, y: 0.3398029910308301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8678085615642573d, y: 0.33916234644201004d), new NpgsqlTypes.NpgsqlPoint(x: 0.738974923997627d, y: 0.6281805137955343d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32368761846774896d, y: 0.24897954400153055d), new NpgsqlTypes.NpgsqlPoint(x: 0.20183182460493487d, y: 0.05092968301187151d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701297411553006d, y: 0.17091845806491957d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6941934394692927d, y: 0.6486995715404252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835899209210088d, y: 0.17206857968973244d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024069801919724965d, y: 0.006490025426841073d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39327241905785115d, y: 0.9966519918210809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913027658593053d, y: 0.022737141313167175d), new NpgsqlTypes.NpgsqlPoint(x: 0.07299582353737921d, y: 0.3652027734564379d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10408920442132863d, y: 0.5527896205997492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7362082244015674d, y: 0.7249760397952735d), new NpgsqlTypes.NpgsqlPoint(x: 0.46822103607158927d, y: 0.4382325693832947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30898108773710453d, y: 0.6589192742034599d), new NpgsqlTypes.NpgsqlPoint(x: 0.8295602935178448d, y: 0.7058082870409873d), new NpgsqlTypes.NpgsqlPoint(x: 0.08759743251750662d, y: 0.6475269611722011d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8889013207984379d, y: 0.6684816555992986d), new NpgsqlTypes.NpgsqlPoint(x: 0.40488659201725086d, y: 0.33621171795925353d), new NpgsqlTypes.NpgsqlPoint(x: 0.25083589230437475d, y: 0.24926992046163454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23966037077189206d, y: 0.16705857876622898d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831474247850158d, y: 0.4858790842786821d), new NpgsqlTypes.NpgsqlPoint(x: 0.24958175064692312d, y: 0.9327336805154546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5971609993344917d, y: 0.3336130652831859d), new NpgsqlTypes.NpgsqlPoint(x: 0.4661288600804746d, y: 0.9506044831900393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619072981564164d, y: 0.5226283199004284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2215897406305961d, y: 0.26858468374003297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8977047555979234d, y: 0.023690889304077145d), new NpgsqlTypes.NpgsqlPoint(x: 0.1397487660051191d, y: 0.37588456034417594d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16457755303900046d, y: 0.8403046863866401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560616106552803d, y: 0.051450705937281516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662383671856732d, y: 0.22369844386207416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30014537672762964d, y: 0.4635731037413935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485640462759454d, y: 0.5526985536947864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440784236827677d, y: 0.06232208087120206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17800535004466622d, y: 0.3668160672597153d), new NpgsqlTypes.NpgsqlPoint(x: 0.14432756149692172d, y: 0.6688714103294574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9160803284805958d, y: 0.4573042252982833d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8231390090140049d, y: 0.8413334145498703d), new NpgsqlTypes.NpgsqlPoint(x: 0.17208694775251598d, y: 0.8778118240743922d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404909500898212d, y: 0.06443634537015908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20636236736619107d, y: 0.4122316774799252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6115275809191865d, y: 0.35468285178538383d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070951959281905d, y: 0.2588094558553644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21859417546602666d, y: 0.6214944873586001d), new NpgsqlTypes.NpgsqlPoint(x: 0.20267912394754217d, y: 0.21155674385912582d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561180904189259d, y: 0.9546658578610183d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5105612905394692d, y: 0.11973969564012366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443707421504748d, y: 0.4349792497772391d), new NpgsqlTypes.NpgsqlPoint(x: 0.16047851445555494d, y: 0.8820211348575416d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5619295544906177d, y: 0.24927468288516874d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324737263888428d, y: 0.9599161722881981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651998809390532d, y: 0.01411421758966136d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19251855977664534d, y: 0.9796484362612242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9857346324455903d, y: 0.18127319400065856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5858295930374714d, y: 0.10928513956711772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6645716192781878d, y: 0.5012564764209525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793377801036364d, y: 0.7863187410327969d), new NpgsqlTypes.NpgsqlPoint(x: 0.06258307217642134d, y: 0.9319775030765524d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.576580832454132d, y: 0.6607197656108557d), new NpgsqlTypes.NpgsqlPoint(x: 0.05280892715784202d, y: 0.5332603125081444d), new NpgsqlTypes.NpgsqlPoint(x: 0.18655262776297288d, y: 0.8116928784622328d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11825671713124908d, y: 0.8981242187502722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9399741768874358d, y: 0.14740885291442796d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267023226703997d, y: 0.7942714070672574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14156365071365995d, y: 0.34168653304834085d), new NpgsqlTypes.NpgsqlPoint(x: 0.848440066726593d, y: 0.8223591793718601d), new NpgsqlTypes.NpgsqlPoint(x: 0.39008647982122535d, y: 0.3635659461917776d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24251823163457786d, y: 0.8306046074778047d), new NpgsqlTypes.NpgsqlPoint(x: 0.3198093396610162d, y: 0.6324987187697584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4359324537872581d, y: 0.5072379625313841d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25956033371550713d, y: 0.26844505992849477d), new NpgsqlTypes.NpgsqlPoint(x: 0.06663071095402506d, y: 0.8513960768381624d), new NpgsqlTypes.NpgsqlPoint(x: 0.45919541775844264d, y: 0.06021675920050584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9092908295661808d, y: 0.21811027179512854d), new NpgsqlTypes.NpgsqlPoint(x: 0.47978816092854126d, y: 0.1700122062687901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181178557415008d, y: 0.3660188123006818d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23413156880966624d, y: 0.21575650427243676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432487359074152d, y: 0.0691931893464347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9044655334759768d, y: 0.32275143842658927d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8713099198476421d, y: 0.08656548164178812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5737125737881765d, y: 0.8698657419167004d), new NpgsqlTypes.NpgsqlPoint(x: 0.01325922329133744d, y: 0.00036432195679336754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9976911853075479d, y: 0.9428850572860775d), new NpgsqlTypes.NpgsqlPoint(x: 0.982245204479546d, y: 0.6680012251217082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6284685482049235d, y: 0.8725009491760628d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8970417724239229d, y: 0.6912555085042682d), new NpgsqlTypes.NpgsqlPoint(x: 0.18066210916850778d, y: 0.018679569651939065d), new NpgsqlTypes.NpgsqlPoint(x: 0.1235425478833827d, y: 0.8416598358104314d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5548711528174062d, y: 0.6338378080606066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7068677253343875d, y: 0.5656139382313218d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194011379483488d, y: 0.3193210122564206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45405504852441225d, y: 0.9144418672710736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282504310800642d, y: 0.46362036205700874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8691326845595005d, y: 0.4155197870422942d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.783731378477319d, y: 0.24023376459501333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060036054033761d, y: 0.23281273963959292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7311205488977716d, y: 0.5506169745122518d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7968169051734408d, y: 0.8586827346788295d), new NpgsqlTypes.NpgsqlPoint(x: 0.42018590808604206d, y: 0.22020081916707224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428794610110952d, y: 0.9088396381835803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305198906824416d, y: 0.04543450306162533d), new NpgsqlTypes.NpgsqlPoint(x: 0.06966976805642366d, y: 0.12057302708001338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348228188365758d, y: 0.6963973491701012d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17644465233651585d, y: 0.3723408214892161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491476627211256d, y: 0.08481851109040794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812155119005115d, y: 0.740336333296682d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06983774808077492d, y: 0.8149051102868315d), new NpgsqlTypes.NpgsqlPoint(x: 0.543483992647679d, y: 0.630266100757503d), new NpgsqlTypes.NpgsqlPoint(x: 0.6329237897944194d, y: 0.5727034032359317d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5241050820519141d, y: 0.9680991549353226d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731761639590773d, y: 0.9637336865309487d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172319651183217d, y: 0.15394524686866007d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7339301008569264d, y: 0.13085696819195802d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110870601156191d, y: 0.4439912436051008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095716201419085d, y: 0.9645893672614704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5401138542620402d, y: 0.04993826058631268d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617762535126327d, y: 0.5306604186946623d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412793301751403d, y: 0.293691455161615d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6181867263743885d, y: 0.703127907390331d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224082676895337d, y: 0.7965845508441494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105678529699954d, y: 0.9011430816862445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24318587518602197d, y: 0.7443634074219408d), new NpgsqlTypes.NpgsqlPoint(x: 0.9232069734173536d, y: 0.8765939533395432d), new NpgsqlTypes.NpgsqlPoint(x: 0.033914593735781984d, y: 0.9496904856060056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9292741192144135d, y: 0.2966281550349038d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673745417296389d, y: 0.9100533650880147d), new NpgsqlTypes.NpgsqlPoint(x: 0.008453663137461431d, y: 0.7771013556019076d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6451048180217364d, y: 0.10256331954760967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613437598967365d, y: 0.0957580095533036d), new NpgsqlTypes.NpgsqlPoint(x: 0.041065710642404385d, y: 0.1980158019708279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44550973087040757d, y: 0.2379833557708978d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431567858641943d, y: 0.1831308953871964d), new NpgsqlTypes.NpgsqlPoint(x: 0.562449060343404d, y: 0.23211678806067682d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8500245735162515d, y: 0.4150247913885431d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592164671306569d, y: 0.7813892011468229d), new NpgsqlTypes.NpgsqlPoint(x: 0.7272725484441146d, y: 0.9244160998962231d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11827840238874732d, y: 0.33715486365047476d), new NpgsqlTypes.NpgsqlPoint(x: 0.5423994931856255d, y: 0.3938155442702531d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106044028200452d, y: 0.4542976627459483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18707597778859864d, y: 0.9396183889966324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6981846520911257d, y: 0.6048984268617555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025134657961184d, y: 0.9628266506065084d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9454857629955273d, y: 0.35130402318754017d), new NpgsqlTypes.NpgsqlPoint(x: 0.23232000549028586d, y: 0.2565071889843401d), new NpgsqlTypes.NpgsqlPoint(x: 0.2045647426170547d, y: 0.9333940672596717d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.966921909893532d, y: 0.7920104790122371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380697336640437d, y: 0.11501930842205332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056208448348269d, y: 0.4411379475346493d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4529597011948826d, y: 0.2998785345970766d), new NpgsqlTypes.NpgsqlPoint(x: 0.22684508970343553d, y: 0.3188837714361519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651349650574704d, y: 0.49002631872687463d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9844565435675253d, y: 0.17665575357151608d), new NpgsqlTypes.NpgsqlPoint(x: 0.022644156971226903d, y: 0.19414399228082702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242577483635126d, y: 0.28073249524040333d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38360322456097673d, y: 0.5727770346074913d), new NpgsqlTypes.NpgsqlPoint(x: 0.008970506808770762d, y: 0.2978106794634917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060982401644297d, y: 0.026744962943825d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.599853673168559d, y: 0.25506663686018105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158054306490007d, y: 0.8762274151288152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5312001841388276d, y: 0.8044357327955323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39657639388737664d, y: 0.1813065382250063d), new NpgsqlTypes.NpgsqlPoint(x: 0.27304398515328754d, y: 0.7231040673406064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130408783893199d, y: 0.7862052285756681d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9225238597543215d, y: 0.7918634940409933d), new NpgsqlTypes.NpgsqlPoint(x: 0.969831188949586d, y: 0.4068296667025655d), new NpgsqlTypes.NpgsqlPoint(x: 0.09056876747785436d, y: 0.9275310394571981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5545560237652319d, y: 0.5265013823138651d), new NpgsqlTypes.NpgsqlPoint(x: 0.94665252816885d, y: 0.3484310645275044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151836852567432d, y: 0.01641730079852277d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8868470064508914d, y: 0.6066088377201183d), new NpgsqlTypes.NpgsqlPoint(x: 0.06902085848834927d, y: 0.7061738999417555d), new NpgsqlTypes.NpgsqlPoint(x: 0.534151726278812d, y: 0.013482543303557248d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042230950344069096d, y: 0.6770084391142197d), new NpgsqlTypes.NpgsqlPoint(x: 0.40337657203046684d, y: 0.7536965996158501d), new NpgsqlTypes.NpgsqlPoint(x: 0.28128877577724387d, y: 0.7950502648270893d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0844945163485934d, y: 0.6687086334961029d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121920909769308d, y: 0.8505446220580549d), new NpgsqlTypes.NpgsqlPoint(x: 0.10249832134609715d, y: 0.8557493099329141d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5695397585889067d, y: 0.38313594404768925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4242660110980071d, y: 0.6725588814528479d), new NpgsqlTypes.NpgsqlPoint(x: 0.3458658252154374d, y: 0.23387444331869622d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5708517425761618d, y: 0.8603530029444997d), new NpgsqlTypes.NpgsqlPoint(x: 0.3493578951043438d, y: 0.12628846904735203d), new NpgsqlTypes.NpgsqlPoint(x: 0.09542737043570604d, y: 0.15682619983860513d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5855132999331769d, y: 0.9886412274846061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934599276970621d, y: 0.16383442481080468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4446845894995157d, y: 0.6259958152437511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6751511308420867d, y: 0.18148011130720176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915781759824744d, y: 0.7369494468201483d), new NpgsqlTypes.NpgsqlPoint(x: 0.0021667525827533396d, y: 0.22879265050800512d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.958395199526156d, y: 0.9403341349842971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128092088630816d, y: 0.4234820558889153d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675261841518486d, y: 0.5572518764700494d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5043262779753331d, y: 0.9191223165983808d), new NpgsqlTypes.NpgsqlPoint(x: 0.2180813313520732d, y: 0.7832144234675587d), new NpgsqlTypes.NpgsqlPoint(x: 0.8579831906877873d, y: 0.1604305011159104d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5296159435205542d, y: 0.5463161541399602d), new NpgsqlTypes.NpgsqlPoint(x: 0.669189828934806d, y: 0.7526782198919637d), new NpgsqlTypes.NpgsqlPoint(x: 0.376546003660303d, y: 0.7355506014501865d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9473606093150383d, y: 0.4213924473372618d), new NpgsqlTypes.NpgsqlPoint(x: 0.3608052728599169d, y: 0.5720926352982125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136901530992916d, y: 0.1058242253806152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2888577218372397d, y: 0.8587223145884885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9400908510370082d, y: 0.8976155072917557d), new NpgsqlTypes.NpgsqlPoint(x: 0.35790122444610895d, y: 0.5535183985894859d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8563936849313858d, y: 0.18026053294173505d), new NpgsqlTypes.NpgsqlPoint(x: 0.3425024105222255d, y: 0.8719695711850247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953461734633038d, y: 0.15538028921391878d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6430031918486347d, y: 0.33878650489894246d), new NpgsqlTypes.NpgsqlPoint(x: 0.4068927446443463d, y: 0.9764043098736179d), new NpgsqlTypes.NpgsqlPoint(x: 0.11943803933319197d, y: 0.12732721708817263d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1424515785210282d, y: 0.6288652936223601d), new NpgsqlTypes.NpgsqlPoint(x: 0.08090522133823641d, y: 0.5863076894683578d), new NpgsqlTypes.NpgsqlPoint(x: 0.17704644199884578d, y: 0.6907465379839322d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1354221630045528d, y: 0.3450117767652455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521704941667942d, y: 0.6605101018838538d), new NpgsqlTypes.NpgsqlPoint(x: 0.901630473613968d, y: 0.6713725088165103d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4037297362041937d, y: 0.16156077159121496d), new NpgsqlTypes.NpgsqlPoint(x: 0.553918957713129d, y: 0.4744076745904765d), new NpgsqlTypes.NpgsqlPoint(x: 0.623187077889879d, y: 0.05501515887308028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5923457591177725d, y: 0.8595646258877109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7493297081362204d, y: 0.03132143405087606d), new NpgsqlTypes.NpgsqlPoint(x: 0.24251779892029313d, y: 0.803631245617345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08771237849261593d, y: 0.49055425019683385d), new NpgsqlTypes.NpgsqlPoint(x: 0.2971375906785967d, y: 0.7881019757426648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712288926804298d, y: 0.9446392063518004d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.262233764272677d, y: 0.8141270575755263d), new NpgsqlTypes.NpgsqlPoint(x: 0.47624281997781504d, y: 0.2680025677731802d), new NpgsqlTypes.NpgsqlPoint(x: 0.29565586200004335d, y: 0.3406734276452815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5462216269654876d, y: 0.8912918228394384d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204420265022996d, y: 0.6256783828637619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6478839006725043d, y: 0.5355512737280372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5412812894725686d, y: 0.07934049348934447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5300791041483797d, y: 0.5345971225275993d), new NpgsqlTypes.NpgsqlPoint(x: 0.1380764689650814d, y: 0.22345903525862043d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.917268347876396d, y: 0.2737669859573566d), new NpgsqlTypes.NpgsqlPoint(x: 0.17739140235169515d, y: 0.5096114627416709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249264702976828d, y: 0.8252519536064109d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09626332590822384d, y: 0.5546098793111502d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775793451151607d, y: 0.1294556932042682d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875631943856067d, y: 0.7862392516906084d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12442000505726081d, y: 0.8999300850299841d), new NpgsqlTypes.NpgsqlPoint(x: 0.15605594641390563d, y: 0.7241213340681785d), new NpgsqlTypes.NpgsqlPoint(x: 0.19122801501810305d, y: 0.9047383504683295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16388097471554963d, y: 0.06674882028401141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078975183914054d, y: 0.057296769032915695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128632701497061d, y: 0.8109091552250722d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515064293465274d, y: 0.42653872826912675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662278052982062d, y: 0.2991291099190285d), new NpgsqlTypes.NpgsqlPoint(x: 0.811782917002882d, y: 0.20067569929790974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45414325424534185d, y: 0.6379608546935128d), new NpgsqlTypes.NpgsqlPoint(x: 0.67216327294623d, y: 0.08779309733473617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8419881902411079d, y: 0.25727903414061204d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2516320790020157d, y: 0.9487651070798283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8147268549140356d, y: 0.5056624947253635d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842257519045627d, y: 0.32516354863895536d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7026392482370114d, y: 0.3875843187156258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442837130092316d, y: 0.32315664313268566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9076977391750324d, y: 0.7472944742359021d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1730800361796433d, y: 0.034125030449519866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9634396023806098d, y: 0.7379417429465601d), new NpgsqlTypes.NpgsqlPoint(x: 0.21486239861158962d, y: 0.10407757671989937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661921700808493d, y: 0.05329556119704948d), new NpgsqlTypes.NpgsqlPoint(x: 0.2666472668498837d, y: 0.4364599555957438d), new NpgsqlTypes.NpgsqlPoint(x: 0.38202842106078716d, y: 0.0892199331841208d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07486670093206083d, y: 0.8007401320409684d), new NpgsqlTypes.NpgsqlPoint(x: 0.300687184741498d, y: 0.24983469153767401d), new NpgsqlTypes.NpgsqlPoint(x: 0.061623919245078596d, y: 0.6560138065311345d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32577487590567944d, y: 0.26876087889782574d), new NpgsqlTypes.NpgsqlPoint(x: 0.060851625659004815d, y: 0.01745038159394363d), new NpgsqlTypes.NpgsqlPoint(x: 0.39288055490119667d, y: 0.5888923484531752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005472961683806843d, y: 0.871294001843103d), new NpgsqlTypes.NpgsqlPoint(x: 0.1805103448114589d, y: 0.9737546175507594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5683301481993616d, y: 0.18981982276598652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6867816683902149d, y: 0.6539889510643317d), new NpgsqlTypes.NpgsqlPoint(x: 0.6127735220076724d, y: 0.04150306755038924d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205685248573397d, y: 0.7317894432002728d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4088686280293333d, y: 0.11970625754296516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1399706459422505d, y: 0.8276324516661977d), new NpgsqlTypes.NpgsqlPoint(x: 0.412285109450265d, y: 0.702471315580878d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16423829617770946d, y: 0.3048008633005094d), new NpgsqlTypes.NpgsqlPoint(x: 0.46685846319999735d, y: 0.6502667556743436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658857718204646d, y: 0.7915329962226054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5127311613357753d, y: 0.1884929925590858d), new NpgsqlTypes.NpgsqlPoint(x: 0.2508989355068013d, y: 0.205970988130881d), new NpgsqlTypes.NpgsqlPoint(x: 0.30643537096973017d, y: 0.2790905885667687d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1068225179817277d, y: 0.07710094259964717d), new NpgsqlTypes.NpgsqlPoint(x: 0.2613053606761375d, y: 0.5409228462621358d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719259740842973d, y: 0.3377792906036674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5993828986149378d, y: 0.2619814036637673d), new NpgsqlTypes.NpgsqlPoint(x: 0.25280869344460566d, y: 0.937613467656923d), new NpgsqlTypes.NpgsqlPoint(x: 0.017059143783414443d, y: 0.06080615092026265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7516400684165294d, y: 0.31538014097705314d), new NpgsqlTypes.NpgsqlPoint(x: 0.4569248494606267d, y: 0.5548133870666053d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364365178743901d, y: 0.13994157051777734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6220460649120866d, y: 0.7970838374486082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706924058762243d, y: 0.8511997444387707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7479190967034055d, y: 0.251059731481556d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8232789876056905d, y: 0.9092929767975156d), new NpgsqlTypes.NpgsqlPoint(x: 0.10197044835708868d, y: 0.7947428414720938d), new NpgsqlTypes.NpgsqlPoint(x: 0.4865114665761655d, y: 0.7111167570735422d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2033047262713109d, y: 0.37999253418237056d), new NpgsqlTypes.NpgsqlPoint(x: 0.533530520499098d, y: 0.939208211600719d), new NpgsqlTypes.NpgsqlPoint(x: 0.886966632990931d, y: 0.46458413357948236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8406723270351281d, y: 0.03060529087232422d), new NpgsqlTypes.NpgsqlPoint(x: 0.4607591020207452d, y: 0.9940648300467174d), new NpgsqlTypes.NpgsqlPoint(x: 0.4617282155199398d, y: 0.8937537871965037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6598560774781719d, y: 0.31818575995050835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746652407029534d, y: 0.7290676949752262d), new NpgsqlTypes.NpgsqlPoint(x: 0.7474700788601857d, y: 0.32449386464008234d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9016769846840577d, y: 0.5568539545814336d), new NpgsqlTypes.NpgsqlPoint(x: 0.38370924689910146d, y: 0.014569751105150908d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155767510230596d, y: 0.16733345434943026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045414301212094776d, y: 0.4398020376856894d), new NpgsqlTypes.NpgsqlPoint(x: 0.06247192335677276d, y: 0.16627929976071754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707892888540256d, y: 0.2412687114300437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.859423679535109d, y: 0.7625237317025451d), new NpgsqlTypes.NpgsqlPoint(x: 0.38804786293786253d, y: 0.3175437350898742d), new NpgsqlTypes.NpgsqlPoint(x: 0.6942144566777407d, y: 0.137667836666023d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7043716930239625d, y: 0.5830394559821754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483087307329928d, y: 0.9254402289550286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342609878202349d, y: 0.5795920192475806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46393069715172186d, y: 0.24485863727258694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8643734989908878d, y: 0.8060998350441316d), new NpgsqlTypes.NpgsqlPoint(x: 0.15404751045665632d, y: 0.4300549684662849d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7011085516231051d, y: 0.9947086445976809d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619937231394382d, y: 0.9229045600533775d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789750371684993d, y: 0.35988476646901024d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3969359565650209d, y: 0.9462089587781429d), new NpgsqlTypes.NpgsqlPoint(x: 0.15018568005010569d, y: 0.4630062658136226d), new NpgsqlTypes.NpgsqlPoint(x: 0.4445528767746898d, y: 0.8738554096284094d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5623544620687111d, y: 0.961435399783309d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389800408167387d, y: 0.05717019403032064d), new NpgsqlTypes.NpgsqlPoint(x: 0.4488000123321939d, y: 0.34487178733990376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9190958988227916d, y: 0.6992173622618145d), new NpgsqlTypes.NpgsqlPoint(x: 0.2831919882840255d, y: 0.9095634216566824d), new NpgsqlTypes.NpgsqlPoint(x: 0.750011095868572d, y: 0.6861776556537461d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7742739590439441d, y: 0.06387491135401657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4538936280467071d, y: 0.7714421748474998d), new NpgsqlTypes.NpgsqlPoint(x: 0.2797095439799574d, y: 0.7096999655797998d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9087528106300856d, y: 0.8220583606911077d), new NpgsqlTypes.NpgsqlPoint(x: 0.49932523150569075d, y: 0.5780904595150413d), new NpgsqlTypes.NpgsqlPoint(x: 0.27267227094297286d, y: 0.9595680029322483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6971597345083805d, y: 0.6194889485716985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693715770235283d, y: 0.4768186007980765d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564503179312223d, y: 0.2249694155714903d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16411861378914572d, y: 0.6078120077936741d), new NpgsqlTypes.NpgsqlPoint(x: 0.3274269525214709d, y: 0.7062983587376311d), new NpgsqlTypes.NpgsqlPoint(x: 0.09224513816044833d, y: 0.3986232997180028d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2824411750103747d, y: 0.8211025764069048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434735080133388d, y: 0.40271125022982257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9077252819485151d, y: 0.6829327043928217d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14026659721590296d, y: 0.6212294275529313d), new NpgsqlTypes.NpgsqlPoint(x: 0.5497697259201114d, y: 0.3553075602178777d), new NpgsqlTypes.NpgsqlPoint(x: 0.4164090863293486d, y: 0.8337393120686549d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12182754299155252d, y: 0.6709203755925071d), new NpgsqlTypes.NpgsqlPoint(x: 0.18920954699492154d, y: 0.9200252555042663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042502485064547d, y: 0.6558399783807389d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7319689336188372d, y: 0.6343990135701676d), new NpgsqlTypes.NpgsqlPoint(x: 0.13580377110511122d, y: 0.5611061201685434d), new NpgsqlTypes.NpgsqlPoint(x: 0.044607263086766435d, y: 0.5954734387376233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6887763720455413d, y: 0.16030901065629377d), new NpgsqlTypes.NpgsqlPoint(x: 0.2676096105064858d, y: 0.850507341379321d), new NpgsqlTypes.NpgsqlPoint(x: 0.45320848261118674d, y: 0.29370879937678285d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6240887902443628d, y: 0.8497082944438477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862498351420844d, y: 0.9049197898939384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913690864359933d, y: 0.44086086292374127d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.985089975852117d, y: 0.6888670258134524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720297804994861d, y: 0.7931723691730125d), new NpgsqlTypes.NpgsqlPoint(x: 0.672674672020879d, y: 0.7734575539088384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017066908681926618d, y: 0.8114166508012333d), new NpgsqlTypes.NpgsqlPoint(x: 0.806333753997149d, y: 0.5476291426354213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5311932993666494d, y: 0.9290050418141074d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8357143687123486d, y: 0.3076385650083219d), new NpgsqlTypes.NpgsqlPoint(x: 0.870273047927373d, y: 0.9453688743361542d), new NpgsqlTypes.NpgsqlPoint(x: 0.0007702864623647665d, y: 0.4295303618236681d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14323748450641627d, y: 0.5699826623648214d), new NpgsqlTypes.NpgsqlPoint(x: 0.10042305631696402d, y: 0.6943205301947083d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320203190100899d, y: 0.25469920592486894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4809785091838451d, y: 0.35009496714783206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7161461057543109d, y: 0.5249619100598526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101205604813806d, y: 0.05384446393570674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9036199375690805d, y: 0.6399392932374445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765948808531559d, y: 0.7383895040507544d), new NpgsqlTypes.NpgsqlPoint(x: 0.2961785071755981d, y: 0.9246299622447283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8370229482188591d, y: 0.7391641999981149d), new NpgsqlTypes.NpgsqlPoint(x: 0.8548544364715859d, y: 0.27719819053098893d), new NpgsqlTypes.NpgsqlPoint(x: 0.720778843800101d, y: 0.0008283475081278802d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008775201791306753d, y: 0.9289302506804714d), new NpgsqlTypes.NpgsqlPoint(x: 0.4112271852108721d, y: 0.9794015350348438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8016337281236298d, y: 0.04876916674666576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31922000727786937d, y: 0.13324614185158468d), new NpgsqlTypes.NpgsqlPoint(x: 0.3077814471122291d, y: 0.1514566375150187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2280978949964445d, y: 0.4851743797489526d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7250972018380594d, y: 0.1621878716035705d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520114084573339d, y: 0.10157768500263642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624984078029204d, y: 0.2994404417056372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12033157313453102d, y: 0.9027855279834462d), new NpgsqlTypes.NpgsqlPoint(x: 0.3760051214655582d, y: 0.9099127231997542d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034613631651666d, y: 0.46736452641697257d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35746676940524547d, y: 0.7074642811648439d), new NpgsqlTypes.NpgsqlPoint(x: 0.306473122903381d, y: 0.48937096805561664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658761470864969d, y: 0.4599607039339749d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39183526285280257d, y: 0.5155816224033044d), new NpgsqlTypes.NpgsqlPoint(x: 0.2093288300435452d, y: 0.9142870197410776d), new NpgsqlTypes.NpgsqlPoint(x: 0.25106456796577326d, y: 0.6076705867129518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32502954290557506d, y: 0.6156386167387021d), new NpgsqlTypes.NpgsqlPoint(x: 0.08866129137195156d, y: 0.61327198167085d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813611127276408d, y: 0.30908562477046964d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22870963832288882d, y: 0.18653731747851188d), new NpgsqlTypes.NpgsqlPoint(x: 0.30967408225571247d, y: 0.40408427408982595d), new NpgsqlTypes.NpgsqlPoint(x: 0.3409707959881362d, y: 0.5305335354217867d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6537150668564283d, y: 0.6516708205878112d), new NpgsqlTypes.NpgsqlPoint(x: 0.3118342063787578d, y: 0.47954177327106573d), new NpgsqlTypes.NpgsqlPoint(x: 0.05568208319516532d, y: 0.9391091772565304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9298283393749781d, y: 0.6721415148048497d), new NpgsqlTypes.NpgsqlPoint(x: 0.36363357192254764d, y: 0.9962249774092934d), new NpgsqlTypes.NpgsqlPoint(x: 0.15261650928082704d, y: 0.6529699442908292d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8313597701353124d, y: 0.8805516414006942d), new NpgsqlTypes.NpgsqlPoint(x: 0.2902805967060146d, y: 0.7603853020780069d), new NpgsqlTypes.NpgsqlPoint(x: 0.06461968917299643d, y: 0.8596198101017153d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21487187583236644d, y: 0.3485915211264954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968166530819238d, y: 0.5051304106832221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136420672881964d, y: 0.2368898828255145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2360944485541956d, y: 0.09417734505096254d), new NpgsqlTypes.NpgsqlPoint(x: 0.3293007525689975d, y: 0.8536818543958141d), new NpgsqlTypes.NpgsqlPoint(x: 0.19245226423471706d, y: 0.15591481416559017d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6161475599427874d, y: 0.3643600755014951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9543883442646927d, y: 0.371796121308977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6692319618769d, y: 0.1320727818637275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34797316320308913d, y: 0.46611942473371815d), new NpgsqlTypes.NpgsqlPoint(x: 0.24792867977780852d, y: 0.0765833399771283d), new NpgsqlTypes.NpgsqlPoint(x: 0.20085375864462507d, y: 0.6973657264287308d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38298609646618365d, y: 0.14016221449930555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4934081444878764d, y: 0.06524379648245737d), new NpgsqlTypes.NpgsqlPoint(x: 0.08325830453152439d, y: 0.6950094929190026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45046905828111383d, y: 0.144951902672948d), new NpgsqlTypes.NpgsqlPoint(x: 0.05682266364401656d, y: 0.23198585291465412d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565656088378169d, y: 0.9105910928599225d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8293887712897563d, y: 0.16718518002212523d), new NpgsqlTypes.NpgsqlPoint(x: 0.08790680207614288d, y: 0.8993884564964065d), new NpgsqlTypes.NpgsqlPoint(x: 0.2723951388569372d, y: 0.3477997064137921d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4182381740820781d, y: 0.8135227007152083d), new NpgsqlTypes.NpgsqlPoint(x: 0.14227815982520509d, y: 0.7625716560399767d), new NpgsqlTypes.NpgsqlPoint(x: 0.033618035497998466d, y: 0.09745672462615862d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9913909617063721d, y: 0.671530647087815d), new NpgsqlTypes.NpgsqlPoint(x: 0.0867940673680454d, y: 0.79046639912492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8655061906549459d, y: 0.6229490644588846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6406668066618266d, y: 0.41990223031561025d), new NpgsqlTypes.NpgsqlPoint(x: 0.18118515669427926d, y: 0.8323014931293545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164916100259424d, y: 0.009232083541087066d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17851266726723547d, y: 0.5946842701214369d), new NpgsqlTypes.NpgsqlPoint(x: 0.2873354803654098d, y: 0.9802461474692113d), new NpgsqlTypes.NpgsqlPoint(x: 0.14571065936257266d, y: 0.2461621568426282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.741840907674471d, y: 0.15696401428634832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991808664386133d, y: 0.9829817294639552d), new NpgsqlTypes.NpgsqlPoint(x: 0.4492618451193239d, y: 0.5170527000616592d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39665710539170673d, y: 0.7217358724620868d), new NpgsqlTypes.NpgsqlPoint(x: 0.05095183225038391d, y: 0.2858483093711258d), new NpgsqlTypes.NpgsqlPoint(x: 0.09672878062999524d, y: 0.7913148091235338d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754539079200654d, y: 0.9607245588911607d), new NpgsqlTypes.NpgsqlPoint(x: 0.4218181689188817d, y: 0.6523674204870505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559020253811349d, y: 0.23375100731232d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5205668494627089d, y: 0.3190958980396713d), new NpgsqlTypes.NpgsqlPoint(x: 0.17141323762453398d, y: 0.0834934673832134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775163253326017d, y: 0.853616858376674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15932729644546828d, y: 0.07305799881139263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8555868605251075d, y: 0.07571266220716377d), new NpgsqlTypes.NpgsqlPoint(x: 0.03226751479219281d, y: 0.3919850834994404d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20423550194763584d, y: 0.8873557232466054d), new NpgsqlTypes.NpgsqlPoint(x: 0.16143413833871167d, y: 0.7837893497633398d), new NpgsqlTypes.NpgsqlPoint(x: 0.6892382510945433d, y: 0.6270108419183203d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22933136304830082d, y: 0.64236356682694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091154459483422d, y: 0.15003888520417064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8152825719419353d, y: 0.8030825173750338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3933092591122771d, y: 0.4446587074313254d), new NpgsqlTypes.NpgsqlPoint(x: 0.18964284767425243d, y: 0.8237545193873606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412846378491868d, y: 0.9967479220270776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27984948717000935d, y: 0.7439119285044372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7865478383617441d, y: 0.03336125653489164d), new NpgsqlTypes.NpgsqlPoint(x: 0.23310852319177644d, y: 0.8555007387526369d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2790969410032379d, y: 0.7491527448495164d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902393437913148d, y: 0.8459561333585446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880792971219066d, y: 0.1766046920269203d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8343394494543899d, y: 0.7177457276052407d), new NpgsqlTypes.NpgsqlPoint(x: 0.19869768975455337d, y: 0.36950770864471727d), new NpgsqlTypes.NpgsqlPoint(x: 0.05171179053947317d, y: 0.7055611300803839d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8494341417369847d, y: 0.08201555776875258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766201030535387d, y: 0.5219174175811175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3575262557898249d, y: 0.4365858784694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19021125980223552d, y: 0.3863421485558005d), new NpgsqlTypes.NpgsqlPoint(x: 0.04929347622319191d, y: 0.8561044553023012d), new NpgsqlTypes.NpgsqlPoint(x: 0.49909012824752474d, y: 0.8552864348369009d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08778715546368332d, y: 0.0673933448325158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760179380101965d, y: 0.12322496531690574d), new NpgsqlTypes.NpgsqlPoint(x: 0.570038253488163d, y: 0.8488097468460959d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33700026740445366d, y: 0.6287196255679053d), new NpgsqlTypes.NpgsqlPoint(x: 0.772592237647962d, y: 0.2735994904489323d), new NpgsqlTypes.NpgsqlPoint(x: 0.2894645025194571d, y: 0.20635244806763808d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.402922598904192d, y: 0.4926552644573573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8689791563857271d, y: 0.6943497531650066d), new NpgsqlTypes.NpgsqlPoint(x: 0.19684680066733606d, y: 0.31396100120338843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1647086056496031d, y: 0.7317738344214227d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275892483896028d, y: 0.8186616312723245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070601963586793d, y: 0.5314106823750572d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2064927197474794d, y: 0.43651082817064524d), new NpgsqlTypes.NpgsqlPoint(x: 0.571603434078791d, y: 0.15286697448562225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8488543002632694d, y: 0.7753055288565892d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35943668417909547d, y: 0.19524568754797444d), new NpgsqlTypes.NpgsqlPoint(x: 0.0031889821255802753d, y: 0.7234841223384476d), new NpgsqlTypes.NpgsqlPoint(x: 0.06043064427206779d, y: 0.6859617129020793d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5991354215675079d, y: 0.37865410139986433d), new NpgsqlTypes.NpgsqlPoint(x: 0.8713112302620764d, y: 0.37106698193918186d), new NpgsqlTypes.NpgsqlPoint(x: 0.04917415338103459d, y: 0.8805903747470165d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29070118518625d, y: 0.6557879921287417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218035199833891d, y: 0.64086759832791d), new NpgsqlTypes.NpgsqlPoint(x: 0.19395957925886387d, y: 0.5502599093773032d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6172579607171191d, y: 0.7241264984537961d), new NpgsqlTypes.NpgsqlPoint(x: 0.12270876984571233d, y: 0.19058214103616333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9453774878207231d, y: 0.022606495284941297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24398708651419931d, y: 0.0722981313396559d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329545754842065d, y: 0.9112782666160844d), new NpgsqlTypes.NpgsqlPoint(x: 0.07407791178080536d, y: 0.02163099538513713d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19219489927115252d, y: 0.8862230995625524d), new NpgsqlTypes.NpgsqlPoint(x: 0.20394123556904575d, y: 0.4492353114417099d), new NpgsqlTypes.NpgsqlPoint(x: 0.39391549677660864d, y: 0.7061827444118615d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.83291642154571d, y: 0.304244521949693d), new NpgsqlTypes.NpgsqlPoint(x: 0.783442556185361d, y: 0.76927931470384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7952943003471287d, y: 0.14387322944617642d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22195184262220602d, y: 0.9663262027541292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5353963724244065d, y: 0.3079605449456121d), new NpgsqlTypes.NpgsqlPoint(x: 0.0847126653750544d, y: 0.6001095222183406d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7624652712129987d, y: 0.36500773835588574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133167502900841d, y: 0.7666780862875546d), new NpgsqlTypes.NpgsqlPoint(x: 0.608205644744477d, y: 0.3614754758674673d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5729763756691948d, y: 0.7623606513367788d), new NpgsqlTypes.NpgsqlPoint(x: 0.41002701619446336d, y: 0.15240039882748946d), new NpgsqlTypes.NpgsqlPoint(x: 0.935807325250942d, y: 0.8592548316679799d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42541325753700754d, y: 0.0910815086122897d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314184290980092d, y: 0.5946358936028475d), new NpgsqlTypes.NpgsqlPoint(x: 0.17103613334155954d, y: 0.6960275632279543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1380737159339569d, y: 0.7607550676793852d), new NpgsqlTypes.NpgsqlPoint(x: 0.669287365719664d, y: 0.3176833169127268d), new NpgsqlTypes.NpgsqlPoint(x: 0.1443050141625506d, y: 0.07599611128530281d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.369988538925312d, y: 0.5614305448768219d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921781705949841d, y: 0.7529328310192261d), new NpgsqlTypes.NpgsqlPoint(x: 0.44759874258188215d, y: 0.9162809174187864d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09054612185313071d, y: 0.5674166282753407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678764013824198d, y: 0.7969356967766443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3452795259119903d, y: 0.8855459644646484d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9777188981370267d, y: 0.618785890075454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4842023896974811d, y: 0.8443527938016251d), new NpgsqlTypes.NpgsqlPoint(x: 0.831372494098043d, y: 0.8039066971890091d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033421790053041134d, y: 0.945309867067597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9506792878363368d, y: 0.5796161562684661d), new NpgsqlTypes.NpgsqlPoint(x: 0.12212367758892517d, y: 0.5726367495962625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3369864095425412d, y: 0.2524554916870162d), new NpgsqlTypes.NpgsqlPoint(x: 0.0763124900975597d, y: 0.3719524004653234d), new NpgsqlTypes.NpgsqlPoint(x: 0.005819827770353725d, y: 0.2215005208807771d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8678815036618035d, y: 0.0003029923726227679d), new NpgsqlTypes.NpgsqlPoint(x: 0.9024992536922508d, y: 0.7804133323861762d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832803060479128d, y: 0.7646524904144688d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4374930359935353d, y: 0.37598232650189833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430389690993257d, y: 0.1674041227863874d), new NpgsqlTypes.NpgsqlPoint(x: 0.012637569368982193d, y: 0.7916252402081939d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9158175078786094d, y: 0.08122677223573294d), new NpgsqlTypes.NpgsqlPoint(x: 0.929671107232654d, y: 0.6924853391789936d), new NpgsqlTypes.NpgsqlPoint(x: 0.6779712486449614d, y: 0.8092022511755179d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8538512134471321d, y: 0.9653078162512182d), new NpgsqlTypes.NpgsqlPoint(x: 0.513432967461576d, y: 0.8509630971316156d), new NpgsqlTypes.NpgsqlPoint(x: 0.35899190405961934d, y: 0.6992939356762272d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5119907101475235d, y: 0.5951271142425538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6118933744610819d, y: 0.6701453675042921d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726983694771885d, y: 0.7155075851630199d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0037174659153726974d, y: 0.23935675798232325d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658634362554276d, y: 0.13066877989803172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7466284630991817d, y: 0.48974717335063955d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21464522303022782d, y: 0.6472489235091576d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968451943383084d, y: 0.36469210909091687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243006363463977d, y: 0.2621299823380374d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6710350568009309d, y: 0.9377777964957663d), new NpgsqlTypes.NpgsqlPoint(x: 0.32821770542482287d, y: 0.7099577982895829d), new NpgsqlTypes.NpgsqlPoint(x: 0.9592291821632474d, y: 0.08911279092691038d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4667843427857813d, y: 0.434805166893666d), new NpgsqlTypes.NpgsqlPoint(x: 0.4335425792352138d, y: 0.9993300760808295d), new NpgsqlTypes.NpgsqlPoint(x: 0.701327905539221d, y: 0.025848278072379216d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6169411794936664d, y: 0.2802712648098402d), new NpgsqlTypes.NpgsqlPoint(x: 0.22508696196291222d, y: 0.5346878613161585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9576933598419883d, y: 0.07997375304108889d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.462283642942816d, y: 0.5300885471912894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163095540663719d, y: 0.6273104365378588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7834659165106184d, y: 0.6226791439385759d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7007031772766198d, y: 0.4196564767693248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557226373431258d, y: 0.1830186898345867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7038396004685741d, y: 0.5057617387850604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8295189901257006d, y: 0.7831918504186052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5289647524096266d, y: 0.16207320829680816d), new NpgsqlTypes.NpgsqlPoint(x: 0.982054061661832d, y: 0.16755549743884623d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9327884319518073d, y: 0.015621308329946904d), new NpgsqlTypes.NpgsqlPoint(x: 0.27330106665596443d, y: 0.8615099201291008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944361217686557d, y: 0.8286215910338653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06824671814246208d, y: 0.8682513343683186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248800110284169d, y: 0.2841988027989739d), new NpgsqlTypes.NpgsqlPoint(x: 0.1397067724375297d, y: 0.8798596554592262d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28375244548776d, y: 0.990983573353602d), new NpgsqlTypes.NpgsqlPoint(x: 0.08179541389840328d, y: 0.5727135905618433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5936953444067669d, y: 0.25057458029669843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5675202511083326d, y: 0.24880817407020073d), new NpgsqlTypes.NpgsqlPoint(x: 0.938657923712985d, y: 0.09226599781542522d), new NpgsqlTypes.NpgsqlPoint(x: 0.22397722818297772d, y: 0.3730804741505247d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805236918664431d, y: 0.9487881119329776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7102137332641935d, y: 0.1092168310234728d), new NpgsqlTypes.NpgsqlPoint(x: 0.1976390970750732d, y: 0.12612612175921767d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8612785768953568d, y: 0.6333370776083093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818278452082435d, y: 0.7277999852315369d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110253725618711d, y: 0.8290911529034981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9785481488595326d, y: 0.4008614014275469d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969206469542881d, y: 0.614431375798212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899206254028856d, y: 0.38531861698083303d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10827163596897071d, y: 0.9672457901795073d), new NpgsqlTypes.NpgsqlPoint(x: 0.12052485280881753d, y: 0.9798930980841533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315758670048061d, y: 0.8395233927941247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5693922271003488d, y: 0.730521477951908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889620730364339d, y: 0.5497850584287075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6879488936798122d, y: 0.8939504424889824d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07348765886276731d, y: 0.4242243855121447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459539659132361d, y: 0.9679151175113505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717604399184025d, y: 0.06101358805311963d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8975291907035582d, y: 0.9675270511177035d), new NpgsqlTypes.NpgsqlPoint(x: 0.17374420406135416d, y: 0.556324695616854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708730033027933d, y: 0.5064603554785952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19065850344564816d, y: 0.5153336276624418d), new NpgsqlTypes.NpgsqlPoint(x: 0.743246985314621d, y: 0.4338953857651554d), new NpgsqlTypes.NpgsqlPoint(x: 0.011963130153897827d, y: 0.09566497185841105d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1848104797258613d, y: 0.34166833243732486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045759514934503d, y: 0.3466093669259658d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628681918601705d, y: 0.2742353768598699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5871333875415252d, y: 0.7350724020546184d), new NpgsqlTypes.NpgsqlPoint(x: 0.45959985271220727d, y: 0.7525505176790418d), new NpgsqlTypes.NpgsqlPoint(x: 0.15782706197313512d, y: 0.7032712227171238d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6922855246579878d, y: 0.1878860079231367d), new NpgsqlTypes.NpgsqlPoint(x: 0.05616841088775826d, y: 0.5749580201263171d), new NpgsqlTypes.NpgsqlPoint(x: 0.11206824730368226d, y: 0.16555079378012438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27930831583347837d, y: 0.05873467019508005d), new NpgsqlTypes.NpgsqlPoint(x: 0.1832065991087075d, y: 0.7738040808798817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377816689648848d, y: 0.7146357038321745d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5321861632313941d, y: 0.02721876997155437d), new NpgsqlTypes.NpgsqlPoint(x: 0.1322140666368341d, y: 0.14541997678542207d), new NpgsqlTypes.NpgsqlPoint(x: 0.6220412806715913d, y: 0.23923733538353575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4287909858790083d, y: 0.411665720497853d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845569688427241d, y: 0.6563402526589345d), new NpgsqlTypes.NpgsqlPoint(x: 0.2264841607959499d, y: 0.5059430502432426d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8792322953003577d, y: 0.7576331812426077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568873937623917d, y: 0.3852961507425542d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451284986434073d, y: 0.4549420377790766d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.937719789042481d, y: 0.8956213345820104d), new NpgsqlTypes.NpgsqlPoint(x: 0.577493488812935d, y: 0.44755478060677234d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337421144857748d, y: 0.8463873257194987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5140615448766231d, y: 0.4547253640336173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137281958197472d, y: 0.22894347767668088d), new NpgsqlTypes.NpgsqlPoint(x: 0.610687011438679d, y: 0.8555220391605902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6975949676071787d, y: 0.3833520684635382d), new NpgsqlTypes.NpgsqlPoint(x: 0.521270425359833d, y: 0.2432482801923158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7879424115417514d, y: 0.9152065456599439d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9910795532832763d, y: 0.20820683738330303d), new NpgsqlTypes.NpgsqlPoint(x: 0.48468358073690565d, y: 0.6815623400224005d), new NpgsqlTypes.NpgsqlPoint(x: 0.186246780001051d, y: 0.45572515329514096d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2701013207207371d, y: 0.9419681310342802d), new NpgsqlTypes.NpgsqlPoint(x: 0.797649621378471d, y: 0.1274503700930708d), new NpgsqlTypes.NpgsqlPoint(x: 0.09111450148792677d, y: 0.11729031706633941d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4094588952406518d, y: 0.47227580296901484d), new NpgsqlTypes.NpgsqlPoint(x: 0.12489294187463418d, y: 0.32579641650122504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7466673940773704d, y: 0.6643638414762445d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08333235035727127d, y: 0.42910414964875454d), new NpgsqlTypes.NpgsqlPoint(x: 0.30745076584727893d, y: 0.6475641136956636d), new NpgsqlTypes.NpgsqlPoint(x: 0.45757592007145675d, y: 0.6304740303226296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4310933933558615d, y: 0.711443403856288d), new NpgsqlTypes.NpgsqlPoint(x: 0.25557764205237476d, y: 0.23337204120725596d), new NpgsqlTypes.NpgsqlPoint(x: 0.1108636795934651d, y: 0.08636165503353554d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6150486732106601d, y: 0.0913214250652119d), new NpgsqlTypes.NpgsqlPoint(x: 0.41361789222650003d, y: 0.08163970042112467d), new NpgsqlTypes.NpgsqlPoint(x: 0.03073159728570618d, y: 0.29238486842359324d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11493792542938208d, y: 0.7138840192576912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7204684519830281d, y: 0.40370333334661446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6333009103346015d, y: 0.7645741719323741d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8770144644988138d, y: 0.097747585509109d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650335519127039d, y: 0.12052294798540908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496763873214465d, y: 0.3957408009996227d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3036412955739526d, y: 0.4527923577381381d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704567076596835d, y: 0.8723777533861561d), new NpgsqlTypes.NpgsqlPoint(x: 0.2510925712864631d, y: 0.33014693999150524d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 198,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6893355646666404d, y: 0.11384569097138864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9099290741371778d, y: 0.2600840827771159d), new NpgsqlTypes.NpgsqlPoint(x: 0.2599419971665987d, y: 0.08146089315730654d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7053758231547759d, y: 0.4523066016523659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939049461228594d, y: 0.16207154121660328d), new NpgsqlTypes.NpgsqlPoint(x: 0.15518247811198027d, y: 0.6808109166117934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2907797539943777d, y: 0.7506496133913926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481682824603181d, y: 0.30988687103993284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3615742138489195d, y: 0.5926000387741645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1313158312621352d, y: 0.3933916719216768d), new NpgsqlTypes.NpgsqlPoint(x: 0.6672745569384798d, y: 0.5410720280896117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9751325374562091d, y: 0.012230828620030998d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9221703627894013d, y: 0.5767471791181341d), new NpgsqlTypes.NpgsqlPoint(x: 0.038574497730050394d, y: 0.13364185234550896d), new NpgsqlTypes.NpgsqlPoint(x: 0.29659103429407907d, y: 0.785845337856131d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021115906055319655d, y: 0.8265592134072317d), new NpgsqlTypes.NpgsqlPoint(x: 0.008595542990537997d, y: 0.5073921088105255d), new NpgsqlTypes.NpgsqlPoint(x: 0.47098093476716096d, y: 0.26031802477401467d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8971756393378943d, y: 0.5122560538192741d), new NpgsqlTypes.NpgsqlPoint(x: 0.18695248416256727d, y: 0.535253186654976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8470688684853651d, y: 0.9384517681799944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40542376103754985d, y: 0.6636799792913287d), new NpgsqlTypes.NpgsqlPoint(x: 0.4374356564782741d, y: 0.9736026281465183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9081452710703583d, y: 0.04320366358552119d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 201,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5850870609405847d, y: 0.43263150171155595d), new NpgsqlTypes.NpgsqlPoint(x: 0.0967902865837269d, y: 0.5486159291234457d), new NpgsqlTypes.NpgsqlPoint(x: 0.4508629630629053d, y: 0.9886752833758748d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9282490232865835d, y: 0.3346195345173788d), new NpgsqlTypes.NpgsqlPoint(x: 0.40673163995803274d, y: 0.7747032612146204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6143048328339384d, y: 0.5108789258995747d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811324625833146d, y: 0.48832368624590616d), new NpgsqlTypes.NpgsqlPoint(x: 0.12060656935719738d, y: 0.19516088730325198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4656495141170379d, y: 0.9561451419000504d)),

},
    ModelInner = new NpgsqlPathpathListD12MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0032644166696637056d, y: 0.6013115421118883d), new NpgsqlTypes.NpgsqlPoint(x: 0.21409277649784497d, y: 0.2608910486745928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8940897323217498d, y: 0.0802523791231814d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42890425650882136d, y: 0.7403063671342538d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766347943110631d, y: 0.059760554232920926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6754744337509778d, y: 0.8161754879526051d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9505444152941289d, y: 0.4956095519567868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5968587155863669d, y: 0.1063171616243439d), new NpgsqlTypes.NpgsqlPoint(x: 0.031625294580042485d, y: 0.8908280305465047d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48081574359011403d, y: 0.0013159053196873938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8836914015857533d, y: 0.7129232390570309d), new NpgsqlTypes.NpgsqlPoint(x: 0.3600443946358013d, y: 0.33783193137281753d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49631926459564146d, y: 0.34066521426852214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878178202349844d, y: 0.49085909188098953d), new NpgsqlTypes.NpgsqlPoint(x: 0.21062335460636517d, y: 0.38552735869207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0592228084950408d, y: 0.19635831837982676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389437971296131d, y: 0.050649837578949364d), new NpgsqlTypes.NpgsqlPoint(x: 0.9027747681649173d, y: 0.20768642389220404d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1971313650891352d, y: 0.4687592149482287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6736979835851371d, y: 0.565153210494574d), new NpgsqlTypes.NpgsqlPoint(x: 0.28698295224431136d, y: 0.30569258711496583d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.681879505743024d, y: 0.045244107284678425d), new NpgsqlTypes.NpgsqlPoint(x: 0.13118673336869047d, y: 0.05188823044796842d), new NpgsqlTypes.NpgsqlPoint(x: 0.013589203395140137d, y: 0.43613413042005045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49645588879974234d, y: 0.8621034765404146d), new NpgsqlTypes.NpgsqlPoint(x: 0.2839700878171689d, y: 0.9887148571365131d), new NpgsqlTypes.NpgsqlPoint(x: 0.633344424421174d, y: 0.15232288629013946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229098244247943d, y: 0.008857633377947538d), new NpgsqlTypes.NpgsqlPoint(x: 0.2564401190133897d, y: 0.4811429096890075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056582125994513d, y: 0.005159600522293917d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 205,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28072226995221594d, y: 0.5376844637575747d), new NpgsqlTypes.NpgsqlPoint(x: 0.42182494697368855d, y: 0.744668408869971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991767438231707d, y: 0.1845156260247176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7498947053266538d, y: 0.6310027685127639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151771791681578d, y: 0.12091747737794323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5664437169656433d, y: 0.9903713685210608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.599387901423658d, y: 0.30595042826021934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8681799398674896d, y: 0.9903562188702764d), new NpgsqlTypes.NpgsqlPoint(x: 0.011371695152560979d, y: 0.6267290286250649d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24315063004425497d, y: 0.5324156288511995d), new NpgsqlTypes.NpgsqlPoint(x: 0.43263891489918493d, y: 0.4673385708162997d), new NpgsqlTypes.NpgsqlPoint(x: 0.07232827290440369d, y: 0.7215105686630585d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754488506315034d, y: 0.959016732922679d), new NpgsqlTypes.NpgsqlPoint(x: 0.00864870855174249d, y: 0.9180431302637796d), new NpgsqlTypes.NpgsqlPoint(x: 0.290722530625415d, y: 0.32655994681655487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7095288859623299d, y: 0.15968087408911746d), new NpgsqlTypes.NpgsqlPoint(x: 0.19189131274391602d, y: 0.7739959522446287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7556633988066725d, y: 0.5086500972265134d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1989223052288943d, y: 0.7873824347748952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791057839212269d, y: 0.809486126087909d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355400673328395d, y: 0.5921277021913551d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27328228809281485d, y: 0.3220801153540379d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673821789356305d, y: 0.01699998641059619d), new NpgsqlTypes.NpgsqlPoint(x: 0.09160338375192167d, y: 0.9611694972090105d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd12mi(
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
INSERT INTO public.npgsqlpathpathlistd12mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathListD12MI)],
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
    npgsqlpathpathlistd12mi_id
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
                methodParametrName: "npgsqlpathpathlistd12mi_id", 
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
    npgsqlpathpathlistd12mi_id
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
    npgsqlpathpathlistd12mi_id,
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
    npgsqlpathpathlistd12mi_id
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
    npgsqlpathpathlistd12mi_id,
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
                methodParametrName: "npgsqlpathpathlistd12mi_id", 
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
LEFT JOIN public.npgsqlpathpathlistd12mi mi ON mi.id = m.npgsqlpathpathlistd12mi_id
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
LEFT JOIN public.npgsqlpathpathlistd12mi mi ON mi.id = m.npgsqlpathpathlistd12mi_id
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 186;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
LEFT JOIN public.npgsqlpathpathlistd12mi mi ON mi.id = m.npgsqlpathpathlistd12mi_id
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 190;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[34], false);
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
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 196, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 113, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 130, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 42, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 135, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[34], false);
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
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 190, query1, 142, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 42, query1, 142, query2))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[34], false);
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
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 190, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
LEFT JOIN public.npgsqlpathpathlistd12mi mi ON mi.id = m.npgsqlpathpathlistd12mi_id
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 87, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 33, 107))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[34], false);
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
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[6], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[7], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[8], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[9], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[10], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[11], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[12], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[13], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[14], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[15], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[16], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[17], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[18], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[19], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[20], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[21], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[22], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[23], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqlpathpathlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA)],
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
            queryMapType: typeof(NpgsqlPathpathListD12MIWA),
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
                var importCollection = new List<NpgsqlPathpathListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA)],
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
            queryMapType: typeof(NpgsqlPathpathListD12MIWA),
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
                var importCollection = new List<NpgsqlPathpathListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MI)],
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
COPY public.binary_npgsqlpathpathlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD12MI),
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
                var importCollection = new List<NpgsqlPathpathListD12MI>(2);
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
                    NpgsqlPathpathListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD12MI>(2);
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
                    NpgsqlPathpathListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA)],
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
COPY public.binary_npgsqlpathpathlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD12MIWA),
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
                var importCollection = new List<NpgsqlPathpathListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD12MIWA
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
                    NpgsqlPathpathListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD12MIWA
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
                    NpgsqlPathpathListD12MIWA.AssertModel(actual, expect, false);
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
npgsqlpathpathlistd12mi_id,
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
LEFT JOIN public.binary_npgsqlpathpathlistd12mi mi ON mi.id = m.npgsqlpathpathlistd12mi_id
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
    npgsqlpathpathlistd12mi_id,
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
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA), typeof(NpgsqlPathpathListD12MIWA)],
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
                var models1 = new List<NpgsqlPathpathListD12MIWA>();
                var models2 = new List<NpgsqlPathpathListD12MIWA>();
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
    FROM public.binary_npgsqlpathpathlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD12MIWA>();
                var models2 = new List<NpgsqlPathpathListD12MIWA>();
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
    FROM public.binary_npgsqlpathpathlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA)],
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
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA), typeof(NpgsqlPathpathListD12MIWA)],
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
                var models1 = new List<NpgsqlPathpathListD12MIWA>();
                var models2 = new List<NpgsqlPathpathListD12MIWA>();
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
    FROM public.binary_npgsqlpathpathlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD12MIWA>();
                var models2 = new List<NpgsqlPathpathListD12MIWA>();
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
    FROM public.binary_npgsqlpathpathlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA)],
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
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpathlistd12mi
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
                    NpgsqlPathpathListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MI), typeof(NpgsqlPathpathListD12MI)],
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
                var models1 = new List<NpgsqlPathpathListD12MI>();
                var models2 = new List<NpgsqlPathpathListD12MI>();
                await ((INpgsqlPathListpathListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD12MI>();
                var models2 = new List<NpgsqlPathpathListD12MI>();
                ((INpgsqlPathListpathListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MI)],
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
                    NpgsqlPathpathListD12MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpathListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA), typeof(NpgsqlPathpathListD12MIWA)],
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
                var models1 = new List<NpgsqlPathpathListD12MIWA>();
                var models2 = new List<NpgsqlPathpathListD12MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD12MIWA>();
                var models2 = new List<NpgsqlPathpathListD12MIWA>();
                ((INpgsqlPathListpathListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD12MIWA)],
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
                    NpgsqlPathpathListD12MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpathListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

