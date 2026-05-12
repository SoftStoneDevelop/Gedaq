

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10352176537498192d, y: 0.9933211731747721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815805436117949d, y: 0.41329612453180564d), new NpgsqlTypes.NpgsqlPoint(x: 0.517338218773846d, y: 0.19959602726617076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9135250000526958d, y: 0.7018397915291321d), new NpgsqlTypes.NpgsqlPoint(x: 0.263321916324357d, y: 0.527097625897208d), new NpgsqlTypes.NpgsqlPoint(x: 0.22505642562485062d, y: 0.9216878642833604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6212865462931209d, y: 0.7653718454035155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684445037968898d, y: 0.945734493826205d), new NpgsqlTypes.NpgsqlPoint(x: 0.46835850788364985d, y: 0.9679899032401521d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3761745459921927d, y: 0.36283389008282685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9379502081848752d, y: 0.9532760270754914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155925943183314d, y: 0.6597329326173909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8072857878947737d, y: 0.7223743417642219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8012391638487265d, y: 0.9938947566739332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442255303469885d, y: 0.2866051534952454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5207218739033828d, y: 0.1184247417634785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476623765211355d, y: 0.33678174399881977d), new NpgsqlTypes.NpgsqlPoint(x: 0.850034149103968d, y: 0.6462103693817972d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35475812334765044d, y: 0.3882996700392519d), new NpgsqlTypes.NpgsqlPoint(x: 0.23246016434473815d, y: 0.34206290382590976d), new NpgsqlTypes.NpgsqlPoint(x: 0.025057636724497345d, y: 0.09086267239396173d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3496066712981992d, y: 0.053856986843655696d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499643379812247d, y: 0.5987261553966279d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113519518440892d, y: 0.6538665032566494d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47741987590943835d, y: 0.7106444573235187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771037601553589d, y: 0.06967341300857388d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732461259423105d, y: 0.28020382453859327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8810313045663901d, y: 0.9963398036621812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5093012525766439d, y: 0.4250181075022642d), new NpgsqlTypes.NpgsqlPoint(x: 0.1572461704546826d, y: 0.18364828520527d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9221774377385803d, y: 0.7549061536513209d), new NpgsqlTypes.NpgsqlPoint(x: 0.20884554486058926d, y: 0.9272761025594016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733029272160495d, y: 0.9483759775835917d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5653105083495565d, y: 0.7281308546849894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6911020823665563d, y: 0.45242653406451305d), new NpgsqlTypes.NpgsqlPoint(x: 0.4571489114533166d, y: 0.566341316193926d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22328217286776908d, y: 0.34281431190874767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445492969048632d, y: 0.8071107903816404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749257028459889d, y: 0.7883534821533774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903191375743396d, y: 0.5549068398923986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3883122625284855d, y: 0.30498366887907113d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536315236773917d, y: 0.4940410514784771d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357608398511396d, y: 0.4431344387379692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275642003594774d, y: 0.9555133383388654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939520143742328d, y: 0.20787032762593483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8227542767442353d, y: 0.9068220073179999d), new NpgsqlTypes.NpgsqlPoint(x: 0.623152258960057d, y: 0.47565301264341375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503095397953882d, y: 0.6760186906113991d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3677709198122039d, y: 0.07749350546865963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496442829001819d, y: 0.7264606674953011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225718764432164d, y: 0.8612023559577138d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1920480095568894d, y: 0.9213694906926334d), new NpgsqlTypes.NpgsqlPoint(x: 0.2160578490636068d, y: 0.9567849618300159d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899995982448206d, y: 0.15518421669426619d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.375188479088738d, y: 0.34598871141262877d), new NpgsqlTypes.NpgsqlPoint(x: 0.36373462350045904d, y: 0.6629234895086086d), new NpgsqlTypes.NpgsqlPoint(x: 0.005524164654655994d, y: 0.7571056447198131d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14272532463082732d, y: 0.6681105501931296d), new NpgsqlTypes.NpgsqlPoint(x: 0.015083005196617538d, y: 0.6759430139624155d), new NpgsqlTypes.NpgsqlPoint(x: 0.1424862100957086d, y: 0.1264997971147075d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6500974461004576d, y: 0.9938476879411652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555318465206242d, y: 0.7977943421280007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276446468140335d, y: 0.2491449699567716d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8268796162427201d, y: 0.7591007613664629d), new NpgsqlTypes.NpgsqlPoint(x: 0.4025610484875921d, y: 0.6349729548458021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5925343408117342d, y: 0.8976167039573072d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025306392858682747d, y: 0.24480775460788362d), new NpgsqlTypes.NpgsqlPoint(x: 0.48688453653902697d, y: 0.5105724721327426d), new NpgsqlTypes.NpgsqlPoint(x: 0.04224868649056546d, y: 0.6235084639151218d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9546842037468031d, y: 0.9502613712180292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343070364025678d, y: 0.9076787554295546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6577250339428323d, y: 0.47013129629996553d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45666744804443293d, y: 0.9846580934925175d), new NpgsqlTypes.NpgsqlPoint(x: 0.679832472030785d, y: 0.6310871864542739d), new NpgsqlTypes.NpgsqlPoint(x: 0.18717397182419615d, y: 0.5369692927887636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13988319959919837d, y: 0.21766619362465478d), new NpgsqlTypes.NpgsqlPoint(x: 0.37718834587270733d, y: 0.9689422194189847d), new NpgsqlTypes.NpgsqlPoint(x: 0.12290183471139349d, y: 0.4371260560044924d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5560462873187998d, y: 0.01005136441648613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324784236451111d, y: 0.42657386503033756d), new NpgsqlTypes.NpgsqlPoint(x: 0.14918203990034384d, y: 0.9987956107356252d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7759799985190619d, y: 0.06574373917694776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9741000813926715d, y: 0.13160797869557728d), new NpgsqlTypes.NpgsqlPoint(x: 0.709445694003186d, y: 0.8615004014721295d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14697720503984824d, y: 0.8492056939603558d), new NpgsqlTypes.NpgsqlPoint(x: 0.46510039023898175d, y: 0.8808535324085102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6120408900220772d, y: 0.5947660055540614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6681927468698831d, y: 0.3115266845377753d), new NpgsqlTypes.NpgsqlPoint(x: 0.094659516440037d, y: 0.77942830448023d), new NpgsqlTypes.NpgsqlPoint(x: 0.14394726907649347d, y: 0.09552029519819905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7837785546040192d, y: 0.8655039955477616d), new NpgsqlTypes.NpgsqlPoint(x: 0.42250934504287785d, y: 0.6368219861141596d), new NpgsqlTypes.NpgsqlPoint(x: 0.633549875105873d, y: 0.151181006735579d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8564218636050783d, y: 0.3652858858674153d), new NpgsqlTypes.NpgsqlPoint(x: 0.4771734292219548d, y: 0.1627788353273727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086580781735467d, y: 0.625531193771291d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3470554116843133d, y: 0.980293856247851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7040811227224607d, y: 0.8968863145893475d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981349076910139d, y: 0.14585418524943627d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.815847436404901d, y: 0.28926030235372546d), new NpgsqlTypes.NpgsqlPoint(x: 0.2752902839304744d, y: 0.8009659392688873d), new NpgsqlTypes.NpgsqlPoint(x: 0.05038720047655976d, y: 0.7413424232730865d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8718284302841288d, y: 0.13554108951917188d), new NpgsqlTypes.NpgsqlPoint(x: 0.2717306230481602d, y: 0.3399714158786421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309448456620788d, y: 0.3876387792948347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.886926548249325d, y: 0.724394328220224d), new NpgsqlTypes.NpgsqlPoint(x: 0.1381198403970202d, y: 0.1489883951353449d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205363031466705d, y: 0.5173364975118172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04458782067217848d, y: 0.39018539554336806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930473406987374d, y: 0.42501978605211765d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995386314336616d, y: 0.8464060100919706d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1708237522253726d, y: 0.7996828728640554d), new NpgsqlTypes.NpgsqlPoint(x: 0.05741827241128061d, y: 0.9983263681598514d), new NpgsqlTypes.NpgsqlPoint(x: 0.571201377913569d, y: 0.2557180747173561d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34356963144166586d, y: 0.2691104190076654d), new NpgsqlTypes.NpgsqlPoint(x: 0.30229830416439474d, y: 0.8787624318977793d), new NpgsqlTypes.NpgsqlPoint(x: 0.317982912730536d, y: 0.7184496249713861d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7926473792990706d, y: 0.930542988549525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6463186882140092d, y: 0.5049334607064682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320837489266434d, y: 0.7895760038066627d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5592045089725395d, y: 0.6822453292337531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889544423206239d, y: 0.5852490965413204d), new NpgsqlTypes.NpgsqlPoint(x: 0.10214966614693932d, y: 0.5567842158086519d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.724610204888373d, y: 0.036976751325257795d), new NpgsqlTypes.NpgsqlPoint(x: 0.05816966926597689d, y: 0.7896819852126175d), new NpgsqlTypes.NpgsqlPoint(x: 0.2459238237233411d, y: 0.5336730575037079d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2795555569495247d, y: 0.4854701291387514d), new NpgsqlTypes.NpgsqlPoint(x: 0.20833281930261727d, y: 0.5298483896001632d), new NpgsqlTypes.NpgsqlPoint(x: 0.3000595827507455d, y: 0.5378229467268507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08094559890430097d, y: 0.5328018216177223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085268458120431d, y: 0.6222665146856137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886181437944533d, y: 0.6928677449642079d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9985290817348158d, y: 0.47579410253807086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8290384632835418d, y: 0.0009704939818756531d), new NpgsqlTypes.NpgsqlPoint(x: 0.8049672208090447d, y: 0.23205833845862966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8123566932571421d, y: 0.17179287185537517d), new NpgsqlTypes.NpgsqlPoint(x: 0.06593258186751605d, y: 0.7863773049161507d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551184869070467d, y: 0.09769727948423201d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4011800842526956d, y: 0.9898968386502585d), new NpgsqlTypes.NpgsqlPoint(x: 0.1564754429510452d, y: 0.8169510286247632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5185414024528875d, y: 0.589901736172042d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5494674201706082d, y: 0.20444467526347987d), new NpgsqlTypes.NpgsqlPoint(x: 0.7924942961883966d, y: 0.17113750052469445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833486421369694d, y: 0.15472306865526497d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.199287461128555d, y: 0.9184154735055734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036273415835145d, y: 0.5461553259017162d), new NpgsqlTypes.NpgsqlPoint(x: 0.838675762358866d, y: 0.32666691024568806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7762645505963398d, y: 0.27671393048487225d), new NpgsqlTypes.NpgsqlPoint(x: 0.25012827356006406d, y: 0.8744149947463766d), new NpgsqlTypes.NpgsqlPoint(x: 0.021418201923298574d, y: 0.45793008408866787d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3942951489047911d, y: 0.9421601560093178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021511128773865d, y: 0.8478256645092811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7687981340114252d, y: 0.8336974101343758d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44167344718798596d, y: 0.13329258650670694d), new NpgsqlTypes.NpgsqlPoint(x: 0.46278244406846014d, y: 0.4424827245628554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974853195318679d, y: 0.2881960386639886d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45542257916683704d, y: 0.18666184580278d), new NpgsqlTypes.NpgsqlPoint(x: 0.1877479800424967d, y: 0.4536008395076807d), new NpgsqlTypes.NpgsqlPoint(x: 0.2842193896674263d, y: 0.5412357342854369d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4385065484980626d, y: 0.8499086899591397d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768654480029292d, y: 0.7029703439464163d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517894441053156d, y: 0.384516919261508d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3483647914368623d, y: 0.4497113340645156d), new NpgsqlTypes.NpgsqlPoint(x: 0.21225124482805746d, y: 0.0463761746739233d), new NpgsqlTypes.NpgsqlPoint(x: 0.35971713492408763d, y: 0.4944880412045345d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3247436542474459d, y: 0.6491300063771449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7693385555012221d, y: 0.9456861276808015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363106993717994d, y: 0.21544508156625064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1489371035327478d, y: 0.6294822948745504d), new NpgsqlTypes.NpgsqlPoint(x: 0.029694426004540087d, y: 0.12127298333692371d), new NpgsqlTypes.NpgsqlPoint(x: 0.35017392053284546d, y: 0.9709083295837431d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13889469539336485d, y: 0.8087491634100341d), new NpgsqlTypes.NpgsqlPoint(x: 0.9341870083797775d, y: 0.5524193079476996d), new NpgsqlTypes.NpgsqlPoint(x: 0.10379691762374954d, y: 0.43755531672017833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24519661898629364d, y: 0.3958094491053483d), new NpgsqlTypes.NpgsqlPoint(x: 0.671496076773985d, y: 0.28084927672954507d), new NpgsqlTypes.NpgsqlPoint(x: 0.13174084046712609d, y: 0.21853934373876793d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8598456220479583d, y: 0.29667926292857816d), new NpgsqlTypes.NpgsqlPoint(x: 0.12339361462876808d, y: 0.1388673263252571d), new NpgsqlTypes.NpgsqlPoint(x: 0.3439437715844502d, y: 0.31687361662574187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6255857059580436d, y: 0.4880343544449628d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303348969524244d, y: 0.9878336874535922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424888867172143d, y: 0.6101091579225364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21334335775461144d, y: 0.09024769968790336d), new NpgsqlTypes.NpgsqlPoint(x: 0.3985745604217389d, y: 0.2905143548265804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378350596977754d, y: 0.3083969695210773d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19999079791310148d, y: 0.2813412151760001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6482296491991683d, y: 0.7295069942487648d), new NpgsqlTypes.NpgsqlPoint(x: 0.37543364971205384d, y: 0.7446496918341277d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21705606383680165d, y: 0.21822610782225427d), new NpgsqlTypes.NpgsqlPoint(x: 0.4768185868625623d, y: 0.7168936405573498d), new NpgsqlTypes.NpgsqlPoint(x: 0.10248393618696394d, y: 0.054195806589757645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10312333534106821d, y: 0.4945803570035838d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062848589707188d, y: 0.27846551494483684d), new NpgsqlTypes.NpgsqlPoint(x: 0.05160342489513725d, y: 0.039933807227736096d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7576763137674497d, y: 0.34353041825998953d), new NpgsqlTypes.NpgsqlPoint(x: 0.48852227509384505d, y: 0.9873639224986576d), new NpgsqlTypes.NpgsqlPoint(x: 0.17964731561254044d, y: 0.49517721337584675d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.793852499982062d, y: 0.23876016014584978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9817198092033476d, y: 0.9090855026842073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8370372844077892d, y: 0.10727352592139716d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43354233248178653d, y: 0.11426028415854139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8704355631159081d, y: 0.8627031885239022d), new NpgsqlTypes.NpgsqlPoint(x: 0.42904076059378204d, y: 0.6946790269395761d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49128259428852283d, y: 0.300480882138607d), new NpgsqlTypes.NpgsqlPoint(x: 0.18239082529059103d, y: 0.8916372023024252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6151575727282014d, y: 0.23841042464115259d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8618841323469778d, y: 0.969696129269881d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012310885660909987d, y: 0.6727039035176957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353741969641292d, y: 0.14039948971566896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6801161680507466d, y: 0.4024824604370776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168530543171111d, y: 0.5239008211835805d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454090819996046d, y: 0.33816907234149685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9222402873680043d, y: 0.4557052538907508d), new NpgsqlTypes.NpgsqlPoint(x: 0.44116724977537325d, y: 0.5612376657640333d), new NpgsqlTypes.NpgsqlPoint(x: 0.79930276621905d, y: 0.11088569836954654d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6225550634919234d, y: 0.30138444762648486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4677171966133664d, y: 0.19531847278522263d), new NpgsqlTypes.NpgsqlPoint(x: 0.48576796238995024d, y: 0.9826102529395578d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2185953849840493d, y: 0.38677062823639874d), new NpgsqlTypes.NpgsqlPoint(x: 0.38219516824796285d, y: 0.7357635591820643d), new NpgsqlTypes.NpgsqlPoint(x: 0.12585389437596972d, y: 0.5403698199594489d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08324300693547149d, y: 0.5416369471679587d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735922464397013d, y: 0.7760800671465184d), new NpgsqlTypes.NpgsqlPoint(x: 0.14561190960356107d, y: 0.4044632519444399d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2938275849862423d, y: 0.526655189599917d), new NpgsqlTypes.NpgsqlPoint(x: 0.26438281485733506d, y: 0.4756669071112076d), new NpgsqlTypes.NpgsqlPoint(x: 0.2315870682542236d, y: 0.11903707462970703d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06076572402568092d, y: 0.8528305692198972d), new NpgsqlTypes.NpgsqlPoint(x: 0.45938007866874453d, y: 0.11896651347531229d), new NpgsqlTypes.NpgsqlPoint(x: 0.951205347694548d, y: 0.582423607100873d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6713841696929115d, y: 0.46889457451319516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598057526171692d, y: 0.4734705053255237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998316780247075d, y: 0.14790047045562127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3616783694980661d, y: 0.7293433946668894d), new NpgsqlTypes.NpgsqlPoint(x: 0.1702813247207815d, y: 0.8056933814518475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288678870663993d, y: 0.24751400710836235d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9799991162623983d, y: 0.3135728657308836d), new NpgsqlTypes.NpgsqlPoint(x: 0.24315382897940252d, y: 0.5175536225987251d), new NpgsqlTypes.NpgsqlPoint(x: 0.9318184782840241d, y: 0.14937641217921616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057595154763923295d, y: 0.5563853123527236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850128878437555d, y: 0.016708194684584954d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177674537237022d, y: 0.07094876600813682d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5525237024816801d, y: 0.8761754902732339d), new NpgsqlTypes.NpgsqlPoint(x: 0.06561359002335831d, y: 0.17044377072852268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8618284752226816d, y: 0.1893650253282173d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05908368484139026d, y: 0.5304544429968521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7453036543058541d, y: 0.14366984443320374d), new NpgsqlTypes.NpgsqlPoint(x: 0.17471542202397705d, y: 0.19991429074650036d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059833297591884826d, y: 0.8825792758052058d), new NpgsqlTypes.NpgsqlPoint(x: 0.31132942884379466d, y: 0.9368875672842507d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497919847125379d, y: 0.9222209824698722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03581109599628418d, y: 0.41005333682762124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5320940768162704d, y: 0.4863825419386809d), new NpgsqlTypes.NpgsqlPoint(x: 0.07018875037700456d, y: 0.5349001937876167d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8388818278503338d, y: 0.7751415555083327d), new NpgsqlTypes.NpgsqlPoint(x: 0.00880811811251625d, y: 0.26084051329772473d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865399645610188d, y: 0.7337204859350424d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7275182366348077d, y: 0.626948742344954d), new NpgsqlTypes.NpgsqlPoint(x: 0.650072630499251d, y: 0.7087615818458558d), new NpgsqlTypes.NpgsqlPoint(x: 0.696940014583132d, y: 0.16035070565534337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26677044296851693d, y: 0.29620733057830284d), new NpgsqlTypes.NpgsqlPoint(x: 0.027636807097514038d, y: 0.7485784227376912d), new NpgsqlTypes.NpgsqlPoint(x: 0.22346521603361136d, y: 0.16334301105164506d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7286775717618644d, y: 0.6150907707543447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9587235460001476d, y: 0.4621901802624675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968614489639916d, y: 0.7995176943587967d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3407947315952523d, y: 0.1819330954473969d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686165833772871d, y: 0.5412229255483386d), new NpgsqlTypes.NpgsqlPoint(x: 0.4567962047900085d, y: 0.8164169652757798d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6788810268382277d, y: 0.983216841965476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159374689738419d, y: 0.5071675129528765d), new NpgsqlTypes.NpgsqlPoint(x: 0.24926403119642626d, y: 0.46530274000166394d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41876587281967437d, y: 0.31219333126176174d), new NpgsqlTypes.NpgsqlPoint(x: 0.06956161424552676d, y: 0.6142380359263837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8377696286877826d, y: 0.5257905677541532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8679544790776175d, y: 0.43817461221352105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570495693180796d, y: 0.6422322375956518d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302091171071297d, y: 0.6415327610835778d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4997995870988212d, y: 0.2834735237714876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934420274058705d, y: 0.09653625355220008d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190113629415902d, y: 0.29743288619917085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3886718941415108d, y: 0.3817219571644217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513827164776368d, y: 0.14864918473413524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471216521737363d, y: 0.8520898291650734d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10711130538163194d, y: 0.09938779215644344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9153582387099586d, y: 0.9807201620788484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323119013975916d, y: 0.7016158933208558d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21803479221762045d, y: 0.38282020101210545d), new NpgsqlTypes.NpgsqlPoint(x: 0.12008659725419857d, y: 0.5920738512197407d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793512850706649d, y: 0.6891338396492944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5535219689356368d, y: 0.24892705754623068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4725023721310331d, y: 0.8617918776613627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258808239852537d, y: 0.31226333620632507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9832860000057136d, y: 0.30308965831235324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7631132754166383d, y: 0.6824191907504986d), new NpgsqlTypes.NpgsqlPoint(x: 0.09131069852020435d, y: 0.32527822200447554d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028637014428407603d, y: 0.39782327173864884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5270604472397862d, y: 0.46782864993481965d), new NpgsqlTypes.NpgsqlPoint(x: 0.020015457434872763d, y: 0.1018076232890891d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.861260600429171d, y: 0.21998228455460445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7286595369230642d, y: 0.7612989147972267d), new NpgsqlTypes.NpgsqlPoint(x: 0.06868546875124448d, y: 0.5561805531234825d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6208078522209016d, y: 0.07801867580558786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372234001318027d, y: 0.13248746878496498d), new NpgsqlTypes.NpgsqlPoint(x: 0.19674130787697186d, y: 0.40479968956309065d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8158739272994702d, y: 0.893091350928936d), new NpgsqlTypes.NpgsqlPoint(x: 0.42777599914972897d, y: 0.7882054514365097d), new NpgsqlTypes.NpgsqlPoint(x: 0.45157198644761987d, y: 0.153104149263676d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6830288179555828d, y: 0.3215560713062634d), new NpgsqlTypes.NpgsqlPoint(x: 0.466205521256293d, y: 0.40251395053049577d), new NpgsqlTypes.NpgsqlPoint(x: 0.13476999478896545d, y: 0.1420385350903337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.366793741191069d, y: 0.7658435733275218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9246180616030445d, y: 0.17013346077489677d), new NpgsqlTypes.NpgsqlPoint(x: 0.28211113149451594d, y: 0.6201232548777297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48442517995992374d, y: 0.9069509966348551d), new NpgsqlTypes.NpgsqlPoint(x: 0.004252802725344451d, y: 0.5635870752938553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552734087228846d, y: 0.4863203840541467d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8579824158326036d, y: 0.7276795633467616d), new NpgsqlTypes.NpgsqlPoint(x: 0.08266015929042869d, y: 0.1477065186878942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5336318482303779d, y: 0.6838390801153615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833729070734213d, y: 0.9904693717419458d), new NpgsqlTypes.NpgsqlPoint(x: 0.031030085009285946d, y: 0.9111932859874862d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126643025197675d, y: 0.7371889719905721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6021363387027908d, y: 0.7337455516901458d), new NpgsqlTypes.NpgsqlPoint(x: 0.2448563268682582d, y: 0.15836165657169676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313588844560627d, y: 0.43685171956393243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7365054273780857d, y: 0.9366583608383556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878674036445336d, y: 0.24075546944028836d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141364959413519d, y: 0.2985355288293272d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20054459326313312d, y: 0.6839408069646317d), new NpgsqlTypes.NpgsqlPoint(x: 0.1559651179431527d, y: 0.16883088098296806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3861230517507498d, y: 0.1981257342886945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5948106756988241d, y: 0.4872462630030072d), new NpgsqlTypes.NpgsqlPoint(x: 0.328601459162317d, y: 0.1554827835063729d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789284746966906d, y: 0.2558602077502188d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2081702079975012d, y: 0.7547080012561487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022218976801111d, y: 0.5269422167074531d), new NpgsqlTypes.NpgsqlPoint(x: 0.7810107881125955d, y: 0.3893401483850104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23524334779873946d, y: 0.7294248234098167d), new NpgsqlTypes.NpgsqlPoint(x: 0.0737566135498755d, y: 0.10338870845919423d), new NpgsqlTypes.NpgsqlPoint(x: 0.17016921660453588d, y: 0.28829091118899974d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7589715090918429d, y: 0.13474472891616684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5365795448135753d, y: 0.9910223388626459d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002055986716965d, y: 0.8849757156800496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29549950381007994d, y: 0.2568372309807775d), new NpgsqlTypes.NpgsqlPoint(x: 0.03031463646590926d, y: 0.9862960692974762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014312936669079d, y: 0.28197399646632226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9233602708937327d, y: 0.8531667533945508d), new NpgsqlTypes.NpgsqlPoint(x: 0.381740222089033d, y: 0.3105413595802925d), new NpgsqlTypes.NpgsqlPoint(x: 0.2728980467017944d, y: 0.7357921939510189d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28329124971240205d, y: 0.18813368927416185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899467074548553d, y: 0.6342530085698511d), new NpgsqlTypes.NpgsqlPoint(x: 0.862511774188324d, y: 0.7250642559806222d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.710136726045095d, y: 0.7898679051947144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890553492618291d, y: 0.7729587695769168d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766089024997393d, y: 0.6009976541829359d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5650255820715095d, y: 0.614551457530651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3272446257034416d, y: 0.6272880264266227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6648464569205704d, y: 0.26230085282262583d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9625305296919207d, y: 0.8628681296928915d), new NpgsqlTypes.NpgsqlPoint(x: 0.061755081426892566d, y: 0.35050862801987115d), new NpgsqlTypes.NpgsqlPoint(x: 0.2376553481862581d, y: 0.3296047481104404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4235688018534324d, y: 0.1197828144323978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9592113516798678d, y: 0.7991922995205132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342685534681149d, y: 0.7799266929493283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30752596926406617d, y: 0.8674172023713159d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108809066677964d, y: 0.4743081230663735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581083116991988d, y: 0.37147100099196706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2013357987115575d, y: 0.5341314556999722d), new NpgsqlTypes.NpgsqlPoint(x: 0.133719316675883d, y: 0.7070578501311289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171071389213527d, y: 0.7453982027617108d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7688447034340099d, y: 0.19267264576630472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6075437972138464d, y: 0.6099825194664573d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016483646018524d, y: 0.41379344818943453d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9196113310768523d, y: 0.09784967690105806d), new NpgsqlTypes.NpgsqlPoint(x: 0.26558994958218807d, y: 0.3445744013654133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6034718537022808d, y: 0.12915478569468475d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08990779728622578d, y: 0.40543023646574083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8257879320199026d, y: 0.7020203488641743d), new NpgsqlTypes.NpgsqlPoint(x: 0.94056259675252d, y: 0.9467914029006347d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6143979365804442d, y: 0.574453390641792d), new NpgsqlTypes.NpgsqlPoint(x: 0.10273925839984621d, y: 0.9794059713021851d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333001363054902d, y: 0.688481468421401d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3343315792258922d, y: 0.7221483590347049d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874914618059592d, y: 0.8694503194199805d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654429441137861d, y: 0.008563836197350683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5398385097970042d, y: 0.8318356138133947d), new NpgsqlTypes.NpgsqlPoint(x: 0.42377013051036194d, y: 0.02596824276028442d), new NpgsqlTypes.NpgsqlPoint(x: 0.4907050236964121d, y: 0.844165319582829d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15228108304266352d, y: 0.14832475351837338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6793585573556713d, y: 0.05838111531720447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203610643314489d, y: 0.5537456935122602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6354293074280103d, y: 0.999967048660008d), new NpgsqlTypes.NpgsqlPoint(x: 0.876758557931132d, y: 0.5550374770088463d), new NpgsqlTypes.NpgsqlPoint(x: 0.18646691287601502d, y: 0.3789888447417349d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3875677163910799d, y: 0.0007555878385860915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459893751126721d, y: 0.18971186219586267d), new NpgsqlTypes.NpgsqlPoint(x: 0.22872258660926614d, y: 0.9958967896318076d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3238732495675214d, y: 0.5307418402224664d), new NpgsqlTypes.NpgsqlPoint(x: 0.48216485260372066d, y: 0.2813594215615739d), new NpgsqlTypes.NpgsqlPoint(x: 0.15947005656540658d, y: 0.5730040506723241d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18633397064497204d, y: 0.2637817413595661d), new NpgsqlTypes.NpgsqlPoint(x: 0.0684582173205025d, y: 0.9312993956345644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6281889374363964d, y: 0.4250676228487006d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36092041275550824d, y: 0.8967974786656089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8097961803941175d, y: 0.8240806589741129d), new NpgsqlTypes.NpgsqlPoint(x: 0.22344334353872142d, y: 0.6724187742042337d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7091813989607352d, y: 0.18272697667990123d), new NpgsqlTypes.NpgsqlPoint(x: 0.28313491657456813d, y: 0.8630328046630695d), new NpgsqlTypes.NpgsqlPoint(x: 0.10826705753180654d, y: 0.334509400651837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2084846060265947d, y: 0.7231485587002477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6545028305673777d, y: 0.2732244701385216d), new NpgsqlTypes.NpgsqlPoint(x: 0.293243967864557d, y: 0.762225853175907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05608503677517196d, y: 0.8537778246870901d), new NpgsqlTypes.NpgsqlPoint(x: 0.21415648374500207d, y: 0.7226718306474544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7461955548021594d, y: 0.2631278409381035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41160835831452336d, y: 0.6546550836455539d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610353168312246d, y: 0.028982810541644533d), new NpgsqlTypes.NpgsqlPoint(x: 0.2525941569876389d, y: 0.6397343564235377d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9649429602096868d, y: 0.7672377355711295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4652777783600095d, y: 0.10548728385961259d), new NpgsqlTypes.NpgsqlPoint(x: 0.13382910480353816d, y: 0.14061867747496026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3763330339766381d, y: 0.2678504528532627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268741669433814d, y: 0.9350821091048944d), new NpgsqlTypes.NpgsqlPoint(x: 0.2796497411503446d, y: 0.3253538316876101d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9667069228537126d, y: 0.7292173437806343d), new NpgsqlTypes.NpgsqlPoint(x: 0.2806722269944498d, y: 0.8239442284153572d), new NpgsqlTypes.NpgsqlPoint(x: 0.4300098259311247d, y: 0.49340871923668983d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1818133304382883d, y: 0.9697350411065174d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531283192932972d, y: 0.5581496292395837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9271355622907719d, y: 0.9807895461921842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49218041375557564d, y: 0.32910833414644947d), new NpgsqlTypes.NpgsqlPoint(x: 0.30114516518094214d, y: 0.09983727500730022d), new NpgsqlTypes.NpgsqlPoint(x: 0.918937990847846d, y: 0.6095137355779496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3381017347039308d, y: 0.8392053258669873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8443382521592422d, y: 0.8056397924077746d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114702199216085d, y: 0.6280532717973918d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11434653904871472d, y: 0.9146080716694396d), new NpgsqlTypes.NpgsqlPoint(x: 0.3919521552698413d, y: 0.05392261323398784d), new NpgsqlTypes.NpgsqlPoint(x: 0.2154515200889745d, y: 0.33080505246711056d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5461535886043071d, y: 0.5185750063572243d), new NpgsqlTypes.NpgsqlPoint(x: 0.9901566439590453d, y: 0.9007601235274911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227651646228961d, y: 0.744968206410304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9200286689184052d, y: 0.07726703390883327d), new NpgsqlTypes.NpgsqlPoint(x: 0.41272101468699307d, y: 0.7644809974180877d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317715718099674d, y: 0.709115537119776d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6391477455142803d, y: 0.486448270608677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6477153571748592d, y: 0.9337328873690138d), new NpgsqlTypes.NpgsqlPoint(x: 0.16709539573520582d, y: 0.03402974384890034d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9737691889002856d, y: 0.042104707169712485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248216591134868d, y: 0.6297472411989712d), new NpgsqlTypes.NpgsqlPoint(x: 0.1320841235918755d, y: 0.9992563441474154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4448670754444439d, y: 0.5209430692687353d), new NpgsqlTypes.NpgsqlPoint(x: 0.8139611830377737d, y: 0.2555131281647739d), new NpgsqlTypes.NpgsqlPoint(x: 0.19041454822009363d, y: 0.9711982948307895d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2948857235311444d, y: 0.9720027370655852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691743063185635d, y: 0.8125781289625936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5313652235285963d, y: 0.2676351274862131d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6828686122528956d, y: 0.44772611473790014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975956275373174d, y: 0.25229348500416204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139067456305808d, y: 0.8059595445818826d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6301038769997253d, y: 0.9703453688002582d), new NpgsqlTypes.NpgsqlPoint(x: 0.37913445683402414d, y: 0.04835951684046358d), new NpgsqlTypes.NpgsqlPoint(x: 0.5018756789530693d, y: 0.9258997950054537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49711450925690637d, y: 0.5590616836523222d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313199092288775d, y: 0.11494431022471963d), new NpgsqlTypes.NpgsqlPoint(x: 0.4188895516022779d, y: 0.5791062671011715d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9373120364544033d, y: 0.27716606249942966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5130124004041092d, y: 0.2709212444894179d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535166107645207d, y: 0.6681134465579364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6105462845101539d, y: 0.790351042641989d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989635800874667d, y: 0.42129900658515185d), new NpgsqlTypes.NpgsqlPoint(x: 0.43897259718298653d, y: 0.18632640534034928d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7135286470389641d, y: 0.7192273919963404d), new NpgsqlTypes.NpgsqlPoint(x: 0.3687967966136446d, y: 0.5835634617885953d), new NpgsqlTypes.NpgsqlPoint(x: 0.37346995309196085d, y: 0.3874465734171679d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6471639083035544d, y: 0.8335237801331584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999142780182188d, y: 0.38366107621694256d), new NpgsqlTypes.NpgsqlPoint(x: 0.04430813940256284d, y: 0.5162429738541061d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9418175160122901d, y: 0.30255980573610697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8245124865782775d, y: 0.243144267869417d), new NpgsqlTypes.NpgsqlPoint(x: 0.44527086621407597d, y: 0.14445870123896287d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7758646802994215d, y: 0.8858335450952254d), new NpgsqlTypes.NpgsqlPoint(x: 0.22977557536645532d, y: 0.05736009772289541d), new NpgsqlTypes.NpgsqlPoint(x: 0.2450072632431779d, y: 0.8316584487764754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17619609380287093d, y: 0.43771662282962176d), new NpgsqlTypes.NpgsqlPoint(x: 0.314761209665382d, y: 0.6316708243915381d), new NpgsqlTypes.NpgsqlPoint(x: 0.28058933541490416d, y: 0.208682093155246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8080651434087139d, y: 0.16379730874520637d), new NpgsqlTypes.NpgsqlPoint(x: 0.23909050379843888d, y: 0.02957530439941458d), new NpgsqlTypes.NpgsqlPoint(x: 0.06807634343754454d, y: 0.9065905537759612d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27714049626382464d, y: 0.32688719931190036d), new NpgsqlTypes.NpgsqlPoint(x: 0.045969361687214216d, y: 0.31115333144938295d), new NpgsqlTypes.NpgsqlPoint(x: 0.080025002437073d, y: 0.5517324231972596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7323336494140618d, y: 0.3987488880802811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491581055316606d, y: 0.2925290733012157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450980141198073d, y: 0.7734919541826016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2193472861931246d, y: 0.8711475315629946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8964549398960274d, y: 0.4052340489195101d), new NpgsqlTypes.NpgsqlPoint(x: 0.40872360506128924d, y: 0.11767925691475933d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12691056942107648d, y: 0.5876472549916076d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749527740809494d, y: 0.6651757678672823d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867190602857922d, y: 0.6776174410995001d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6337400869886849d, y: 0.39094277927863763d), new NpgsqlTypes.NpgsqlPoint(x: 0.78447493276984d, y: 0.17014467783622644d), new NpgsqlTypes.NpgsqlPoint(x: 0.2327230200667979d, y: 0.24082401594779024d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9769153993908705d, y: 0.8544263554278964d), new NpgsqlTypes.NpgsqlPoint(x: 0.46086174865371143d, y: 0.2537269511972631d), new NpgsqlTypes.NpgsqlPoint(x: 0.797863324496897d, y: 0.8508132676562927d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5117407583502457d, y: 0.6762877064261269d), new NpgsqlTypes.NpgsqlPoint(x: 0.6979629973415546d, y: 0.5317045257464967d), new NpgsqlTypes.NpgsqlPoint(x: 0.02541036146238007d, y: 0.49870863029212853d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3389905410666214d, y: 0.7950052016111828d), new NpgsqlTypes.NpgsqlPoint(x: 0.34243165626309446d, y: 0.7199453255918926d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874174455428346d, y: 0.9713814695562141d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.876552570512493d, y: 0.18852964391209626d), new NpgsqlTypes.NpgsqlPoint(x: 0.004024083711669291d, y: 0.9232541937301074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813267319287894d, y: 0.03212647692366577d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5441117708901188d, y: 0.31597073021516053d), new NpgsqlTypes.NpgsqlPoint(x: 0.3627410396851434d, y: 0.24829616182053582d), new NpgsqlTypes.NpgsqlPoint(x: 0.3900942210869719d, y: 0.07808988346203127d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9359556169387282d, y: 0.6152472778408182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875659481493542d, y: 0.8378824646466113d), new NpgsqlTypes.NpgsqlPoint(x: 0.45981612311470355d, y: 0.829409527449608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2511619888672193d, y: 0.6529125135298354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4169464612961149d, y: 0.5704043180875766d), new NpgsqlTypes.NpgsqlPoint(x: 0.43663435382195515d, y: 0.5338069805466868d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22326570396996337d, y: 0.09259181839686892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9958076441366436d, y: 0.8628849955536045d), new NpgsqlTypes.NpgsqlPoint(x: 0.15223648892508945d, y: 0.8404909014045547d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6401198244778109d, y: 0.5137626410596511d), new NpgsqlTypes.NpgsqlPoint(x: 0.43524652144875753d, y: 0.947955313186876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356284324633986d, y: 0.596880902545323d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29453673041463835d, y: 0.8843534126073967d), new NpgsqlTypes.NpgsqlPoint(x: 0.17384349785396658d, y: 0.5073289174020899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396383075586501d, y: 0.8517806608681544d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5920705248163136d, y: 0.6365584640125596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847952473066258d, y: 0.13983250834745609d), new NpgsqlTypes.NpgsqlPoint(x: 0.30911631504161374d, y: 0.35525123094157995d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46280571458824193d, y: 0.8698981468064254d), new NpgsqlTypes.NpgsqlPoint(x: 0.868839066744511d, y: 0.2657623994748437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169515092169706d, y: 0.4301947487221345d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5477185817126466d, y: 0.0802656686480594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749509037092699d, y: 0.18117280076118525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5062088325920535d, y: 0.7717564911491566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27852249209793656d, y: 0.2014327867590655d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034423212804475d, y: 0.35636746366487104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772919393567811d, y: 0.23755466803639802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5389321727902067d, y: 0.7217814407863741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729660977818235d, y: 0.6328869666728959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005462337305811d, y: 0.889500862587119d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04562108428750544d, y: 0.05286058420706308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246804611467748d, y: 0.9197720758804296d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843619218176699d, y: 0.5355398728638338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0924191969331335d, y: 0.014755760228478132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084806849409395d, y: 0.3932113996153629d), new NpgsqlTypes.NpgsqlPoint(x: 0.18043817826570374d, y: 0.03797424332098842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7589166906353929d, y: 0.9019459335954003d), new NpgsqlTypes.NpgsqlPoint(x: 0.4664586525578134d, y: 0.5423013242306549d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312908137945673d, y: 0.7200135063118793d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6274881495228597d, y: 0.7593013585863458d), new NpgsqlTypes.NpgsqlPoint(x: 0.18620006534241462d, y: 0.5450721826045132d), new NpgsqlTypes.NpgsqlPoint(x: 0.02845076154504944d, y: 0.6792329645012507d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5327050036604367d, y: 0.044396121190154236d), new NpgsqlTypes.NpgsqlPoint(x: 0.739241166137604d, y: 0.053401543686680375d), new NpgsqlTypes.NpgsqlPoint(x: 0.23484381314768887d, y: 0.3801387358313386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.702603487324491d, y: 0.6900208673417384d), new NpgsqlTypes.NpgsqlPoint(x: 0.1513135585740878d, y: 0.19359334475270595d), new NpgsqlTypes.NpgsqlPoint(x: 0.09399775593317206d, y: 0.6094977405501173d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13670480424424847d, y: 0.2848372046627765d), new NpgsqlTypes.NpgsqlPoint(x: 0.2950011794655152d, y: 0.3621827914141076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645076872690328d, y: 0.6560869644693078d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4345649127992066d, y: 0.09403248680377774d), new NpgsqlTypes.NpgsqlPoint(x: 0.3108623564619628d, y: 0.2818718167459252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394767531649519d, y: 0.06727654872971622d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6965276888983152d, y: 0.394255911317992d), new NpgsqlTypes.NpgsqlPoint(x: 0.14742374741838093d, y: 0.39670917119839344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230448705749569d, y: 0.5764370936763292d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9544883680477105d, y: 0.45799808304697787d), new NpgsqlTypes.NpgsqlPoint(x: 0.40894717461579255d, y: 0.18646223297506814d), new NpgsqlTypes.NpgsqlPoint(x: 0.7189481268959305d, y: 0.31676141518368217d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7966509521223192d, y: 0.19173949740531693d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990459638432118d, y: 0.9418065509291457d), new NpgsqlTypes.NpgsqlPoint(x: 0.35112562599959385d, y: 0.43051642767640275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7159655682955176d, y: 0.45091125204374016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820978361215547d, y: 0.09730238527222224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8412274713589505d, y: 0.45006099668524435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7630963952244807d, y: 0.11429148719105575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710635370202195d, y: 0.5937095714796793d), new NpgsqlTypes.NpgsqlPoint(x: 0.43760349908733576d, y: 0.7383046848428602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09706351228068988d, y: 0.4837726271366084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3392185093824388d, y: 0.326161167070944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228185278363124d, y: 0.10312765672082402d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9801250162847158d, y: 0.48330318585167087d), new NpgsqlTypes.NpgsqlPoint(x: 0.867165665308504d, y: 0.7064578012191888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477084149444617d, y: 0.9532139534230823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3863976923135892d, y: 0.748167770088763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7057636842642805d, y: 0.7612225236535993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995158621377047d, y: 0.5768272861838052d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9999866114142684d, y: 0.8357083177721427d), new NpgsqlTypes.NpgsqlPoint(x: 0.7693873635044811d, y: 0.9800833107662276d), new NpgsqlTypes.NpgsqlPoint(x: 0.915663955774215d, y: 0.14829999256399506d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9072886898949065d, y: 0.3352638097500663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861192821343199d, y: 0.3076900017107965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854738975062847d, y: 0.21495947072159272d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33077691557024946d, y: 0.6544696168157025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7322655556289213d, y: 0.8552042894174203d), new NpgsqlTypes.NpgsqlPoint(x: 0.18956885111381194d, y: 0.4461627427812044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6812518858405644d, y: 0.2682879668285453d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142177691311342d, y: 0.7493130216681959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6644318729898826d, y: 0.7850273862648186d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4916463622223217d, y: 0.9820837760559412d), new NpgsqlTypes.NpgsqlPoint(x: 0.008622980660525026d, y: 0.18294318202739135d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785796510466741d, y: 0.732483085295973d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9878323440314135d, y: 0.17921919495748406d), new NpgsqlTypes.NpgsqlPoint(x: 0.13788023761183388d, y: 0.6413252584510369d), new NpgsqlTypes.NpgsqlPoint(x: 0.16029009525025695d, y: 0.3566606961193748d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3740070427256229d, y: 0.2086189018103486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701870749837358d, y: 0.25884132680316774d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282419299956295d, y: 0.8180083331729707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.053703333793119534d, y: 0.13217141257288145d), new NpgsqlTypes.NpgsqlPoint(x: 0.8492448159525667d, y: 0.5340623828360187d), new NpgsqlTypes.NpgsqlPoint(x: 0.022955373986644934d, y: 0.4981747805137492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23199770916288232d, y: 0.36246346992030287d), new NpgsqlTypes.NpgsqlPoint(x: 0.47846752852774166d, y: 0.19356775546913596d), new NpgsqlTypes.NpgsqlPoint(x: 0.24481395443105447d, y: 0.3268115006164559d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9776050503088729d, y: 0.3712804510563208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6617393470321807d, y: 0.054203924279944915d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844415006339287d, y: 0.03597435885775124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06745688504122982d, y: 0.5163318020313092d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516689475503988d, y: 0.9569566654028302d), new NpgsqlTypes.NpgsqlPoint(x: 0.49666013813684495d, y: 0.6046157854836428d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11074027926949137d, y: 0.0016137558466665647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751234696208893d, y: 0.6220199339928388d), new NpgsqlTypes.NpgsqlPoint(x: 0.017002027108933504d, y: 0.06078603818986683d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8699241881020492d, y: 0.785434861655381d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023338492836866287d, y: 0.6732030318620366d), new NpgsqlTypes.NpgsqlPoint(x: 0.997134634505696d, y: 0.5970846622755398d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2091929526768106d, y: 0.4231969770536578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632474918180152d, y: 0.0702269663743399d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986681948563686d, y: 0.22180292960870973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3029266052551379d, y: 0.8338743225714708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551256000952438d, y: 0.9937962069920695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393599477228916d, y: 0.863410791186316d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.565625296284803d, y: 0.14219241891115353d), new NpgsqlTypes.NpgsqlPoint(x: 0.8895980506108978d, y: 0.3772691974030934d), new NpgsqlTypes.NpgsqlPoint(x: 0.0422416424835379d, y: 0.40352006720459166d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4092294259127982d, y: 0.6440012148510535d), new NpgsqlTypes.NpgsqlPoint(x: 0.23809754437835784d, y: 0.337547380022888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4397102659139731d, y: 0.7194165736404541d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5328652522900774d, y: 0.9233822940986087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689929549958609d, y: 0.8291157127259099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800357005620747d, y: 0.6109195081274543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8019836965088759d, y: 0.20467039404603482d), new NpgsqlTypes.NpgsqlPoint(x: 0.9317470648560097d, y: 0.4852480451816702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9330637485711727d, y: 0.10271976139066086d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7045798375248106d, y: 0.6342169739717217d), new NpgsqlTypes.NpgsqlPoint(x: 0.14084856498115705d, y: 0.6715733975372861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775996551971801d, y: 0.5007187142852632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5722023489414392d, y: 0.7175980321739079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6054958916043456d, y: 0.1317231506719997d), new NpgsqlTypes.NpgsqlPoint(x: 0.99305555949405d, y: 0.2863222243092127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7292041019592952d, y: 0.43702375060791787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638378985689069d, y: 0.7914194759640423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7666236017633572d, y: 0.6416243879101474d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028157765376922383d, y: 0.1834893413635621d), new NpgsqlTypes.NpgsqlPoint(x: 0.6713944078177311d, y: 0.02602887792066788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5501890006858604d, y: 0.6912760062164826d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47092615607170263d, y: 0.7774353509723676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345031613370703d, y: 0.24811905287464242d), new NpgsqlTypes.NpgsqlPoint(x: 0.012882580064505045d, y: 0.9662716521649724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2095460889899572d, y: 0.5114232732907112d), new NpgsqlTypes.NpgsqlPoint(x: 0.47719427056041386d, y: 0.9275614189759895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6292815046468454d, y: 0.9378951419569049d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8189432476791281d, y: 0.0028639073205201093d), new NpgsqlTypes.NpgsqlPoint(x: 0.15903517842912096d, y: 0.6635829659448401d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473584955121392d, y: 0.46590424506863215d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5896240105052455d, y: 0.9361870077273036d), new NpgsqlTypes.NpgsqlPoint(x: 0.20089615001013916d, y: 0.21860988330080733d), new NpgsqlTypes.NpgsqlPoint(x: 0.434661107534301d, y: 0.6623274351734236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5144083179126031d, y: 0.4776063426961241d), new NpgsqlTypes.NpgsqlPoint(x: 0.35911653059438886d, y: 0.1715919338108134d), new NpgsqlTypes.NpgsqlPoint(x: 0.24676657606479202d, y: 0.2585105700976137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07839740165002818d, y: 0.9753704524626843d), new NpgsqlTypes.NpgsqlPoint(x: 0.04943382958931841d, y: 0.8104029704129216d), new NpgsqlTypes.NpgsqlPoint(x: 0.09870198920816142d, y: 0.1640335300124265d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8217994116848653d, y: 0.7732931544564928d), new NpgsqlTypes.NpgsqlPoint(x: 0.460184195059266d, y: 0.9793154653961873d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368859908050261d, y: 0.020502350999451968d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0162693452462781d, y: 0.8276546923151207d), new NpgsqlTypes.NpgsqlPoint(x: 0.631516890742674d, y: 0.7558573921013767d), new NpgsqlTypes.NpgsqlPoint(x: 0.30604659937600065d, y: 0.33053138011770566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08815294916233796d, y: 0.44741947853258124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499583891714677d, y: 0.5080605142305317d), new NpgsqlTypes.NpgsqlPoint(x: 0.623133138833861d, y: 0.1999697817570374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3180656720220929d, y: 0.33868420623324036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054437751388713d, y: 0.5975868639049101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853503713979337d, y: 0.26647647110327655d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4856908216453455d, y: 0.8553085777639361d), new NpgsqlTypes.NpgsqlPoint(x: 0.7690468598536908d, y: 0.1342290215970363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762140427225841d, y: 0.2139499993877595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05148723899740992d, y: 0.20393167852260974d), new NpgsqlTypes.NpgsqlPoint(x: 0.4953557265196833d, y: 0.6886283756377606d), new NpgsqlTypes.NpgsqlPoint(x: 0.46126474170980103d, y: 0.5741540381003393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5594845973896745d, y: 0.9776421947818259d), new NpgsqlTypes.NpgsqlPoint(x: 0.3532634892581622d, y: 0.4356635197373875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7989353435475208d, y: 0.4322904872638582d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6319392525762796d, y: 0.8710838620844977d), new NpgsqlTypes.NpgsqlPoint(x: 0.5458692884240895d, y: 0.1977192490958798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4445853066045289d, y: 0.7718477335658273d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3519589524564668d, y: 0.933931832546057d), new NpgsqlTypes.NpgsqlPoint(x: 0.3155419310520632d, y: 0.7681103210345047d), new NpgsqlTypes.NpgsqlPoint(x: 0.47237691736152343d, y: 0.7619179282131601d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5639343753401266d, y: 0.2690327056450087d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009302947963181207d, y: 0.49878590589460214d), new NpgsqlTypes.NpgsqlPoint(x: 0.311860249876457d, y: 0.3507896001539724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5994104523723675d, y: 0.029186304733557544d), new NpgsqlTypes.NpgsqlPoint(x: 0.559654289167783d, y: 0.7026781662748159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895276718970214d, y: 0.42427816085404113d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3938441288727409d, y: 0.444603997361831d), new NpgsqlTypes.NpgsqlPoint(x: 0.7907681970881119d, y: 0.4607526269105411d), new NpgsqlTypes.NpgsqlPoint(x: 0.8239919022057275d, y: 0.7981722326319617d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6208162236768904d, y: 0.25818066006543106d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754996424638073d, y: 0.297750033976216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238866160481453d, y: 0.3216148272085063d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3657750316916605d, y: 0.6334266221820384d), new NpgsqlTypes.NpgsqlPoint(x: 0.24508197815767208d, y: 0.033769172195036834d), new NpgsqlTypes.NpgsqlPoint(x: 0.813197788745338d, y: 0.7867334396024586d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9042224018538471d, y: 0.06671331792392743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8537347240250582d, y: 0.022822850817074358d), new NpgsqlTypes.NpgsqlPoint(x: 0.27018603721115d, y: 0.3367459139853356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4809943863627304d, y: 0.5345497053671552d), new NpgsqlTypes.NpgsqlPoint(x: 0.4152118813569522d, y: 0.5818581003865483d), new NpgsqlTypes.NpgsqlPoint(x: 0.55193593407393d, y: 0.24595059506033246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9110103006495569d, y: 0.3897828523497886d), new NpgsqlTypes.NpgsqlPoint(x: 0.2781149258097888d, y: 0.7075611997279714d), new NpgsqlTypes.NpgsqlPoint(x: 0.16844400700381068d, y: 0.12301909389708587d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22465323255210434d, y: 0.15715741866637267d), new NpgsqlTypes.NpgsqlPoint(x: 0.2443081782822939d, y: 0.3030560710433745d), new NpgsqlTypes.NpgsqlPoint(x: 0.7688864785811634d, y: 0.46460939235773d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7831346002801127d, y: 0.8969207934034471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209161690508755d, y: 0.4777412274927417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337292691780863d, y: 0.6179339105151525d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9220103138452167d, y: 0.016999567789282466d), new NpgsqlTypes.NpgsqlPoint(x: 0.3903558332767584d, y: 0.3754874454636672d), new NpgsqlTypes.NpgsqlPoint(x: 0.6287257145415986d, y: 0.7951867226361036d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7085373964495655d, y: 0.40077143554996364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606313378193967d, y: 0.7285583677980149d), new NpgsqlTypes.NpgsqlPoint(x: 0.4533693971063306d, y: 0.9381608224630348d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19281078607909197d, y: 0.648428153391965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694620806369034d, y: 0.6956520227759355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540742379524863d, y: 0.0676726362858282d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9397864126811076d, y: 0.2657497912397915d), new NpgsqlTypes.NpgsqlPoint(x: 0.37644460317962103d, y: 0.9980544553760675d), new NpgsqlTypes.NpgsqlPoint(x: 0.3477151523281705d, y: 0.3337519262507307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7904197319877116d, y: 0.21303834971537472d), new NpgsqlTypes.NpgsqlPoint(x: 0.61576201877058d, y: 0.4314683612015433d), new NpgsqlTypes.NpgsqlPoint(x: 0.22995429417944224d, y: 0.4956173216362276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6658861498321719d, y: 0.5549108627454402d), new NpgsqlTypes.NpgsqlPoint(x: 0.4399474712599064d, y: 0.6581590259708973d), new NpgsqlTypes.NpgsqlPoint(x: 0.1515499529177896d, y: 0.3035068243061343d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2985871414286241d, y: 0.12081969317951202d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613977494538927d, y: 0.8169862918196337d), new NpgsqlTypes.NpgsqlPoint(x: 0.27978094532930387d, y: 0.3094616666131379d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4681944601425183d, y: 0.9139076098598937d), new NpgsqlTypes.NpgsqlPoint(x: 0.4117612662364406d, y: 0.48948689830527226d), new NpgsqlTypes.NpgsqlPoint(x: 0.29514654670868845d, y: 0.5952662593715384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29362024130774966d, y: 0.6271136590682154d), new NpgsqlTypes.NpgsqlPoint(x: 0.02626201063285938d, y: 0.5999934172561517d), new NpgsqlTypes.NpgsqlPoint(x: 0.18948914833264852d, y: 0.0667514113035993d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8692913582625268d, y: 0.4122937634960684d), new NpgsqlTypes.NpgsqlPoint(x: 0.684457066119761d, y: 0.2926104832208307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930016571968261d, y: 0.30712328518929355d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10750830206494921d, y: 0.348428651456851d), new NpgsqlTypes.NpgsqlPoint(x: 0.845166590531476d, y: 0.1394151661865124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7226121487061354d, y: 0.5316825938392973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9947868004809564d, y: 0.5739193106997144d), new NpgsqlTypes.NpgsqlPoint(x: 0.05377290574938609d, y: 0.027119042507030344d), new NpgsqlTypes.NpgsqlPoint(x: 0.611114904105914d, y: 0.014085942523815675d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13736661780915194d, y: 0.6720057377714562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288130777126562d, y: 0.48316377501976693d), new NpgsqlTypes.NpgsqlPoint(x: 0.4043294067594547d, y: 0.37446988309430573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10086008253504575d, y: 0.6120718840988019d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222195604690481d, y: 0.9725199436292317d), new NpgsqlTypes.NpgsqlPoint(x: 0.30551697859672267d, y: 0.7926989793452646d)),

},
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
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
                parametr1.Value = 107;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 81, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 147, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 159, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 147, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[34], false);
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
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 159, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[34], false);
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
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 114, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 25, 114))
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 14, 14))
                {
                    if(++resultIndex == 1)
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

