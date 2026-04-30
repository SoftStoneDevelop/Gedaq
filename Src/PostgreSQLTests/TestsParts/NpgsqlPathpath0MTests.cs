

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42007190528741256d, y: 0.7111390393928599d), new NpgsqlTypes.NpgsqlPoint(x: 0.3991514010608398d, y: 0.1784656104615041d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276462255100856d, y: 0.056167026147875054d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4556296979871006d, y: 0.9747604757976334d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809357472683172d, y: 0.41578986282895325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3200187381436941d, y: 0.23427317577186924d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09482919152691949d, y: 0.7735072629437367d), new NpgsqlTypes.NpgsqlPoint(x: 0.34750866403410385d, y: 0.18546737503258726d), new NpgsqlTypes.NpgsqlPoint(x: 0.2863219156305812d, y: 0.8743112541249347d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24046853355013476d, y: 0.5315049890357592d), new NpgsqlTypes.NpgsqlPoint(x: 0.05188837185284101d, y: 0.5693518826081635d), new NpgsqlTypes.NpgsqlPoint(x: 0.33893694146893183d, y: 0.5354344188757381d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7659819694767227d, y: 0.3871045355298305d), new NpgsqlTypes.NpgsqlPoint(x: 0.971373851378681d, y: 0.8518038261699977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270676305824695d, y: 0.8399961796657383d)),
},
            new NpgsqlPathpath0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8019075041284955d, y: 0.7225600703123091d), new NpgsqlTypes.NpgsqlPoint(x: 0.983598069482191d, y: 0.4524566566518702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464163819434878d, y: 0.20187637342923603d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30025338585646755d, y: 0.31633281878114816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888338501376811d, y: 0.8120192410850763d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601087864473334d, y: 0.018100790532690536d)),
},
            new NpgsqlPathpath0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8738448096081898d, y: 0.534739863420353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425951078875779d, y: 0.854723592203326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855578832938374d, y: 0.7467599032711759d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8619358948921124d, y: 0.7511012423336572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133169124355144d, y: 0.652321094039965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027053357886598d, y: 0.8080311641894645d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9136346572589675d, y: 0.9442060359227009d), new NpgsqlTypes.NpgsqlPoint(x: 0.3387647072602623d, y: 0.4514940966370701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680572859231663d, y: 0.41633742563848697d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7280766908058817d, y: 0.28744555318936404d), new NpgsqlTypes.NpgsqlPoint(x: 0.773330383240113d, y: 0.5254313279344512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620528885590197d, y: 0.8223400547154913d)),
},
            new NpgsqlPathpath0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.959254175915464d, y: 0.44504642889672974d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064242579671126d, y: 0.3562368692555664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337849764775397d, y: 0.609529673118169d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.347832764731717d, y: 0.3118483252282124d), new NpgsqlTypes.NpgsqlPoint(x: 0.9830908443035306d, y: 0.11425161878040957d), new NpgsqlTypes.NpgsqlPoint(x: 0.2053658173369588d, y: 0.5669513668575314d)),
},
            new NpgsqlPathpath0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5590978393752443d, y: 0.7772613270587903d), new NpgsqlTypes.NpgsqlPoint(x: 0.976313124448512d, y: 0.26714216268557744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442411827809612d, y: 0.07851137157490962d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2437101652279109d, y: 0.13507337388797436d), new NpgsqlTypes.NpgsqlPoint(x: 0.6265369721249646d, y: 0.7108225583119139d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471234461734914d, y: 0.5736537352438515d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173819488312407d, y: 0.32234756225572214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4063297992548738d, y: 0.27361902293825413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9285067713938976d, y: 0.36663212203403317d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597702946862d, y: 0.1622668341994402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5947832092534419d, y: 0.44703781730521663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525255186639999d, y: 0.019722593727259374d)),
},
            new NpgsqlPathpath0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5626597686839759d, y: 0.2848059983081911d), new NpgsqlTypes.NpgsqlPoint(x: 0.013310990726593364d, y: 0.24348442195981768d), new NpgsqlTypes.NpgsqlPoint(x: 0.3300834667364212d, y: 0.850760494656696d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03009767895265547d, y: 0.7142574431397406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456397447868018d, y: 0.15371668397316762d), new NpgsqlTypes.NpgsqlPoint(x: 0.3917693932078604d, y: 0.40293622076704494d)),
},
            new NpgsqlPathpath0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4440984819991899d, y: 0.2514463226654755d), new NpgsqlTypes.NpgsqlPoint(x: 0.24314638405357147d, y: 0.5207792114882286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600280273533859d, y: 0.8277436371709774d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45108101402974055d, y: 0.4880134761056266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973011053642461d, y: 0.7771343300625432d), new NpgsqlTypes.NpgsqlPoint(x: 0.999567458142863d, y: 0.311962714505431d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8701023028810994d, y: 0.7975572990677305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938236125543842d, y: 0.6583585864666343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103649864927243d, y: 0.2813758797577882d)),
},
            new NpgsqlPathpath0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5517197785094395d, y: 0.0739328078504703d), new NpgsqlTypes.NpgsqlPoint(x: 0.07892045030979067d, y: 0.9184806642497686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4662838389547479d, y: 0.4274539586367445d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229768204926611d, y: 0.40353178376249577d), new NpgsqlTypes.NpgsqlPoint(x: 0.19585357636065048d, y: 0.5235564598745372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7723018523625902d, y: 0.9647870572491242d)),
},
            new NpgsqlPathpath0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5054021423761887d, y: 0.42822461716653537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324921329474262d, y: 0.3737933620739503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5324820064455075d, y: 0.7139999665628065d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5750233560685521d, y: 0.00460827796705332d), new NpgsqlTypes.NpgsqlPoint(x: 0.49491245525746586d, y: 0.9593271990250561d), new NpgsqlTypes.NpgsqlPoint(x: 0.4572423076286335d, y: 0.9396672444502584d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2328325258935725d, y: 0.8796251654836791d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875429280302675d, y: 0.9070275691047625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217786396033118d, y: 0.19776105949123024d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903850398746094d, y: 0.7855667857643828d), new NpgsqlTypes.NpgsqlPoint(x: 0.38559561893195504d, y: 0.24615408195143917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426114203931449d, y: 0.7826252223408098d)),
},
            new NpgsqlPathpath0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07112100218450856d, y: 0.2671225190196437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610353933174655d, y: 0.17328869972973504d), new NpgsqlTypes.NpgsqlPoint(x: 0.358199612754882d, y: 0.1104999024531762d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.589624343331949d, y: 0.6015908454286324d), new NpgsqlTypes.NpgsqlPoint(x: 0.05514382869632917d, y: 0.5482654934950935d), new NpgsqlTypes.NpgsqlPoint(x: 0.15775998185918527d, y: 0.7898469986083144d)),
},
            new NpgsqlPathpath0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069427381079052d, y: 0.21406369961560556d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473767225126461d, y: 0.21050601780666933d), new NpgsqlTypes.NpgsqlPoint(x: 0.22010663308500167d, y: 0.854445111164415d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23386931011471246d, y: 0.5292425764829963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954758014368364d, y: 0.8283389268215675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560271844156168d, y: 0.9899705815147896d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2126912354609669d, y: 0.6464236277622251d), new NpgsqlTypes.NpgsqlPoint(x: 0.1979928071470376d, y: 0.85558088171999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690888032085699d, y: 0.5183684228772952d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54582581020138d, y: 0.14727773647011322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712973066079948d, y: 0.35312875040858627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540158746970958d, y: 0.6018550243373265d)),
},
            new NpgsqlPathpath0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833624193550645d, y: 0.15318535517744059d), new NpgsqlTypes.NpgsqlPoint(x: 0.43827252584412113d, y: 0.6217901066593962d), new NpgsqlTypes.NpgsqlPoint(x: 0.19350299812239957d, y: 0.366209872474632d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36262423736544414d, y: 0.5439405031667749d), new NpgsqlTypes.NpgsqlPoint(x: 0.14411116312581562d, y: 0.4440886072165323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274403425224742d, y: 0.8209554821467571d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30628368752062785d, y: 0.42495333287395176d), new NpgsqlTypes.NpgsqlPoint(x: 0.23876473423389244d, y: 0.2943917560796807d), new NpgsqlTypes.NpgsqlPoint(x: 0.23954062376644003d, y: 0.14462401577627093d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165484567945809d, y: 0.3382722969692691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337967240898355d, y: 0.3326470587457486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928513096040378d, y: 0.7862085811926116d)),
},
            new NpgsqlPathpath0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7288286898696441d, y: 0.9483306429937463d), new NpgsqlTypes.NpgsqlPoint(x: 0.20684032915489237d, y: 0.0894176438967037d), new NpgsqlTypes.NpgsqlPoint(x: 0.40575852146470515d, y: 0.1326409152672995d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3514771910705612d, y: 0.9125148243523543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731148934592749d, y: 0.289135214097734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4249741293852147d, y: 0.6451744257131682d)),
},
            new NpgsqlPathpath0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10971325105074436d, y: 0.2817085936715371d), new NpgsqlTypes.NpgsqlPoint(x: 0.710437570729855d, y: 0.06207731851556131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742443867470257d, y: 0.014505175845037854d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2157742890079879d, y: 0.19316567558683728d), new NpgsqlTypes.NpgsqlPoint(x: 0.20893396936776132d, y: 0.4397717338322933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936611865347339d, y: 0.10610118299471061d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4614903176744344d, y: 0.15634870077825158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4732697408444211d, y: 0.5158570954456608d), new NpgsqlTypes.NpgsqlPoint(x: 0.49609118586240375d, y: 0.4932628005064318d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9763097379478463d, y: 0.9921613027223823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789973915902291d, y: 0.818296191815611d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405755939057536d, y: 0.25158870137654366d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14296338531198882d, y: 0.04406093960398627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081715777224777d, y: 0.6811960649371215d), new NpgsqlTypes.NpgsqlPoint(x: 0.1305097314274276d, y: 0.7235859284425762d)),
},
            new NpgsqlPathpath0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3614272179946372d, y: 0.9468080994804018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219574676319492d, y: 0.37968393488721697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313135344262934d, y: 0.3302437406083871d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7986496084514538d, y: 0.8238438397078913d), new NpgsqlTypes.NpgsqlPoint(x: 0.14863240444832448d, y: 0.2648433186328444d), new NpgsqlTypes.NpgsqlPoint(x: 0.303808162087697d, y: 0.41242349488031416d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.360997487642553d, y: 0.9860002500177198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411951326123915d, y: 0.30791999966371253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5031495469282309d, y: 0.20775387440836657d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3606840620201105d, y: 0.5694322376696069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693308336663508d, y: 0.10953333567710799d), new NpgsqlTypes.NpgsqlPoint(x: 0.1403652201904283d, y: 0.08023090634090191d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1294948715295834d, y: 0.6079554018452318d), new NpgsqlTypes.NpgsqlPoint(x: 0.05352115123894707d, y: 0.4690327477761781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4480871892678554d, y: 0.21010068028185813d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9237952042601267d, y: 0.39805700140686606d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239644030021137d, y: 0.24409200992978097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520215026045951d, y: 0.8443475546087068d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09054084725247791d, y: 0.8045127770098992d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874302366720364d, y: 0.9135796805116129d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072098546155939d, y: 0.12086507724606133d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33703311269182434d, y: 0.6934809674314807d), new NpgsqlTypes.NpgsqlPoint(x: 0.960515412138512d, y: 0.7401345833813263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4189265866555746d, y: 0.9243408702768832d)),
},
            new NpgsqlPathpath0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5868396486630107d, y: 0.6693423249953776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4754570432087476d, y: 0.19311926214719244d), new NpgsqlTypes.NpgsqlPoint(x: 0.39934219420894734d, y: 0.2391371835979994d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7555767443527839d, y: 0.8589841468133407d), new NpgsqlTypes.NpgsqlPoint(x: 0.49443617103624804d, y: 0.26266346075133384d), new NpgsqlTypes.NpgsqlPoint(x: 0.12022878107357948d, y: 0.9559051552049709d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046682052827031084d, y: 0.9469813245055037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8206682323370643d, y: 0.2047660522614715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785742451978052d, y: 0.6999899700159076d)),
},
            new NpgsqlPathpath0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25294823615907536d, y: 0.3437692901683218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250977351362382d, y: 0.5024181324262751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103790611886682d, y: 0.9969964911291357d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6192978664496229d, y: 0.6804885920417456d), new NpgsqlTypes.NpgsqlPoint(x: 0.35296435329288345d, y: 0.6244101025639922d), new NpgsqlTypes.NpgsqlPoint(x: 0.007091082033146012d, y: 0.9774203881943029d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8750001100665968d, y: 0.9938592985843587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757276175911403d, y: 0.7318227781151665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079735379037568d, y: 0.21924384164717914d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062586443448416d, y: 0.9103440411984074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836894900462825d, y: 0.9327703441723486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217377064569548d, y: 0.7318050108306717d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31863899048196076d, y: 0.6470521982193667d), new NpgsqlTypes.NpgsqlPoint(x: 0.0747258360372548d, y: 0.09397626538269954d), new NpgsqlTypes.NpgsqlPoint(x: 0.1562080907778144d, y: 0.3262797692500836d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32187327043589575d, y: 0.228410418180242d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009145540688272336d, y: 0.883254471719743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375903852522603d, y: 0.3174093447916979d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03911337525966485d, y: 0.28296135071323414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620911858519049d, y: 0.19400887069279704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242707122197058d, y: 0.003178167559247713d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8642639992871445d, y: 0.4798468572868084d), new NpgsqlTypes.NpgsqlPoint(x: 0.03846302684524827d, y: 0.3165945155202793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7490729288428647d, y: 0.8916481509851328d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38355530332731214d, y: 0.44152638550694456d), new NpgsqlTypes.NpgsqlPoint(x: 0.16271176914947305d, y: 0.7504541165437573d), new NpgsqlTypes.NpgsqlPoint(x: 0.3094864525526071d, y: 0.5800925753680897d)),
},
            new NpgsqlPathpath0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2922127358819294d, y: 0.06624607751371825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3744074351159896d, y: 0.10207676661209986d), new NpgsqlTypes.NpgsqlPoint(x: 0.19091406890148754d, y: 0.2768902037868024d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9031825391359953d, y: 0.5530866141679989d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516313087438328d, y: 0.4549450750688867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338495204286019d, y: 0.9293430413680613d)),
},
            new NpgsqlPathpath0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7424912051156785d, y: 0.04089180903060363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127479850809532d, y: 0.36476874669973625d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180615617491874d, y: 0.5025670575086302d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7765372778024846d, y: 0.7840543449001016d), new NpgsqlTypes.NpgsqlPoint(x: 0.2251291937322073d, y: 0.8572199937023669d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772029355083453d, y: 0.35365284690388665d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9067663024044426d, y: 0.053686681452055685d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866072211400776d, y: 0.0010334437887462578d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502315135811354d, y: 0.3245150942851205d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36246752567512597d, y: 0.11558209151973886d), new NpgsqlTypes.NpgsqlPoint(x: 0.41281767498654653d, y: 0.4313278729307255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4346299438391922d, y: 0.6982159161158599d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6125229781437485d, y: 0.5019688747726884d), new NpgsqlTypes.NpgsqlPoint(x: 0.36006955453514067d, y: 0.08709130246992902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846088889530598d, y: 0.37574554358738665d)),
},
            new NpgsqlPathpath0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8814080017144472d, y: 0.6592808758898664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078292623130311d, y: 0.7101351531789216d), new NpgsqlTypes.NpgsqlPoint(x: 0.28141069341515534d, y: 0.9258881540771073d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9521738308018969d, y: 0.1035951986033331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907021013263358d, y: 0.7967175214265595d), new NpgsqlTypes.NpgsqlPoint(x: 0.596219840813451d, y: 0.8156665389821796d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2416767285294935d, y: 0.6694812158820806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8090937537452266d, y: 0.5302654003091029d), new NpgsqlTypes.NpgsqlPoint(x: 0.43751640314200124d, y: 0.3660852149776196d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9953632873126613d, y: 0.5036812957233803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751698640069436d, y: 0.08313687246028723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032319691462384d, y: 0.5260127117636448d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7611083174792694d, y: 0.027586287894260764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8803696697398643d, y: 0.8106330497506302d), new NpgsqlTypes.NpgsqlPoint(x: 0.1364944413212903d, y: 0.9949692162627364d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1053735769843912d, y: 0.6040351341619649d), new NpgsqlTypes.NpgsqlPoint(x: 0.16350975550763835d, y: 0.20888270991443902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625117025240804d, y: 0.96809285790694d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5440292344825134d, y: 0.737304636964042d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420984519056698d, y: 0.9095904194959086d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286530689146012d, y: 0.16736611225976916d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20100276921681715d, y: 0.06586059214488726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987644849737835d, y: 0.9367577819529264d), new NpgsqlTypes.NpgsqlPoint(x: 0.06402741553061042d, y: 0.38611298251056203d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009104377315829026d, y: 0.06889183031306845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8096890761424917d, y: 0.8915408754280861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326649341647822d, y: 0.24544530442876455d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512651615456333d, y: 0.5610533826248768d), new NpgsqlTypes.NpgsqlPoint(x: 0.21951626676559166d, y: 0.9186722860008681d), new NpgsqlTypes.NpgsqlPoint(x: 0.1517256927123064d, y: 0.5203043553763875d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.347832764731717d, y: 0.3118483252282124d), new NpgsqlTypes.NpgsqlPoint(x: 0.9830908443035306d, y: 0.11425161878040957d), new NpgsqlTypes.NpgsqlPoint(x: 0.2053658173369588d, y: 0.5669513668575314d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597702946862d, y: 0.1622668341994402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5947832092534419d, y: 0.44703781730521663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525255186639999d, y: 0.019722593727259374d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03009767895265547d, y: 0.7142574431397406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456397447868018d, y: 0.15371668397316762d), new NpgsqlTypes.NpgsqlPoint(x: 0.3917693932078604d, y: 0.40293622076704494d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8701023028810994d, y: 0.7975572990677305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938236125543842d, y: 0.6583585864666343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103649864927243d, y: 0.2813758797577882d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229768204926611d, y: 0.40353178376249577d), new NpgsqlTypes.NpgsqlPoint(x: 0.19585357636065048d, y: 0.5235564598745372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7723018523625902d, y: 0.9647870572491242d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903850398746094d, y: 0.7855667857643828d), new NpgsqlTypes.NpgsqlPoint(x: 0.38559561893195504d, y: 0.24615408195143917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426114203931449d, y: 0.7826252223408098d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.589624343331949d, y: 0.6015908454286324d), new NpgsqlTypes.NpgsqlPoint(x: 0.05514382869632917d, y: 0.5482654934950935d), new NpgsqlTypes.NpgsqlPoint(x: 0.15775998185918527d, y: 0.7898469986083144d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 67, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 135, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 84, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 127, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 8, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[30], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[31], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[32], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[33], false);NpgsqlPathpath0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42007190528741256d, y: 0.7111390393928599d), new NpgsqlTypes.NpgsqlPoint(x: 0.3991514010608398d, y: 0.1784656104615041d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276462255100856d, y: 0.056167026147875054d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4556296979871006d, y: 0.9747604757976334d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809357472683172d, y: 0.41578986282895325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3200187381436941d, y: 0.23427317577186924d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09482919152691949d, y: 0.7735072629437367d), new NpgsqlTypes.NpgsqlPoint(x: 0.34750866403410385d, y: 0.18546737503258726d), new NpgsqlTypes.NpgsqlPoint(x: 0.2863219156305812d, y: 0.8743112541249347d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24046853355013476d, y: 0.5315049890357592d), new NpgsqlTypes.NpgsqlPoint(x: 0.05188837185284101d, y: 0.5693518826081635d), new NpgsqlTypes.NpgsqlPoint(x: 0.33893694146893183d, y: 0.5354344188757381d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7659819694767227d, y: 0.3871045355298305d), new NpgsqlTypes.NpgsqlPoint(x: 0.971373851378681d, y: 0.8518038261699977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270676305824695d, y: 0.8399961796657383d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8019075041284955d, y: 0.7225600703123091d), new NpgsqlTypes.NpgsqlPoint(x: 0.983598069482191d, y: 0.4524566566518702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464163819434878d, y: 0.20187637342923603d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30025338585646755d, y: 0.31633281878114816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888338501376811d, y: 0.8120192410850763d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601087864473334d, y: 0.018100790532690536d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8738448096081898d, y: 0.534739863420353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425951078875779d, y: 0.854723592203326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855578832938374d, y: 0.7467599032711759d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8619358948921124d, y: 0.7511012423336572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133169124355144d, y: 0.652321094039965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027053357886598d, y: 0.8080311641894645d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9136346572589675d, y: 0.9442060359227009d), new NpgsqlTypes.NpgsqlPoint(x: 0.3387647072602623d, y: 0.4514940966370701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680572859231663d, y: 0.41633742563848697d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7280766908058817d, y: 0.28744555318936404d), new NpgsqlTypes.NpgsqlPoint(x: 0.773330383240113d, y: 0.5254313279344512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620528885590197d, y: 0.8223400547154913d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.959254175915464d, y: 0.44504642889672974d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064242579671126d, y: 0.3562368692555664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337849764775397d, y: 0.609529673118169d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.347832764731717d, y: 0.3118483252282124d), new NpgsqlTypes.NpgsqlPoint(x: 0.9830908443035306d, y: 0.11425161878040957d), new NpgsqlTypes.NpgsqlPoint(x: 0.2053658173369588d, y: 0.5669513668575314d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5590978393752443d, y: 0.7772613270587903d), new NpgsqlTypes.NpgsqlPoint(x: 0.976313124448512d, y: 0.26714216268557744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442411827809612d, y: 0.07851137157490962d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2437101652279109d, y: 0.13507337388797436d), new NpgsqlTypes.NpgsqlPoint(x: 0.6265369721249646d, y: 0.7108225583119139d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471234461734914d, y: 0.5736537352438515d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173819488312407d, y: 0.32234756225572214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4063297992548738d, y: 0.27361902293825413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9285067713938976d, y: 0.36663212203403317d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597702946862d, y: 0.1622668341994402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5947832092534419d, y: 0.44703781730521663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525255186639999d, y: 0.019722593727259374d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5626597686839759d, y: 0.2848059983081911d), new NpgsqlTypes.NpgsqlPoint(x: 0.013310990726593364d, y: 0.24348442195981768d), new NpgsqlTypes.NpgsqlPoint(x: 0.3300834667364212d, y: 0.850760494656696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03009767895265547d, y: 0.7142574431397406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456397447868018d, y: 0.15371668397316762d), new NpgsqlTypes.NpgsqlPoint(x: 0.3917693932078604d, y: 0.40293622076704494d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4440984819991899d, y: 0.2514463226654755d), new NpgsqlTypes.NpgsqlPoint(x: 0.24314638405357147d, y: 0.5207792114882286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600280273533859d, y: 0.8277436371709774d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45108101402974055d, y: 0.4880134761056266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973011053642461d, y: 0.7771343300625432d), new NpgsqlTypes.NpgsqlPoint(x: 0.999567458142863d, y: 0.311962714505431d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8701023028810994d, y: 0.7975572990677305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938236125543842d, y: 0.6583585864666343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103649864927243d, y: 0.2813758797577882d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5517197785094395d, y: 0.0739328078504703d), new NpgsqlTypes.NpgsqlPoint(x: 0.07892045030979067d, y: 0.9184806642497686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4662838389547479d, y: 0.4274539586367445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229768204926611d, y: 0.40353178376249577d), new NpgsqlTypes.NpgsqlPoint(x: 0.19585357636065048d, y: 0.5235564598745372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7723018523625902d, y: 0.9647870572491242d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5054021423761887d, y: 0.42822461716653537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324921329474262d, y: 0.3737933620739503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5324820064455075d, y: 0.7139999665628065d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5750233560685521d, y: 0.00460827796705332d), new NpgsqlTypes.NpgsqlPoint(x: 0.49491245525746586d, y: 0.9593271990250561d), new NpgsqlTypes.NpgsqlPoint(x: 0.4572423076286335d, y: 0.9396672444502584d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2328325258935725d, y: 0.8796251654836791d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875429280302675d, y: 0.9070275691047625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217786396033118d, y: 0.19776105949123024d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903850398746094d, y: 0.7855667857643828d), new NpgsqlTypes.NpgsqlPoint(x: 0.38559561893195504d, y: 0.24615408195143917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426114203931449d, y: 0.7826252223408098d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07112100218450856d, y: 0.2671225190196437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610353933174655d, y: 0.17328869972973504d), new NpgsqlTypes.NpgsqlPoint(x: 0.358199612754882d, y: 0.1104999024531762d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.589624343331949d, y: 0.6015908454286324d), new NpgsqlTypes.NpgsqlPoint(x: 0.05514382869632917d, y: 0.5482654934950935d), new NpgsqlTypes.NpgsqlPoint(x: 0.15775998185918527d, y: 0.7898469986083144d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069427381079052d, y: 0.21406369961560556d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473767225126461d, y: 0.21050601780666933d), new NpgsqlTypes.NpgsqlPoint(x: 0.22010663308500167d, y: 0.854445111164415d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23386931011471246d, y: 0.5292425764829963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954758014368364d, y: 0.8283389268215675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560271844156168d, y: 0.9899705815147896d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2126912354609669d, y: 0.6464236277622251d), new NpgsqlTypes.NpgsqlPoint(x: 0.1979928071470376d, y: 0.85558088171999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690888032085699d, y: 0.5183684228772952d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54582581020138d, y: 0.14727773647011322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712973066079948d, y: 0.35312875040858627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540158746970958d, y: 0.6018550243373265d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833624193550645d, y: 0.15318535517744059d), new NpgsqlTypes.NpgsqlPoint(x: 0.43827252584412113d, y: 0.6217901066593962d), new NpgsqlTypes.NpgsqlPoint(x: 0.19350299812239957d, y: 0.366209872474632d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36262423736544414d, y: 0.5439405031667749d), new NpgsqlTypes.NpgsqlPoint(x: 0.14411116312581562d, y: 0.4440886072165323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274403425224742d, y: 0.8209554821467571d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30628368752062785d, y: 0.42495333287395176d), new NpgsqlTypes.NpgsqlPoint(x: 0.23876473423389244d, y: 0.2943917560796807d), new NpgsqlTypes.NpgsqlPoint(x: 0.23954062376644003d, y: 0.14462401577627093d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165484567945809d, y: 0.3382722969692691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337967240898355d, y: 0.3326470587457486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928513096040378d, y: 0.7862085811926116d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7288286898696441d, y: 0.9483306429937463d), new NpgsqlTypes.NpgsqlPoint(x: 0.20684032915489237d, y: 0.0894176438967037d), new NpgsqlTypes.NpgsqlPoint(x: 0.40575852146470515d, y: 0.1326409152672995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3514771910705612d, y: 0.9125148243523543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731148934592749d, y: 0.289135214097734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4249741293852147d, y: 0.6451744257131682d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10971325105074436d, y: 0.2817085936715371d), new NpgsqlTypes.NpgsqlPoint(x: 0.710437570729855d, y: 0.06207731851556131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742443867470257d, y: 0.014505175845037854d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2157742890079879d, y: 0.19316567558683728d), new NpgsqlTypes.NpgsqlPoint(x: 0.20893396936776132d, y: 0.4397717338322933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936611865347339d, y: 0.10610118299471061d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4614903176744344d, y: 0.15634870077825158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4732697408444211d, y: 0.5158570954456608d), new NpgsqlTypes.NpgsqlPoint(x: 0.49609118586240375d, y: 0.4932628005064318d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9763097379478463d, y: 0.9921613027223823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789973915902291d, y: 0.818296191815611d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405755939057536d, y: 0.25158870137654366d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14296338531198882d, y: 0.04406093960398627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081715777224777d, y: 0.6811960649371215d), new NpgsqlTypes.NpgsqlPoint(x: 0.1305097314274276d, y: 0.7235859284425762d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3614272179946372d, y: 0.9468080994804018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219574676319492d, y: 0.37968393488721697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313135344262934d, y: 0.3302437406083871d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7986496084514538d, y: 0.8238438397078913d), new NpgsqlTypes.NpgsqlPoint(x: 0.14863240444832448d, y: 0.2648433186328444d), new NpgsqlTypes.NpgsqlPoint(x: 0.303808162087697d, y: 0.41242349488031416d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.360997487642553d, y: 0.9860002500177198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411951326123915d, y: 0.30791999966371253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5031495469282309d, y: 0.20775387440836657d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3606840620201105d, y: 0.5694322376696069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693308336663508d, y: 0.10953333567710799d), new NpgsqlTypes.NpgsqlPoint(x: 0.1403652201904283d, y: 0.08023090634090191d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1294948715295834d, y: 0.6079554018452318d), new NpgsqlTypes.NpgsqlPoint(x: 0.05352115123894707d, y: 0.4690327477761781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4480871892678554d, y: 0.21010068028185813d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9237952042601267d, y: 0.39805700140686606d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239644030021137d, y: 0.24409200992978097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520215026045951d, y: 0.8443475546087068d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09054084725247791d, y: 0.8045127770098992d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874302366720364d, y: 0.9135796805116129d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072098546155939d, y: 0.12086507724606133d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33703311269182434d, y: 0.6934809674314807d), new NpgsqlTypes.NpgsqlPoint(x: 0.960515412138512d, y: 0.7401345833813263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4189265866555746d, y: 0.9243408702768832d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5868396486630107d, y: 0.6693423249953776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4754570432087476d, y: 0.19311926214719244d), new NpgsqlTypes.NpgsqlPoint(x: 0.39934219420894734d, y: 0.2391371835979994d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7555767443527839d, y: 0.8589841468133407d), new NpgsqlTypes.NpgsqlPoint(x: 0.49443617103624804d, y: 0.26266346075133384d), new NpgsqlTypes.NpgsqlPoint(x: 0.12022878107357948d, y: 0.9559051552049709d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046682052827031084d, y: 0.9469813245055037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8206682323370643d, y: 0.2047660522614715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785742451978052d, y: 0.6999899700159076d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25294823615907536d, y: 0.3437692901683218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250977351362382d, y: 0.5024181324262751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103790611886682d, y: 0.9969964911291357d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6192978664496229d, y: 0.6804885920417456d), new NpgsqlTypes.NpgsqlPoint(x: 0.35296435329288345d, y: 0.6244101025639922d), new NpgsqlTypes.NpgsqlPoint(x: 0.007091082033146012d, y: 0.9774203881943029d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8750001100665968d, y: 0.9938592985843587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757276175911403d, y: 0.7318227781151665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079735379037568d, y: 0.21924384164717914d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062586443448416d, y: 0.9103440411984074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836894900462825d, y: 0.9327703441723486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217377064569548d, y: 0.7318050108306717d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31863899048196076d, y: 0.6470521982193667d), new NpgsqlTypes.NpgsqlPoint(x: 0.0747258360372548d, y: 0.09397626538269954d), new NpgsqlTypes.NpgsqlPoint(x: 0.1562080907778144d, y: 0.3262797692500836d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32187327043589575d, y: 0.228410418180242d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009145540688272336d, y: 0.883254471719743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375903852522603d, y: 0.3174093447916979d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03911337525966485d, y: 0.28296135071323414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620911858519049d, y: 0.19400887069279704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242707122197058d, y: 0.003178167559247713d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8642639992871445d, y: 0.4798468572868084d), new NpgsqlTypes.NpgsqlPoint(x: 0.03846302684524827d, y: 0.3165945155202793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7490729288428647d, y: 0.8916481509851328d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38355530332731214d, y: 0.44152638550694456d), new NpgsqlTypes.NpgsqlPoint(x: 0.16271176914947305d, y: 0.7504541165437573d), new NpgsqlTypes.NpgsqlPoint(x: 0.3094864525526071d, y: 0.5800925753680897d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2922127358819294d, y: 0.06624607751371825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3744074351159896d, y: 0.10207676661209986d), new NpgsqlTypes.NpgsqlPoint(x: 0.19091406890148754d, y: 0.2768902037868024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9031825391359953d, y: 0.5530866141679989d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516313087438328d, y: 0.4549450750688867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338495204286019d, y: 0.9293430413680613d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7424912051156785d, y: 0.04089180903060363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127479850809532d, y: 0.36476874669973625d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180615617491874d, y: 0.5025670575086302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7765372778024846d, y: 0.7840543449001016d), new NpgsqlTypes.NpgsqlPoint(x: 0.2251291937322073d, y: 0.8572199937023669d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772029355083453d, y: 0.35365284690388665d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9067663024044426d, y: 0.053686681452055685d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866072211400776d, y: 0.0010334437887462578d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502315135811354d, y: 0.3245150942851205d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36246752567512597d, y: 0.11558209151973886d), new NpgsqlTypes.NpgsqlPoint(x: 0.41281767498654653d, y: 0.4313278729307255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4346299438391922d, y: 0.6982159161158599d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6125229781437485d, y: 0.5019688747726884d), new NpgsqlTypes.NpgsqlPoint(x: 0.36006955453514067d, y: 0.08709130246992902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846088889530598d, y: 0.37574554358738665d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8814080017144472d, y: 0.6592808758898664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078292623130311d, y: 0.7101351531789216d), new NpgsqlTypes.NpgsqlPoint(x: 0.28141069341515534d, y: 0.9258881540771073d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9521738308018969d, y: 0.1035951986033331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907021013263358d, y: 0.7967175214265595d), new NpgsqlTypes.NpgsqlPoint(x: 0.596219840813451d, y: 0.8156665389821796d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2416767285294935d, y: 0.6694812158820806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8090937537452266d, y: 0.5302654003091029d), new NpgsqlTypes.NpgsqlPoint(x: 0.43751640314200124d, y: 0.3660852149776196d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9953632873126613d, y: 0.5036812957233803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751698640069436d, y: 0.08313687246028723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032319691462384d, y: 0.5260127117636448d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7611083174792694d, y: 0.027586287894260764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8803696697398643d, y: 0.8106330497506302d), new NpgsqlTypes.NpgsqlPoint(x: 0.1364944413212903d, y: 0.9949692162627364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1053735769843912d, y: 0.6040351341619649d), new NpgsqlTypes.NpgsqlPoint(x: 0.16350975550763835d, y: 0.20888270991443902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625117025240804d, y: 0.96809285790694d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5440292344825134d, y: 0.737304636964042d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420984519056698d, y: 0.9095904194959086d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286530689146012d, y: 0.16736611225976916d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20100276921681715d, y: 0.06586059214488726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987644849737835d, y: 0.9367577819529264d), new NpgsqlTypes.NpgsqlPoint(x: 0.06402741553061042d, y: 0.38611298251056203d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009104377315829026d, y: 0.06889183031306845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8096890761424917d, y: 0.8915408754280861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326649341647822d, y: 0.24544530442876455d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512651615456333d, y: 0.5610533826248768d), new NpgsqlTypes.NpgsqlPoint(x: 0.21951626676559166d, y: 0.9186722860008681d), new NpgsqlTypes.NpgsqlPoint(x: 0.1517256927123064d, y: 0.5203043553763875d)))));//Value

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
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42007190528741256d, y: 0.7111390393928599d), new NpgsqlTypes.NpgsqlPoint(x: 0.3991514010608398d, y: 0.1784656104615041d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276462255100856d, y: 0.056167026147875054d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4556296979871006d, y: 0.9747604757976334d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809357472683172d, y: 0.41578986282895325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3200187381436941d, y: 0.23427317577186924d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09482919152691949d, y: 0.7735072629437367d), new NpgsqlTypes.NpgsqlPoint(x: 0.34750866403410385d, y: 0.18546737503258726d), new NpgsqlTypes.NpgsqlPoint(x: 0.2863219156305812d, y: 0.8743112541249347d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24046853355013476d, y: 0.5315049890357592d), new NpgsqlTypes.NpgsqlPoint(x: 0.05188837185284101d, y: 0.5693518826081635d), new NpgsqlTypes.NpgsqlPoint(x: 0.33893694146893183d, y: 0.5354344188757381d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7659819694767227d, y: 0.3871045355298305d), new NpgsqlTypes.NpgsqlPoint(x: 0.971373851378681d, y: 0.8518038261699977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270676305824695d, y: 0.8399961796657383d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8019075041284955d, y: 0.7225600703123091d), new NpgsqlTypes.NpgsqlPoint(x: 0.983598069482191d, y: 0.4524566566518702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464163819434878d, y: 0.20187637342923603d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30025338585646755d, y: 0.31633281878114816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888338501376811d, y: 0.8120192410850763d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601087864473334d, y: 0.018100790532690536d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8738448096081898d, y: 0.534739863420353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425951078875779d, y: 0.854723592203326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855578832938374d, y: 0.7467599032711759d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8619358948921124d, y: 0.7511012423336572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133169124355144d, y: 0.652321094039965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027053357886598d, y: 0.8080311641894645d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9136346572589675d, y: 0.9442060359227009d), new NpgsqlTypes.NpgsqlPoint(x: 0.3387647072602623d, y: 0.4514940966370701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680572859231663d, y: 0.41633742563848697d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7280766908058817d, y: 0.28744555318936404d), new NpgsqlTypes.NpgsqlPoint(x: 0.773330383240113d, y: 0.5254313279344512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620528885590197d, y: 0.8223400547154913d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.959254175915464d, y: 0.44504642889672974d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064242579671126d, y: 0.3562368692555664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337849764775397d, y: 0.609529673118169d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.347832764731717d, y: 0.3118483252282124d), new NpgsqlTypes.NpgsqlPoint(x: 0.9830908443035306d, y: 0.11425161878040957d), new NpgsqlTypes.NpgsqlPoint(x: 0.2053658173369588d, y: 0.5669513668575314d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5590978393752443d, y: 0.7772613270587903d), new NpgsqlTypes.NpgsqlPoint(x: 0.976313124448512d, y: 0.26714216268557744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442411827809612d, y: 0.07851137157490962d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2437101652279109d, y: 0.13507337388797436d), new NpgsqlTypes.NpgsqlPoint(x: 0.6265369721249646d, y: 0.7108225583119139d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471234461734914d, y: 0.5736537352438515d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8173819488312407d, y: 0.32234756225572214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4063297992548738d, y: 0.27361902293825413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9285067713938976d, y: 0.36663212203403317d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597702946862d, y: 0.1622668341994402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5947832092534419d, y: 0.44703781730521663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525255186639999d, y: 0.019722593727259374d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5626597686839759d, y: 0.2848059983081911d), new NpgsqlTypes.NpgsqlPoint(x: 0.013310990726593364d, y: 0.24348442195981768d), new NpgsqlTypes.NpgsqlPoint(x: 0.3300834667364212d, y: 0.850760494656696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03009767895265547d, y: 0.7142574431397406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456397447868018d, y: 0.15371668397316762d), new NpgsqlTypes.NpgsqlPoint(x: 0.3917693932078604d, y: 0.40293622076704494d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4440984819991899d, y: 0.2514463226654755d), new NpgsqlTypes.NpgsqlPoint(x: 0.24314638405357147d, y: 0.5207792114882286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600280273533859d, y: 0.8277436371709774d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45108101402974055d, y: 0.4880134761056266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973011053642461d, y: 0.7771343300625432d), new NpgsqlTypes.NpgsqlPoint(x: 0.999567458142863d, y: 0.311962714505431d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8701023028810994d, y: 0.7975572990677305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938236125543842d, y: 0.6583585864666343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103649864927243d, y: 0.2813758797577882d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5517197785094395d, y: 0.0739328078504703d), new NpgsqlTypes.NpgsqlPoint(x: 0.07892045030979067d, y: 0.9184806642497686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4662838389547479d, y: 0.4274539586367445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229768204926611d, y: 0.40353178376249577d), new NpgsqlTypes.NpgsqlPoint(x: 0.19585357636065048d, y: 0.5235564598745372d), new NpgsqlTypes.NpgsqlPoint(x: 0.7723018523625902d, y: 0.9647870572491242d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5054021423761887d, y: 0.42822461716653537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9324921329474262d, y: 0.3737933620739503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5324820064455075d, y: 0.7139999665628065d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5750233560685521d, y: 0.00460827796705332d), new NpgsqlTypes.NpgsqlPoint(x: 0.49491245525746586d, y: 0.9593271990250561d), new NpgsqlTypes.NpgsqlPoint(x: 0.4572423076286335d, y: 0.9396672444502584d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2328325258935725d, y: 0.8796251654836791d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875429280302675d, y: 0.9070275691047625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217786396033118d, y: 0.19776105949123024d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903850398746094d, y: 0.7855667857643828d), new NpgsqlTypes.NpgsqlPoint(x: 0.38559561893195504d, y: 0.24615408195143917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426114203931449d, y: 0.7826252223408098d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07112100218450856d, y: 0.2671225190196437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610353933174655d, y: 0.17328869972973504d), new NpgsqlTypes.NpgsqlPoint(x: 0.358199612754882d, y: 0.1104999024531762d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.589624343331949d, y: 0.6015908454286324d), new NpgsqlTypes.NpgsqlPoint(x: 0.05514382869632917d, y: 0.5482654934950935d), new NpgsqlTypes.NpgsqlPoint(x: 0.15775998185918527d, y: 0.7898469986083144d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069427381079052d, y: 0.21406369961560556d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473767225126461d, y: 0.21050601780666933d), new NpgsqlTypes.NpgsqlPoint(x: 0.22010663308500167d, y: 0.854445111164415d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23386931011471246d, y: 0.5292425764829963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954758014368364d, y: 0.8283389268215675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560271844156168d, y: 0.9899705815147896d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2126912354609669d, y: 0.6464236277622251d), new NpgsqlTypes.NpgsqlPoint(x: 0.1979928071470376d, y: 0.85558088171999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690888032085699d, y: 0.5183684228772952d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54582581020138d, y: 0.14727773647011322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712973066079948d, y: 0.35312875040858627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540158746970958d, y: 0.6018550243373265d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833624193550645d, y: 0.15318535517744059d), new NpgsqlTypes.NpgsqlPoint(x: 0.43827252584412113d, y: 0.6217901066593962d), new NpgsqlTypes.NpgsqlPoint(x: 0.19350299812239957d, y: 0.366209872474632d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36262423736544414d, y: 0.5439405031667749d), new NpgsqlTypes.NpgsqlPoint(x: 0.14411116312581562d, y: 0.4440886072165323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274403425224742d, y: 0.8209554821467571d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30628368752062785d, y: 0.42495333287395176d), new NpgsqlTypes.NpgsqlPoint(x: 0.23876473423389244d, y: 0.2943917560796807d), new NpgsqlTypes.NpgsqlPoint(x: 0.23954062376644003d, y: 0.14462401577627093d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6165484567945809d, y: 0.3382722969692691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337967240898355d, y: 0.3326470587457486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928513096040378d, y: 0.7862085811926116d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7288286898696441d, y: 0.9483306429937463d), new NpgsqlTypes.NpgsqlPoint(x: 0.20684032915489237d, y: 0.0894176438967037d), new NpgsqlTypes.NpgsqlPoint(x: 0.40575852146470515d, y: 0.1326409152672995d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3514771910705612d, y: 0.9125148243523543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731148934592749d, y: 0.289135214097734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4249741293852147d, y: 0.6451744257131682d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10971325105074436d, y: 0.2817085936715371d), new NpgsqlTypes.NpgsqlPoint(x: 0.710437570729855d, y: 0.06207731851556131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742443867470257d, y: 0.014505175845037854d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2157742890079879d, y: 0.19316567558683728d), new NpgsqlTypes.NpgsqlPoint(x: 0.20893396936776132d, y: 0.4397717338322933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936611865347339d, y: 0.10610118299471061d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4614903176744344d, y: 0.15634870077825158d), new NpgsqlTypes.NpgsqlPoint(x: 0.4732697408444211d, y: 0.5158570954456608d), new NpgsqlTypes.NpgsqlPoint(x: 0.49609118586240375d, y: 0.4932628005064318d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9763097379478463d, y: 0.9921613027223823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789973915902291d, y: 0.818296191815611d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405755939057536d, y: 0.25158870137654366d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14296338531198882d, y: 0.04406093960398627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081715777224777d, y: 0.6811960649371215d), new NpgsqlTypes.NpgsqlPoint(x: 0.1305097314274276d, y: 0.7235859284425762d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3614272179946372d, y: 0.9468080994804018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219574676319492d, y: 0.37968393488721697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313135344262934d, y: 0.3302437406083871d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7986496084514538d, y: 0.8238438397078913d), new NpgsqlTypes.NpgsqlPoint(x: 0.14863240444832448d, y: 0.2648433186328444d), new NpgsqlTypes.NpgsqlPoint(x: 0.303808162087697d, y: 0.41242349488031416d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.360997487642553d, y: 0.9860002500177198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411951326123915d, y: 0.30791999966371253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5031495469282309d, y: 0.20775387440836657d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3606840620201105d, y: 0.5694322376696069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693308336663508d, y: 0.10953333567710799d), new NpgsqlTypes.NpgsqlPoint(x: 0.1403652201904283d, y: 0.08023090634090191d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1294948715295834d, y: 0.6079554018452318d), new NpgsqlTypes.NpgsqlPoint(x: 0.05352115123894707d, y: 0.4690327477761781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4480871892678554d, y: 0.21010068028185813d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9237952042601267d, y: 0.39805700140686606d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239644030021137d, y: 0.24409200992978097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520215026045951d, y: 0.8443475546087068d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09054084725247791d, y: 0.8045127770098992d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874302366720364d, y: 0.9135796805116129d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072098546155939d, y: 0.12086507724606133d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33703311269182434d, y: 0.6934809674314807d), new NpgsqlTypes.NpgsqlPoint(x: 0.960515412138512d, y: 0.7401345833813263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4189265866555746d, y: 0.9243408702768832d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5868396486630107d, y: 0.6693423249953776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4754570432087476d, y: 0.19311926214719244d), new NpgsqlTypes.NpgsqlPoint(x: 0.39934219420894734d, y: 0.2391371835979994d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7555767443527839d, y: 0.8589841468133407d), new NpgsqlTypes.NpgsqlPoint(x: 0.49443617103624804d, y: 0.26266346075133384d), new NpgsqlTypes.NpgsqlPoint(x: 0.12022878107357948d, y: 0.9559051552049709d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046682052827031084d, y: 0.9469813245055037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8206682323370643d, y: 0.2047660522614715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785742451978052d, y: 0.6999899700159076d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25294823615907536d, y: 0.3437692901683218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250977351362382d, y: 0.5024181324262751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103790611886682d, y: 0.9969964911291357d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6192978664496229d, y: 0.6804885920417456d), new NpgsqlTypes.NpgsqlPoint(x: 0.35296435329288345d, y: 0.6244101025639922d), new NpgsqlTypes.NpgsqlPoint(x: 0.007091082033146012d, y: 0.9774203881943029d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8750001100665968d, y: 0.9938592985843587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757276175911403d, y: 0.7318227781151665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079735379037568d, y: 0.21924384164717914d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062586443448416d, y: 0.9103440411984074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836894900462825d, y: 0.9327703441723486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217377064569548d, y: 0.7318050108306717d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31863899048196076d, y: 0.6470521982193667d), new NpgsqlTypes.NpgsqlPoint(x: 0.0747258360372548d, y: 0.09397626538269954d), new NpgsqlTypes.NpgsqlPoint(x: 0.1562080907778144d, y: 0.3262797692500836d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32187327043589575d, y: 0.228410418180242d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009145540688272336d, y: 0.883254471719743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375903852522603d, y: 0.3174093447916979d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03911337525966485d, y: 0.28296135071323414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4620911858519049d, y: 0.19400887069279704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242707122197058d, y: 0.003178167559247713d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8642639992871445d, y: 0.4798468572868084d), new NpgsqlTypes.NpgsqlPoint(x: 0.03846302684524827d, y: 0.3165945155202793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7490729288428647d, y: 0.8916481509851328d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38355530332731214d, y: 0.44152638550694456d), new NpgsqlTypes.NpgsqlPoint(x: 0.16271176914947305d, y: 0.7504541165437573d), new NpgsqlTypes.NpgsqlPoint(x: 0.3094864525526071d, y: 0.5800925753680897d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2922127358819294d, y: 0.06624607751371825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3744074351159896d, y: 0.10207676661209986d), new NpgsqlTypes.NpgsqlPoint(x: 0.19091406890148754d, y: 0.2768902037868024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9031825391359953d, y: 0.5530866141679989d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516313087438328d, y: 0.4549450750688867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338495204286019d, y: 0.9293430413680613d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7424912051156785d, y: 0.04089180903060363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127479850809532d, y: 0.36476874669973625d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180615617491874d, y: 0.5025670575086302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7765372778024846d, y: 0.7840543449001016d), new NpgsqlTypes.NpgsqlPoint(x: 0.2251291937322073d, y: 0.8572199937023669d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772029355083453d, y: 0.35365284690388665d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9067663024044426d, y: 0.053686681452055685d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866072211400776d, y: 0.0010334437887462578d), new NpgsqlTypes.NpgsqlPoint(x: 0.1502315135811354d, y: 0.3245150942851205d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36246752567512597d, y: 0.11558209151973886d), new NpgsqlTypes.NpgsqlPoint(x: 0.41281767498654653d, y: 0.4313278729307255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4346299438391922d, y: 0.6982159161158599d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6125229781437485d, y: 0.5019688747726884d), new NpgsqlTypes.NpgsqlPoint(x: 0.36006955453514067d, y: 0.08709130246992902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846088889530598d, y: 0.37574554358738665d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8814080017144472d, y: 0.6592808758898664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078292623130311d, y: 0.7101351531789216d), new NpgsqlTypes.NpgsqlPoint(x: 0.28141069341515534d, y: 0.9258881540771073d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9521738308018969d, y: 0.1035951986033331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907021013263358d, y: 0.7967175214265595d), new NpgsqlTypes.NpgsqlPoint(x: 0.596219840813451d, y: 0.8156665389821796d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2416767285294935d, y: 0.6694812158820806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8090937537452266d, y: 0.5302654003091029d), new NpgsqlTypes.NpgsqlPoint(x: 0.43751640314200124d, y: 0.3660852149776196d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9953632873126613d, y: 0.5036812957233803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751698640069436d, y: 0.08313687246028723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7032319691462384d, y: 0.5260127117636448d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7611083174792694d, y: 0.027586287894260764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8803696697398643d, y: 0.8106330497506302d), new NpgsqlTypes.NpgsqlPoint(x: 0.1364944413212903d, y: 0.9949692162627364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1053735769843912d, y: 0.6040351341619649d), new NpgsqlTypes.NpgsqlPoint(x: 0.16350975550763835d, y: 0.20888270991443902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625117025240804d, y: 0.96809285790694d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5440292344825134d, y: 0.737304636964042d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420984519056698d, y: 0.9095904194959086d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286530689146012d, y: 0.16736611225976916d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20100276921681715d, y: 0.06586059214488726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987644849737835d, y: 0.9367577819529264d), new NpgsqlTypes.NpgsqlPoint(x: 0.06402741553061042d, y: 0.38611298251056203d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009104377315829026d, y: 0.06889183031306845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8096890761424917d, y: 0.8915408754280861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326649341647822d, y: 0.24544530442876455d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512651615456333d, y: 0.5610533826248768d), new NpgsqlTypes.NpgsqlPoint(x: 0.21951626676559166d, y: 0.9186722860008681d), new NpgsqlTypes.NpgsqlPoint(x: 0.1517256927123064d, y: 0.5203043553763875d)))));//Value

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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpath0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI), typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

