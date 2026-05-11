

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
    internal partial interface INpgsqlPointMArraypointMMArrayD1
    {
    }
    
    internal partial class NpgsqlPointMArraypointMMArrayD1 : INpgsqlPointMArraypointMMArrayD1
    {


#region TestData

        private readonly NpgsqlPointpointMMArrayD1E1M[] _testData = new NpgsqlPointpointMMArrayD1E1M[]
        {
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7931841409542688d, y: 0.3651131852014067d),
new NpgsqlTypes.NpgsqlPoint(x: 0.153012253324755d, y: 0.8958228370757758d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46489545792279185d, y: 0.4291002181082637d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9934477231876423d, y: 0.8523258685065452d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3295973173706408d, y: 0.1904096475389968d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3053867156386004d, y: 0.09033777561083267d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8841385302378617d, y: 0.8037221841538187d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8337328905659454d, y: 0.2358942433843506d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6054343546389963d, y: 0.05800969909328069d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9836120974195052d, y: 0.3072259935654499d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12996732316788262d, y: 0.7120103195347738d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7076184349038835d, y: 0.12594082756537506d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3294100760859938d, y: 0.271360449347419d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6570345728287151d, y: 0.611473278839249d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8260968979857896d, y: 0.7115623342126881d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7639682312624989d, y: 0.805919691087052d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3404034692609945d, y: 0.24065853582739727d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7423351539182254d, y: 0.3152558002735063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2900421739060246d, y: 0.0990131583637125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5640191292087584d, y: 0.28678890976127747d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17303895295258964d, y: 0.1883027744006276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4263207314184523d, y: 0.5353465686055264d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6776203449310819d, y: 0.6350283142365188d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7228213947651774d, y: 0.3318329571003301d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9955616223417256d, y: 0.9784914977808467d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41332577934240156d, y: 0.6991442342210726d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5398127510931405d, y: 0.1431300358564549d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6724351676969131d, y: 0.2937495554610696d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9418437840988662d, y: 0.08001650654614956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4085333176000919d, y: 0.9230029109499611d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8468692726308931d, y: 0.2397011221763351d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1497803785624966d, y: 0.5073879169932575d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9920321655844738d, y: 0.39561417786369313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.516248650389511d, y: 0.817520221420572d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5245767474791152d, y: 0.3398688802512454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14650707334945012d, y: 0.8937437000592826d),
new NpgsqlTypes.NpgsqlPoint(x: 0.010546001263757043d, y: 0.24269360047086352d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5755384313281017d, y: 0.3586146838783071d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6455857891042878d, y: 0.7426470318425318d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9985133747730667d, y: 0.8503090643105432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22370161062259386d, y: 0.6107874018485033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10571514461687204d, y: 0.9139586551466092d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18518773448903592d, y: 0.6355333079216071d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12578185834575106d, y: 0.24076102716144465d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15110284764879423d, y: 0.4409148866798468d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4256031461655857d, y: 0.046084445983724076d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6253312022470735d, y: 0.9840623036174088d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8036575197174596d, y: 0.0415680388874502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4847526311818019d, y: 0.4838203073111119d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28270796985707347d, y: 0.7582962638489553d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9844148251082618d, y: 0.14824203835650074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9055199906413796d, y: 0.9342892030802286d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15921794393131705d, y: 0.48002586220286836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5823103015711976d, y: 0.5307966042753031d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6461797648510996d, y: 0.20717212369977156d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.790538431503209d, y: 0.4425895636393411d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19786984982283362d, y: 0.38556930411798285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03371660120020914d, y: 0.35441239946821856d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3408249675108713d, y: 0.02216724901014644d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5719263018283888d, y: 0.4700142501134612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3382062045378028d, y: 0.02684814043336403d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08615492880762587d, y: 0.5801415973152613d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3858719239956331d, y: 0.10127782624414938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30869291587563663d, y: 0.636089345411745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4965217246316863d, y: 0.8954838294874706d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1383155793176567d, y: 0.28993299386141935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.389860119767958d, y: 0.0639302911769043d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17839146366661363d, y: 0.016825734812559223d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5595186752230293d, y: 0.06756199324818823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42954603395516233d, y: 0.026330519228270233d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6232218579567157d, y: 0.13933376574188294d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3711281857201524d, y: 0.963247686043376d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16833700123691397d, y: 0.028543213445817672d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8618168751949332d, y: 0.611554793318889d),
new NpgsqlTypes.NpgsqlPoint(x: 0.704364352390422d, y: 0.20791438441372412d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2606357436352228d, y: 0.9216791753516789d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4780994848170881d, y: 0.7649284517785588d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7021206061208419d, y: 0.4798629354576257d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7077715521489598d, y: 0.09935567568138026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6392020383263652d, y: 0.0019024802680308595d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07691603907716338d, y: 0.6483778184594646d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9508561708766602d, y: 0.11699031210411626d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9133334733813092d, y: 0.03782911297945213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9148963496921063d, y: 0.4477227691339094d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5157097719116612d, y: 0.9115448180151148d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37922324916189754d, y: 0.2013204596077125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9568461109821441d, y: 0.7647711541121643d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7555481620141656d, y: 0.44601790957404774d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41414688654065346d, y: 0.9445304547429063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6056361157199184d, y: 0.8960203114052854d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8738361803978482d, y: 0.4972618873418072d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6466616550165883d, y: 0.799943772516724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7070520649053721d, y: 0.6894503324232585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3546622710601445d, y: 0.38858083747245786d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1004232910098416d, y: 0.300347415641537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5240582781054918d, y: 0.007633169423271635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5070786726587385d, y: 0.27351918575531686d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26815056937322757d, y: 0.181091873355694d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23605017244814264d, y: 0.3263721619053994d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16841580325164984d, y: 0.061769202550055136d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11910451002115874d, y: 0.39531014871972436d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46733527680437426d, y: 0.20233412585134836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8401816031483836d, y: 0.653104030242631d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2656042830244074d, y: 0.5876014649189327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7318692942109913d, y: 0.8017856802442892d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4236764478562006d, y: 0.4898024578727018d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48878437900698724d, y: 0.8215375402994579d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8687465268840533d, y: 0.45017984887819285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32698348202317107d, y: 0.30771538692741596d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3432385142765505d, y: 0.2072962941300447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37031545932269283d, y: 0.8217895992146194d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1283040826546189d, y: 0.8895224462361315d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7991242812967712d, y: 0.3732898582308447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4131335131763586d, y: 0.6593664584105233d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6413981792423539d, y: 0.19407988481679916d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7756323399485607d, y: 0.9966800459711438d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5224969672538206d, y: 0.3532330211507637d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6453186132143347d, y: 0.22105790398223046d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20818758833487616d, y: 0.968981338274389d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36222781128055004d, y: 0.032337096263243215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24091810719402607d, y: 0.6503357986138275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9951941304276355d, y: 0.1387048103843158d),
new NpgsqlTypes.NpgsqlPoint(x: 0.043798820346532485d, y: 0.03703514218644599d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25907483852979096d, y: 0.08798819284119608d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12147504341978188d, y: 0.7545742697993701d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6686124349381077d, y: 0.3207957241053252d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5973471875616023d, y: 0.9619976867380134d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7577646947747467d, y: 0.7836979284828138d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8108336269135477d, y: 0.3916489685183778d),
new NpgsqlTypes.NpgsqlPoint(x: 0.860143426367337d, y: 0.5612127084363953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4367155023621023d, y: 0.6959406753313416d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9010707250273424d, y: 0.6936915294360328d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9975988230789155d, y: 0.8539766708848194d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24436857780452503d, y: 0.5520165675837807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.052759662751986625d, y: 0.9158111340614259d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5209926476309501d, y: 0.23465100568122432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.00667188190277912d, y: 0.594553185618051d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45494561918604925d, y: 0.36825808741667576d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3228475965651161d, y: 0.7915617940351951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5137085529895212d, y: 0.9642750176593909d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3021815827122194d, y: 0.778268690115621d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3754209235991236d, y: 0.20251817459071886d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9372359983251657d, y: 0.2977482111049754d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3522750357957599d, y: 0.79895127650416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8094990068685105d, y: 0.7801410643833065d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8134107989590273d, y: 0.9679454529395948d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10140843910901831d, y: 0.242651393757497d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22810423666562996d, y: 0.5692746654580699d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04994543523450601d, y: 0.6267756179804012d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15320820783164002d, y: 0.8569223644410892d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8826437346029099d, y: 0.376856029812088d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5647867899117185d, y: 0.6930735885144815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26551262535176134d, y: 0.950915017895034d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30742295243133066d, y: 0.6136689374948481d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.015261780723060725d, y: 0.41649294139462323d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34421791084739295d, y: 0.4603376488511792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39375165611654195d, y: 0.6153482562111646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39839413946605284d, y: 0.10085638140038067d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9547586089978689d, y: 0.42106862218725016d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8259526111914609d, y: 0.04660504175605007d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4033757706040114d, y: 0.8202341907179387d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4846288777253631d, y: 0.1565126745265557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5531031829685563d, y: 0.29687462431944156d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0632188534595971d, y: 0.16984533556290715d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11539909052163133d, y: 0.7556104483546551d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26055424377724623d, y: 0.9493842281447404d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5356122869344666d, y: 0.7457300039111836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23650087116752672d, y: 0.5869526609976567d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.013311297953627954d, y: 0.8259498209544722d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10681484838152766d, y: 0.09049433371566196d),
new NpgsqlTypes.NpgsqlPoint(x: 0.334929955177079d, y: 0.17815927451387636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17005855213357934d, y: 0.0031352080922636416d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42823348053165455d, y: 0.28789596348859037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2464060060804083d, y: 0.7795518871872039d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8584230103258288d, y: 0.2985187600864274d),
new NpgsqlTypes.NpgsqlPoint(x: 0.023086018658962093d, y: 0.7685588130530265d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9476138413894878d, y: 0.3965033932197146d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9829805862696506d, y: 0.7021057151683926d),
new NpgsqlTypes.NpgsqlPoint(x: 0.017143128661057605d, y: 0.368741719747697d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44939166770146344d, y: 0.3403714242770335d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7117283525588458d, y: 0.8268955690795587d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07586568845741637d, y: 0.8197644235732521d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6821806583348908d, y: 0.5457832912596272d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43850635024060947d, y: 0.8412983360730629d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39222599560424753d, y: 0.2588524942242446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.371455200680478d, y: 0.5447953938642196d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8329065941814445d, y: 0.4970992322163549d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3983476741913169d, y: 0.7957789671622932d),
new NpgsqlTypes.NpgsqlPoint(x: 0.681809031715169d, y: 0.24349978605079559d),
new NpgsqlTypes.NpgsqlPoint(x: 0.955975347353514d, y: 0.29997817237015434d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15420747109091226d, y: 0.5498485000028162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7133662067694062d, y: 0.15487902841387224d),
new NpgsqlTypes.NpgsqlPoint(x: 0.773770583821163d, y: 0.18629681182819025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8898901601855992d, y: 0.9460382223300315d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.812137237405342d, y: 0.3609665270627317d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7875732823597511d, y: 0.95020337856412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5065360114191649d, y: 0.1805083463596543d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6596573810111284d, y: 0.6740130315816968d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7863192349638749d, y: 0.9970729339669033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8936156874204486d, y: 0.6627514354418734d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14546807037335863d, y: 0.03609217654503194d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8418975995764906d, y: 0.4882741086542127d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36925532186819643d, y: 0.02606044957839604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9940556250549315d, y: 0.7038623210710063d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40815457339453765d, y: 0.1500488667108023d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10256831962492541d, y: 0.1474300475634751d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28940834846730157d, y: 0.9828954081191316d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0019312642462401275d, y: 0.27369531860971474d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31815290274147623d, y: 0.7954734593835016d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3508977339526086d, y: 0.173483700249218d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10995351517356156d, y: 0.871766394033702d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5185705579302886d, y: 0.2153432928105845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3371007790326187d, y: 0.24709565095913744d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34965722607955174d, y: 0.28409186555045796d),
new NpgsqlTypes.NpgsqlPoint(x: 0.264869082779983d, y: 0.25867879815794104d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4009955693581029d, y: 0.04804905037705176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1860340043679135d, y: 0.9480016546454352d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6397960403051489d, y: 0.9989229849387771d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2388053963222675d, y: 0.9927067356618564d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1921653559335762d, y: 0.6959612558273489d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3033340808085111d, y: 0.01081833500927143d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49308681005882904d, y: 0.5684888964119267d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3157421277396464d, y: 0.9946662541346277d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2438888848124069d, y: 0.5124603384419668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40196666515853663d, y: 0.30985976504094626d),
new NpgsqlTypes.NpgsqlPoint(x: 0.014828388343709364d, y: 0.15787629649226975d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5170960104641398d, y: 0.05841847519285659d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9553224125562197d, y: 0.03507328637445728d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5681182428637099d, y: 0.26852691712502696d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11871623006698595d, y: 0.9106053240336913d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28816919116463924d, y: 0.5383078280059168d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1443722253364933d, y: 0.12176305916267294d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8736187650355709d, y: 0.14561156880063253d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7473508057781268d, y: 0.8916939554743714d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45022781070905626d, y: 0.3833138864011302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.013907226189655786d, y: 0.7603497905529262d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8781176922633304d, y: 0.23841157150733505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7690960015461903d, y: 0.20041360268804176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8838816253364294d, y: 0.5285998201666877d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8653490123220648d, y: 0.03210355482302174d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.887439600969591d, y: 0.3189140587954423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1397324958281746d, y: 0.3429116497032274d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3681037777588333d, y: 0.037778475308919424d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5796246408436214d, y: 0.14117629398835818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.911167224448947d, y: 0.5592274572451316d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5985282670205522d, y: 0.509936339507436d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7234282946067568d, y: 0.3314430580926693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47283254292401067d, y: 0.5876622684888523d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2986454306614592d, y: 0.9461261356065491d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5196325525288074d, y: 0.8241169054467514d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.770708931430001d, y: 0.5773912654576223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5744619364117525d, y: 0.9643551009939625d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3937766225371352d, y: 0.20748567449829491d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8004799419948668d, y: 0.9767712009345779d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2547691944429952d, y: 0.2990579928245791d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04974730475861466d, y: 0.49753569800472985d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9589848675289007d, y: 0.015368502487170255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.047343286156230624d, y: 0.6049679414863394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8965025350692764d, y: 0.5923926782970518d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4517928823773465d, y: 0.5389143687659236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2682720178911663d, y: 0.06477555816189307d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49312222288082197d, y: 0.4989776987464337d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6819146025230975d, y: 0.08458265750540939d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7083000601101465d, y: 0.36928933248136664d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22740019185547922d, y: 0.5481940575180405d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2372836585379714d, y: 0.6234581021569183d),
},
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4711583284002753d, y: 0.6060171820375899d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5344014524423718d, y: 0.07381751712785423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9775326714791295d, y: 0.0007370734761975584d),
},
    ModelInner = new NpgsqlPointpointMMArrayD1E1MI
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8432105753284532d, y: 0.761804479830845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5696977319884339d, y: 0.18259746479631622d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7528641753410793d, y: 0.8778055332402922d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.503781168066922d, y: 0.5208526105321265d),
new NpgsqlTypes.NpgsqlPoint(x: 0.64333952731101d, y: 0.41046439704115456d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22760285444915762d, y: 0.5176939719011513d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD1E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37499877680400384d, y: 0.42730582745539114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4269996784248883d, y: 0.4420251531612597d),
new NpgsqlTypes.NpgsqlPoint(x: 0.041119236919319624d, y: 0.3263770838218334d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
INSERT INTO public.npgsqlpointpointmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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

                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)), 
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
                methodParametrName: "npgsqlpointpointmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18518773448903592d, y: 0.6355333079216071d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12578185834575106d, y: 0.24076102716144465d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15110284764879423d, y: 0.4409148866798468d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4256031461655857d, y: 0.046084445983724076d),
}));
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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15921794393131705d, y: 0.48002586220286836d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5823103015711976d, y: 0.5307966042753031d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6461797648510996d, y: 0.20717212369977156d),
}));
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5595186752230293d, y: 0.06756199324818823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42954603395516233d, y: 0.026330519228270233d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6232218579567157d, y: 0.13933376574188294d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3711281857201524d, y: 0.963247686043376d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd1e1mi_id
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
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                methodParametrName: "npgsqlpointpointmmarrayd1e1mi_id", 
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
                nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointMArraypointMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD1E1M> models = null;

                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD1E1M> models = null;

                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M), typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 151, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 75, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 89, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 147, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 89, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
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
FROM public.npgsqlpointpointmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 139, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 7, 151))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((INpgsqlPointMArraypointMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                NpgsqlPointpointMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
FROM public.binary_npgsqlpointpointmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpointpointmmarrayd1e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models =  ((INpgsqlPointMArraypointMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
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
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI), typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MI>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA), typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD1E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

