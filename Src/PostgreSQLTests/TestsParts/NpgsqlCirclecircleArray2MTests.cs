

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7425503846419772d, y: 0.7862442773612519d), radius: 0.23157978248172018d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8628277104713556d, y: 0.026303276860426328d), radius: 0.7341238220300816d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1291258629045906d, y: 0.47226566658526636d), radius: 0.032371851383306116d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8066918949536036d, y: 0.6622002607723246d), radius: 0.26405674761314224d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7413140212433894d, y: 0.14816854006098457d), radius: 0.5448258923346988d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.795310555954109d, y: 0.5218944750013312d), radius: 0.8082893724840107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12266797108803973d, y: 0.017586621937972002d), radius: 0.5237587511605101d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12748842978629182d, y: 0.8072212305517674d), radius: 0.16912003415552856d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09944340074221081d, y: 0.8029336172711244d), radius: 0.2677510930742104d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2290684913632426d, y: 0.9786276826380101d), radius: 0.4183044695287522d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.208822852108958d, y: 0.48095065426850714d), radius: 0.07511229528881092d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8078610092496584d, y: 0.18739743340591375d), radius: 0.5624832002676264d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4338760721214705d, y: 0.6190679454661528d), radius: 0.18485743666749488d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37508206970213076d, y: 0.6102558618039409d), radius: 0.4096194851837768d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2797816972748328d, y: 0.536100208067173d), radius: 0.15198345949878744d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8177291120154015d, y: 0.36778331791400176d), radius: 0.8187943267100083d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8136496484875307d, y: 0.6186046142859212d), radius: 0.036527141001022945d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5750658794465628d, y: 0.36036159153603786d), radius: 0.40912120897595494d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21609331399324327d, y: 0.8569887662228735d), radius: 0.2367098144233023d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11759980427351202d, y: 0.020451344207715105d), radius: 0.9780013908923993d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6035696589680853d, y: 0.663735293960808d), radius: 0.5578241131652594d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7230655698048198d, y: 0.0038642667275716747d), radius: 0.485093048998827d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04296721482696986d, y: 0.9649556733114159d), radius: 0.056622144304385724d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04575312366036366d, y: 0.5074881842833804d), radius: 0.8460566724789325d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07616549099741377d, y: 0.07543466967704349d), radius: 0.6821278077569749d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022704248781108327d, y: 0.2306720043851913d), radius: 0.40778333904240616d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9278037539392353d, y: 0.3340469473734473d), radius: 0.613594214545916d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7067611255387847d, y: 0.07040319396697681d), radius: 0.9413261650770833d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3225210933793584d, y: 0.36255459580481275d), radius: 0.17976089747062696d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.826253990961454d, y: 0.9506017756962458d), radius: 0.18091829019325734d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46035923698490633d, y: 0.7488698976520215d), radius: 0.8902067975280378d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20373101696457452d, y: 0.6927668365235523d), radius: 0.693070587757262d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6401652183730142d, y: 0.6476606174436856d), radius: 0.6645447457935066d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6258679099621499d, y: 0.37778584161694395d), radius: 0.3351498083747124d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20791842383959402d, y: 0.06845695267652385d), radius: 0.9524530034119791d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06647601997389496d, y: 0.12080323270823301d), radius: 0.4452772044166733d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7586078719161061d, y: 0.21325514287041214d), radius: 0.28990816950484644d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2472589516275936d, y: 0.8792470820413827d), radius: 0.5695736618886988d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4394263918609157d, y: 0.7941423012325651d), radius: 0.03206471398179633d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.018069542095517255d, y: 0.4242848924014526d), radius: 0.9909833706145369d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4706254858055292d, y: 0.9987387786634552d), radius: 0.6505978948710794d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27264694841046266d, y: 0.4887649338515102d), radius: 0.26080815634789445d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.619233804803986d, y: 0.35904584992590616d), radius: 0.46609587534452745d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11749323597600991d, y: 0.23690152643182394d), radius: 0.5461257880076963d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5826463216272095d, y: 0.06526475273134746d), radius: 0.37221760116861236d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44580337029890826d, y: 0.8667468766114852d), radius: 0.45838547287587095d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7443822250674297d, y: 0.4162721499735198d), radius: 0.4718811079999842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5668349499706289d, y: 0.4668223909290454d), radius: 0.1232574747313736d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5004043244485495d, y: 0.1662420483533732d), radius: 0.22254632156799314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06798123109087251d, y: 0.6837721085452214d), radius: 0.948214347048424d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5457397459271822d, y: 0.05663901628875645d), radius: 0.7062131293735409d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14334341674455575d, y: 0.8761210843151733d), radius: 0.17297386087838107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8113152035411425d, y: 0.6951403445043455d), radius: 0.8547826428631619d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.536528911449304d, y: 0.6978039988990067d), radius: 0.2375044422095448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13238066014232408d, y: 0.7155436561660432d), radius: 0.627479609817684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.997030255567743d, y: 0.0019276068274390878d), radius: 0.04858211072109142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32833294515327405d, y: 0.40665590243905536d), radius: 0.4451665398823432d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6942448867962742d, y: 0.9131950387777726d), radius: 0.5810105328814007d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3075885291656544d, y: 0.9159383113708438d), radius: 0.22136723257738566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7335531294199246d, y: 0.13966676022746005d), radius: 0.18596139458212357d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9827451032945086d, y: 0.7253569167492693d), radius: 0.7728211821711086d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.633623208063697d, y: 0.9104224152802323d), radius: 0.5325127016185923d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6488392015865603d, y: 0.38174909586920436d), radius: 0.2935745764000911d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7696107490761285d, y: 0.7716939829155138d), radius: 0.5501748158341718d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3529001922656727d, y: 0.6568994095224848d), radius: 0.8789092660884961d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08298321342969206d, y: 0.6711805401594132d), radius: 0.24570807437062991d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.884303723460294d, y: 0.6465810787287146d), radius: 0.37514212381551115d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1712240266632481d, y: 0.571070737444276d), radius: 0.4975523187192328d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9903309451065753d, y: 0.012188025479684117d), radius: 0.9385685548552575d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.723937906316418d, y: 0.2293428794756085d), radius: 0.17418075019039359d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3342659563282918d, y: 0.09681797529763203d), radius: 0.8488263246800549d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.75042138682716d, y: 0.026876983546294975d), radius: 0.18760797749139924d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5919387774665236d, y: 0.3290255912895178d), radius: 0.9453464607704327d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6882457373873256d, y: 0.8706428204196727d), radius: 0.9236209356659124d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025506366246805356d, y: 0.7185197213013537d), radius: 0.46412185745776424d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6180000153276928d, y: 0.5113861916270478d), radius: 0.4870918011927381d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.126947020446445d, y: 0.3661115328745359d), radius: 0.4571175280870061d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3077176048810937d, y: 0.579140511054052d), radius: 0.7334218910716385d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2865668846635431d, y: 0.7318347714333433d), radius: 0.7665023923858026d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33553859271708775d, y: 0.8909545542778949d), radius: 0.5675523748272346d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4181062197221639d, y: 0.5679130921770665d), radius: 0.683772006929435d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606342850103806d, y: 0.5317302403005963d), radius: 0.04250915199561067d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9304906007801891d, y: 0.46108874762547936d), radius: 0.7014534446767655d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09427975969290747d, y: 0.864098119354272d), radius: 0.5231952128425154d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34846490827266274d, y: 0.029697602125880573d), radius: 0.6850029862427687d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13564632149655687d, y: 0.7803481592944086d), radius: 0.7399194965003222d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5994963728947449d, y: 0.1275092374577932d), radius: 0.1678349802365957d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9236694035772073d, y: 0.6808218581535073d), radius: 0.30305471014572716d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9560595616009329d, y: 0.6820578684685275d), radius: 0.7754339651542634d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34879696249344205d, y: 0.33482442942308843d), radius: 0.6866729279352821d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0686420372203499d, y: 0.9980901542729819d), radius: 0.3495319605263546d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.884929946187954d, y: 0.25498977625633645d), radius: 0.8964058328246358d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8384281072037364d, y: 0.7331739988036517d), radius: 0.9534623066915054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7790388126847205d, y: 0.5645745177419617d), radius: 0.7050771229221495d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.003808096996804178d, y: 0.3266087670587219d), radius: 0.7290195990672059d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4402219099404402d, y: 0.05614908924953799d), radius: 0.13953170664582681d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8829853626065619d, y: 0.7332628486142208d), radius: 0.5965911362956025d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18773034795790944d, y: 0.47418588933529426d), radius: 0.8457276311385971d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09365436343409583d, y: 0.8695882159466456d), radius: 0.043766717777226405d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9668018938600479d, y: 0.6902041484596346d), radius: 0.6886737415775905d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20006127833005893d, y: 0.18126930475926828d), radius: 0.909809625539269d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7483117885561856d, y: 0.8598666159433526d), radius: 0.5844396364632294d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28879943394092866d, y: 0.7744028799318777d), radius: 0.24030739143075497d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8108328158933141d, y: 0.5148008674506721d), radius: 0.8080598390848508d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6205540087960353d, y: 0.8280136628160366d), radius: 0.12434207515354168d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41194057751073043d, y: 0.3137946395207657d), radius: 0.4449067106693072d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8796583156878386d, y: 0.762760979997197d), radius: 0.5064260629993643d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.751776550301596d, y: 0.9426561703052951d), radius: 0.2750063110777111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08213618242597553d, y: 0.9513218385929496d), radius: 0.7589186789672588d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016672731562405896d, y: 0.799256935627466d), radius: 0.10422808134651362d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6635270869670824d, y: 0.32623470526311327d), radius: 0.37254383621314746d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7336223700982968d, y: 0.738902563237344d), radius: 0.8362837246666028d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4255357640149683d, y: 0.8346500612239669d), radius: 0.7641616633364784d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5160298066239634d, y: 0.3104441299289419d), radius: 0.32862175108057834d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5993515056709653d, y: 0.5365415064092082d), radius: 0.2696241971218142d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878555032854158d, y: 0.9912620349173475d), radius: 0.8550722957911029d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13853900834945154d, y: 0.1332027597739991d), radius: 0.6682244094948745d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17199980456935215d, y: 0.1994486293159119d), radius: 0.51784834796721d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8221823300796609d, y: 0.8338119391188067d), radius: 0.932848463651069d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6822243326436134d, y: 0.1770999481388148d), radius: 0.7679546597373346d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3228314799089331d, y: 0.4497774001782011d), radius: 0.7487930020733263d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6636385373897584d, y: 0.9913508789291589d), radius: 0.5108941177011103d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3530295755579046d, y: 0.17504763588183825d), radius: 0.3227065654991351d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6032556419191949d, y: 0.7547576622962288d), radius: 0.07436998703020858d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.544809117984722d, y: 0.13449306920143067d), radius: 0.6024759581021346d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6912069959232815d, y: 0.8708455972958589d), radius: 0.6610730751554881d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6612640555142516d, y: 0.6713161144413416d), radius: 0.8819738991492453d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25964751124001373d, y: 0.4915474451868358d), radius: 0.39811371627448544d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36814959420692583d, y: 0.20504955971506267d), radius: 0.5325289721520202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24572774927309315d, y: 0.06766349436692087d), radius: 0.9772750563216996d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9348725803071989d, y: 0.5098969407949269d), radius: 0.3899021813200504d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30195711694345173d, y: 0.49365375718996485d), radius: 0.7373154970598961d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0047335191783163255d, y: 0.6068390072038178d), radius: 0.773029852493858d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6062173705565906d, y: 0.9230333459785877d), radius: 0.935944126605626d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34990732393980295d, y: 0.08688787050477598d), radius: 0.09227674853514867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49395215287519234d, y: 0.7540508223409408d), radius: 0.13767818922756792d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19183171144326638d, y: 0.1524471358419507d), radius: 0.01879484160964029d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5662333351441536d, y: 0.170910735358068d), radius: 0.17399315086323786d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28191487710413d, y: 0.3976014495730712d), radius: 0.9063365810142011d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45035321835766096d, y: 0.4710459533712483d), radius: 0.5066108386341573d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9632191080149286d, y: 0.4207234387498042d), radius: 0.019984285419255565d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7994677054572772d, y: 0.6985008609651802d), radius: 0.26962826144805363d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7649958350741597d, y: 0.9533339618390354d), radius: 0.3835533307186283d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7311947328156051d, y: 0.13548346417156987d), radius: 0.13284460937764253d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06413547440739498d, y: 0.8242566105491196d), radius: 0.593933155951977d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4999456904728652d, y: 0.5768987732838685d), radius: 0.6826399747682828d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9490997875772043d, y: 0.6836546999139943d), radius: 0.5441009610114181d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19929638910690362d, y: 0.1216470469456783d), radius: 0.050560826764703304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19183108516680958d, y: 0.47873575804624346d), radius: 0.11581961379412609d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.885122199232434d, y: 0.9001215363272331d), radius: 0.4066597259005721d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4438605048466271d, y: 0.3896506895024804d), radius: 0.12972620316494188d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45432928280978524d, y: 0.6023942834429743d), radius: 0.24531816651007043d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41802486636015246d, y: 0.5772825560029612d), radius: 0.9837805658759375d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4449531055422583d, y: 0.7001124910751064d), radius: 0.7470131743095632d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6690648460323091d, y: 0.9989065255299762d), radius: 0.5868497008398178d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10174193086199979d, y: 0.6029122757867321d), radius: 0.2628003603536251d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19975716742002614d, y: 0.9234179254932516d), radius: 0.5524169971603103d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14607759609668713d, y: 0.5566185179848578d), radius: 0.8866164964574443d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023658385774800283d, y: 0.6158397070073934d), radius: 0.6237148070664268d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13060570464180532d, y: 0.37884980383027445d), radius: 0.3513474178059315d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7905135318078513d, y: 0.4689668369915191d), radius: 0.9843470619600745d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3941198011696829d, y: 0.09756119367364036d), radius: 0.6398341991897701d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022625530711208763d, y: 0.06001889527467519d), radius: 0.06435998689117473d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8300742495068364d, y: 0.5448302454319002d), radius: 0.8912353404269387d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18947918935363917d, y: 0.7229748313939286d), radius: 0.22916661924406967d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44727340643720137d, y: 0.6421980238877276d), radius: 0.10265304126059993d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5436036791534893d, y: 0.2906923549711772d), radius: 0.5984467480854345d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9678176111850318d, y: 0.9088827315781246d), radius: 0.029662923596395552d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5127934716247815d, y: 0.2835873189480598d), radius: 0.7051328667150989d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8798063762529608d, y: 0.23829238133797848d), radius: 0.7100946483290684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7595144997916434d, y: 0.44106400157522074d), radius: 0.6401427519138082d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7882699580363999d, y: 0.26405069129712755d), radius: 0.6350094409436523d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22358643132036637d, y: 0.7089320720264389d), radius: 0.23736210215932518d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7724529924345543d, y: 0.13759781545820648d), radius: 0.8191564016548883d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17898600954657828d, y: 0.07326143971087506d), radius: 0.2093469284480023d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09458621509344611d, y: 0.28560847080574747d), radius: 0.4911784092233501d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12779106522997385d, y: 0.3962783054066831d), radius: 0.8532769342981729d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9513744793203354d, y: 0.45505932141300154d), radius: 0.3113763860508645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1775425630018591d, y: 0.649241770654884d), radius: 0.3309512307451177d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19933980888846736d, y: 0.20782273955118702d), radius: 0.4935017875945581d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.154248182480193d, y: 0.38981020184828175d), radius: 0.007893142567133471d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24448137179569263d, y: 0.2530927488807413d), radius: 0.3884476591081716d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.831743235263755d, y: 0.945020826439029d), radius: 0.3167345853260741d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8470894709550105d, y: 0.2071539019841503d), radius: 0.5200629805497268d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28263274046166964d, y: 0.7875499266554008d), radius: 0.8487023364250988d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22169386629739396d, y: 0.6300841166109264d), radius: 0.42000904002945494d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3091508868260696d, y: 0.59555628380079d), radius: 0.5846869195650691d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8838881204813828d, y: 0.5358927239540124d), radius: 0.0004305983426887705d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07995868831601471d, y: 0.7767876306957566d), radius: 0.5896805167590118d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30984464509630627d, y: 0.9368136101141832d), radius: 0.09355048458603776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3238922715156941d, y: 0.5768855749293531d), radius: 0.9401675768225861d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3774066598191157d, y: 0.6893134133869752d), radius: 0.6235645881586434d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.900644114359019d, y: 0.8588457306993231d), radius: 0.9691564237954781d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6039724973584982d, y: 0.27746368400771715d), radius: 0.5833690898657354d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16880875261135575d, y: 0.11094408533276001d), radius: 0.15134027824558727d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0739888403692428d, y: 0.5677573073817656d), radius: 0.4629950680426159d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4885097278759978d, y: 0.9468107675994272d), radius: 0.974810524913321d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3244055724376017d, y: 0.8205962594029153d), radius: 0.9657641764516046d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3172123110309575d, y: 0.10119742083688832d), radius: 0.7072629695583385d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3429245833319319d, y: 0.4032918879118128d), radius: 0.40394053947386543d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5663322614767438d, y: 0.9710137460012d), radius: 0.41972144756077046d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31419968417041777d, y: 0.5041760269422223d), radius: 0.44477724180940204d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.332918420497871d, y: 0.25039206276503956d), radius: 0.9927186431494339d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28252408217211455d, y: 0.5178434528971987d), radius: 0.3069739752949656d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24775867373773497d, y: 0.7901982156620957d), radius: 0.7075931870561738d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6841693218394276d, y: 0.3671944248183784d), radius: 0.25288571362128043d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.857987731854627d, y: 0.3629888396110801d), radius: 0.3423568527150789d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7990476775852593d, y: 0.25020340930679064d), radius: 0.660550925247342d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.57290747410722d, y: 0.6173476477202027d), radius: 0.36429846959792167d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2506049515461167d, y: 0.8849182784998333d), radius: 0.2665022285093177d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8997587746822066d, y: 0.4116944235145339d), radius: 0.956171159133908d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7444575200997888d, y: 0.8958000530089957d), radius: 0.8663780976955421d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9678174543304213d, y: 0.8215904438239583d), radius: 0.6274506609553604d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05631789926870068d, y: 0.0538552450229991d), radius: 0.9482921605314504d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34328145936835464d, y: 0.22511121636390707d), radius: 0.5565738244394519d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12312036636058366d, y: 0.7251036879579221d), radius: 0.53745422691576d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023523110062820818d, y: 0.10097608895856891d), radius: 0.7701153858093273d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.055595148864560184d, y: 0.7997427466465796d), radius: 0.25839435154344814d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7479900148165722d, y: 0.7054945266947703d), radius: 0.8894742220229525d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6899389467912134d, y: 0.29150056562780546d), radius: 0.393082022034838d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19922147513594302d, y: 0.241190487950389d), radius: 0.29622057683441627d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47742551036646574d, y: 0.25726322357948883d), radius: 0.7049386306842625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9049549140917005d, y: 0.21254796581685487d), radius: 0.7196566144889688d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6172126768500746d, y: 0.3643518144598251d), radius: 0.04640536922456817d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.755578309051567d, y: 0.6182499656235252d), radius: 0.2388657584859577d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6760006007386307d, y: 0.8530584175849908d), radius: 0.6473027264149355d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2687868050620559d, y: 0.6693979202837104d), radius: 0.22033557684367377d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28482967153893624d, y: 0.9855364926697774d), radius: 0.4844404134354763d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7124620929273608d, y: 0.015390001775476114d), radius: 0.2668369568211739d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6942215277713433d, y: 0.37131248514351445d), radius: 0.7766698592613467d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3250285033646244d, y: 0.9391533820480793d), radius: 0.365430854953417d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 196,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36005922051210937d, y: 0.8490556868600628d), radius: 0.21458411684854317d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17920180120446993d, y: 0.133314176124798d), radius: 0.10022294156990708d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6047978070396807d, y: 0.7902277864232814d), radius: 0.3481551324562143d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5233813165959239d, y: 0.07784768289308996d), radius: 0.19198125071600713d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3081864637534798d, y: 0.30617860089217075d), radius: 0.0011177818592452704d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7467801000613046d, y: 0.2704376014546459d), radius: 0.8795878849844241d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8809320380849778d, y: 0.742044932666961d), radius: 0.36758468258700794d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.284951374686934d, y: 0.7042055023124013d), radius: 0.3393612012399151d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2509456354985168d, y: 0.870225180983163d), radius: 0.3562448091933338d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24717755070785918d, y: 0.04718005664675462d), radius: 0.09588572894820901d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 205,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.555720192634181d, y: 0.7164735289910367d), radius: 0.4022806372630424d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20334567779627255d, y: 0.6941803781213562d), radius: 0.41761280410344903d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8128537158781545d, y: 0.07255935153820581d), radius: 0.7090547725157572d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25665877398910397d, y: 0.9027451560946452d), radius: 0.3885141394966929d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8069967382290311d, y: 0.894605562685502d), radius: 0.05976040641094327d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3479287817554171d, y: 0.1617020252912893d), radius: 0.7925359992135503d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1576359336908244d, y: 0.7533238798263142d), radius: 0.8340245748177554d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 213,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09662693076168649d, y: 0.056509342776695615d), radius: 0.2546087555040921d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3902888296643797d, y: 0.2964297761238367d), radius: 0.7698425166855716d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2776216683267243d, y: 0.849415014113402d), radius: 0.7178217529365888d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9782057519591449d, y: 0.8206183311712079d), radius: 0.007395783458779004d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15553257169122103d, y: 0.64583465857625d), radius: 0.833167403610379d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4413795647382758d, y: 0.7467508961805878d), radius: 0.16259372265565897d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19731100923907585d, y: 0.7154803947231367d), radius: 0.9484712694923402d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19195508071768763d, y: 0.8197089710608644d), radius: 0.1069136509759595d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7106074046161285d, y: 0.6659103265038124d), radius: 0.48007129510722957d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17081985020155843d, y: 0.7028347755249671d), radius: 0.10532065711312255d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24535577665078023d, y: 0.5108121856022851d), radius: 0.0956596093644353d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0731820406925291d, y: 0.2440294150458071d), radius: 0.46895352312739524d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10645654482389633d, y: 0.8427423068579859d), radius: 0.15114855280826345d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9434272826364983d, y: 0.22591193839750934d), radius: 0.5531685489150495d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43660243581460756d, y: 0.44589488591449133d), radius: 0.3498837494300957d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 216,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12968371335940032d, y: 0.8932072628424681d), radius: 0.46242656055618114d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19961116714085825d, y: 0.564724115433034d), radius: 0.8446382370136448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7001306226621984d, y: 0.6717054901041892d), radius: 0.8237879610208231d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 187;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 196;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 179;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 187;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 177, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 122, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 115, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 177, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 42, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 74, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 177, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI), typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                await ((INpgsqlCircleListcircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                ((INpgsqlCircleListcircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

