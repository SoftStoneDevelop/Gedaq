

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
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2803528712958001d, y: 0.6293844721178131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883918372599341d, y: 0.7720020799506303d), new NpgsqlTypes.NpgsqlPoint(x: 0.38575553048035893d, y: 0.8166280069204144d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5503460558399814d, y: 0.4670707171609909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414559428849136d, y: 0.3991597636333213d), new NpgsqlTypes.NpgsqlPoint(x: 0.19945178466342606d, y: 0.6411206232131528d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9015332012803364d, y: 0.6446868755817879d), new NpgsqlTypes.NpgsqlPoint(x: 0.32946780639692475d, y: 0.019044713324383622d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369787210141602d, y: 0.4030969195691191d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4946886061609185d, y: 0.49780283192866914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412817749866788d, y: 0.8486017970569862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345643349684049d, y: 0.8033707090540768d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9750682399972812d, y: 0.8171608650309794d), new NpgsqlTypes.NpgsqlPoint(x: 0.4465548398046929d, y: 0.00269879700184239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492802558125998d, y: 0.3030231835464561d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05232683426672158d, y: 0.04908374480312494d), new NpgsqlTypes.NpgsqlPoint(x: 0.26331944213562053d, y: 0.20567777571554735d), new NpgsqlTypes.NpgsqlPoint(x: 0.23389319978070722d, y: 0.020048197463262474d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9688596921889829d, y: 0.13831167984033998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959115758711049d, y: 0.37247142373018327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227596415016406d, y: 0.778408625390037d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425036070708117d, y: 0.7944843169171718d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787611467387594d, y: 0.6410827672022023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483032652979382d, y: 0.02396631565279761d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7379056430717199d, y: 0.1275005581177373d), new NpgsqlTypes.NpgsqlPoint(x: 0.28370097920624493d, y: 0.7247047723248209d), new NpgsqlTypes.NpgsqlPoint(x: 0.037345346385438516d, y: 0.5345677646313259d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7833117199980056d, y: 0.4900572022913928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641269033623692d, y: 0.3393639310293741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902212195403963d, y: 0.41802211341780116d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4614896083282334d, y: 0.46911157737653897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5767021258725892d, y: 0.1789088809547984d), new NpgsqlTypes.NpgsqlPoint(x: 0.14318918214032383d, y: 0.913587790115197d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28553637595682524d, y: 0.1519878917126758d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756938739555874d, y: 0.14909472232024723d), new NpgsqlTypes.NpgsqlPoint(x: 0.2990926202079822d, y: 0.6810752627811283d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9463338181661032d, y: 0.4924540220022142d), new NpgsqlTypes.NpgsqlPoint(x: 0.35061992021358923d, y: 0.8945299148716137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663516985427937d, y: 0.5816105954948069d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5771156778287848d, y: 0.269155294223962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729005734198666d, y: 0.6424988197396007d), new NpgsqlTypes.NpgsqlPoint(x: 0.501990534404265d, y: 0.9332688823390495d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37178478210772925d, y: 0.2057091219638365d), new NpgsqlTypes.NpgsqlPoint(x: 0.579506996336162d, y: 0.17372590426379608d), new NpgsqlTypes.NpgsqlPoint(x: 0.3503096777057709d, y: 0.7782931513096197d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1757190124914091d, y: 0.6102057654098513d), new NpgsqlTypes.NpgsqlPoint(x: 0.04307659518186424d, y: 0.382630023285089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4147475045393574d, y: 0.18513779376541406d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.96108267291151d, y: 0.45468550620991777d), new NpgsqlTypes.NpgsqlPoint(x: 0.1338924314512201d, y: 0.7819014986027617d), new NpgsqlTypes.NpgsqlPoint(x: 0.17155071087180562d, y: 0.3843301987183806d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7020973394315834d, y: 0.10462512387140988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415762551568821d, y: 0.6721661435000957d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740220996960467d, y: 0.5145955908439003d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858193474808163d, y: 0.9613351011667097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196885387329333d, y: 0.8276932888010009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535151298688968d, y: 0.15677952539645046d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07190776711738944d, y: 0.7170248327670823d), new NpgsqlTypes.NpgsqlPoint(x: 0.18788241280800144d, y: 0.8439298331987665d), new NpgsqlTypes.NpgsqlPoint(x: 0.09721309181649829d, y: 0.6153661505398338d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25688110039953227d, y: 0.7266484070494581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775299135993092d, y: 0.26788715576020405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304497542761041d, y: 0.7517808501919852d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05293958946972688d, y: 0.8335857495069566d), new NpgsqlTypes.NpgsqlPoint(x: 0.37663703673679094d, y: 0.38106523049915664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2854794019979414d, y: 0.9395927924425086d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4258340705770406d, y: 0.9343567805049025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718918369119709d, y: 0.45808278041025485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5199416446612575d, y: 0.14515570695733349d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10144694792541276d, y: 0.705262229980848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974628679701353d, y: 0.9503791707024839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539390120869675d, y: 0.6817646082777292d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.390940083104115d, y: 0.9898943794668095d), new NpgsqlTypes.NpgsqlPoint(x: 0.08058956228132785d, y: 0.14218965823885443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028074685037425d, y: 0.8331264273828932d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8259598053360316d, y: 0.8123034562735889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167816998779117d, y: 0.0805203611933023d), new NpgsqlTypes.NpgsqlPoint(x: 0.13277258143563164d, y: 0.4087882480717242d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37957014373912057d, y: 0.3045864506719518d), new NpgsqlTypes.NpgsqlPoint(x: 0.05396118614169487d, y: 0.6610993281223562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279094960823391d, y: 0.9124047257403922d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05204097882709513d, y: 0.10091990055494393d), new NpgsqlTypes.NpgsqlPoint(x: 0.944054200735481d, y: 0.08727166073086323d), new NpgsqlTypes.NpgsqlPoint(x: 0.11583656459077918d, y: 0.9938051884669301d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16340495682860012d, y: 0.4763951137477659d), new NpgsqlTypes.NpgsqlPoint(x: 0.08057655422634258d, y: 0.8780219978933747d), new NpgsqlTypes.NpgsqlPoint(x: 0.1481834161264005d, y: 0.5319038890835689d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6289041171321861d, y: 0.2874504821497854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642185617033471d, y: 0.28155336895097205d), new NpgsqlTypes.NpgsqlPoint(x: 0.179321793351217d, y: 0.7619948924913024d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.712839272758314d, y: 0.8514922923393122d), new NpgsqlTypes.NpgsqlPoint(x: 0.47733943759545894d, y: 0.6566506414521078d), new NpgsqlTypes.NpgsqlPoint(x: 0.9891364241539496d, y: 0.8407987892463142d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9521009115517861d, y: 0.6915973088651436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031250075016095d, y: 0.06530852309776736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457659574813057d, y: 0.29040737756420665d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4170431218219601d, y: 0.19180217170201075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712732345052554d, y: 0.5472153772489688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848131604969748d, y: 0.47828397732325945d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5175853573534585d, y: 0.6835478194911938d), new NpgsqlTypes.NpgsqlPoint(x: 0.0698653984713572d, y: 0.3100831286628575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2436792550688167d, y: 0.596274332073177d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369199735572316d, y: 0.055146096642249676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429053634783339d, y: 0.44381954802221724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1047125267567196d, y: 0.8960127825805104d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3379757706043619d, y: 0.5273279042167832d), new NpgsqlTypes.NpgsqlPoint(x: 0.16440680854910505d, y: 0.020545821426417366d), new NpgsqlTypes.NpgsqlPoint(x: 0.10125542192620163d, y: 0.2699568259836699d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7050995718122277d, y: 0.596468853895303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3671876719140663d, y: 0.6138967541507718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4639778557008041d, y: 0.7639279133728833d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34956758992163084d, y: 0.5666982478345949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460689730580194d, y: 0.4870048306114111d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095773876402148d, y: 0.26614862130005024d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9972706371243363d, y: 0.8880938813099333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931210733328103d, y: 0.9343319230073402d), new NpgsqlTypes.NpgsqlPoint(x: 0.499012638297457d, y: 0.6666287113987569d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.646695667773017d, y: 0.37335032211378494d), new NpgsqlTypes.NpgsqlPoint(x: 0.0824534807916415d, y: 0.4209910701544449d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215925922070591d, y: 0.21906353784219457d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8040665262438149d, y: 0.4507059466913289d), new NpgsqlTypes.NpgsqlPoint(x: 0.25275239132204164d, y: 0.8837777831348158d), new NpgsqlTypes.NpgsqlPoint(x: 0.331007882010825d, y: 0.6144521130485932d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3839117022310057d, y: 0.8679160420363455d), new NpgsqlTypes.NpgsqlPoint(x: 0.16739441714901493d, y: 0.8991725215518416d), new NpgsqlTypes.NpgsqlPoint(x: 0.385120812984719d, y: 0.619197047534891d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1496263418659175d, y: 0.0460614387258339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168080715293354d, y: 0.47248158796441053d), new NpgsqlTypes.NpgsqlPoint(x: 0.37003474103780964d, y: 0.482450819772128d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09559647990048026d, y: 0.12756946799031477d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648377661821885d, y: 0.7605326264445904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675141721854176d, y: 0.36416888844677076d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24761496005485084d, y: 0.5480215723723199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671193290648792d, y: 0.34633086827909854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843753628889893d, y: 0.8720683666540151d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010309617818873185d, y: 0.7619587047186073d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634666840002476d, y: 0.6268935310157032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398429770584167d, y: 0.2365078358338798d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0416545660766513d, y: 0.2162947422145297d), new NpgsqlTypes.NpgsqlPoint(x: 0.04000825122385254d, y: 0.30620499349108976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003810411572444d, y: 0.34619729820345135d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9279740092799297d, y: 0.8696872464995966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1494276612695693d, y: 0.6482088740077993d), new NpgsqlTypes.NpgsqlPoint(x: 0.96315935056476d, y: 0.6261407771495626d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6830085037005551d, y: 0.8656859979075067d), new NpgsqlTypes.NpgsqlPoint(x: 0.27942231758372515d, y: 0.3228648801366667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068371885930206d, y: 0.3624713926731278d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3286944961548718d, y: 0.9811756185628723d), new NpgsqlTypes.NpgsqlPoint(x: 0.309523913225596d, y: 0.8582040972001289d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896215059261822d, y: 0.11357459760032951d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27830631328943667d, y: 0.6353710289312323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299045701738858d, y: 0.6958695664158957d), new NpgsqlTypes.NpgsqlPoint(x: 0.37135467248819387d, y: 0.4259168194183922d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2984343509980565d, y: 0.49770977254721427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984693503734907d, y: 0.533386487320559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635694735341634d, y: 0.371656534273469d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9355580883750149d, y: 0.5261912221543559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8031190760467267d, y: 0.15573914526914234d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907165062595295d, y: 0.8405026103721867d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6330542046464797d, y: 0.2568948398545775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510284379986262d, y: 0.8530296115904761d), new NpgsqlTypes.NpgsqlPoint(x: 0.1848007056874964d, y: 0.38881510493999205d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7822130538988332d, y: 0.8455550671227653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3856711676529505d, y: 0.05285003378925801d), new NpgsqlTypes.NpgsqlPoint(x: 0.3867997090820915d, y: 0.16196784186396374d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6735302519065699d, y: 0.2732251264505863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082899244440064d, y: 0.8996430714321556d), new NpgsqlTypes.NpgsqlPoint(x: 0.11774676517525995d, y: 0.5578401358467903d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7079191392944398d, y: 0.3874687229697259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8957586830313587d, y: 0.3430150865499362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3268674647921169d, y: 0.274961229210267d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46942740440186415d, y: 0.3292966408971939d), new NpgsqlTypes.NpgsqlPoint(x: 0.466762075993836d, y: 0.4245574642376829d), new NpgsqlTypes.NpgsqlPoint(x: 0.887183892033852d, y: 0.03889449362498598d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3017935685563975d, y: 0.6457501022013078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718021290110088d, y: 0.9501681474522758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133139927836149d, y: 0.5176013734953439d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09752267742851406d, y: 0.2827569248271943d), new NpgsqlTypes.NpgsqlPoint(x: 0.889696330856498d, y: 0.8426922669884293d), new NpgsqlTypes.NpgsqlPoint(x: 0.27638027725860226d, y: 0.38927710554039907d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9294622430440802d, y: 0.9452919491258224d), new NpgsqlTypes.NpgsqlPoint(x: 0.08981164483196313d, y: 0.1892775179384063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900814297714932d, y: 0.11930179786670592d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15953526366005588d, y: 0.944087396511371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287463797488761d, y: 0.006837737258069909d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335674115328729d, y: 0.0645918726872835d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21836606732935782d, y: 0.4768187789486332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510254165338439d, y: 0.3373363131908347d), new NpgsqlTypes.NpgsqlPoint(x: 0.14064959346827044d, y: 0.825044350758304d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13501340836687103d, y: 0.7221303311538705d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920985669398092d, y: 0.6688950414220056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022913385398633d, y: 0.9192147889686224d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7453062377440893d, y: 0.9614395946073775d), new NpgsqlTypes.NpgsqlPoint(x: 0.12079225083474954d, y: 0.3364233383485489d), new NpgsqlTypes.NpgsqlPoint(x: 0.057138599451448835d, y: 0.05972505964999886d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14539993980614951d, y: 0.6615197705112471d), new NpgsqlTypes.NpgsqlPoint(x: 0.4711272568385937d, y: 0.647659465055746d), new NpgsqlTypes.NpgsqlPoint(x: 0.35601796821308207d, y: 0.8661556383304004d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006189453526919797d, y: 0.7643177573533659d), new NpgsqlTypes.NpgsqlPoint(x: 0.2442013054460247d, y: 0.3173293147082513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2700639107452577d, y: 0.6137158075537962d)),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25688110039953227d, y: 0.7266484070494581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775299135993092d, y: 0.26788715576020405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304497542761041d, y: 0.7517808501919852d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 104, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 44, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 33, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 119, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 111, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 119, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2803528712958001d, y: 0.6293844721178131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883918372599341d, y: 0.7720020799506303d), new NpgsqlTypes.NpgsqlPoint(x: 0.38575553048035893d, y: 0.8166280069204144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5503460558399814d, y: 0.4670707171609909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414559428849136d, y: 0.3991597636333213d), new NpgsqlTypes.NpgsqlPoint(x: 0.19945178466342606d, y: 0.6411206232131528d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9015332012803364d, y: 0.6446868755817879d), new NpgsqlTypes.NpgsqlPoint(x: 0.32946780639692475d, y: 0.019044713324383622d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369787210141602d, y: 0.4030969195691191d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4946886061609185d, y: 0.49780283192866914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412817749866788d, y: 0.8486017970569862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345643349684049d, y: 0.8033707090540768d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9750682399972812d, y: 0.8171608650309794d), new NpgsqlTypes.NpgsqlPoint(x: 0.4465548398046929d, y: 0.00269879700184239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492802558125998d, y: 0.3030231835464561d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05232683426672158d, y: 0.04908374480312494d), new NpgsqlTypes.NpgsqlPoint(x: 0.26331944213562053d, y: 0.20567777571554735d), new NpgsqlTypes.NpgsqlPoint(x: 0.23389319978070722d, y: 0.020048197463262474d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9688596921889829d, y: 0.13831167984033998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959115758711049d, y: 0.37247142373018327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227596415016406d, y: 0.778408625390037d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425036070708117d, y: 0.7944843169171718d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787611467387594d, y: 0.6410827672022023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483032652979382d, y: 0.02396631565279761d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7379056430717199d, y: 0.1275005581177373d), new NpgsqlTypes.NpgsqlPoint(x: 0.28370097920624493d, y: 0.7247047723248209d), new NpgsqlTypes.NpgsqlPoint(x: 0.037345346385438516d, y: 0.5345677646313259d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7833117199980056d, y: 0.4900572022913928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641269033623692d, y: 0.3393639310293741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902212195403963d, y: 0.41802211341780116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4614896083282334d, y: 0.46911157737653897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5767021258725892d, y: 0.1789088809547984d), new NpgsqlTypes.NpgsqlPoint(x: 0.14318918214032383d, y: 0.913587790115197d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28553637595682524d, y: 0.1519878917126758d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756938739555874d, y: 0.14909472232024723d), new NpgsqlTypes.NpgsqlPoint(x: 0.2990926202079822d, y: 0.6810752627811283d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9463338181661032d, y: 0.4924540220022142d), new NpgsqlTypes.NpgsqlPoint(x: 0.35061992021358923d, y: 0.8945299148716137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663516985427937d, y: 0.5816105954948069d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5771156778287848d, y: 0.269155294223962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729005734198666d, y: 0.6424988197396007d), new NpgsqlTypes.NpgsqlPoint(x: 0.501990534404265d, y: 0.9332688823390495d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37178478210772925d, y: 0.2057091219638365d), new NpgsqlTypes.NpgsqlPoint(x: 0.579506996336162d, y: 0.17372590426379608d), new NpgsqlTypes.NpgsqlPoint(x: 0.3503096777057709d, y: 0.7782931513096197d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1757190124914091d, y: 0.6102057654098513d), new NpgsqlTypes.NpgsqlPoint(x: 0.04307659518186424d, y: 0.382630023285089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4147475045393574d, y: 0.18513779376541406d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.96108267291151d, y: 0.45468550620991777d), new NpgsqlTypes.NpgsqlPoint(x: 0.1338924314512201d, y: 0.7819014986027617d), new NpgsqlTypes.NpgsqlPoint(x: 0.17155071087180562d, y: 0.3843301987183806d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7020973394315834d, y: 0.10462512387140988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415762551568821d, y: 0.6721661435000957d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740220996960467d, y: 0.5145955908439003d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858193474808163d, y: 0.9613351011667097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196885387329333d, y: 0.8276932888010009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535151298688968d, y: 0.15677952539645046d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07190776711738944d, y: 0.7170248327670823d), new NpgsqlTypes.NpgsqlPoint(x: 0.18788241280800144d, y: 0.8439298331987665d), new NpgsqlTypes.NpgsqlPoint(x: 0.09721309181649829d, y: 0.6153661505398338d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25688110039953227d, y: 0.7266484070494581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775299135993092d, y: 0.26788715576020405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304497542761041d, y: 0.7517808501919852d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05293958946972688d, y: 0.8335857495069566d), new NpgsqlTypes.NpgsqlPoint(x: 0.37663703673679094d, y: 0.38106523049915664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2854794019979414d, y: 0.9395927924425086d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4258340705770406d, y: 0.9343567805049025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718918369119709d, y: 0.45808278041025485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5199416446612575d, y: 0.14515570695733349d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10144694792541276d, y: 0.705262229980848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974628679701353d, y: 0.9503791707024839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539390120869675d, y: 0.6817646082777292d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.390940083104115d, y: 0.9898943794668095d), new NpgsqlTypes.NpgsqlPoint(x: 0.08058956228132785d, y: 0.14218965823885443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028074685037425d, y: 0.8331264273828932d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8259598053360316d, y: 0.8123034562735889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167816998779117d, y: 0.0805203611933023d), new NpgsqlTypes.NpgsqlPoint(x: 0.13277258143563164d, y: 0.4087882480717242d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37957014373912057d, y: 0.3045864506719518d), new NpgsqlTypes.NpgsqlPoint(x: 0.05396118614169487d, y: 0.6610993281223562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279094960823391d, y: 0.9124047257403922d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05204097882709513d, y: 0.10091990055494393d), new NpgsqlTypes.NpgsqlPoint(x: 0.944054200735481d, y: 0.08727166073086323d), new NpgsqlTypes.NpgsqlPoint(x: 0.11583656459077918d, y: 0.9938051884669301d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16340495682860012d, y: 0.4763951137477659d), new NpgsqlTypes.NpgsqlPoint(x: 0.08057655422634258d, y: 0.8780219978933747d), new NpgsqlTypes.NpgsqlPoint(x: 0.1481834161264005d, y: 0.5319038890835689d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6289041171321861d, y: 0.2874504821497854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642185617033471d, y: 0.28155336895097205d), new NpgsqlTypes.NpgsqlPoint(x: 0.179321793351217d, y: 0.7619948924913024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.712839272758314d, y: 0.8514922923393122d), new NpgsqlTypes.NpgsqlPoint(x: 0.47733943759545894d, y: 0.6566506414521078d), new NpgsqlTypes.NpgsqlPoint(x: 0.9891364241539496d, y: 0.8407987892463142d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9521009115517861d, y: 0.6915973088651436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031250075016095d, y: 0.06530852309776736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457659574813057d, y: 0.29040737756420665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4170431218219601d, y: 0.19180217170201075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712732345052554d, y: 0.5472153772489688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848131604969748d, y: 0.47828397732325945d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5175853573534585d, y: 0.6835478194911938d), new NpgsqlTypes.NpgsqlPoint(x: 0.0698653984713572d, y: 0.3100831286628575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2436792550688167d, y: 0.596274332073177d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369199735572316d, y: 0.055146096642249676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429053634783339d, y: 0.44381954802221724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1047125267567196d, y: 0.8960127825805104d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3379757706043619d, y: 0.5273279042167832d), new NpgsqlTypes.NpgsqlPoint(x: 0.16440680854910505d, y: 0.020545821426417366d), new NpgsqlTypes.NpgsqlPoint(x: 0.10125542192620163d, y: 0.2699568259836699d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7050995718122277d, y: 0.596468853895303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3671876719140663d, y: 0.6138967541507718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4639778557008041d, y: 0.7639279133728833d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34956758992163084d, y: 0.5666982478345949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460689730580194d, y: 0.4870048306114111d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095773876402148d, y: 0.26614862130005024d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9972706371243363d, y: 0.8880938813099333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931210733328103d, y: 0.9343319230073402d), new NpgsqlTypes.NpgsqlPoint(x: 0.499012638297457d, y: 0.6666287113987569d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.646695667773017d, y: 0.37335032211378494d), new NpgsqlTypes.NpgsqlPoint(x: 0.0824534807916415d, y: 0.4209910701544449d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215925922070591d, y: 0.21906353784219457d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8040665262438149d, y: 0.4507059466913289d), new NpgsqlTypes.NpgsqlPoint(x: 0.25275239132204164d, y: 0.8837777831348158d), new NpgsqlTypes.NpgsqlPoint(x: 0.331007882010825d, y: 0.6144521130485932d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3839117022310057d, y: 0.8679160420363455d), new NpgsqlTypes.NpgsqlPoint(x: 0.16739441714901493d, y: 0.8991725215518416d), new NpgsqlTypes.NpgsqlPoint(x: 0.385120812984719d, y: 0.619197047534891d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1496263418659175d, y: 0.0460614387258339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168080715293354d, y: 0.47248158796441053d), new NpgsqlTypes.NpgsqlPoint(x: 0.37003474103780964d, y: 0.482450819772128d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09559647990048026d, y: 0.12756946799031477d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648377661821885d, y: 0.7605326264445904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675141721854176d, y: 0.36416888844677076d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24761496005485084d, y: 0.5480215723723199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671193290648792d, y: 0.34633086827909854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843753628889893d, y: 0.8720683666540151d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010309617818873185d, y: 0.7619587047186073d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634666840002476d, y: 0.6268935310157032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398429770584167d, y: 0.2365078358338798d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0416545660766513d, y: 0.2162947422145297d), new NpgsqlTypes.NpgsqlPoint(x: 0.04000825122385254d, y: 0.30620499349108976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003810411572444d, y: 0.34619729820345135d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9279740092799297d, y: 0.8696872464995966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1494276612695693d, y: 0.6482088740077993d), new NpgsqlTypes.NpgsqlPoint(x: 0.96315935056476d, y: 0.6261407771495626d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6830085037005551d, y: 0.8656859979075067d), new NpgsqlTypes.NpgsqlPoint(x: 0.27942231758372515d, y: 0.3228648801366667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068371885930206d, y: 0.3624713926731278d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3286944961548718d, y: 0.9811756185628723d), new NpgsqlTypes.NpgsqlPoint(x: 0.309523913225596d, y: 0.8582040972001289d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896215059261822d, y: 0.11357459760032951d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27830631328943667d, y: 0.6353710289312323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299045701738858d, y: 0.6958695664158957d), new NpgsqlTypes.NpgsqlPoint(x: 0.37135467248819387d, y: 0.4259168194183922d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2984343509980565d, y: 0.49770977254721427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984693503734907d, y: 0.533386487320559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635694735341634d, y: 0.371656534273469d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9355580883750149d, y: 0.5261912221543559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8031190760467267d, y: 0.15573914526914234d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907165062595295d, y: 0.8405026103721867d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6330542046464797d, y: 0.2568948398545775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510284379986262d, y: 0.8530296115904761d), new NpgsqlTypes.NpgsqlPoint(x: 0.1848007056874964d, y: 0.38881510493999205d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7822130538988332d, y: 0.8455550671227653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3856711676529505d, y: 0.05285003378925801d), new NpgsqlTypes.NpgsqlPoint(x: 0.3867997090820915d, y: 0.16196784186396374d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6735302519065699d, y: 0.2732251264505863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082899244440064d, y: 0.8996430714321556d), new NpgsqlTypes.NpgsqlPoint(x: 0.11774676517525995d, y: 0.5578401358467903d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7079191392944398d, y: 0.3874687229697259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8957586830313587d, y: 0.3430150865499362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3268674647921169d, y: 0.274961229210267d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46942740440186415d, y: 0.3292966408971939d), new NpgsqlTypes.NpgsqlPoint(x: 0.466762075993836d, y: 0.4245574642376829d), new NpgsqlTypes.NpgsqlPoint(x: 0.887183892033852d, y: 0.03889449362498598d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3017935685563975d, y: 0.6457501022013078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718021290110088d, y: 0.9501681474522758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133139927836149d, y: 0.5176013734953439d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09752267742851406d, y: 0.2827569248271943d), new NpgsqlTypes.NpgsqlPoint(x: 0.889696330856498d, y: 0.8426922669884293d), new NpgsqlTypes.NpgsqlPoint(x: 0.27638027725860226d, y: 0.38927710554039907d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9294622430440802d, y: 0.9452919491258224d), new NpgsqlTypes.NpgsqlPoint(x: 0.08981164483196313d, y: 0.1892775179384063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900814297714932d, y: 0.11930179786670592d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15953526366005588d, y: 0.944087396511371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287463797488761d, y: 0.006837737258069909d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335674115328729d, y: 0.0645918726872835d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21836606732935782d, y: 0.4768187789486332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510254165338439d, y: 0.3373363131908347d), new NpgsqlTypes.NpgsqlPoint(x: 0.14064959346827044d, y: 0.825044350758304d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13501340836687103d, y: 0.7221303311538705d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920985669398092d, y: 0.6688950414220056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022913385398633d, y: 0.9192147889686224d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7453062377440893d, y: 0.9614395946073775d), new NpgsqlTypes.NpgsqlPoint(x: 0.12079225083474954d, y: 0.3364233383485489d), new NpgsqlTypes.NpgsqlPoint(x: 0.057138599451448835d, y: 0.05972505964999886d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14539993980614951d, y: 0.6615197705112471d), new NpgsqlTypes.NpgsqlPoint(x: 0.4711272568385937d, y: 0.647659465055746d), new NpgsqlTypes.NpgsqlPoint(x: 0.35601796821308207d, y: 0.8661556383304004d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006189453526919797d, y: 0.7643177573533659d), new NpgsqlTypes.NpgsqlPoint(x: 0.2442013054460247d, y: 0.3173293147082513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2700639107452577d, y: 0.6137158075537962d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2803528712958001d, y: 0.6293844721178131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883918372599341d, y: 0.7720020799506303d), new NpgsqlTypes.NpgsqlPoint(x: 0.38575553048035893d, y: 0.8166280069204144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5503460558399814d, y: 0.4670707171609909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414559428849136d, y: 0.3991597636333213d), new NpgsqlTypes.NpgsqlPoint(x: 0.19945178466342606d, y: 0.6411206232131528d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9015332012803364d, y: 0.6446868755817879d), new NpgsqlTypes.NpgsqlPoint(x: 0.32946780639692475d, y: 0.019044713324383622d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369787210141602d, y: 0.4030969195691191d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4946886061609185d, y: 0.49780283192866914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412817749866788d, y: 0.8486017970569862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345643349684049d, y: 0.8033707090540768d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9750682399972812d, y: 0.8171608650309794d), new NpgsqlTypes.NpgsqlPoint(x: 0.4465548398046929d, y: 0.00269879700184239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492802558125998d, y: 0.3030231835464561d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05232683426672158d, y: 0.04908374480312494d), new NpgsqlTypes.NpgsqlPoint(x: 0.26331944213562053d, y: 0.20567777571554735d), new NpgsqlTypes.NpgsqlPoint(x: 0.23389319978070722d, y: 0.020048197463262474d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9688596921889829d, y: 0.13831167984033998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959115758711049d, y: 0.37247142373018327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227596415016406d, y: 0.778408625390037d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425036070708117d, y: 0.7944843169171718d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787611467387594d, y: 0.6410827672022023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483032652979382d, y: 0.02396631565279761d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7379056430717199d, y: 0.1275005581177373d), new NpgsqlTypes.NpgsqlPoint(x: 0.28370097920624493d, y: 0.7247047723248209d), new NpgsqlTypes.NpgsqlPoint(x: 0.037345346385438516d, y: 0.5345677646313259d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7833117199980056d, y: 0.4900572022913928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641269033623692d, y: 0.3393639310293741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902212195403963d, y: 0.41802211341780116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4614896083282334d, y: 0.46911157737653897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5767021258725892d, y: 0.1789088809547984d), new NpgsqlTypes.NpgsqlPoint(x: 0.14318918214032383d, y: 0.913587790115197d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28553637595682524d, y: 0.1519878917126758d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756938739555874d, y: 0.14909472232024723d), new NpgsqlTypes.NpgsqlPoint(x: 0.2990926202079822d, y: 0.6810752627811283d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9463338181661032d, y: 0.4924540220022142d), new NpgsqlTypes.NpgsqlPoint(x: 0.35061992021358923d, y: 0.8945299148716137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663516985427937d, y: 0.5816105954948069d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5771156778287848d, y: 0.269155294223962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729005734198666d, y: 0.6424988197396007d), new NpgsqlTypes.NpgsqlPoint(x: 0.501990534404265d, y: 0.9332688823390495d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37178478210772925d, y: 0.2057091219638365d), new NpgsqlTypes.NpgsqlPoint(x: 0.579506996336162d, y: 0.17372590426379608d), new NpgsqlTypes.NpgsqlPoint(x: 0.3503096777057709d, y: 0.7782931513096197d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1757190124914091d, y: 0.6102057654098513d), new NpgsqlTypes.NpgsqlPoint(x: 0.04307659518186424d, y: 0.382630023285089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4147475045393574d, y: 0.18513779376541406d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.96108267291151d, y: 0.45468550620991777d), new NpgsqlTypes.NpgsqlPoint(x: 0.1338924314512201d, y: 0.7819014986027617d), new NpgsqlTypes.NpgsqlPoint(x: 0.17155071087180562d, y: 0.3843301987183806d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7020973394315834d, y: 0.10462512387140988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415762551568821d, y: 0.6721661435000957d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740220996960467d, y: 0.5145955908439003d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858193474808163d, y: 0.9613351011667097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196885387329333d, y: 0.8276932888010009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535151298688968d, y: 0.15677952539645046d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07190776711738944d, y: 0.7170248327670823d), new NpgsqlTypes.NpgsqlPoint(x: 0.18788241280800144d, y: 0.8439298331987665d), new NpgsqlTypes.NpgsqlPoint(x: 0.09721309181649829d, y: 0.6153661505398338d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25688110039953227d, y: 0.7266484070494581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775299135993092d, y: 0.26788715576020405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304497542761041d, y: 0.7517808501919852d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05293958946972688d, y: 0.8335857495069566d), new NpgsqlTypes.NpgsqlPoint(x: 0.37663703673679094d, y: 0.38106523049915664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2854794019979414d, y: 0.9395927924425086d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4258340705770406d, y: 0.9343567805049025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718918369119709d, y: 0.45808278041025485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5199416446612575d, y: 0.14515570695733349d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10144694792541276d, y: 0.705262229980848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974628679701353d, y: 0.9503791707024839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539390120869675d, y: 0.6817646082777292d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.390940083104115d, y: 0.9898943794668095d), new NpgsqlTypes.NpgsqlPoint(x: 0.08058956228132785d, y: 0.14218965823885443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028074685037425d, y: 0.8331264273828932d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8259598053360316d, y: 0.8123034562735889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167816998779117d, y: 0.0805203611933023d), new NpgsqlTypes.NpgsqlPoint(x: 0.13277258143563164d, y: 0.4087882480717242d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37957014373912057d, y: 0.3045864506719518d), new NpgsqlTypes.NpgsqlPoint(x: 0.05396118614169487d, y: 0.6610993281223562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279094960823391d, y: 0.9124047257403922d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05204097882709513d, y: 0.10091990055494393d), new NpgsqlTypes.NpgsqlPoint(x: 0.944054200735481d, y: 0.08727166073086323d), new NpgsqlTypes.NpgsqlPoint(x: 0.11583656459077918d, y: 0.9938051884669301d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16340495682860012d, y: 0.4763951137477659d), new NpgsqlTypes.NpgsqlPoint(x: 0.08057655422634258d, y: 0.8780219978933747d), new NpgsqlTypes.NpgsqlPoint(x: 0.1481834161264005d, y: 0.5319038890835689d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6289041171321861d, y: 0.2874504821497854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642185617033471d, y: 0.28155336895097205d), new NpgsqlTypes.NpgsqlPoint(x: 0.179321793351217d, y: 0.7619948924913024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.712839272758314d, y: 0.8514922923393122d), new NpgsqlTypes.NpgsqlPoint(x: 0.47733943759545894d, y: 0.6566506414521078d), new NpgsqlTypes.NpgsqlPoint(x: 0.9891364241539496d, y: 0.8407987892463142d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9521009115517861d, y: 0.6915973088651436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031250075016095d, y: 0.06530852309776736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457659574813057d, y: 0.29040737756420665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4170431218219601d, y: 0.19180217170201075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712732345052554d, y: 0.5472153772489688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848131604969748d, y: 0.47828397732325945d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5175853573534585d, y: 0.6835478194911938d), new NpgsqlTypes.NpgsqlPoint(x: 0.0698653984713572d, y: 0.3100831286628575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2436792550688167d, y: 0.596274332073177d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369199735572316d, y: 0.055146096642249676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429053634783339d, y: 0.44381954802221724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1047125267567196d, y: 0.8960127825805104d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3379757706043619d, y: 0.5273279042167832d), new NpgsqlTypes.NpgsqlPoint(x: 0.16440680854910505d, y: 0.020545821426417366d), new NpgsqlTypes.NpgsqlPoint(x: 0.10125542192620163d, y: 0.2699568259836699d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7050995718122277d, y: 0.596468853895303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3671876719140663d, y: 0.6138967541507718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4639778557008041d, y: 0.7639279133728833d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34956758992163084d, y: 0.5666982478345949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460689730580194d, y: 0.4870048306114111d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095773876402148d, y: 0.26614862130005024d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9972706371243363d, y: 0.8880938813099333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3931210733328103d, y: 0.9343319230073402d), new NpgsqlTypes.NpgsqlPoint(x: 0.499012638297457d, y: 0.6666287113987569d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.646695667773017d, y: 0.37335032211378494d), new NpgsqlTypes.NpgsqlPoint(x: 0.0824534807916415d, y: 0.4209910701544449d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215925922070591d, y: 0.21906353784219457d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8040665262438149d, y: 0.4507059466913289d), new NpgsqlTypes.NpgsqlPoint(x: 0.25275239132204164d, y: 0.8837777831348158d), new NpgsqlTypes.NpgsqlPoint(x: 0.331007882010825d, y: 0.6144521130485932d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3839117022310057d, y: 0.8679160420363455d), new NpgsqlTypes.NpgsqlPoint(x: 0.16739441714901493d, y: 0.8991725215518416d), new NpgsqlTypes.NpgsqlPoint(x: 0.385120812984719d, y: 0.619197047534891d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1496263418659175d, y: 0.0460614387258339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168080715293354d, y: 0.47248158796441053d), new NpgsqlTypes.NpgsqlPoint(x: 0.37003474103780964d, y: 0.482450819772128d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09559647990048026d, y: 0.12756946799031477d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648377661821885d, y: 0.7605326264445904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675141721854176d, y: 0.36416888844677076d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24761496005485084d, y: 0.5480215723723199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671193290648792d, y: 0.34633086827909854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843753628889893d, y: 0.8720683666540151d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010309617818873185d, y: 0.7619587047186073d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634666840002476d, y: 0.6268935310157032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398429770584167d, y: 0.2365078358338798d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0416545660766513d, y: 0.2162947422145297d), new NpgsqlTypes.NpgsqlPoint(x: 0.04000825122385254d, y: 0.30620499349108976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003810411572444d, y: 0.34619729820345135d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9279740092799297d, y: 0.8696872464995966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1494276612695693d, y: 0.6482088740077993d), new NpgsqlTypes.NpgsqlPoint(x: 0.96315935056476d, y: 0.6261407771495626d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6830085037005551d, y: 0.8656859979075067d), new NpgsqlTypes.NpgsqlPoint(x: 0.27942231758372515d, y: 0.3228648801366667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068371885930206d, y: 0.3624713926731278d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3286944961548718d, y: 0.9811756185628723d), new NpgsqlTypes.NpgsqlPoint(x: 0.309523913225596d, y: 0.8582040972001289d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896215059261822d, y: 0.11357459760032951d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27830631328943667d, y: 0.6353710289312323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299045701738858d, y: 0.6958695664158957d), new NpgsqlTypes.NpgsqlPoint(x: 0.37135467248819387d, y: 0.4259168194183922d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2984343509980565d, y: 0.49770977254721427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984693503734907d, y: 0.533386487320559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635694735341634d, y: 0.371656534273469d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9355580883750149d, y: 0.5261912221543559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8031190760467267d, y: 0.15573914526914234d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907165062595295d, y: 0.8405026103721867d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6330542046464797d, y: 0.2568948398545775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510284379986262d, y: 0.8530296115904761d), new NpgsqlTypes.NpgsqlPoint(x: 0.1848007056874964d, y: 0.38881510493999205d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7822130538988332d, y: 0.8455550671227653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3856711676529505d, y: 0.05285003378925801d), new NpgsqlTypes.NpgsqlPoint(x: 0.3867997090820915d, y: 0.16196784186396374d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6735302519065699d, y: 0.2732251264505863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7082899244440064d, y: 0.8996430714321556d), new NpgsqlTypes.NpgsqlPoint(x: 0.11774676517525995d, y: 0.5578401358467903d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7079191392944398d, y: 0.3874687229697259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8957586830313587d, y: 0.3430150865499362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3268674647921169d, y: 0.274961229210267d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46942740440186415d, y: 0.3292966408971939d), new NpgsqlTypes.NpgsqlPoint(x: 0.466762075993836d, y: 0.4245574642376829d), new NpgsqlTypes.NpgsqlPoint(x: 0.887183892033852d, y: 0.03889449362498598d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3017935685563975d, y: 0.6457501022013078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718021290110088d, y: 0.9501681474522758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133139927836149d, y: 0.5176013734953439d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09752267742851406d, y: 0.2827569248271943d), new NpgsqlTypes.NpgsqlPoint(x: 0.889696330856498d, y: 0.8426922669884293d), new NpgsqlTypes.NpgsqlPoint(x: 0.27638027725860226d, y: 0.38927710554039907d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9294622430440802d, y: 0.9452919491258224d), new NpgsqlTypes.NpgsqlPoint(x: 0.08981164483196313d, y: 0.1892775179384063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900814297714932d, y: 0.11930179786670592d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15953526366005588d, y: 0.944087396511371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287463797488761d, y: 0.006837737258069909d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335674115328729d, y: 0.0645918726872835d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21836606732935782d, y: 0.4768187789486332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510254165338439d, y: 0.3373363131908347d), new NpgsqlTypes.NpgsqlPoint(x: 0.14064959346827044d, y: 0.825044350758304d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13501340836687103d, y: 0.7221303311538705d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920985669398092d, y: 0.6688950414220056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022913385398633d, y: 0.9192147889686224d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7453062377440893d, y: 0.9614395946073775d), new NpgsqlTypes.NpgsqlPoint(x: 0.12079225083474954d, y: 0.3364233383485489d), new NpgsqlTypes.NpgsqlPoint(x: 0.057138599451448835d, y: 0.05972505964999886d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14539993980614951d, y: 0.6615197705112471d), new NpgsqlTypes.NpgsqlPoint(x: 0.4711272568385937d, y: 0.647659465055746d), new NpgsqlTypes.NpgsqlPoint(x: 0.35601796821308207d, y: 0.8661556383304004d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006189453526919797d, y: 0.7643177573533659d), new NpgsqlTypes.NpgsqlPoint(x: 0.2442013054460247d, y: 0.3173293147082513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2700639107452577d, y: 0.6137158075537962d)))));

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

