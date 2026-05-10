

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
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39981628150467086d, y: 0.9096898415071147d), new NpgsqlTypes.NpgsqlPoint(x: 0.05649285434184925d, y: 0.37915713332349554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175941934909284d, y: 0.9760204893139196d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5987718483089792d, y: 0.04337441217924509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9331045485509675d, y: 0.054168558775153364d), new NpgsqlTypes.NpgsqlPoint(x: 0.30564662403822995d, y: 0.5937996693997128d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2209666322002316d, y: 0.4289486972844535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8693400152484233d, y: 0.38701815174862775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7239540917670024d, y: 0.2179009838991991d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12866210448567983d, y: 0.6532803918416004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126471583279905d, y: 0.08711789286067129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122497435005867d, y: 0.1516666789960982d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05145058541767078d, y: 0.978447950131792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772482575982819d, y: 0.1254097146582338d), new NpgsqlTypes.NpgsqlPoint(x: 0.704332056840099d, y: 0.24716104647193993d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7509629667208474d, y: 0.4023191880168512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7171574816783656d, y: 0.1806950667911862d), new NpgsqlTypes.NpgsqlPoint(x: 0.12020999785853215d, y: 0.02080979039430053d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9356851321913437d, y: 0.05087194388733274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8245707583149722d, y: 0.19160907284642115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4713405576572467d, y: 0.5328875119397529d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9707670925404813d, y: 0.3456372585869063d), new NpgsqlTypes.NpgsqlPoint(x: 0.3467185734050793d, y: 0.9157451116815868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351530527118231d, y: 0.7736318919295477d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.469844425350868d, y: 0.5016252454246847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258990749113402d, y: 0.9414535948205212d), new NpgsqlTypes.NpgsqlPoint(x: 0.42092458307342706d, y: 0.4051690497766939d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9990950146358278d, y: 0.06665172531791708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179833418329941d, y: 0.07972677932874939d), new NpgsqlTypes.NpgsqlPoint(x: 0.1842612322796091d, y: 0.4889844449660339d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13421654710776387d, y: 0.9529303734243604d), new NpgsqlTypes.NpgsqlPoint(x: 0.11471645404595843d, y: 0.2986467268785533d), new NpgsqlTypes.NpgsqlPoint(x: 0.10307155407526913d, y: 0.10721248015931395d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27377208839339806d, y: 0.48262378435917686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3497606476786371d, y: 0.9517053489536329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537623891975697d, y: 0.16608764451237878d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11043207592530835d, y: 0.7872360646003627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871401222056356d, y: 0.8245591502650523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807014876554195d, y: 0.30091412272868856d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5062797256258798d, y: 0.5229130733339268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809614850113121d, y: 0.05840070818494869d), new NpgsqlTypes.NpgsqlPoint(x: 0.450899811334565d, y: 0.646565862360338d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6364815917076038d, y: 0.6805176680656899d), new NpgsqlTypes.NpgsqlPoint(x: 0.515268439407007d, y: 0.6767480784301377d), new NpgsqlTypes.NpgsqlPoint(x: 0.11926799965785906d, y: 0.3009763012547306d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33411106204344654d, y: 0.6477008772139324d), new NpgsqlTypes.NpgsqlPoint(x: 0.22728907841162416d, y: 0.2260375516158829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344091666723848d, y: 0.8695466608270727d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29045127504163715d, y: 0.10698409678536425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989444857165744d, y: 0.9970026295141289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311914405579254d, y: 0.8707505392150061d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6552138044720905d, y: 0.23318507129297794d), new NpgsqlTypes.NpgsqlPoint(x: 0.1641811897474741d, y: 0.3846920384086773d), new NpgsqlTypes.NpgsqlPoint(x: 0.10094300964391145d, y: 0.4917632562228974d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6794123351754863d, y: 0.6805209255301184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477938487124839d, y: 0.6086266039676168d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535733892668518d, y: 0.47266066327282785d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44749758430418485d, y: 0.8111304097602124d), new NpgsqlTypes.NpgsqlPoint(x: 0.4149401408121871d, y: 0.029768258353617516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2739204983861002d, y: 0.13859679534079739d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9306894858408014d, y: 0.8729808582488856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384530870422628d, y: 0.7451877876489719d), new NpgsqlTypes.NpgsqlPoint(x: 0.14935563284081366d, y: 0.6681050767234552d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606749044425382d, y: 0.8189327137750921d), new NpgsqlTypes.NpgsqlPoint(x: 0.22821770156941312d, y: 0.10708541563528107d), new NpgsqlTypes.NpgsqlPoint(x: 0.05368812923098687d, y: 0.7654790229772713d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1912890521821914d, y: 0.22258640119340722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009196048933527d, y: 0.3070741830260013d), new NpgsqlTypes.NpgsqlPoint(x: 0.06326856242712631d, y: 0.8413676478339261d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.708007861649994d, y: 0.20465161534187581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275713697907468d, y: 0.4411013154721378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2107110747320241d, y: 0.17348336665496433d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3075605779052115d, y: 0.10130240501256416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9121819950670285d, y: 0.9797255225695497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124703055841977d, y: 0.9850524511620676d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28453371378995806d, y: 0.35816627023371617d), new NpgsqlTypes.NpgsqlPoint(x: 0.607636565474895d, y: 0.7459226720012685d), new NpgsqlTypes.NpgsqlPoint(x: 0.3137269891304788d, y: 0.48299553480548707d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33444923747091715d, y: 0.24822800062532213d), new NpgsqlTypes.NpgsqlPoint(x: 0.3067351285216262d, y: 0.5072034392967705d), new NpgsqlTypes.NpgsqlPoint(x: 0.16450105190653974d, y: 0.11211427160249443d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30078413711453456d, y: 0.9290816096881368d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554563632546238d, y: 0.8983250726058022d), new NpgsqlTypes.NpgsqlPoint(x: 0.698894389139898d, y: 0.3159395348614953d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5656802144379972d, y: 0.8648990895294142d), new NpgsqlTypes.NpgsqlPoint(x: 0.667891486904991d, y: 0.8181877837101925d), new NpgsqlTypes.NpgsqlPoint(x: 0.15506819450077358d, y: 0.023899745295255292d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22739963230989202d, y: 0.6591827401758863d), new NpgsqlTypes.NpgsqlPoint(x: 0.3082322629286265d, y: 0.15363984368433015d), new NpgsqlTypes.NpgsqlPoint(x: 0.464451138687492d, y: 0.10312434880749377d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18884688117124704d, y: 0.07492472329462807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028192453885521d, y: 0.15950006489384472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364956684946806d, y: 0.3805306528054262d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17928316741065564d, y: 0.7146823917402549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118901092752094d, y: 0.3218618909664347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551300407102793d, y: 0.1096876976227481d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45347945165162196d, y: 0.20983235583191484d), new NpgsqlTypes.NpgsqlPoint(x: 0.08528379836429689d, y: 0.03713109709817397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123952730783987d, y: 0.033995098249328115d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7008572349205422d, y: 0.8997614005785748d), new NpgsqlTypes.NpgsqlPoint(x: 0.21653627397342545d, y: 0.3394356819771842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785136324576341d, y: 0.9032861178599476d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38726753126787516d, y: 0.005183676312143115d), new NpgsqlTypes.NpgsqlPoint(x: 0.1319870220250009d, y: 0.7370238446030709d), new NpgsqlTypes.NpgsqlPoint(x: 0.130710174764199d, y: 0.9803336610187536d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0843820425399524d, y: 0.732243679022812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711569594156373d, y: 0.3233246658226312d), new NpgsqlTypes.NpgsqlPoint(x: 0.009959119558207163d, y: 0.8931044613855814d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.607493314563342d, y: 0.5741698247720027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7308428911948642d, y: 0.7604994301282415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063079380775325d, y: 0.096081690998855d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8988382641777065d, y: 0.8195300977255039d), new NpgsqlTypes.NpgsqlPoint(x: 0.9065466833056028d, y: 0.7345614717194644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350566575801287d, y: 0.9669861100742709d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03908902608029219d, y: 0.6245006126614341d), new NpgsqlTypes.NpgsqlPoint(x: 0.024322386875919477d, y: 0.48888716021360834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751989882732856d, y: 0.690200835899033d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9108454313523218d, y: 0.7980978852956719d), new NpgsqlTypes.NpgsqlPoint(x: 0.14499302244901302d, y: 0.4471244818076442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2774712780364398d, y: 0.7643531335832734d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8283086650315015d, y: 0.7317282752931071d), new NpgsqlTypes.NpgsqlPoint(x: 0.966068763328064d, y: 0.5283928013403414d), new NpgsqlTypes.NpgsqlPoint(x: 0.47277127238346695d, y: 0.9018652573187166d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8904313123560418d, y: 0.4424442205364083d), new NpgsqlTypes.NpgsqlPoint(x: 0.17387189064995123d, y: 0.6735641232466063d), new NpgsqlTypes.NpgsqlPoint(x: 0.20330877145849702d, y: 0.8457578440402048d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5352531799038845d, y: 0.5482190258716891d), new NpgsqlTypes.NpgsqlPoint(x: 0.07654202894679218d, y: 0.6936796692002938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978023675955646d, y: 0.42804922336852835d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7797596617275848d, y: 0.5138825416451362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3315154511225282d, y: 0.01256642968856947d), new NpgsqlTypes.NpgsqlPoint(x: 0.605836590801458d, y: 0.17190764958083926d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10414241994851181d, y: 0.3540289275565264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586759022838581d, y: 0.31898646923117335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046194307127687d, y: 0.8664986632730861d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9613072489919364d, y: 0.7022632855514832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136694559924324d, y: 0.4287980800679553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7563907069840874d, y: 0.028738342894612745d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34146388966470653d, y: 0.43403360078360664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242966407870647d, y: 0.8737395200445248d), new NpgsqlTypes.NpgsqlPoint(x: 0.03215327475184382d, y: 0.418872343722435d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.828435034736428d, y: 0.6268006261385097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517361551558206d, y: 0.6893178582602142d), new NpgsqlTypes.NpgsqlPoint(x: 0.23761337388026815d, y: 0.8435058927556883d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3814690891316108d, y: 0.11981443410266901d), new NpgsqlTypes.NpgsqlPoint(x: 0.006651835848228704d, y: 0.567819092333346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171072788186748d, y: 0.17464756385467628d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12779365169863321d, y: 0.0006959341248080619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7264882927331098d, y: 0.10346056110278301d), new NpgsqlTypes.NpgsqlPoint(x: 0.15532776557940509d, y: 0.6544439700343386d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16794310173772953d, y: 0.3893949582521288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35246975667522906d, y: 0.2530053373427892d), new NpgsqlTypes.NpgsqlPoint(x: 0.44360131933878866d, y: 0.9800945399882506d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.61138804875418d, y: 0.5882495475120714d), new NpgsqlTypes.NpgsqlPoint(x: 0.12741917661785906d, y: 0.7963877275946722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781575912557273d, y: 0.6485891040935818d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6248755325859874d, y: 0.8066290870936879d), new NpgsqlTypes.NpgsqlPoint(x: 0.38421568831149533d, y: 0.4543659180849524d), new NpgsqlTypes.NpgsqlPoint(x: 0.763821233843467d, y: 0.4814998660535318d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42882940994647734d, y: 0.7334054487369978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256490731435729d, y: 0.9073970136041067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234135206280194d, y: 0.37690262481724135d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6533765126794808d, y: 0.20715915878900204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215201391091808d, y: 0.875234017097137d), new NpgsqlTypes.NpgsqlPoint(x: 0.24082856322217472d, y: 0.746731731431582d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5452711110579846d, y: 0.6960620612188358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005113402112438d, y: 0.5465671322651828d), new NpgsqlTypes.NpgsqlPoint(x: 0.31412096585286153d, y: 0.8962966939772795d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5883830851427113d, y: 0.3356770672819792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549555693749293d, y: 0.4436861258000333d), new NpgsqlTypes.NpgsqlPoint(x: 0.11915159847070855d, y: 0.2476720837772104d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8335835899867289d, y: 0.7472232306380157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113993534076228d, y: 0.018174451822580484d), new NpgsqlTypes.NpgsqlPoint(x: 0.03184584968173554d, y: 0.8255871977901493d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46899691271965727d, y: 0.4840367349917335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1286000970453911d, y: 0.5666647088039347d), new NpgsqlTypes.NpgsqlPoint(x: 0.30217880827094146d, y: 0.6388716551705576d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.630378732960267d, y: 0.16072388937482962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245590116327394d, y: 0.39084321680483913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8504013746515993d, y: 0.5866202813435655d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.701025759346924d, y: 0.5061154497405885d), new NpgsqlTypes.NpgsqlPoint(x: 0.17076668473691858d, y: 0.2916260222562669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4878914377962259d, y: 0.7017598120413696d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4108226776582007d, y: 0.6784757463410962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4668702372654673d, y: 0.20686289124574353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358567318949567d, y: 0.6352852541776717d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6772233252836851d, y: 0.4302409511084371d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618124516277405d, y: 0.9340414700901698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468600260839312d, y: 0.38010661072839336d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9544537524344588d, y: 0.7834285927152476d), new NpgsqlTypes.NpgsqlPoint(x: 0.35006380848009866d, y: 0.8481781640525444d), new NpgsqlTypes.NpgsqlPoint(x: 0.20310366656191814d, y: 0.5982174941054361d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5535037189132412d, y: 0.782544159812637d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836074331386584d, y: 0.08732447735271143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4141152104927308d, y: 0.35445024584180485d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.046324557132656374d, y: 0.4937478355284176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594628607013508d, y: 0.831686693758147d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935081759260278d, y: 0.5254427216659179d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.889717777993385d, y: 0.7165319619527264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6492325051471985d, y: 0.7934378198189911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8206685859327251d, y: 0.820970423594795d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15504661383606844d, y: 0.8494431179256143d), new NpgsqlTypes.NpgsqlPoint(x: 0.10957146336256385d, y: 0.05335487216180079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14608562020547378d, y: 0.2840806660884647d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03086584190739161d, y: 0.1671491178045047d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736408761379012d, y: 0.29614761976567805d), new NpgsqlTypes.NpgsqlPoint(x: 0.628475906743996d, y: 0.4472068425975948d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10369157492048686d, y: 0.7196430900455493d), new NpgsqlTypes.NpgsqlPoint(x: 0.43146223909672365d, y: 0.7899310310977129d), new NpgsqlTypes.NpgsqlPoint(x: 0.044446851210606764d, y: 0.5481880966615931d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944992224767675d, y: 0.9790426811280429d), new NpgsqlTypes.NpgsqlPoint(x: 0.4826230573173593d, y: 0.6527091875203705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9102121519389906d, y: 0.5622478594201633d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17589304252171234d, y: 0.48094513434629993d), new NpgsqlTypes.NpgsqlPoint(x: 0.08120526677799333d, y: 0.05390422396224204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315002314615468d, y: 0.5448514495504164d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12906429844197753d, y: 0.8914782338340005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150426411185028d, y: 0.27702716386943194d), new NpgsqlTypes.NpgsqlPoint(x: 0.10741223319886073d, y: 0.945614371800984d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6379250086904117d, y: 0.6361354394294206d), new NpgsqlTypes.NpgsqlPoint(x: 0.894808474819018d, y: 0.5432073475724415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382052463646125d, y: 0.1450968498443268d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6886564091999825d, y: 0.6904760881811756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999699412836332d, y: 0.7977073362673088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207921819387614d, y: 0.99081827093795d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9816463910937645d, y: 0.19261964909044949d), new NpgsqlTypes.NpgsqlPoint(x: 0.24170469351919777d, y: 0.7546916259080851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7926076260473696d, y: 0.0017679966853337836d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7625573139724937d, y: 0.024785498270420425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535237699796944d, y: 0.2756425988617085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972243032241285d, y: 0.62553521881743d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.781999022114262d, y: 0.4788377810278822d), new NpgsqlTypes.NpgsqlPoint(x: 0.13765928621293366d, y: 0.19684447865898114d), new NpgsqlTypes.NpgsqlPoint(x: 0.025626340629043898d, y: 0.596727348087263d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6099545850305831d, y: 0.900839281440075d), new NpgsqlTypes.NpgsqlPoint(x: 0.38741649078205365d, y: 0.8193711242622901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2192999488637396d, y: 0.6581338811096814d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28385335898833486d, y: 0.05214879615295942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346942219715389d, y: 0.252557555128582d), new NpgsqlTypes.NpgsqlPoint(x: 0.51833306798709d, y: 0.40547902921696455d)),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44749758430418485d, y: 0.8111304097602124d), new NpgsqlTypes.NpgsqlPoint(x: 0.4149401408121871d, y: 0.029768258353617516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2739204983861002d, y: 0.13859679534079739d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1912890521821914d, y: 0.22258640119340722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009196048933527d, y: 0.3070741830260013d), new NpgsqlTypes.NpgsqlPoint(x: 0.06326856242712631d, y: 0.8413676478339261d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3075605779052115d, y: 0.10130240501256416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9121819950670285d, y: 0.9797255225695497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124703055841977d, y: 0.9850524511620676d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30078413711453456d, y: 0.9290816096881368d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554563632546238d, y: 0.8983250726058022d), new NpgsqlTypes.NpgsqlPoint(x: 0.698894389139898d, y: 0.3159395348614953d))));
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[34], false);
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
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 94, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[34], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 99, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[34], false);
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 6, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[34], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 113, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 13, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 101, 100))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[34], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 145);
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
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39981628150467086d, y: 0.9096898415071147d), new NpgsqlTypes.NpgsqlPoint(x: 0.05649285434184925d, y: 0.37915713332349554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175941934909284d, y: 0.9760204893139196d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5987718483089792d, y: 0.04337441217924509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9331045485509675d, y: 0.054168558775153364d), new NpgsqlTypes.NpgsqlPoint(x: 0.30564662403822995d, y: 0.5937996693997128d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2209666322002316d, y: 0.4289486972844535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8693400152484233d, y: 0.38701815174862775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7239540917670024d, y: 0.2179009838991991d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12866210448567983d, y: 0.6532803918416004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126471583279905d, y: 0.08711789286067129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122497435005867d, y: 0.1516666789960982d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05145058541767078d, y: 0.978447950131792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772482575982819d, y: 0.1254097146582338d), new NpgsqlTypes.NpgsqlPoint(x: 0.704332056840099d, y: 0.24716104647193993d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7509629667208474d, y: 0.4023191880168512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7171574816783656d, y: 0.1806950667911862d), new NpgsqlTypes.NpgsqlPoint(x: 0.12020999785853215d, y: 0.02080979039430053d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9356851321913437d, y: 0.05087194388733274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8245707583149722d, y: 0.19160907284642115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4713405576572467d, y: 0.5328875119397529d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9707670925404813d, y: 0.3456372585869063d), new NpgsqlTypes.NpgsqlPoint(x: 0.3467185734050793d, y: 0.9157451116815868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351530527118231d, y: 0.7736318919295477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.469844425350868d, y: 0.5016252454246847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258990749113402d, y: 0.9414535948205212d), new NpgsqlTypes.NpgsqlPoint(x: 0.42092458307342706d, y: 0.4051690497766939d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9990950146358278d, y: 0.06665172531791708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179833418329941d, y: 0.07972677932874939d), new NpgsqlTypes.NpgsqlPoint(x: 0.1842612322796091d, y: 0.4889844449660339d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13421654710776387d, y: 0.9529303734243604d), new NpgsqlTypes.NpgsqlPoint(x: 0.11471645404595843d, y: 0.2986467268785533d), new NpgsqlTypes.NpgsqlPoint(x: 0.10307155407526913d, y: 0.10721248015931395d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27377208839339806d, y: 0.48262378435917686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3497606476786371d, y: 0.9517053489536329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537623891975697d, y: 0.16608764451237878d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11043207592530835d, y: 0.7872360646003627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871401222056356d, y: 0.8245591502650523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807014876554195d, y: 0.30091412272868856d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5062797256258798d, y: 0.5229130733339268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809614850113121d, y: 0.05840070818494869d), new NpgsqlTypes.NpgsqlPoint(x: 0.450899811334565d, y: 0.646565862360338d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6364815917076038d, y: 0.6805176680656899d), new NpgsqlTypes.NpgsqlPoint(x: 0.515268439407007d, y: 0.6767480784301377d), new NpgsqlTypes.NpgsqlPoint(x: 0.11926799965785906d, y: 0.3009763012547306d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33411106204344654d, y: 0.6477008772139324d), new NpgsqlTypes.NpgsqlPoint(x: 0.22728907841162416d, y: 0.2260375516158829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344091666723848d, y: 0.8695466608270727d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29045127504163715d, y: 0.10698409678536425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989444857165744d, y: 0.9970026295141289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311914405579254d, y: 0.8707505392150061d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6552138044720905d, y: 0.23318507129297794d), new NpgsqlTypes.NpgsqlPoint(x: 0.1641811897474741d, y: 0.3846920384086773d), new NpgsqlTypes.NpgsqlPoint(x: 0.10094300964391145d, y: 0.4917632562228974d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6794123351754863d, y: 0.6805209255301184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477938487124839d, y: 0.6086266039676168d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535733892668518d, y: 0.47266066327282785d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44749758430418485d, y: 0.8111304097602124d), new NpgsqlTypes.NpgsqlPoint(x: 0.4149401408121871d, y: 0.029768258353617516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2739204983861002d, y: 0.13859679534079739d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9306894858408014d, y: 0.8729808582488856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384530870422628d, y: 0.7451877876489719d), new NpgsqlTypes.NpgsqlPoint(x: 0.14935563284081366d, y: 0.6681050767234552d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606749044425382d, y: 0.8189327137750921d), new NpgsqlTypes.NpgsqlPoint(x: 0.22821770156941312d, y: 0.10708541563528107d), new NpgsqlTypes.NpgsqlPoint(x: 0.05368812923098687d, y: 0.7654790229772713d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1912890521821914d, y: 0.22258640119340722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009196048933527d, y: 0.3070741830260013d), new NpgsqlTypes.NpgsqlPoint(x: 0.06326856242712631d, y: 0.8413676478339261d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.708007861649994d, y: 0.20465161534187581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275713697907468d, y: 0.4411013154721378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2107110747320241d, y: 0.17348336665496433d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3075605779052115d, y: 0.10130240501256416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9121819950670285d, y: 0.9797255225695497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124703055841977d, y: 0.9850524511620676d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28453371378995806d, y: 0.35816627023371617d), new NpgsqlTypes.NpgsqlPoint(x: 0.607636565474895d, y: 0.7459226720012685d), new NpgsqlTypes.NpgsqlPoint(x: 0.3137269891304788d, y: 0.48299553480548707d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33444923747091715d, y: 0.24822800062532213d), new NpgsqlTypes.NpgsqlPoint(x: 0.3067351285216262d, y: 0.5072034392967705d), new NpgsqlTypes.NpgsqlPoint(x: 0.16450105190653974d, y: 0.11211427160249443d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30078413711453456d, y: 0.9290816096881368d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554563632546238d, y: 0.8983250726058022d), new NpgsqlTypes.NpgsqlPoint(x: 0.698894389139898d, y: 0.3159395348614953d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5656802144379972d, y: 0.8648990895294142d), new NpgsqlTypes.NpgsqlPoint(x: 0.667891486904991d, y: 0.8181877837101925d), new NpgsqlTypes.NpgsqlPoint(x: 0.15506819450077358d, y: 0.023899745295255292d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22739963230989202d, y: 0.6591827401758863d), new NpgsqlTypes.NpgsqlPoint(x: 0.3082322629286265d, y: 0.15363984368433015d), new NpgsqlTypes.NpgsqlPoint(x: 0.464451138687492d, y: 0.10312434880749377d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18884688117124704d, y: 0.07492472329462807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028192453885521d, y: 0.15950006489384472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364956684946806d, y: 0.3805306528054262d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17928316741065564d, y: 0.7146823917402549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118901092752094d, y: 0.3218618909664347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551300407102793d, y: 0.1096876976227481d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45347945165162196d, y: 0.20983235583191484d), new NpgsqlTypes.NpgsqlPoint(x: 0.08528379836429689d, y: 0.03713109709817397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123952730783987d, y: 0.033995098249328115d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7008572349205422d, y: 0.8997614005785748d), new NpgsqlTypes.NpgsqlPoint(x: 0.21653627397342545d, y: 0.3394356819771842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785136324576341d, y: 0.9032861178599476d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38726753126787516d, y: 0.005183676312143115d), new NpgsqlTypes.NpgsqlPoint(x: 0.1319870220250009d, y: 0.7370238446030709d), new NpgsqlTypes.NpgsqlPoint(x: 0.130710174764199d, y: 0.9803336610187536d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0843820425399524d, y: 0.732243679022812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711569594156373d, y: 0.3233246658226312d), new NpgsqlTypes.NpgsqlPoint(x: 0.009959119558207163d, y: 0.8931044613855814d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.607493314563342d, y: 0.5741698247720027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7308428911948642d, y: 0.7604994301282415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063079380775325d, y: 0.096081690998855d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8988382641777065d, y: 0.8195300977255039d), new NpgsqlTypes.NpgsqlPoint(x: 0.9065466833056028d, y: 0.7345614717194644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350566575801287d, y: 0.9669861100742709d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03908902608029219d, y: 0.6245006126614341d), new NpgsqlTypes.NpgsqlPoint(x: 0.024322386875919477d, y: 0.48888716021360834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751989882732856d, y: 0.690200835899033d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9108454313523218d, y: 0.7980978852956719d), new NpgsqlTypes.NpgsqlPoint(x: 0.14499302244901302d, y: 0.4471244818076442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2774712780364398d, y: 0.7643531335832734d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8283086650315015d, y: 0.7317282752931071d), new NpgsqlTypes.NpgsqlPoint(x: 0.966068763328064d, y: 0.5283928013403414d), new NpgsqlTypes.NpgsqlPoint(x: 0.47277127238346695d, y: 0.9018652573187166d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8904313123560418d, y: 0.4424442205364083d), new NpgsqlTypes.NpgsqlPoint(x: 0.17387189064995123d, y: 0.6735641232466063d), new NpgsqlTypes.NpgsqlPoint(x: 0.20330877145849702d, y: 0.8457578440402048d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5352531799038845d, y: 0.5482190258716891d), new NpgsqlTypes.NpgsqlPoint(x: 0.07654202894679218d, y: 0.6936796692002938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978023675955646d, y: 0.42804922336852835d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7797596617275848d, y: 0.5138825416451362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3315154511225282d, y: 0.01256642968856947d), new NpgsqlTypes.NpgsqlPoint(x: 0.605836590801458d, y: 0.17190764958083926d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10414241994851181d, y: 0.3540289275565264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586759022838581d, y: 0.31898646923117335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046194307127687d, y: 0.8664986632730861d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9613072489919364d, y: 0.7022632855514832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136694559924324d, y: 0.4287980800679553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7563907069840874d, y: 0.028738342894612745d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34146388966470653d, y: 0.43403360078360664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242966407870647d, y: 0.8737395200445248d), new NpgsqlTypes.NpgsqlPoint(x: 0.03215327475184382d, y: 0.418872343722435d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.828435034736428d, y: 0.6268006261385097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517361551558206d, y: 0.6893178582602142d), new NpgsqlTypes.NpgsqlPoint(x: 0.23761337388026815d, y: 0.8435058927556883d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3814690891316108d, y: 0.11981443410266901d), new NpgsqlTypes.NpgsqlPoint(x: 0.006651835848228704d, y: 0.567819092333346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171072788186748d, y: 0.17464756385467628d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12779365169863321d, y: 0.0006959341248080619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7264882927331098d, y: 0.10346056110278301d), new NpgsqlTypes.NpgsqlPoint(x: 0.15532776557940509d, y: 0.6544439700343386d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16794310173772953d, y: 0.3893949582521288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35246975667522906d, y: 0.2530053373427892d), new NpgsqlTypes.NpgsqlPoint(x: 0.44360131933878866d, y: 0.9800945399882506d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.61138804875418d, y: 0.5882495475120714d), new NpgsqlTypes.NpgsqlPoint(x: 0.12741917661785906d, y: 0.7963877275946722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781575912557273d, y: 0.6485891040935818d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6248755325859874d, y: 0.8066290870936879d), new NpgsqlTypes.NpgsqlPoint(x: 0.38421568831149533d, y: 0.4543659180849524d), new NpgsqlTypes.NpgsqlPoint(x: 0.763821233843467d, y: 0.4814998660535318d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42882940994647734d, y: 0.7334054487369978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256490731435729d, y: 0.9073970136041067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234135206280194d, y: 0.37690262481724135d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6533765126794808d, y: 0.20715915878900204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215201391091808d, y: 0.875234017097137d), new NpgsqlTypes.NpgsqlPoint(x: 0.24082856322217472d, y: 0.746731731431582d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5452711110579846d, y: 0.6960620612188358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005113402112438d, y: 0.5465671322651828d), new NpgsqlTypes.NpgsqlPoint(x: 0.31412096585286153d, y: 0.8962966939772795d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5883830851427113d, y: 0.3356770672819792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549555693749293d, y: 0.4436861258000333d), new NpgsqlTypes.NpgsqlPoint(x: 0.11915159847070855d, y: 0.2476720837772104d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8335835899867289d, y: 0.7472232306380157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113993534076228d, y: 0.018174451822580484d), new NpgsqlTypes.NpgsqlPoint(x: 0.03184584968173554d, y: 0.8255871977901493d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46899691271965727d, y: 0.4840367349917335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1286000970453911d, y: 0.5666647088039347d), new NpgsqlTypes.NpgsqlPoint(x: 0.30217880827094146d, y: 0.6388716551705576d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.630378732960267d, y: 0.16072388937482962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245590116327394d, y: 0.39084321680483913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8504013746515993d, y: 0.5866202813435655d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.701025759346924d, y: 0.5061154497405885d), new NpgsqlTypes.NpgsqlPoint(x: 0.17076668473691858d, y: 0.2916260222562669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4878914377962259d, y: 0.7017598120413696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4108226776582007d, y: 0.6784757463410962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4668702372654673d, y: 0.20686289124574353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358567318949567d, y: 0.6352852541776717d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6772233252836851d, y: 0.4302409511084371d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618124516277405d, y: 0.9340414700901698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468600260839312d, y: 0.38010661072839336d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9544537524344588d, y: 0.7834285927152476d), new NpgsqlTypes.NpgsqlPoint(x: 0.35006380848009866d, y: 0.8481781640525444d), new NpgsqlTypes.NpgsqlPoint(x: 0.20310366656191814d, y: 0.5982174941054361d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5535037189132412d, y: 0.782544159812637d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836074331386584d, y: 0.08732447735271143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4141152104927308d, y: 0.35445024584180485d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.046324557132656374d, y: 0.4937478355284176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594628607013508d, y: 0.831686693758147d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935081759260278d, y: 0.5254427216659179d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.889717777993385d, y: 0.7165319619527264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6492325051471985d, y: 0.7934378198189911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8206685859327251d, y: 0.820970423594795d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15504661383606844d, y: 0.8494431179256143d), new NpgsqlTypes.NpgsqlPoint(x: 0.10957146336256385d, y: 0.05335487216180079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14608562020547378d, y: 0.2840806660884647d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03086584190739161d, y: 0.1671491178045047d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736408761379012d, y: 0.29614761976567805d), new NpgsqlTypes.NpgsqlPoint(x: 0.628475906743996d, y: 0.4472068425975948d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10369157492048686d, y: 0.7196430900455493d), new NpgsqlTypes.NpgsqlPoint(x: 0.43146223909672365d, y: 0.7899310310977129d), new NpgsqlTypes.NpgsqlPoint(x: 0.044446851210606764d, y: 0.5481880966615931d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944992224767675d, y: 0.9790426811280429d), new NpgsqlTypes.NpgsqlPoint(x: 0.4826230573173593d, y: 0.6527091875203705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9102121519389906d, y: 0.5622478594201633d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17589304252171234d, y: 0.48094513434629993d), new NpgsqlTypes.NpgsqlPoint(x: 0.08120526677799333d, y: 0.05390422396224204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315002314615468d, y: 0.5448514495504164d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12906429844197753d, y: 0.8914782338340005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150426411185028d, y: 0.27702716386943194d), new NpgsqlTypes.NpgsqlPoint(x: 0.10741223319886073d, y: 0.945614371800984d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6379250086904117d, y: 0.6361354394294206d), new NpgsqlTypes.NpgsqlPoint(x: 0.894808474819018d, y: 0.5432073475724415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382052463646125d, y: 0.1450968498443268d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6886564091999825d, y: 0.6904760881811756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999699412836332d, y: 0.7977073362673088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207921819387614d, y: 0.99081827093795d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9816463910937645d, y: 0.19261964909044949d), new NpgsqlTypes.NpgsqlPoint(x: 0.24170469351919777d, y: 0.7546916259080851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7926076260473696d, y: 0.0017679966853337836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7625573139724937d, y: 0.024785498270420425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535237699796944d, y: 0.2756425988617085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972243032241285d, y: 0.62553521881743d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.781999022114262d, y: 0.4788377810278822d), new NpgsqlTypes.NpgsqlPoint(x: 0.13765928621293366d, y: 0.19684447865898114d), new NpgsqlTypes.NpgsqlPoint(x: 0.025626340629043898d, y: 0.596727348087263d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6099545850305831d, y: 0.900839281440075d), new NpgsqlTypes.NpgsqlPoint(x: 0.38741649078205365d, y: 0.8193711242622901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2192999488637396d, y: 0.6581338811096814d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28385335898833486d, y: 0.05214879615295942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346942219715389d, y: 0.252557555128582d), new NpgsqlTypes.NpgsqlPoint(x: 0.51833306798709d, y: 0.40547902921696455d)))));//Value

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
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39981628150467086d, y: 0.9096898415071147d), new NpgsqlTypes.NpgsqlPoint(x: 0.05649285434184925d, y: 0.37915713332349554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175941934909284d, y: 0.9760204893139196d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5987718483089792d, y: 0.04337441217924509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9331045485509675d, y: 0.054168558775153364d), new NpgsqlTypes.NpgsqlPoint(x: 0.30564662403822995d, y: 0.5937996693997128d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2209666322002316d, y: 0.4289486972844535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8693400152484233d, y: 0.38701815174862775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7239540917670024d, y: 0.2179009838991991d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12866210448567983d, y: 0.6532803918416004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126471583279905d, y: 0.08711789286067129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122497435005867d, y: 0.1516666789960982d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05145058541767078d, y: 0.978447950131792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772482575982819d, y: 0.1254097146582338d), new NpgsqlTypes.NpgsqlPoint(x: 0.704332056840099d, y: 0.24716104647193993d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7509629667208474d, y: 0.4023191880168512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7171574816783656d, y: 0.1806950667911862d), new NpgsqlTypes.NpgsqlPoint(x: 0.12020999785853215d, y: 0.02080979039430053d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9356851321913437d, y: 0.05087194388733274d), new NpgsqlTypes.NpgsqlPoint(x: 0.8245707583149722d, y: 0.19160907284642115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4713405576572467d, y: 0.5328875119397529d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9707670925404813d, y: 0.3456372585869063d), new NpgsqlTypes.NpgsqlPoint(x: 0.3467185734050793d, y: 0.9157451116815868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351530527118231d, y: 0.7736318919295477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.469844425350868d, y: 0.5016252454246847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258990749113402d, y: 0.9414535948205212d), new NpgsqlTypes.NpgsqlPoint(x: 0.42092458307342706d, y: 0.4051690497766939d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9990950146358278d, y: 0.06665172531791708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179833418329941d, y: 0.07972677932874939d), new NpgsqlTypes.NpgsqlPoint(x: 0.1842612322796091d, y: 0.4889844449660339d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13421654710776387d, y: 0.9529303734243604d), new NpgsqlTypes.NpgsqlPoint(x: 0.11471645404595843d, y: 0.2986467268785533d), new NpgsqlTypes.NpgsqlPoint(x: 0.10307155407526913d, y: 0.10721248015931395d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27377208839339806d, y: 0.48262378435917686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3497606476786371d, y: 0.9517053489536329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537623891975697d, y: 0.16608764451237878d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11043207592530835d, y: 0.7872360646003627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871401222056356d, y: 0.8245591502650523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807014876554195d, y: 0.30091412272868856d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5062797256258798d, y: 0.5229130733339268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809614850113121d, y: 0.05840070818494869d), new NpgsqlTypes.NpgsqlPoint(x: 0.450899811334565d, y: 0.646565862360338d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6364815917076038d, y: 0.6805176680656899d), new NpgsqlTypes.NpgsqlPoint(x: 0.515268439407007d, y: 0.6767480784301377d), new NpgsqlTypes.NpgsqlPoint(x: 0.11926799965785906d, y: 0.3009763012547306d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33411106204344654d, y: 0.6477008772139324d), new NpgsqlTypes.NpgsqlPoint(x: 0.22728907841162416d, y: 0.2260375516158829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344091666723848d, y: 0.8695466608270727d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29045127504163715d, y: 0.10698409678536425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989444857165744d, y: 0.9970026295141289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311914405579254d, y: 0.8707505392150061d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6552138044720905d, y: 0.23318507129297794d), new NpgsqlTypes.NpgsqlPoint(x: 0.1641811897474741d, y: 0.3846920384086773d), new NpgsqlTypes.NpgsqlPoint(x: 0.10094300964391145d, y: 0.4917632562228974d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6794123351754863d, y: 0.6805209255301184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477938487124839d, y: 0.6086266039676168d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535733892668518d, y: 0.47266066327282785d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44749758430418485d, y: 0.8111304097602124d), new NpgsqlTypes.NpgsqlPoint(x: 0.4149401408121871d, y: 0.029768258353617516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2739204983861002d, y: 0.13859679534079739d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9306894858408014d, y: 0.8729808582488856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384530870422628d, y: 0.7451877876489719d), new NpgsqlTypes.NpgsqlPoint(x: 0.14935563284081366d, y: 0.6681050767234552d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9606749044425382d, y: 0.8189327137750921d), new NpgsqlTypes.NpgsqlPoint(x: 0.22821770156941312d, y: 0.10708541563528107d), new NpgsqlTypes.NpgsqlPoint(x: 0.05368812923098687d, y: 0.7654790229772713d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1912890521821914d, y: 0.22258640119340722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009196048933527d, y: 0.3070741830260013d), new NpgsqlTypes.NpgsqlPoint(x: 0.06326856242712631d, y: 0.8413676478339261d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.708007861649994d, y: 0.20465161534187581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9275713697907468d, y: 0.4411013154721378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2107110747320241d, y: 0.17348336665496433d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3075605779052115d, y: 0.10130240501256416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9121819950670285d, y: 0.9797255225695497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124703055841977d, y: 0.9850524511620676d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28453371378995806d, y: 0.35816627023371617d), new NpgsqlTypes.NpgsqlPoint(x: 0.607636565474895d, y: 0.7459226720012685d), new NpgsqlTypes.NpgsqlPoint(x: 0.3137269891304788d, y: 0.48299553480548707d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33444923747091715d, y: 0.24822800062532213d), new NpgsqlTypes.NpgsqlPoint(x: 0.3067351285216262d, y: 0.5072034392967705d), new NpgsqlTypes.NpgsqlPoint(x: 0.16450105190653974d, y: 0.11211427160249443d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30078413711453456d, y: 0.9290816096881368d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554563632546238d, y: 0.8983250726058022d), new NpgsqlTypes.NpgsqlPoint(x: 0.698894389139898d, y: 0.3159395348614953d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5656802144379972d, y: 0.8648990895294142d), new NpgsqlTypes.NpgsqlPoint(x: 0.667891486904991d, y: 0.8181877837101925d), new NpgsqlTypes.NpgsqlPoint(x: 0.15506819450077358d, y: 0.023899745295255292d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22739963230989202d, y: 0.6591827401758863d), new NpgsqlTypes.NpgsqlPoint(x: 0.3082322629286265d, y: 0.15363984368433015d), new NpgsqlTypes.NpgsqlPoint(x: 0.464451138687492d, y: 0.10312434880749377d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18884688117124704d, y: 0.07492472329462807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028192453885521d, y: 0.15950006489384472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364956684946806d, y: 0.3805306528054262d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17928316741065564d, y: 0.7146823917402549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118901092752094d, y: 0.3218618909664347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551300407102793d, y: 0.1096876976227481d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45347945165162196d, y: 0.20983235583191484d), new NpgsqlTypes.NpgsqlPoint(x: 0.08528379836429689d, y: 0.03713109709817397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123952730783987d, y: 0.033995098249328115d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7008572349205422d, y: 0.8997614005785748d), new NpgsqlTypes.NpgsqlPoint(x: 0.21653627397342545d, y: 0.3394356819771842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785136324576341d, y: 0.9032861178599476d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38726753126787516d, y: 0.005183676312143115d), new NpgsqlTypes.NpgsqlPoint(x: 0.1319870220250009d, y: 0.7370238446030709d), new NpgsqlTypes.NpgsqlPoint(x: 0.130710174764199d, y: 0.9803336610187536d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0843820425399524d, y: 0.732243679022812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711569594156373d, y: 0.3233246658226312d), new NpgsqlTypes.NpgsqlPoint(x: 0.009959119558207163d, y: 0.8931044613855814d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.607493314563342d, y: 0.5741698247720027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7308428911948642d, y: 0.7604994301282415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063079380775325d, y: 0.096081690998855d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8988382641777065d, y: 0.8195300977255039d), new NpgsqlTypes.NpgsqlPoint(x: 0.9065466833056028d, y: 0.7345614717194644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350566575801287d, y: 0.9669861100742709d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03908902608029219d, y: 0.6245006126614341d), new NpgsqlTypes.NpgsqlPoint(x: 0.024322386875919477d, y: 0.48888716021360834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751989882732856d, y: 0.690200835899033d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9108454313523218d, y: 0.7980978852956719d), new NpgsqlTypes.NpgsqlPoint(x: 0.14499302244901302d, y: 0.4471244818076442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2774712780364398d, y: 0.7643531335832734d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8283086650315015d, y: 0.7317282752931071d), new NpgsqlTypes.NpgsqlPoint(x: 0.966068763328064d, y: 0.5283928013403414d), new NpgsqlTypes.NpgsqlPoint(x: 0.47277127238346695d, y: 0.9018652573187166d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8904313123560418d, y: 0.4424442205364083d), new NpgsqlTypes.NpgsqlPoint(x: 0.17387189064995123d, y: 0.6735641232466063d), new NpgsqlTypes.NpgsqlPoint(x: 0.20330877145849702d, y: 0.8457578440402048d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5352531799038845d, y: 0.5482190258716891d), new NpgsqlTypes.NpgsqlPoint(x: 0.07654202894679218d, y: 0.6936796692002938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978023675955646d, y: 0.42804922336852835d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7797596617275848d, y: 0.5138825416451362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3315154511225282d, y: 0.01256642968856947d), new NpgsqlTypes.NpgsqlPoint(x: 0.605836590801458d, y: 0.17190764958083926d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10414241994851181d, y: 0.3540289275565264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586759022838581d, y: 0.31898646923117335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046194307127687d, y: 0.8664986632730861d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9613072489919364d, y: 0.7022632855514832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136694559924324d, y: 0.4287980800679553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7563907069840874d, y: 0.028738342894612745d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34146388966470653d, y: 0.43403360078360664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242966407870647d, y: 0.8737395200445248d), new NpgsqlTypes.NpgsqlPoint(x: 0.03215327475184382d, y: 0.418872343722435d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.828435034736428d, y: 0.6268006261385097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517361551558206d, y: 0.6893178582602142d), new NpgsqlTypes.NpgsqlPoint(x: 0.23761337388026815d, y: 0.8435058927556883d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3814690891316108d, y: 0.11981443410266901d), new NpgsqlTypes.NpgsqlPoint(x: 0.006651835848228704d, y: 0.567819092333346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171072788186748d, y: 0.17464756385467628d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12779365169863321d, y: 0.0006959341248080619d), new NpgsqlTypes.NpgsqlPoint(x: 0.7264882927331098d, y: 0.10346056110278301d), new NpgsqlTypes.NpgsqlPoint(x: 0.15532776557940509d, y: 0.6544439700343386d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16794310173772953d, y: 0.3893949582521288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35246975667522906d, y: 0.2530053373427892d), new NpgsqlTypes.NpgsqlPoint(x: 0.44360131933878866d, y: 0.9800945399882506d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.61138804875418d, y: 0.5882495475120714d), new NpgsqlTypes.NpgsqlPoint(x: 0.12741917661785906d, y: 0.7963877275946722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781575912557273d, y: 0.6485891040935818d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6248755325859874d, y: 0.8066290870936879d), new NpgsqlTypes.NpgsqlPoint(x: 0.38421568831149533d, y: 0.4543659180849524d), new NpgsqlTypes.NpgsqlPoint(x: 0.763821233843467d, y: 0.4814998660535318d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42882940994647734d, y: 0.7334054487369978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256490731435729d, y: 0.9073970136041067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234135206280194d, y: 0.37690262481724135d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6533765126794808d, y: 0.20715915878900204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215201391091808d, y: 0.875234017097137d), new NpgsqlTypes.NpgsqlPoint(x: 0.24082856322217472d, y: 0.746731731431582d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5452711110579846d, y: 0.6960620612188358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005113402112438d, y: 0.5465671322651828d), new NpgsqlTypes.NpgsqlPoint(x: 0.31412096585286153d, y: 0.8962966939772795d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5883830851427113d, y: 0.3356770672819792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549555693749293d, y: 0.4436861258000333d), new NpgsqlTypes.NpgsqlPoint(x: 0.11915159847070855d, y: 0.2476720837772104d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8335835899867289d, y: 0.7472232306380157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113993534076228d, y: 0.018174451822580484d), new NpgsqlTypes.NpgsqlPoint(x: 0.03184584968173554d, y: 0.8255871977901493d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46899691271965727d, y: 0.4840367349917335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1286000970453911d, y: 0.5666647088039347d), new NpgsqlTypes.NpgsqlPoint(x: 0.30217880827094146d, y: 0.6388716551705576d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.630378732960267d, y: 0.16072388937482962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245590116327394d, y: 0.39084321680483913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8504013746515993d, y: 0.5866202813435655d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.701025759346924d, y: 0.5061154497405885d), new NpgsqlTypes.NpgsqlPoint(x: 0.17076668473691858d, y: 0.2916260222562669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4878914377962259d, y: 0.7017598120413696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4108226776582007d, y: 0.6784757463410962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4668702372654673d, y: 0.20686289124574353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358567318949567d, y: 0.6352852541776717d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6772233252836851d, y: 0.4302409511084371d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618124516277405d, y: 0.9340414700901698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468600260839312d, y: 0.38010661072839336d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9544537524344588d, y: 0.7834285927152476d), new NpgsqlTypes.NpgsqlPoint(x: 0.35006380848009866d, y: 0.8481781640525444d), new NpgsqlTypes.NpgsqlPoint(x: 0.20310366656191814d, y: 0.5982174941054361d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5535037189132412d, y: 0.782544159812637d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836074331386584d, y: 0.08732447735271143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4141152104927308d, y: 0.35445024584180485d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.046324557132656374d, y: 0.4937478355284176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594628607013508d, y: 0.831686693758147d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935081759260278d, y: 0.5254427216659179d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.889717777993385d, y: 0.7165319619527264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6492325051471985d, y: 0.7934378198189911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8206685859327251d, y: 0.820970423594795d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15504661383606844d, y: 0.8494431179256143d), new NpgsqlTypes.NpgsqlPoint(x: 0.10957146336256385d, y: 0.05335487216180079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14608562020547378d, y: 0.2840806660884647d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03086584190739161d, y: 0.1671491178045047d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736408761379012d, y: 0.29614761976567805d), new NpgsqlTypes.NpgsqlPoint(x: 0.628475906743996d, y: 0.4472068425975948d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10369157492048686d, y: 0.7196430900455493d), new NpgsqlTypes.NpgsqlPoint(x: 0.43146223909672365d, y: 0.7899310310977129d), new NpgsqlTypes.NpgsqlPoint(x: 0.044446851210606764d, y: 0.5481880966615931d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944992224767675d, y: 0.9790426811280429d), new NpgsqlTypes.NpgsqlPoint(x: 0.4826230573173593d, y: 0.6527091875203705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9102121519389906d, y: 0.5622478594201633d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17589304252171234d, y: 0.48094513434629993d), new NpgsqlTypes.NpgsqlPoint(x: 0.08120526677799333d, y: 0.05390422396224204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315002314615468d, y: 0.5448514495504164d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12906429844197753d, y: 0.8914782338340005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150426411185028d, y: 0.27702716386943194d), new NpgsqlTypes.NpgsqlPoint(x: 0.10741223319886073d, y: 0.945614371800984d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6379250086904117d, y: 0.6361354394294206d), new NpgsqlTypes.NpgsqlPoint(x: 0.894808474819018d, y: 0.5432073475724415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382052463646125d, y: 0.1450968498443268d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6886564091999825d, y: 0.6904760881811756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999699412836332d, y: 0.7977073362673088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207921819387614d, y: 0.99081827093795d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9816463910937645d, y: 0.19261964909044949d), new NpgsqlTypes.NpgsqlPoint(x: 0.24170469351919777d, y: 0.7546916259080851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7926076260473696d, y: 0.0017679966853337836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7625573139724937d, y: 0.024785498270420425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535237699796944d, y: 0.2756425988617085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972243032241285d, y: 0.62553521881743d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.781999022114262d, y: 0.4788377810278822d), new NpgsqlTypes.NpgsqlPoint(x: 0.13765928621293366d, y: 0.19684447865898114d), new NpgsqlTypes.NpgsqlPoint(x: 0.025626340629043898d, y: 0.596727348087263d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6099545850305831d, y: 0.900839281440075d), new NpgsqlTypes.NpgsqlPoint(x: 0.38741649078205365d, y: 0.8193711242622901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2192999488637396d, y: 0.6581338811096814d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28385335898833486d, y: 0.05214879615295942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346942219715389d, y: 0.252557555128582d), new NpgsqlTypes.NpgsqlPoint(x: 0.51833306798709d, y: 0.40547902921696455d)))));//Value

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

