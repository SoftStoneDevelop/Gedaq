

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

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.981065317031377d, y: 0.8193251911016571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134749770819311d, y: 0.6621599195945411d), new NpgsqlTypes.NpgsqlPoint(x: 0.31068002192903976d, y: 0.13394789244812255d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611602747360045d, y: 0.13746346261509057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677356541620757d, y: 0.265938488740489d), new NpgsqlTypes.NpgsqlPoint(x: 0.25189799686606995d, y: 0.9488205854575653d)),
},
            new NpgsqlPathpathE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10547025657085951d, y: 0.06700544927770602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006153045560849d, y: 0.16473268257753582d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136298616577854d, y: 0.7330109994928222d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3049214835612989d, y: 0.9549494937164014d), new NpgsqlTypes.NpgsqlPoint(x: 0.28607970179320263d, y: 0.6422878910847255d), new NpgsqlTypes.NpgsqlPoint(x: 0.39803716911358045d, y: 0.511879538575002d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07694337341809698d, y: 0.7637528939471838d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671306826870361d, y: 0.6645137847038698d), new NpgsqlTypes.NpgsqlPoint(x: 0.48601171143653543d, y: 0.7903528528628608d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693585510853292d, y: 0.3198891517361456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6724070815648681d, y: 0.5537189058563112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851305351987489d, y: 0.9188766046482236d)),
},
            new NpgsqlPathpathE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18991499525319444d, y: 0.24931721021374897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499195253331879d, y: 0.8676832775029764d), new NpgsqlTypes.NpgsqlPoint(x: 0.536266410527553d, y: 0.5971903891205234d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3856121630335676d, y: 0.2817121711522633d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273978872811538d, y: 0.9693935612443195d), new NpgsqlTypes.NpgsqlPoint(x: 0.10265409853053464d, y: 0.9555127052738435d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15733512996215027d, y: 0.40022784468436157d), new NpgsqlTypes.NpgsqlPoint(x: 0.35080257003799d, y: 0.5858760036789756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495113594413129d, y: 0.871992268914787d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874063670624266d, y: 0.6779064179847016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422415824637615d, y: 0.9394313034589266d), new NpgsqlTypes.NpgsqlPoint(x: 0.2318674009639351d, y: 0.9465448089548958d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5069529790364206d, y: 0.5639912363276638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439405679517557d, y: 0.7338938541825931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084547774355935d, y: 0.958381236853382d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8951668497881459d, y: 0.6101414230649541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408409624602811d, y: 0.05866907638606411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470265692743109d, y: 0.20859149802453547d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13735662186339181d, y: 0.7665826021063302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925568779925787d, y: 0.030684033452421877d), new NpgsqlTypes.NpgsqlPoint(x: 0.283598735408349d, y: 0.05196701471218779d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8959755585701097d, y: 0.526334596805556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626506421061774d, y: 0.4487556834151363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6970486435329816d, y: 0.28521129480071983d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14947080794568168d, y: 0.8292737065813137d), new NpgsqlTypes.NpgsqlPoint(x: 0.16943538149861248d, y: 0.4437824084115295d), new NpgsqlTypes.NpgsqlPoint(x: 0.17215431015621208d, y: 0.7421064287854873d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4636168815392657d, y: 0.9584697203249136d), new NpgsqlTypes.NpgsqlPoint(x: 0.653053892789103d, y: 0.6836081898033037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7550166077930935d, y: 0.11783003342297582d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5505167584810329d, y: 0.7602759373331355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307779661259739d, y: 0.8893985960025611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326453558378063d, y: 0.8849419232923372d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.482317793605888d, y: 0.3573901511955567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078592782862333d, y: 0.5606039754382063d), new NpgsqlTypes.NpgsqlPoint(x: 0.15258708363225848d, y: 0.7861262827600303d)),
},
            new NpgsqlPathpathE0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14344105072932278d, y: 0.42505141322066675d), new NpgsqlTypes.NpgsqlPoint(x: 0.47656569131773874d, y: 0.7489193344491926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8681063141064941d, y: 0.04723318344150407d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8791806216444941d, y: 0.2767975509906171d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673836260141049d, y: 0.06470523816897589d), new NpgsqlTypes.NpgsqlPoint(x: 0.03690742970082117d, y: 0.764341281763449d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9066510563720664d, y: 0.9443326992464995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4842406763959495d, y: 0.4359225028934529d), new NpgsqlTypes.NpgsqlPoint(x: 0.908465427591784d, y: 0.7127297365207104d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8242162922681069d, y: 0.029241825449482617d), new NpgsqlTypes.NpgsqlPoint(x: 0.14500223910649634d, y: 0.8240205362112775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158225814515747d, y: 0.05268810322909456d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.762971106106952d, y: 0.27454079952914134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946913243949774d, y: 0.9491111350527861d), new NpgsqlTypes.NpgsqlPoint(x: 0.09461686446168616d, y: 0.21999978667750764d)),
},
            new NpgsqlPathpathE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3906661766227445d, y: 0.020831707154019163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294190178100765d, y: 0.9926094278120495d), new NpgsqlTypes.NpgsqlPoint(x: 0.0743503366570114d, y: 0.7969376219096517d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.389279294997809d, y: 0.05924464045644995d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512880790837456d, y: 0.43810928250063663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929117146074954d, y: 0.5008315610679445d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9201592319672462d, y: 0.8779910858850604d), new NpgsqlTypes.NpgsqlPoint(x: 0.26714237185588163d, y: 0.4262218879381865d), new NpgsqlTypes.NpgsqlPoint(x: 0.503786407576967d, y: 0.2036561257499241d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7532121400489148d, y: 0.1885922389028667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7984759575957887d, y: 0.7210450932490186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2147350707593937d, y: 0.4001270174794612d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18281693374977237d, y: 0.9618283748471284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8102972474190304d, y: 0.3371197257014362d), new NpgsqlTypes.NpgsqlPoint(x: 0.04487580842305994d, y: 0.12564900539639035d)),
},
            new NpgsqlPathpathE0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5269101958226722d, y: 0.47494141565800696d), new NpgsqlTypes.NpgsqlPoint(x: 0.19727892636142308d, y: 0.06249625919855084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577445916256071d, y: 0.2574499838305422d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9480658101399232d, y: 0.359683978736247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8029064918806474d, y: 0.28799025739620543d), new NpgsqlTypes.NpgsqlPoint(x: 0.09943204333985933d, y: 0.33476553451040403d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13009013080329812d, y: 0.8995722264619973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920894086687143d, y: 0.8765025749076998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972939482757261d, y: 0.8857286402991229d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015044740569152837d, y: 0.5636814861872315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655392881242149d, y: 0.025773343369113744d), new NpgsqlTypes.NpgsqlPoint(x: 0.553556905790825d, y: 0.7618944384269374d)),
},
            new NpgsqlPathpathE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14072660533653636d, y: 0.12139238728092694d), new NpgsqlTypes.NpgsqlPoint(x: 0.3949839799044421d, y: 0.09323048683343627d), new NpgsqlTypes.NpgsqlPoint(x: 0.14580240539573608d, y: 0.21000064275647157d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48377847092722637d, y: 0.6502567713261181d), new NpgsqlTypes.NpgsqlPoint(x: 0.3647471053781509d, y: 0.3944937069208061d), new NpgsqlTypes.NpgsqlPoint(x: 0.26157137529505725d, y: 0.9820582313832803d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20075638721682054d, y: 0.6030497871576083d), new NpgsqlTypes.NpgsqlPoint(x: 0.22649189006521642d, y: 0.8653489146988982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827290751098205d, y: 0.310672152137476d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6602062380322867d, y: 0.8869629522518182d), new NpgsqlTypes.NpgsqlPoint(x: 0.10723739442698044d, y: 0.37631192236361366d), new NpgsqlTypes.NpgsqlPoint(x: 0.774216749125313d, y: 0.061047232344578095d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5455735221826693d, y: 0.8817817460079589d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134253620388685d, y: 0.5348836399222135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039987680158964d, y: 0.6024928326065774d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4151739260190911d, y: 0.2629569012891265d), new NpgsqlTypes.NpgsqlPoint(x: 0.08656010684806792d, y: 0.024529753456274395d), new NpgsqlTypes.NpgsqlPoint(x: 0.1794820439742585d, y: 0.22051424170543887d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38753231192368465d, y: 0.8497087617874736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156637897967258d, y: 0.3553262162665052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5017633935816281d, y: 0.3771766112817252d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6209407124684121d, y: 0.674532503206998d), new NpgsqlTypes.NpgsqlPoint(x: 0.00045733858584595666d, y: 0.5093271020552321d), new NpgsqlTypes.NpgsqlPoint(x: 0.4215064778195772d, y: 0.565749429245425d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.075371282895204d, y: 0.7747178339694404d), new NpgsqlTypes.NpgsqlPoint(x: 0.43518547451929357d, y: 0.6678676628968272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130763637255689d, y: 0.10750248836172926d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4489921025851793d, y: 0.2623903628155626d), new NpgsqlTypes.NpgsqlPoint(x: 0.37161972963317313d, y: 0.1760861360085647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128840094050065d, y: 0.3526835087271082d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512202052063809d, y: 0.3159679042001724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6451972198566956d, y: 0.8708437316039471d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816635491632703d, y: 0.6237829939679024d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1501619098039102d, y: 0.40896088274830444d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097594920234909d, y: 0.17266943964948145d), new NpgsqlTypes.NpgsqlPoint(x: 0.74261407269969d, y: 0.3209109943341171d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10689921968326876d, y: 0.937277371906875d), new NpgsqlTypes.NpgsqlPoint(x: 0.39054534173446154d, y: 0.7435424690957247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3667626565174964d, y: 0.6625059807033294d)),
},
            new NpgsqlPathpathE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37285071102297274d, y: 0.7033212484206083d), new NpgsqlTypes.NpgsqlPoint(x: 0.05008898773728576d, y: 0.18597618259101756d), new NpgsqlTypes.NpgsqlPoint(x: 0.637259946443072d, y: 0.20577445820585738d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4524410271745746d, y: 0.14826144903694138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440258709129049d, y: 0.028213638940530306d), new NpgsqlTypes.NpgsqlPoint(x: 0.1680753674027078d, y: 0.504359365990382d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9454509042354564d, y: 0.5063446013785337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866037061705858d, y: 0.7396359981671178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177002564122414d, y: 0.42716429254113053d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5036084634286363d, y: 0.45073169862179374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270730182803179d, y: 0.939987095906162d), new NpgsqlTypes.NpgsqlPoint(x: 0.11076300799167038d, y: 0.6364855351217852d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28809434834622416d, y: 0.9906558451070506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570106621904442d, y: 0.469139895069447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3281788528741002d, y: 0.7938261140125308d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3448271141741349d, y: 0.7649045407008149d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323679495310172d, y: 0.47563889339280707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641402982942161d, y: 0.699973874176547d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307474867238511d, y: 0.1431643879052913d), new NpgsqlTypes.NpgsqlPoint(x: 0.38906646201235673d, y: 0.11650317990788672d), new NpgsqlTypes.NpgsqlPoint(x: 0.11419782729192884d, y: 0.4257539649903359d)),
},
            new NpgsqlPathpathE0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1899751689242306d, y: 0.37601784899276314d), new NpgsqlTypes.NpgsqlPoint(x: 0.03233091185678716d, y: 0.7027893447000814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8230521293889055d, y: 0.15138326895187404d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3249669677441591d, y: 0.7780430678578493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8221540507517275d, y: 0.6709981055097319d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160631203548705d, y: 0.813678565003081d)),
},
            new NpgsqlPathpathE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.284844775739834d, y: 0.9718103440576199d), new NpgsqlTypes.NpgsqlPoint(x: 0.14695953603325929d, y: 0.3949515983740721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6198251787581952d, y: 0.38078914409314546d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28532323525991976d, y: 0.12150034571053137d), new NpgsqlTypes.NpgsqlPoint(x: 0.11425508378988525d, y: 0.6071712597820227d), new NpgsqlTypes.NpgsqlPoint(x: 0.159720469628287d, y: 0.5216678790988744d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9302355690165959d, y: 0.4377148928742527d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322599078499434d, y: 0.3389978853544068d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826156446072634d, y: 0.8016914059592326d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9255471644479256d, y: 0.5662823497298385d), new NpgsqlTypes.NpgsqlPoint(x: 0.976166436477021d, y: 0.022170840188835417d), new NpgsqlTypes.NpgsqlPoint(x: 0.006151403422124613d, y: 0.6683760255477892d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4405360340872404d, y: 0.9206715841128211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930643322949478d, y: 0.4627633352942673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2559664065347479d, y: 0.8002063845411641d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6244376497129432d, y: 0.5019484891138951d), new NpgsqlTypes.NpgsqlPoint(x: 0.18101832616757174d, y: 0.6723004028572789d), new NpgsqlTypes.NpgsqlPoint(x: 0.629101812270101d, y: 0.7876802505925671d)),
},
            new NpgsqlPathpathE0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7932342348305355d, y: 0.17265695068504883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197500789446845d, y: 0.6811759576390177d), new NpgsqlTypes.NpgsqlPoint(x: 0.22280534666796048d, y: 0.9372007159307804d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38737992767844576d, y: 0.5312896820650792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834274010391573d, y: 0.5677500036634429d), new NpgsqlTypes.NpgsqlPoint(x: 0.061579358140806395d, y: 0.1003726170559901d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3172368690549179d, y: 0.9028641521845235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363684484076661d, y: 0.4750211030567869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621137335810635d, y: 0.17617382154424932d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.863840535684166d, y: 0.7640083749130336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5251181667633302d, y: 0.9301074028066206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091892189039368d, y: 0.018951273687731862d)),
},
            new NpgsqlPathpathE0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8072749362506929d, y: 0.31499067364405897d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645609884737224d, y: 0.5001128463063619d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628356442034781d, y: 0.5777297556954382d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2778580617340959d, y: 0.6437219817390752d), new NpgsqlTypes.NpgsqlPoint(x: 0.07718821735295678d, y: 0.12213023938347944d), new NpgsqlTypes.NpgsqlPoint(x: 0.05906563103770546d, y: 0.7141818105807172d)),
},
            new NpgsqlPathpathE0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8973381146649394d, y: 0.050420642199188515d), new NpgsqlTypes.NpgsqlPoint(x: 0.18245035959365508d, y: 0.2763461864608868d), new NpgsqlTypes.NpgsqlPoint(x: 0.16201722020356135d, y: 0.1456522397397335d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17969890119033205d, y: 0.6450746485888394d), new NpgsqlTypes.NpgsqlPoint(x: 0.42292584946699985d, y: 0.1897509920625663d), new NpgsqlTypes.NpgsqlPoint(x: 0.25192108078263065d, y: 0.633417075944127d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6185543836890225d, y: 0.9751994184660002d), new NpgsqlTypes.NpgsqlPoint(x: 0.037311984788182095d, y: 0.32655253683694907d), new NpgsqlTypes.NpgsqlPoint(x: 0.06892647754806291d, y: 0.056167116527447325d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8693573096198212d, y: 0.8021531751817987d), new NpgsqlTypes.NpgsqlPoint(x: 0.2798619854781441d, y: 0.3383371317991707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009720890830315d, y: 0.046695958996495146d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4418194261501621d, y: 0.4779255489583528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449643626042651d, y: 0.5316572186798555d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809184879331146d, y: 0.9154904886721918d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8780998074105131d, y: 0.32662259413011785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890535657026025d, y: 0.18611926552915625d), new NpgsqlTypes.NpgsqlPoint(x: 0.07934276080142455d, y: 0.5833883160127753d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 5.9737109724067317E-05d, y: 0.8141522912348065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467549758547968d, y: 0.8578728827652315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328029946798132d, y: 0.9126098102505507d)),
},
            new NpgsqlPathpathE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41398574910529773d, y: 0.37899289668966574d), new NpgsqlTypes.NpgsqlPoint(x: 0.493418770100702d, y: 0.8423708369751345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601106252902103d, y: 0.19625630260374805d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06968643172603117d, y: 0.22804280217869732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405775125399535d, y: 0.17475965481478728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888986087294419d, y: 0.5375060077275062d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
INSERT INTO public.npgsqlpathpathe0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
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
INSERT INTO public.npgsqlpathpathe0mi(
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
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.482317793605888d, y: 0.3573901511955567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078592782862333d, y: 0.5606039754382063d), new NpgsqlTypes.NpgsqlPoint(x: 0.15258708363225848d, y: 0.7861262827600303d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.762971106106952d, y: 0.27454079952914134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946913243949774d, y: 0.9491111350527861d), new NpgsqlTypes.NpgsqlPoint(x: 0.09461686446168616d, y: 0.21999978667750764d))));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18281693374977237d, y: 0.9618283748471284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8102972474190304d, y: 0.3371197257014362d), new NpgsqlTypes.NpgsqlPoint(x: 0.04487580842305994d, y: 0.12564900539639035d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpathe0mi_id
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
                parametrName: "npgsqlpathpathe0mi_id", 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[34], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 31, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 151, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 62, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 151, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 61, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 126, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 126, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
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
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 103, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[2], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[3], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[4], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[5], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[6], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[7], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[8], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[9], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[10], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[24],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[25],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[26],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[27],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[28],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[29],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[30],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[31],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.981065317031377d, y: 0.8193251911016571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134749770819311d, y: 0.6621599195945411d), new NpgsqlTypes.NpgsqlPoint(x: 0.31068002192903976d, y: 0.13394789244812255d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611602747360045d, y: 0.13746346261509057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677356541620757d, y: 0.265938488740489d), new NpgsqlTypes.NpgsqlPoint(x: 0.25189799686606995d, y: 0.9488205854575653d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10547025657085951d, y: 0.06700544927770602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006153045560849d, y: 0.16473268257753582d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136298616577854d, y: 0.7330109994928222d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3049214835612989d, y: 0.9549494937164014d), new NpgsqlTypes.NpgsqlPoint(x: 0.28607970179320263d, y: 0.6422878910847255d), new NpgsqlTypes.NpgsqlPoint(x: 0.39803716911358045d, y: 0.511879538575002d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07694337341809698d, y: 0.7637528939471838d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671306826870361d, y: 0.6645137847038698d), new NpgsqlTypes.NpgsqlPoint(x: 0.48601171143653543d, y: 0.7903528528628608d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693585510853292d, y: 0.3198891517361456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6724070815648681d, y: 0.5537189058563112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851305351987489d, y: 0.9188766046482236d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18991499525319444d, y: 0.24931721021374897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499195253331879d, y: 0.8676832775029764d), new NpgsqlTypes.NpgsqlPoint(x: 0.536266410527553d, y: 0.5971903891205234d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3856121630335676d, y: 0.2817121711522633d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273978872811538d, y: 0.9693935612443195d), new NpgsqlTypes.NpgsqlPoint(x: 0.10265409853053464d, y: 0.9555127052738435d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15733512996215027d, y: 0.40022784468436157d), new NpgsqlTypes.NpgsqlPoint(x: 0.35080257003799d, y: 0.5858760036789756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495113594413129d, y: 0.871992268914787d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874063670624266d, y: 0.6779064179847016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422415824637615d, y: 0.9394313034589266d), new NpgsqlTypes.NpgsqlPoint(x: 0.2318674009639351d, y: 0.9465448089548958d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5069529790364206d, y: 0.5639912363276638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439405679517557d, y: 0.7338938541825931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084547774355935d, y: 0.958381236853382d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8951668497881459d, y: 0.6101414230649541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408409624602811d, y: 0.05866907638606411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470265692743109d, y: 0.20859149802453547d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13735662186339181d, y: 0.7665826021063302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925568779925787d, y: 0.030684033452421877d), new NpgsqlTypes.NpgsqlPoint(x: 0.283598735408349d, y: 0.05196701471218779d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8959755585701097d, y: 0.526334596805556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626506421061774d, y: 0.4487556834151363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6970486435329816d, y: 0.28521129480071983d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14947080794568168d, y: 0.8292737065813137d), new NpgsqlTypes.NpgsqlPoint(x: 0.16943538149861248d, y: 0.4437824084115295d), new NpgsqlTypes.NpgsqlPoint(x: 0.17215431015621208d, y: 0.7421064287854873d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4636168815392657d, y: 0.9584697203249136d), new NpgsqlTypes.NpgsqlPoint(x: 0.653053892789103d, y: 0.6836081898033037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7550166077930935d, y: 0.11783003342297582d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5505167584810329d, y: 0.7602759373331355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307779661259739d, y: 0.8893985960025611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326453558378063d, y: 0.8849419232923372d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.482317793605888d, y: 0.3573901511955567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078592782862333d, y: 0.5606039754382063d), new NpgsqlTypes.NpgsqlPoint(x: 0.15258708363225848d, y: 0.7861262827600303d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14344105072932278d, y: 0.42505141322066675d), new NpgsqlTypes.NpgsqlPoint(x: 0.47656569131773874d, y: 0.7489193344491926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8681063141064941d, y: 0.04723318344150407d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8791806216444941d, y: 0.2767975509906171d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673836260141049d, y: 0.06470523816897589d), new NpgsqlTypes.NpgsqlPoint(x: 0.03690742970082117d, y: 0.764341281763449d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9066510563720664d, y: 0.9443326992464995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4842406763959495d, y: 0.4359225028934529d), new NpgsqlTypes.NpgsqlPoint(x: 0.908465427591784d, y: 0.7127297365207104d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8242162922681069d, y: 0.029241825449482617d), new NpgsqlTypes.NpgsqlPoint(x: 0.14500223910649634d, y: 0.8240205362112775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158225814515747d, y: 0.05268810322909456d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.762971106106952d, y: 0.27454079952914134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946913243949774d, y: 0.9491111350527861d), new NpgsqlTypes.NpgsqlPoint(x: 0.09461686446168616d, y: 0.21999978667750764d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3906661766227445d, y: 0.020831707154019163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294190178100765d, y: 0.9926094278120495d), new NpgsqlTypes.NpgsqlPoint(x: 0.0743503366570114d, y: 0.7969376219096517d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.389279294997809d, y: 0.05924464045644995d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512880790837456d, y: 0.43810928250063663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929117146074954d, y: 0.5008315610679445d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9201592319672462d, y: 0.8779910858850604d), new NpgsqlTypes.NpgsqlPoint(x: 0.26714237185588163d, y: 0.4262218879381865d), new NpgsqlTypes.NpgsqlPoint(x: 0.503786407576967d, y: 0.2036561257499241d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7532121400489148d, y: 0.1885922389028667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7984759575957887d, y: 0.7210450932490186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2147350707593937d, y: 0.4001270174794612d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18281693374977237d, y: 0.9618283748471284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8102972474190304d, y: 0.3371197257014362d), new NpgsqlTypes.NpgsqlPoint(x: 0.04487580842305994d, y: 0.12564900539639035d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5269101958226722d, y: 0.47494141565800696d), new NpgsqlTypes.NpgsqlPoint(x: 0.19727892636142308d, y: 0.06249625919855084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577445916256071d, y: 0.2574499838305422d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9480658101399232d, y: 0.359683978736247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8029064918806474d, y: 0.28799025739620543d), new NpgsqlTypes.NpgsqlPoint(x: 0.09943204333985933d, y: 0.33476553451040403d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13009013080329812d, y: 0.8995722264619973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920894086687143d, y: 0.8765025749076998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972939482757261d, y: 0.8857286402991229d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015044740569152837d, y: 0.5636814861872315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655392881242149d, y: 0.025773343369113744d), new NpgsqlTypes.NpgsqlPoint(x: 0.553556905790825d, y: 0.7618944384269374d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14072660533653636d, y: 0.12139238728092694d), new NpgsqlTypes.NpgsqlPoint(x: 0.3949839799044421d, y: 0.09323048683343627d), new NpgsqlTypes.NpgsqlPoint(x: 0.14580240539573608d, y: 0.21000064275647157d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48377847092722637d, y: 0.6502567713261181d), new NpgsqlTypes.NpgsqlPoint(x: 0.3647471053781509d, y: 0.3944937069208061d), new NpgsqlTypes.NpgsqlPoint(x: 0.26157137529505725d, y: 0.9820582313832803d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20075638721682054d, y: 0.6030497871576083d), new NpgsqlTypes.NpgsqlPoint(x: 0.22649189006521642d, y: 0.8653489146988982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827290751098205d, y: 0.310672152137476d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6602062380322867d, y: 0.8869629522518182d), new NpgsqlTypes.NpgsqlPoint(x: 0.10723739442698044d, y: 0.37631192236361366d), new NpgsqlTypes.NpgsqlPoint(x: 0.774216749125313d, y: 0.061047232344578095d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5455735221826693d, y: 0.8817817460079589d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134253620388685d, y: 0.5348836399222135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039987680158964d, y: 0.6024928326065774d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4151739260190911d, y: 0.2629569012891265d), new NpgsqlTypes.NpgsqlPoint(x: 0.08656010684806792d, y: 0.024529753456274395d), new NpgsqlTypes.NpgsqlPoint(x: 0.1794820439742585d, y: 0.22051424170543887d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38753231192368465d, y: 0.8497087617874736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156637897967258d, y: 0.3553262162665052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5017633935816281d, y: 0.3771766112817252d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6209407124684121d, y: 0.674532503206998d), new NpgsqlTypes.NpgsqlPoint(x: 0.00045733858584595666d, y: 0.5093271020552321d), new NpgsqlTypes.NpgsqlPoint(x: 0.4215064778195772d, y: 0.565749429245425d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.075371282895204d, y: 0.7747178339694404d), new NpgsqlTypes.NpgsqlPoint(x: 0.43518547451929357d, y: 0.6678676628968272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130763637255689d, y: 0.10750248836172926d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4489921025851793d, y: 0.2623903628155626d), new NpgsqlTypes.NpgsqlPoint(x: 0.37161972963317313d, y: 0.1760861360085647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128840094050065d, y: 0.3526835087271082d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512202052063809d, y: 0.3159679042001724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6451972198566956d, y: 0.8708437316039471d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816635491632703d, y: 0.6237829939679024d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1501619098039102d, y: 0.40896088274830444d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097594920234909d, y: 0.17266943964948145d), new NpgsqlTypes.NpgsqlPoint(x: 0.74261407269969d, y: 0.3209109943341171d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10689921968326876d, y: 0.937277371906875d), new NpgsqlTypes.NpgsqlPoint(x: 0.39054534173446154d, y: 0.7435424690957247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3667626565174964d, y: 0.6625059807033294d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37285071102297274d, y: 0.7033212484206083d), new NpgsqlTypes.NpgsqlPoint(x: 0.05008898773728576d, y: 0.18597618259101756d), new NpgsqlTypes.NpgsqlPoint(x: 0.637259946443072d, y: 0.20577445820585738d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4524410271745746d, y: 0.14826144903694138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440258709129049d, y: 0.028213638940530306d), new NpgsqlTypes.NpgsqlPoint(x: 0.1680753674027078d, y: 0.504359365990382d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9454509042354564d, y: 0.5063446013785337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866037061705858d, y: 0.7396359981671178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177002564122414d, y: 0.42716429254113053d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5036084634286363d, y: 0.45073169862179374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270730182803179d, y: 0.939987095906162d), new NpgsqlTypes.NpgsqlPoint(x: 0.11076300799167038d, y: 0.6364855351217852d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28809434834622416d, y: 0.9906558451070506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570106621904442d, y: 0.469139895069447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3281788528741002d, y: 0.7938261140125308d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3448271141741349d, y: 0.7649045407008149d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323679495310172d, y: 0.47563889339280707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641402982942161d, y: 0.699973874176547d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307474867238511d, y: 0.1431643879052913d), new NpgsqlTypes.NpgsqlPoint(x: 0.38906646201235673d, y: 0.11650317990788672d), new NpgsqlTypes.NpgsqlPoint(x: 0.11419782729192884d, y: 0.4257539649903359d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1899751689242306d, y: 0.37601784899276314d), new NpgsqlTypes.NpgsqlPoint(x: 0.03233091185678716d, y: 0.7027893447000814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8230521293889055d, y: 0.15138326895187404d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3249669677441591d, y: 0.7780430678578493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8221540507517275d, y: 0.6709981055097319d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160631203548705d, y: 0.813678565003081d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.284844775739834d, y: 0.9718103440576199d), new NpgsqlTypes.NpgsqlPoint(x: 0.14695953603325929d, y: 0.3949515983740721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6198251787581952d, y: 0.38078914409314546d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28532323525991976d, y: 0.12150034571053137d), new NpgsqlTypes.NpgsqlPoint(x: 0.11425508378988525d, y: 0.6071712597820227d), new NpgsqlTypes.NpgsqlPoint(x: 0.159720469628287d, y: 0.5216678790988744d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9302355690165959d, y: 0.4377148928742527d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322599078499434d, y: 0.3389978853544068d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826156446072634d, y: 0.8016914059592326d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9255471644479256d, y: 0.5662823497298385d), new NpgsqlTypes.NpgsqlPoint(x: 0.976166436477021d, y: 0.022170840188835417d), new NpgsqlTypes.NpgsqlPoint(x: 0.006151403422124613d, y: 0.6683760255477892d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4405360340872404d, y: 0.9206715841128211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930643322949478d, y: 0.4627633352942673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2559664065347479d, y: 0.8002063845411641d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6244376497129432d, y: 0.5019484891138951d), new NpgsqlTypes.NpgsqlPoint(x: 0.18101832616757174d, y: 0.6723004028572789d), new NpgsqlTypes.NpgsqlPoint(x: 0.629101812270101d, y: 0.7876802505925671d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7932342348305355d, y: 0.17265695068504883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197500789446845d, y: 0.6811759576390177d), new NpgsqlTypes.NpgsqlPoint(x: 0.22280534666796048d, y: 0.9372007159307804d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38737992767844576d, y: 0.5312896820650792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834274010391573d, y: 0.5677500036634429d), new NpgsqlTypes.NpgsqlPoint(x: 0.061579358140806395d, y: 0.1003726170559901d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3172368690549179d, y: 0.9028641521845235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363684484076661d, y: 0.4750211030567869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621137335810635d, y: 0.17617382154424932d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.863840535684166d, y: 0.7640083749130336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5251181667633302d, y: 0.9301074028066206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091892189039368d, y: 0.018951273687731862d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8072749362506929d, y: 0.31499067364405897d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645609884737224d, y: 0.5001128463063619d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628356442034781d, y: 0.5777297556954382d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2778580617340959d, y: 0.6437219817390752d), new NpgsqlTypes.NpgsqlPoint(x: 0.07718821735295678d, y: 0.12213023938347944d), new NpgsqlTypes.NpgsqlPoint(x: 0.05906563103770546d, y: 0.7141818105807172d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8973381146649394d, y: 0.050420642199188515d), new NpgsqlTypes.NpgsqlPoint(x: 0.18245035959365508d, y: 0.2763461864608868d), new NpgsqlTypes.NpgsqlPoint(x: 0.16201722020356135d, y: 0.1456522397397335d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17969890119033205d, y: 0.6450746485888394d), new NpgsqlTypes.NpgsqlPoint(x: 0.42292584946699985d, y: 0.1897509920625663d), new NpgsqlTypes.NpgsqlPoint(x: 0.25192108078263065d, y: 0.633417075944127d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6185543836890225d, y: 0.9751994184660002d), new NpgsqlTypes.NpgsqlPoint(x: 0.037311984788182095d, y: 0.32655253683694907d), new NpgsqlTypes.NpgsqlPoint(x: 0.06892647754806291d, y: 0.056167116527447325d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8693573096198212d, y: 0.8021531751817987d), new NpgsqlTypes.NpgsqlPoint(x: 0.2798619854781441d, y: 0.3383371317991707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009720890830315d, y: 0.046695958996495146d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4418194261501621d, y: 0.4779255489583528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449643626042651d, y: 0.5316572186798555d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809184879331146d, y: 0.9154904886721918d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8780998074105131d, y: 0.32662259413011785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890535657026025d, y: 0.18611926552915625d), new NpgsqlTypes.NpgsqlPoint(x: 0.07934276080142455d, y: 0.5833883160127753d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 5.9737109724067317E-05d, y: 0.8141522912348065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467549758547968d, y: 0.8578728827652315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328029946798132d, y: 0.9126098102505507d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41398574910529773d, y: 0.37899289668966574d), new NpgsqlTypes.NpgsqlPoint(x: 0.493418770100702d, y: 0.8423708369751345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601106252902103d, y: 0.19625630260374805d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06968643172603117d, y: 0.22804280217869732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405775125399535d, y: 0.17475965481478728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888986087294419d, y: 0.5375060077275062d)))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.981065317031377d, y: 0.8193251911016571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134749770819311d, y: 0.6621599195945411d), new NpgsqlTypes.NpgsqlPoint(x: 0.31068002192903976d, y: 0.13394789244812255d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611602747360045d, y: 0.13746346261509057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677356541620757d, y: 0.265938488740489d), new NpgsqlTypes.NpgsqlPoint(x: 0.25189799686606995d, y: 0.9488205854575653d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10547025657085951d, y: 0.06700544927770602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006153045560849d, y: 0.16473268257753582d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136298616577854d, y: 0.7330109994928222d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3049214835612989d, y: 0.9549494937164014d), new NpgsqlTypes.NpgsqlPoint(x: 0.28607970179320263d, y: 0.6422878910847255d), new NpgsqlTypes.NpgsqlPoint(x: 0.39803716911358045d, y: 0.511879538575002d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07694337341809698d, y: 0.7637528939471838d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671306826870361d, y: 0.6645137847038698d), new NpgsqlTypes.NpgsqlPoint(x: 0.48601171143653543d, y: 0.7903528528628608d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693585510853292d, y: 0.3198891517361456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6724070815648681d, y: 0.5537189058563112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851305351987489d, y: 0.9188766046482236d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18991499525319444d, y: 0.24931721021374897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499195253331879d, y: 0.8676832775029764d), new NpgsqlTypes.NpgsqlPoint(x: 0.536266410527553d, y: 0.5971903891205234d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3856121630335676d, y: 0.2817121711522633d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273978872811538d, y: 0.9693935612443195d), new NpgsqlTypes.NpgsqlPoint(x: 0.10265409853053464d, y: 0.9555127052738435d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15733512996215027d, y: 0.40022784468436157d), new NpgsqlTypes.NpgsqlPoint(x: 0.35080257003799d, y: 0.5858760036789756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495113594413129d, y: 0.871992268914787d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874063670624266d, y: 0.6779064179847016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422415824637615d, y: 0.9394313034589266d), new NpgsqlTypes.NpgsqlPoint(x: 0.2318674009639351d, y: 0.9465448089548958d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5069529790364206d, y: 0.5639912363276638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439405679517557d, y: 0.7338938541825931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084547774355935d, y: 0.958381236853382d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8951668497881459d, y: 0.6101414230649541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408409624602811d, y: 0.05866907638606411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470265692743109d, y: 0.20859149802453547d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13735662186339181d, y: 0.7665826021063302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925568779925787d, y: 0.030684033452421877d), new NpgsqlTypes.NpgsqlPoint(x: 0.283598735408349d, y: 0.05196701471218779d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8959755585701097d, y: 0.526334596805556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626506421061774d, y: 0.4487556834151363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6970486435329816d, y: 0.28521129480071983d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14947080794568168d, y: 0.8292737065813137d), new NpgsqlTypes.NpgsqlPoint(x: 0.16943538149861248d, y: 0.4437824084115295d), new NpgsqlTypes.NpgsqlPoint(x: 0.17215431015621208d, y: 0.7421064287854873d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4636168815392657d, y: 0.9584697203249136d), new NpgsqlTypes.NpgsqlPoint(x: 0.653053892789103d, y: 0.6836081898033037d), new NpgsqlTypes.NpgsqlPoint(x: 0.7550166077930935d, y: 0.11783003342297582d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5505167584810329d, y: 0.7602759373331355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307779661259739d, y: 0.8893985960025611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326453558378063d, y: 0.8849419232923372d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.482317793605888d, y: 0.3573901511955567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078592782862333d, y: 0.5606039754382063d), new NpgsqlTypes.NpgsqlPoint(x: 0.15258708363225848d, y: 0.7861262827600303d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14344105072932278d, y: 0.42505141322066675d), new NpgsqlTypes.NpgsqlPoint(x: 0.47656569131773874d, y: 0.7489193344491926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8681063141064941d, y: 0.04723318344150407d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8791806216444941d, y: 0.2767975509906171d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673836260141049d, y: 0.06470523816897589d), new NpgsqlTypes.NpgsqlPoint(x: 0.03690742970082117d, y: 0.764341281763449d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9066510563720664d, y: 0.9443326992464995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4842406763959495d, y: 0.4359225028934529d), new NpgsqlTypes.NpgsqlPoint(x: 0.908465427591784d, y: 0.7127297365207104d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8242162922681069d, y: 0.029241825449482617d), new NpgsqlTypes.NpgsqlPoint(x: 0.14500223910649634d, y: 0.8240205362112775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158225814515747d, y: 0.05268810322909456d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.762971106106952d, y: 0.27454079952914134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946913243949774d, y: 0.9491111350527861d), new NpgsqlTypes.NpgsqlPoint(x: 0.09461686446168616d, y: 0.21999978667750764d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3906661766227445d, y: 0.020831707154019163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294190178100765d, y: 0.9926094278120495d), new NpgsqlTypes.NpgsqlPoint(x: 0.0743503366570114d, y: 0.7969376219096517d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.389279294997809d, y: 0.05924464045644995d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512880790837456d, y: 0.43810928250063663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929117146074954d, y: 0.5008315610679445d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9201592319672462d, y: 0.8779910858850604d), new NpgsqlTypes.NpgsqlPoint(x: 0.26714237185588163d, y: 0.4262218879381865d), new NpgsqlTypes.NpgsqlPoint(x: 0.503786407576967d, y: 0.2036561257499241d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7532121400489148d, y: 0.1885922389028667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7984759575957887d, y: 0.7210450932490186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2147350707593937d, y: 0.4001270174794612d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18281693374977237d, y: 0.9618283748471284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8102972474190304d, y: 0.3371197257014362d), new NpgsqlTypes.NpgsqlPoint(x: 0.04487580842305994d, y: 0.12564900539639035d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5269101958226722d, y: 0.47494141565800696d), new NpgsqlTypes.NpgsqlPoint(x: 0.19727892636142308d, y: 0.06249625919855084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577445916256071d, y: 0.2574499838305422d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9480658101399232d, y: 0.359683978736247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8029064918806474d, y: 0.28799025739620543d), new NpgsqlTypes.NpgsqlPoint(x: 0.09943204333985933d, y: 0.33476553451040403d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13009013080329812d, y: 0.8995722264619973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920894086687143d, y: 0.8765025749076998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972939482757261d, y: 0.8857286402991229d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015044740569152837d, y: 0.5636814861872315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655392881242149d, y: 0.025773343369113744d), new NpgsqlTypes.NpgsqlPoint(x: 0.553556905790825d, y: 0.7618944384269374d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14072660533653636d, y: 0.12139238728092694d), new NpgsqlTypes.NpgsqlPoint(x: 0.3949839799044421d, y: 0.09323048683343627d), new NpgsqlTypes.NpgsqlPoint(x: 0.14580240539573608d, y: 0.21000064275647157d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48377847092722637d, y: 0.6502567713261181d), new NpgsqlTypes.NpgsqlPoint(x: 0.3647471053781509d, y: 0.3944937069208061d), new NpgsqlTypes.NpgsqlPoint(x: 0.26157137529505725d, y: 0.9820582313832803d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20075638721682054d, y: 0.6030497871576083d), new NpgsqlTypes.NpgsqlPoint(x: 0.22649189006521642d, y: 0.8653489146988982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827290751098205d, y: 0.310672152137476d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6602062380322867d, y: 0.8869629522518182d), new NpgsqlTypes.NpgsqlPoint(x: 0.10723739442698044d, y: 0.37631192236361366d), new NpgsqlTypes.NpgsqlPoint(x: 0.774216749125313d, y: 0.061047232344578095d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5455735221826693d, y: 0.8817817460079589d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134253620388685d, y: 0.5348836399222135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5039987680158964d, y: 0.6024928326065774d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4151739260190911d, y: 0.2629569012891265d), new NpgsqlTypes.NpgsqlPoint(x: 0.08656010684806792d, y: 0.024529753456274395d), new NpgsqlTypes.NpgsqlPoint(x: 0.1794820439742585d, y: 0.22051424170543887d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38753231192368465d, y: 0.8497087617874736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156637897967258d, y: 0.3553262162665052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5017633935816281d, y: 0.3771766112817252d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6209407124684121d, y: 0.674532503206998d), new NpgsqlTypes.NpgsqlPoint(x: 0.00045733858584595666d, y: 0.5093271020552321d), new NpgsqlTypes.NpgsqlPoint(x: 0.4215064778195772d, y: 0.565749429245425d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.075371282895204d, y: 0.7747178339694404d), new NpgsqlTypes.NpgsqlPoint(x: 0.43518547451929357d, y: 0.6678676628968272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130763637255689d, y: 0.10750248836172926d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4489921025851793d, y: 0.2623903628155626d), new NpgsqlTypes.NpgsqlPoint(x: 0.37161972963317313d, y: 0.1760861360085647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128840094050065d, y: 0.3526835087271082d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512202052063809d, y: 0.3159679042001724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6451972198566956d, y: 0.8708437316039471d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816635491632703d, y: 0.6237829939679024d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1501619098039102d, y: 0.40896088274830444d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097594920234909d, y: 0.17266943964948145d), new NpgsqlTypes.NpgsqlPoint(x: 0.74261407269969d, y: 0.3209109943341171d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10689921968326876d, y: 0.937277371906875d), new NpgsqlTypes.NpgsqlPoint(x: 0.39054534173446154d, y: 0.7435424690957247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3667626565174964d, y: 0.6625059807033294d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37285071102297274d, y: 0.7033212484206083d), new NpgsqlTypes.NpgsqlPoint(x: 0.05008898773728576d, y: 0.18597618259101756d), new NpgsqlTypes.NpgsqlPoint(x: 0.637259946443072d, y: 0.20577445820585738d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4524410271745746d, y: 0.14826144903694138d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440258709129049d, y: 0.028213638940530306d), new NpgsqlTypes.NpgsqlPoint(x: 0.1680753674027078d, y: 0.504359365990382d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9454509042354564d, y: 0.5063446013785337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866037061705858d, y: 0.7396359981671178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177002564122414d, y: 0.42716429254113053d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5036084634286363d, y: 0.45073169862179374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270730182803179d, y: 0.939987095906162d), new NpgsqlTypes.NpgsqlPoint(x: 0.11076300799167038d, y: 0.6364855351217852d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28809434834622416d, y: 0.9906558451070506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570106621904442d, y: 0.469139895069447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3281788528741002d, y: 0.7938261140125308d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3448271141741349d, y: 0.7649045407008149d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323679495310172d, y: 0.47563889339280707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641402982942161d, y: 0.699973874176547d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307474867238511d, y: 0.1431643879052913d), new NpgsqlTypes.NpgsqlPoint(x: 0.38906646201235673d, y: 0.11650317990788672d), new NpgsqlTypes.NpgsqlPoint(x: 0.11419782729192884d, y: 0.4257539649903359d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1899751689242306d, y: 0.37601784899276314d), new NpgsqlTypes.NpgsqlPoint(x: 0.03233091185678716d, y: 0.7027893447000814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8230521293889055d, y: 0.15138326895187404d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3249669677441591d, y: 0.7780430678578493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8221540507517275d, y: 0.6709981055097319d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160631203548705d, y: 0.813678565003081d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.284844775739834d, y: 0.9718103440576199d), new NpgsqlTypes.NpgsqlPoint(x: 0.14695953603325929d, y: 0.3949515983740721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6198251787581952d, y: 0.38078914409314546d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28532323525991976d, y: 0.12150034571053137d), new NpgsqlTypes.NpgsqlPoint(x: 0.11425508378988525d, y: 0.6071712597820227d), new NpgsqlTypes.NpgsqlPoint(x: 0.159720469628287d, y: 0.5216678790988744d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9302355690165959d, y: 0.4377148928742527d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322599078499434d, y: 0.3389978853544068d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826156446072634d, y: 0.8016914059592326d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9255471644479256d, y: 0.5662823497298385d), new NpgsqlTypes.NpgsqlPoint(x: 0.976166436477021d, y: 0.022170840188835417d), new NpgsqlTypes.NpgsqlPoint(x: 0.006151403422124613d, y: 0.6683760255477892d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4405360340872404d, y: 0.9206715841128211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930643322949478d, y: 0.4627633352942673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2559664065347479d, y: 0.8002063845411641d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6244376497129432d, y: 0.5019484891138951d), new NpgsqlTypes.NpgsqlPoint(x: 0.18101832616757174d, y: 0.6723004028572789d), new NpgsqlTypes.NpgsqlPoint(x: 0.629101812270101d, y: 0.7876802505925671d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7932342348305355d, y: 0.17265695068504883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197500789446845d, y: 0.6811759576390177d), new NpgsqlTypes.NpgsqlPoint(x: 0.22280534666796048d, y: 0.9372007159307804d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38737992767844576d, y: 0.5312896820650792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834274010391573d, y: 0.5677500036634429d), new NpgsqlTypes.NpgsqlPoint(x: 0.061579358140806395d, y: 0.1003726170559901d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3172368690549179d, y: 0.9028641521845235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363684484076661d, y: 0.4750211030567869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621137335810635d, y: 0.17617382154424932d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.863840535684166d, y: 0.7640083749130336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5251181667633302d, y: 0.9301074028066206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091892189039368d, y: 0.018951273687731862d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8072749362506929d, y: 0.31499067364405897d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645609884737224d, y: 0.5001128463063619d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628356442034781d, y: 0.5777297556954382d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2778580617340959d, y: 0.6437219817390752d), new NpgsqlTypes.NpgsqlPoint(x: 0.07718821735295678d, y: 0.12213023938347944d), new NpgsqlTypes.NpgsqlPoint(x: 0.05906563103770546d, y: 0.7141818105807172d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8973381146649394d, y: 0.050420642199188515d), new NpgsqlTypes.NpgsqlPoint(x: 0.18245035959365508d, y: 0.2763461864608868d), new NpgsqlTypes.NpgsqlPoint(x: 0.16201722020356135d, y: 0.1456522397397335d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17969890119033205d, y: 0.6450746485888394d), new NpgsqlTypes.NpgsqlPoint(x: 0.42292584946699985d, y: 0.1897509920625663d), new NpgsqlTypes.NpgsqlPoint(x: 0.25192108078263065d, y: 0.633417075944127d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6185543836890225d, y: 0.9751994184660002d), new NpgsqlTypes.NpgsqlPoint(x: 0.037311984788182095d, y: 0.32655253683694907d), new NpgsqlTypes.NpgsqlPoint(x: 0.06892647754806291d, y: 0.056167116527447325d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8693573096198212d, y: 0.8021531751817987d), new NpgsqlTypes.NpgsqlPoint(x: 0.2798619854781441d, y: 0.3383371317991707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009720890830315d, y: 0.046695958996495146d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4418194261501621d, y: 0.4779255489583528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449643626042651d, y: 0.5316572186798555d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809184879331146d, y: 0.9154904886721918d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8780998074105131d, y: 0.32662259413011785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890535657026025d, y: 0.18611926552915625d), new NpgsqlTypes.NpgsqlPoint(x: 0.07934276080142455d, y: 0.5833883160127753d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 5.9737109724067317E-05d, y: 0.8141522912348065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467549758547968d, y: 0.8578728827652315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328029946798132d, y: 0.9126098102505507d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41398574910529773d, y: 0.37899289668966574d), new NpgsqlTypes.NpgsqlPoint(x: 0.493418770100702d, y: 0.8423708369751345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601106252902103d, y: 0.19625630260374805d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06968643172603117d, y: 0.22804280217869732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405775125399535d, y: 0.17475965481478728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888986087294419d, y: 0.5375060077275062d)))));

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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
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
COPY public.binary_npgsqlpathpathe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MI),
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
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
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
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
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
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
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathE0M),
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                var importCollection = new List<NpgsqlPathpathE0M>();
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
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
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
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI), typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

