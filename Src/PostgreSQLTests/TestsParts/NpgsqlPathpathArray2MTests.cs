

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3476557353289311d, y: 0.5730107263931203d), new NpgsqlTypes.NpgsqlPoint(x: 0.4204568771645901d, y: 0.3236377920404576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4099439980298716d, y: 0.4415151779746743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21500596977117592d, y: 0.8323960330558046d), new NpgsqlTypes.NpgsqlPoint(x: 0.06367323636369482d, y: 0.13126636857579388d), new NpgsqlTypes.NpgsqlPoint(x: 0.3957243410611053d, y: 0.23938329406024172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6100274847673204d, y: 0.2737896359103499d), new NpgsqlTypes.NpgsqlPoint(x: 0.4513254861939755d, y: 0.2630235217531183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997874278976133d, y: 0.9055341622452802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224558297045647d, y: 0.2527828105308132d), new NpgsqlTypes.NpgsqlPoint(x: 0.025187140912292016d, y: 0.5530128355994718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490101511496824d, y: 0.01542949118301462d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2515391239892616d, y: 0.037103469469218164d), new NpgsqlTypes.NpgsqlPoint(x: 0.8232277222618958d, y: 0.7042116386113298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480768335979146d, y: 0.20461502252764885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019723201719176298d, y: 0.5970134379664527d), new NpgsqlTypes.NpgsqlPoint(x: 0.24847371009021313d, y: 0.9023180072988881d), new NpgsqlTypes.NpgsqlPoint(x: 0.552208390924134d, y: 0.3442438779878988d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7985964020444856d, y: 0.11691587689913152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8032167940953314d, y: 0.06337524358426139d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418721597869296d, y: 0.414454189513058d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7353125271817885d, y: 0.607309221322786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049882390721865d, y: 0.4005111329361414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828450295675131d, y: 0.5419968364106963d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.307156207096693d, y: 0.47737961460108247d), new NpgsqlTypes.NpgsqlPoint(x: 0.06057894923751783d, y: 0.7312272114266676d), new NpgsqlTypes.NpgsqlPoint(x: 0.552512247181384d, y: 0.1480156833249201d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23918441575191896d, y: 0.15453086178304742d), new NpgsqlTypes.NpgsqlPoint(x: 0.43820244199452274d, y: 0.17054051652162916d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321135002577271d, y: 0.5941668060670833d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.304481805003775d, y: 0.5058482167900098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182077473085126d, y: 0.1671635898778583d), new NpgsqlTypes.NpgsqlPoint(x: 0.09236939729895977d, y: 0.1377835718775231d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7841642370118345d, y: 0.33466005931503784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375938775633613d, y: 0.14432943820545274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014851873417835d, y: 0.34647559791717286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3688292745986541d, y: 0.5896426008506894d), new NpgsqlTypes.NpgsqlPoint(x: 0.36771400715586466d, y: 0.7032148615082411d), new NpgsqlTypes.NpgsqlPoint(x: 0.80251199953538d, y: 0.9646467351018857d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9578285628440439d, y: 0.7535377159387026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8438133403262315d, y: 0.7412300038158415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6351381912654753d, y: 0.19763464112817575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7300260988396348d, y: 0.9748765080080033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038060700426874d, y: 0.6112387636929794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3388340924291753d, y: 0.25464555034702985d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34607618376918947d, y: 0.2019095656047336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973739225185931d, y: 0.40338751673254514d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663084339458208d, y: 0.3596279926416921d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7997335130698675d, y: 0.5588620072305286d), new NpgsqlTypes.NpgsqlPoint(x: 0.18202800101599914d, y: 0.018890179016734288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322541146718465d, y: 0.968725178637597d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9772852150847986d, y: 0.25808518479896025d), new NpgsqlTypes.NpgsqlPoint(x: 0.17652081018914045d, y: 0.6071176920009262d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999115223227928d, y: 0.4929574032697689d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9599537528366835d, y: 0.45521271459470725d), new NpgsqlTypes.NpgsqlPoint(x: 0.441169206682266d, y: 0.3510842005231901d), new NpgsqlTypes.NpgsqlPoint(x: 0.9019791001903069d, y: 0.9680623511060008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.495927126211235d, y: 0.2250669695431986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5310030030559934d, y: 0.6502296066532303d), new NpgsqlTypes.NpgsqlPoint(x: 0.47528094468515303d, y: 0.6841311284644751d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6451399135316012d, y: 0.48997853592183505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541314556649785d, y: 0.40218439564140984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5646891893222136d, y: 0.7908012769689842d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9664171456760633d, y: 0.0069068169301206295d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775404611942194d, y: 0.04161329710016115d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849170751354195d, y: 0.48136020433759397d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9715824900704864d, y: 0.32395658750450684d), new NpgsqlTypes.NpgsqlPoint(x: 0.13018913058783088d, y: 0.5371553864757663d), new NpgsqlTypes.NpgsqlPoint(x: 0.1221171165969056d, y: 0.9263168992491331d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042373739608266736d, y: 0.9328954837425235d), new NpgsqlTypes.NpgsqlPoint(x: 0.2996738494382205d, y: 0.8854784950831474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776642796783603d, y: 0.49041179372300736d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9677280676090283d, y: 0.8158010434959924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9582513032883604d, y: 0.11951616413909916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8519933162375546d, y: 0.8683604807568766d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36814611670494046d, y: 0.4223825088637445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6903018686059884d, y: 0.7819932049168083d), new NpgsqlTypes.NpgsqlPoint(x: 0.27866876286434983d, y: 0.8358010799362704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3490847499362201d, y: 0.1443930238695723d), new NpgsqlTypes.NpgsqlPoint(x: 0.36732178638424084d, y: 0.05792691075212186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2863531912583748d, y: 0.9968457740416032d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6428362975904086d, y: 0.29524354919621487d), new NpgsqlTypes.NpgsqlPoint(x: 0.3084301632236035d, y: 0.9859886150108365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080558235302848d, y: 0.32138588053116035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5121676109960086d, y: 0.769858544005826d), new NpgsqlTypes.NpgsqlPoint(x: 0.3175461364016252d, y: 0.26140313507426205d), new NpgsqlTypes.NpgsqlPoint(x: 0.18159752380996164d, y: 0.662253826532114d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3744662361762904d, y: 0.8262787222280392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5957342915052821d, y: 0.5346848786057787d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618326527900292d, y: 0.8797112100122282d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.030840870324578606d, y: 0.40559073608517615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864215442356722d, y: 0.7623023139388352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6487314510003165d, y: 0.17617456930562125d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4215605984271801d, y: 0.3583395297312687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802849460392417d, y: 0.9016188482045713d), new NpgsqlTypes.NpgsqlPoint(x: 0.2419598826744911d, y: 0.498568383116364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04504856796887202d, y: 0.3620304294209937d), new NpgsqlTypes.NpgsqlPoint(x: 0.08832358677848395d, y: 0.40283569281584997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5083689304047498d, y: 0.7256957638244852d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3232146613751651d, y: 0.40395215544115715d), new NpgsqlTypes.NpgsqlPoint(x: 0.015333105771198952d, y: 0.09435285728160947d), new NpgsqlTypes.NpgsqlPoint(x: 0.22174579042832776d, y: 0.9083267255607493d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6189955949612912d, y: 0.13787833939388638d), new NpgsqlTypes.NpgsqlPoint(x: 0.042025087000267636d, y: 0.2510176503819903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8556686855472507d, y: 0.5641600434020042d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6440403715385924d, y: 0.2292425720868594d), new NpgsqlTypes.NpgsqlPoint(x: 0.10827633210817378d, y: 0.796789342477844d), new NpgsqlTypes.NpgsqlPoint(x: 0.4993709859958777d, y: 0.9134999107400349d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19886961857307883d, y: 0.7769290562493244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785566527556877d, y: 0.2889008164868174d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074282269725306d, y: 0.857084093381428d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5194810101167123d, y: 0.2841118480133805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424389650680668d, y: 0.7632687096264809d), new NpgsqlTypes.NpgsqlPoint(x: 0.583877203593191d, y: 0.4752125112490513d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8342849580366463d, y: 0.44063830789972125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566937503727825d, y: 0.17586882440861895d), new NpgsqlTypes.NpgsqlPoint(x: 0.952314167627644d, y: 0.14538683086320403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07754842207196488d, y: 0.6163632491631205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978774026198921d, y: 0.11067607197999174d), new NpgsqlTypes.NpgsqlPoint(x: 0.07645002469495499d, y: 0.7025126436390781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.673197074200524d, y: 0.3998026143268578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184720865700027d, y: 0.4005715962778842d), new NpgsqlTypes.NpgsqlPoint(x: 0.34628892303903924d, y: 0.7928704288634094d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5630608332137933d, y: 0.23670519270033252d), new NpgsqlTypes.NpgsqlPoint(x: 0.112258197404986d, y: 0.9581522830333081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742112583009066d, y: 0.18805080949108055d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41969092859324375d, y: 0.3824912059025294d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639712425240177d, y: 0.1815747182906764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857678415964045d, y: 0.4657572083085241d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9190037470468099d, y: 0.5139307362280371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968774638801407d, y: 0.5785153673749827d), new NpgsqlTypes.NpgsqlPoint(x: 0.05946285987578104d, y: 0.8865658489752312d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7504710593460402d, y: 0.17048632170425226d), new NpgsqlTypes.NpgsqlPoint(x: 0.061368103655462525d, y: 0.8605024926795958d), new NpgsqlTypes.NpgsqlPoint(x: 0.377220342785509d, y: 0.6152539760311041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8739152213969932d, y: 0.015429469590270695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6834564463000761d, y: 0.7011874826843997d), new NpgsqlTypes.NpgsqlPoint(x: 0.1982089991045174d, y: 0.3407939600721006d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9317194519610508d, y: 0.9759835362967564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267764698061776d, y: 0.17510259472530632d), new NpgsqlTypes.NpgsqlPoint(x: 0.31742973403219477d, y: 0.9644479782200337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9495795584168182d, y: 0.2257754866829358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7013325240019072d, y: 0.3398315824728676d), new NpgsqlTypes.NpgsqlPoint(x: 0.15770736861526014d, y: 0.9847637255719841d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38251043530803996d, y: 0.9396643397171918d), new NpgsqlTypes.NpgsqlPoint(x: 0.25241615812896756d, y: 0.027370688369238505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6744606735534627d, y: 0.5115044536486096d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3344723048633468d, y: 0.462377612962088d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684781373436763d, y: 0.06793924614788693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7694752179440244d, y: 0.8033438194379626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7895846714676865d, y: 0.03594486717241607d), new NpgsqlTypes.NpgsqlPoint(x: 0.5967333959671415d, y: 0.36028366231880404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9448436738286697d, y: 0.7692288227520641d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2455771326854187d, y: 0.9797352069503005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608327085651185d, y: 0.7366140458275491d), new NpgsqlTypes.NpgsqlPoint(x: 0.22350915291642492d, y: 0.7399483868435106d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08357403163705279d, y: 0.7688427144263128d), new NpgsqlTypes.NpgsqlPoint(x: 0.7966953027933693d, y: 0.8697880134058906d), new NpgsqlTypes.NpgsqlPoint(x: 0.3806909732741143d, y: 0.8529213837566706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.989169652827201d, y: 0.7411642336254594d), new NpgsqlTypes.NpgsqlPoint(x: 0.22267609810492517d, y: 0.07168891188997562d), new NpgsqlTypes.NpgsqlPoint(x: 0.12009894559735135d, y: 0.9824114244431605d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04914129190545724d, y: 0.0924189626074422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647417853127198d, y: 0.8661555479137053d), new NpgsqlTypes.NpgsqlPoint(x: 0.4678339120387439d, y: 0.31985879397989325d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5227832550394396d, y: 0.915504281156007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023828645206501d, y: 0.9158928210270044d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334848704240746d, y: 0.07333708160188823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03170794645978903d, y: 0.716357273128921d), new NpgsqlTypes.NpgsqlPoint(x: 0.2843681504417287d, y: 0.37502119544119983d), new NpgsqlTypes.NpgsqlPoint(x: 0.12271856195002584d, y: 0.4341862048158053d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07765874334476885d, y: 0.960790055765897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851664748354034d, y: 0.14185509576640598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009433553912809d, y: 0.2050459177995707d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7433282246974917d, y: 0.6818413164503957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801884187208822d, y: 0.792694433456639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729695386373902d, y: 0.493045770958668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4776047053422692d, y: 0.588140140053941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833121558023403d, y: 0.052992003924103304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9317435978030072d, y: 0.09634072843200392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3513598968160099d, y: 0.18761704186811023d), new NpgsqlTypes.NpgsqlPoint(x: 0.525876494384999d, y: 0.6606927985951613d), new NpgsqlTypes.NpgsqlPoint(x: 0.45393866086427115d, y: 0.800030619722387d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36773382108396624d, y: 0.9620300000201298d), new NpgsqlTypes.NpgsqlPoint(x: 0.4176215813426378d, y: 0.32949977964799193d), new NpgsqlTypes.NpgsqlPoint(x: 0.8868495704850271d, y: 0.9329570304992294d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6414035782798753d, y: 0.3440597424233044d), new NpgsqlTypes.NpgsqlPoint(x: 0.03750322405021056d, y: 0.5352695048395959d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650781833587307d, y: 0.05414912651103865d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.965721198275845d, y: 0.149645480284044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436942992729747d, y: 0.06766329817412997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600153457305566d, y: 0.10664203672015848d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5650547814446207d, y: 0.8948222339823633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576438404896903d, y: 0.0659839307204314d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747345495514822d, y: 0.4972311734932868d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3923512087024378d, y: 0.7871487288454707d), new NpgsqlTypes.NpgsqlPoint(x: 0.430670690818849d, y: 0.8830376048392173d), new NpgsqlTypes.NpgsqlPoint(x: 0.4446070530494364d, y: 0.04677113434361069d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8192642836683419d, y: 0.0073447477176161735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921150207698154d, y: 0.9677228729117553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7576440803768514d, y: 0.2570410149642851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6065979590829815d, y: 0.07088243051795073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513695018026215d, y: 0.4592375966933214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724667547093404d, y: 0.04427874555151945d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19492551250475432d, y: 0.8111430780213141d), new NpgsqlTypes.NpgsqlPoint(x: 0.0802857433640185d, y: 0.43177700589898127d), new NpgsqlTypes.NpgsqlPoint(x: 0.15946064524564285d, y: 0.23976365159352864d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8283063762017097d, y: 0.36718978584390094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628175312881183d, y: 0.5559604976829905d), new NpgsqlTypes.NpgsqlPoint(x: 0.1759530700630072d, y: 0.9621382390159137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8285291545440798d, y: 0.004898134036356971d), new NpgsqlTypes.NpgsqlPoint(x: 0.8590203601278811d, y: 0.5190184924888649d), new NpgsqlTypes.NpgsqlPoint(x: 0.4405894495409308d, y: 0.057941812731442055d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6446046718993572d, y: 0.6761666144149528d), new NpgsqlTypes.NpgsqlPoint(x: 0.622860593758515d, y: 0.011451857926452869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5684731867306682d, y: 0.6224376311565506d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40996323625363074d, y: 0.5118354883485231d), new NpgsqlTypes.NpgsqlPoint(x: 0.5043711782805557d, y: 0.24651505580906363d), new NpgsqlTypes.NpgsqlPoint(x: 0.1375000359612112d, y: 0.31207297282491486d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0993728224449959d, y: 0.17472631115666204d), new NpgsqlTypes.NpgsqlPoint(x: 0.3020972551417662d, y: 0.9838160946102992d), new NpgsqlTypes.NpgsqlPoint(x: 0.13524529306538646d, y: 0.23283423926288416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5218303742098087d, y: 0.24297426394768762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668005091233365d, y: 0.7958082699023653d), new NpgsqlTypes.NpgsqlPoint(x: 0.10880910926695153d, y: 0.10564631169547511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22421344684489253d, y: 0.5127266910114218d), new NpgsqlTypes.NpgsqlPoint(x: 0.35557141583670193d, y: 0.7352488559311305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544903888074795d, y: 0.3525414201108106d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2433714322214482d, y: 0.6683097833974145d), new NpgsqlTypes.NpgsqlPoint(x: 0.8410738931088171d, y: 0.7948356217577188d), new NpgsqlTypes.NpgsqlPoint(x: 0.325904648874939d, y: 0.9033444714065246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09550538246402929d, y: 0.07398716581776099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7428318804236502d, y: 0.8978677723073926d), new NpgsqlTypes.NpgsqlPoint(x: 0.1649956646529499d, y: 0.34962028213732266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3671746370085216d, y: 0.41398041382091555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428438009977209d, y: 0.3938126390680209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5974094863114682d, y: 0.3651322722487702d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6988999230003493d, y: 0.4889014429649172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863337838554369d, y: 0.2168578967785817d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688864532290211d, y: 0.3532386983853567d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.780926387464825d, y: 0.3346793506385042d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335993876786794d, y: 0.4506816202738174d), new NpgsqlTypes.NpgsqlPoint(x: 0.37436297127021567d, y: 0.7022553236366568d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7262431131620593d, y: 0.23323965101282118d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846636689664507d, y: 0.8506048267321589d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605340144448369d, y: 0.0018583842128618855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5542012554937176d, y: 0.8978160999464095d), new NpgsqlTypes.NpgsqlPoint(x: 0.027834755703044833d, y: 0.13727688603574117d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903280269005137d, y: 0.7183219829229237d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5300259995540232d, y: 0.6517322260277578d), new NpgsqlTypes.NpgsqlPoint(x: 0.8654486766119287d, y: 0.8865780917389541d), new NpgsqlTypes.NpgsqlPoint(x: 0.804663126348741d, y: 0.24588933909563881d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6725668508472118d, y: 0.5629957416515989d), new NpgsqlTypes.NpgsqlPoint(x: 0.195117202478729d, y: 0.31376754836905896d), new NpgsqlTypes.NpgsqlPoint(x: 0.04265454698407689d, y: 0.22704863855183155d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6344641391190733d, y: 0.62166507215801d), new NpgsqlTypes.NpgsqlPoint(x: 0.08524305424260603d, y: 0.34522018247941855d), new NpgsqlTypes.NpgsqlPoint(x: 0.010188906590664293d, y: 0.9095237271636271d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6814595751837603d, y: 0.35403884304095967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8506661406373581d, y: 0.6323637985981273d), new NpgsqlTypes.NpgsqlPoint(x: 0.08844214207147771d, y: 0.8277592790082342d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44836472977574127d, y: 0.25229534496309247d), new NpgsqlTypes.NpgsqlPoint(x: 0.02845804048842704d, y: 0.8039167539034667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5265239166971402d, y: 0.789531615870935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42150283730854754d, y: 0.9616473152820088d), new NpgsqlTypes.NpgsqlPoint(x: 0.652318972992299d, y: 0.4673061204355333d), new NpgsqlTypes.NpgsqlPoint(x: 0.45622910809862427d, y: 0.9778545871531328d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19449895249119986d, y: 0.021891186384746186d), new NpgsqlTypes.NpgsqlPoint(x: 0.028534771862062658d, y: 0.5018585130395263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7499197611059801d, y: 0.169822590612833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7064390905488799d, y: 0.2290563863588725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2959147433257313d, y: 0.22980375969455114d), new NpgsqlTypes.NpgsqlPoint(x: 0.40709486048094967d, y: 0.890597738399336d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49784023031809554d, y: 0.22470511970164986d), new NpgsqlTypes.NpgsqlPoint(x: 0.1770641608805944d, y: 0.15510158925754602d), new NpgsqlTypes.NpgsqlPoint(x: 0.0897807374383972d, y: 0.7589807017499045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9089885440182904d, y: 0.22337280851567853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994133041204924d, y: 0.6525223883702804d), new NpgsqlTypes.NpgsqlPoint(x: 0.82565273290778d, y: 0.2435324578063539d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39124353525821787d, y: 0.04236822470268731d), new NpgsqlTypes.NpgsqlPoint(x: 0.2853302952815102d, y: 0.9733273254753392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514343738563183d, y: 0.0727318882388358d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8514612691732353d, y: 0.22677678963540204d), new NpgsqlTypes.NpgsqlPoint(x: 0.11753592517155764d, y: 0.9999960800820799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9027852527687774d, y: 0.2953956145330372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23078858676119884d, y: 0.24581411387332053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618958522469196d, y: 0.15734640153274115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148395669194641d, y: 0.720376949392622d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054204070985853336d, y: 0.5161238736536687d), new NpgsqlTypes.NpgsqlPoint(x: 0.26438766351477094d, y: 0.03986886512738186d), new NpgsqlTypes.NpgsqlPoint(x: 0.23348890844641101d, y: 0.4946906184269555d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9419073297758658d, y: 0.46278436828096015d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155158548962774d, y: 0.10864622091612242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9482914598948436d, y: 0.5440411092002245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20459605725722718d, y: 0.4703667979716991d), new NpgsqlTypes.NpgsqlPoint(x: 0.39536797004860513d, y: 0.9491711805548129d), new NpgsqlTypes.NpgsqlPoint(x: 0.4163427239669295d, y: 0.07634014226784214d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6634058677841727d, y: 0.007890787512308761d), new NpgsqlTypes.NpgsqlPoint(x: 0.20936502724093142d, y: 0.6041970036054846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7266274580482517d, y: 0.3038317073447324d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8665341573981941d, y: 0.1888883156324178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8290915615650802d, y: 0.16804343043642422d), new NpgsqlTypes.NpgsqlPoint(x: 0.20697500974809246d, y: 0.3894608620036174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19324869963856017d, y: 0.31110745967107467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9886237283163058d, y: 0.886873170941225d), new NpgsqlTypes.NpgsqlPoint(x: 0.25676303918835186d, y: 0.9306118605976761d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4068253889772745d, y: 0.22348176774142625d), new NpgsqlTypes.NpgsqlPoint(x: 0.05014558276918346d, y: 0.17575993894829922d), new NpgsqlTypes.NpgsqlPoint(x: 0.43756486428518093d, y: 0.5152914869102396d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6416522535023356d, y: 0.6771195376685931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650563358887978d, y: 0.35726040390131997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8461210178881995d, y: 0.3688000194989731d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2941206596092538d, y: 0.7589378301413706d), new NpgsqlTypes.NpgsqlPoint(x: 0.41567250074281414d, y: 0.9253645323979197d), new NpgsqlTypes.NpgsqlPoint(x: 0.32537063463045657d, y: 0.24449202082901256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39240760452582657d, y: 0.7744903257485934d), new NpgsqlTypes.NpgsqlPoint(x: 0.7698194040814579d, y: 0.07322399812925373d), new NpgsqlTypes.NpgsqlPoint(x: 0.08384607911513264d, y: 0.07042624882241744d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7924229681605535d, y: 0.7669331109710752d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158999880546816d, y: 0.9076720566720463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842402287235165d, y: 0.22727484286065525d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6258193506084853d, y: 0.8386310932902459d), new NpgsqlTypes.NpgsqlPoint(x: 0.4541266929073361d, y: 0.25173305650676336d), new NpgsqlTypes.NpgsqlPoint(x: 0.3997972036237296d, y: 0.9685810350229536d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884156855261302d, y: 0.5403571500512057d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686173726039106d, y: 0.24111176341776985d), new NpgsqlTypes.NpgsqlPoint(x: 0.703527746072389d, y: 0.4106419650353881d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8081666916710619d, y: 0.39858203611848264d), new NpgsqlTypes.NpgsqlPoint(x: 0.05284558361973313d, y: 0.496297175532998d), new NpgsqlTypes.NpgsqlPoint(x: 0.007078272591664159d, y: 0.4380413122150729d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8199393901022396d, y: 0.9268080685386066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629513282199387d, y: 0.9045790428579207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768989799517005d, y: 0.03633304375298041d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9898115280840114d, y: 0.5092670457742599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5597805579843699d, y: 0.11832771749596194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6259254343848887d, y: 0.24351166378238898d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7804555598369094d, y: 0.8205954365555271d), new NpgsqlTypes.NpgsqlPoint(x: 0.9762998297900163d, y: 0.9617669798326655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4408019416581861d, y: 0.9663043337139717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23762665488663448d, y: 0.7657070169645152d), new NpgsqlTypes.NpgsqlPoint(x: 0.4704472759243443d, y: 0.09292403182097664d), new NpgsqlTypes.NpgsqlPoint(x: 0.047172827170407605d, y: 0.6391682344457217d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46133622622764914d, y: 0.6131216101535777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9074072430758163d, y: 0.7510540122372219d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122164200674158d, y: 0.18054678248380973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7837148349226538d, y: 0.32687024654147456d), new NpgsqlTypes.NpgsqlPoint(x: 0.22950867347301895d, y: 0.5581896894200464d), new NpgsqlTypes.NpgsqlPoint(x: 0.5436718462764917d, y: 0.6503028418182432d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8394924853666081d, y: 0.4088081308084158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278468011740447d, y: 0.5544171136220053d), new NpgsqlTypes.NpgsqlPoint(x: 0.06000760464457777d, y: 0.457632754533131d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9380610059155605d, y: 0.48111909421118126d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601277306489966d, y: 0.9069163653141036d), new NpgsqlTypes.NpgsqlPoint(x: 0.09984004534977697d, y: 0.5699879885005149d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4521012512207242d, y: 0.2585396285298367d), new NpgsqlTypes.NpgsqlPoint(x: 0.10033463605769954d, y: 0.4939695452633366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5487760564997353d, y: 0.9641929627489444d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05000361380328011d, y: 0.7332476611445145d), new NpgsqlTypes.NpgsqlPoint(x: 0.5008103765920776d, y: 0.8324163183944402d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998127584690595d, y: 0.2995414364551531d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6305592161896113d, y: 0.936850649671648d), new NpgsqlTypes.NpgsqlPoint(x: 0.38980585241288424d, y: 0.416745076061541d), new NpgsqlTypes.NpgsqlPoint(x: 0.33793757901825583d, y: 0.3372797853482067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.089709115918844d, y: 0.15415957799276547d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571644491300096d, y: 0.8151913799061449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991431567054014d, y: 0.00031662564922085856d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31969598735590443d, y: 0.7101393600207249d), new NpgsqlTypes.NpgsqlPoint(x: 0.4751832380561871d, y: 0.8079490453597822d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348830631860846d, y: 0.2763731625141991d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6959978354450219d, y: 0.4143311766378325d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882648215270835d, y: 0.934973212548641d), new NpgsqlTypes.NpgsqlPoint(x: 0.07487191424681905d, y: 0.3692201127602589d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07531683858430716d, y: 0.8823364952258576d), new NpgsqlTypes.NpgsqlPoint(x: 0.9221859067620359d, y: 0.17256355318909766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503036979389226d, y: 0.25894219848243083d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7215594417263002d, y: 0.48167189707438707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054604033156492d, y: 0.9841013527781329d), new NpgsqlTypes.NpgsqlPoint(x: 0.40384268148210034d, y: 0.9134184886145934d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3084303845749281d, y: 0.9599330234432238d), new NpgsqlTypes.NpgsqlPoint(x: 0.18684619119183243d, y: 0.25240320605407207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407292519285284d, y: 0.7984641230999662d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5981126865624702d, y: 0.258802447795889d), new NpgsqlTypes.NpgsqlPoint(x: 0.605549034716911d, y: 0.155282050265252d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694848373800301d, y: 0.5304225673531772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012356908724359239d, y: 0.32628784701090696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222563921155303d, y: 0.7639458919960735d), new NpgsqlTypes.NpgsqlPoint(x: 0.17387226016911772d, y: 0.03235113332836903d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8485130091785639d, y: 0.10370775484339678d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877066458697225d, y: 0.18622719311429314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668233849244247d, y: 0.9363110071325476d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6781451996687736d, y: 0.8784778214731866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3418647118261402d, y: 0.12029988631126731d), new NpgsqlTypes.NpgsqlPoint(x: 0.38350791286330144d, y: 0.9214126996682287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5572025065370648d, y: 0.6362553247930136d), new NpgsqlTypes.NpgsqlPoint(x: 0.36958942777552584d, y: 0.00021707922919877998d), new NpgsqlTypes.NpgsqlPoint(x: 0.028843173180143733d, y: 0.22520059689378713d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7969219947557974d, y: 0.627452636872385d), new NpgsqlTypes.NpgsqlPoint(x: 0.29775305056930035d, y: 0.1469340365789139d), new NpgsqlTypes.NpgsqlPoint(x: 0.5130091701202355d, y: 0.19294655476875777d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7883476378073518d, y: 0.9775795191737812d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039767812196573d, y: 0.7184261947169385d), new NpgsqlTypes.NpgsqlPoint(x: 0.30519968889852067d, y: 0.19787980484479017d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04389821869357968d, y: 0.4867544822874641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5391591280431923d, y: 0.3678048044751544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768277208560417d, y: 0.8466419618556947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.50661042904285d, y: 0.13327945009115438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6492781848305003d, y: 0.951030610582634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494328769743413d, y: 0.9964281981179302d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49720033539264086d, y: 0.4651366781393417d), new NpgsqlTypes.NpgsqlPoint(x: 0.855276472755102d, y: 0.2441719023617991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715342853064332d, y: 0.536808336751379d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.330112753915065d, y: 0.7686228246711353d), new NpgsqlTypes.NpgsqlPoint(x: 0.1295062277163842d, y: 0.8625140865526763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661294447788631d, y: 0.7903355083974589d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5666132793145666d, y: 0.07307801705986561d), new NpgsqlTypes.NpgsqlPoint(x: 0.09428625340669239d, y: 0.8212091253901191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7785902647982345d, y: 0.10305429026529678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8508985387872176d, y: 0.2585407236148104d), new NpgsqlTypes.NpgsqlPoint(x: 0.752269096823093d, y: 0.7758989419877526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393494779046055d, y: 0.870737505608793d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.630468662875937d, y: 0.1847362373339998d), new NpgsqlTypes.NpgsqlPoint(x: 0.3815000781172191d, y: 0.7484453420222725d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647101632237904d, y: 0.7959026793502114d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8319823420254904d, y: 0.7449908576960175d), new NpgsqlTypes.NpgsqlPoint(x: 0.10765948985391915d, y: 0.6414060107185012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9172641331440294d, y: 0.9896463308903239d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5836811798824093d, y: 0.15934893194502275d), new NpgsqlTypes.NpgsqlPoint(x: 0.2419120168694825d, y: 0.27825882426049997d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199076122922986d, y: 0.01992892965010984d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5602918359508651d, y: 0.1399324048277636d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953645711901089d, y: 0.6052947284436447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878141528356057d, y: 0.4648873089512503d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34093464783786787d, y: 0.37526116912480956d), new NpgsqlTypes.NpgsqlPoint(x: 0.47017356002116484d, y: 0.08080315374671221d), new NpgsqlTypes.NpgsqlPoint(x: 0.29029578479714824d, y: 0.5939714070239124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.718678281595669d, y: 0.274060880628917d), new NpgsqlTypes.NpgsqlPoint(x: 0.4054911814964427d, y: 0.3706796676422405d), new NpgsqlTypes.NpgsqlPoint(x: 0.2766502851778996d, y: 0.17391793606792771d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.312649300024634d, y: 0.38009987951232704d), new NpgsqlTypes.NpgsqlPoint(x: 0.41124072699536784d, y: 0.5015334016454818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056984270815352d, y: 0.6634786121862549d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47575853300798854d, y: 0.8646275437981332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6415040185968554d, y: 0.1248355427858836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995828583332806d, y: 0.1881240040989074d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4533748045417346d, y: 0.5758175154377075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7151735259493781d, y: 0.900301940282162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883036222760321d, y: 0.6937019662067496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03553018894748483d, y: 0.1838178277702801d), new NpgsqlTypes.NpgsqlPoint(x: 0.313084647980048d, y: 0.40187579020761954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045217800677383d, y: 0.8104244999709559d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.95269735891973d, y: 0.7871492184793792d), new NpgsqlTypes.NpgsqlPoint(x: 0.0578131352386585d, y: 0.3105698886430509d), new NpgsqlTypes.NpgsqlPoint(x: 0.38685014955284325d, y: 0.8017546954822443d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1320347682700539d, y: 0.19883969746557917d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066925164107593d, y: 0.9964015825740613d), new NpgsqlTypes.NpgsqlPoint(x: 0.7362859394749633d, y: 0.5776494134767567d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7954927308708046d, y: 0.9640042544045803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9449254527350962d, y: 0.39591383898383714d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444845651557067d, y: 0.5161911556418972d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5834755678231185d, y: 0.43212063573028137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9767545402915873d, y: 0.625639673470881d), new NpgsqlTypes.NpgsqlPoint(x: 0.60099098965094d, y: 0.9839144120034549d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08300353221304624d, y: 0.9851504045877606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394886461731594d, y: 0.18718138336893153d), new NpgsqlTypes.NpgsqlPoint(x: 0.027656104473053778d, y: 0.3962996243101683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36490165998880264d, y: 0.9360921319329317d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410097566583559d, y: 0.8805820530041423d), new NpgsqlTypes.NpgsqlPoint(x: 0.050751985090593865d, y: 0.332356598115528d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22794572220665543d, y: 0.32071957667274564d), new NpgsqlTypes.NpgsqlPoint(x: 0.28299023473651563d, y: 0.6952010375148963d), new NpgsqlTypes.NpgsqlPoint(x: 0.24533820343195223d, y: 0.90169387171713d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5804928215813443d, y: 0.05458629460333242d), new NpgsqlTypes.NpgsqlPoint(x: 0.43604885634977586d, y: 0.5858798203749851d), new NpgsqlTypes.NpgsqlPoint(x: 0.08621790115766148d, y: 0.0645490298625182d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5491855737623528d, y: 0.9124127051971604d), new NpgsqlTypes.NpgsqlPoint(x: 0.08989957817285466d, y: 0.369929778233992d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328177263652367d, y: 0.23112866864859205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5524814561678818d, y: 0.9652096175219439d), new NpgsqlTypes.NpgsqlPoint(x: 0.024854650874406636d, y: 0.4980862206194968d), new NpgsqlTypes.NpgsqlPoint(x: 0.4700146236328272d, y: 0.5030881550979787d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3281572766604274d, y: 0.41620861796839315d), new NpgsqlTypes.NpgsqlPoint(x: 0.4427205634072927d, y: 0.32277732606276355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260573805210161d, y: 0.9255539775538162d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4502385360133392d, y: 0.4497726078047407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6261537795517383d, y: 0.5934047541723623d), new NpgsqlTypes.NpgsqlPoint(x: 0.2776982554733515d, y: 0.1926506584958717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8131043456342109d, y: 0.10764277868956296d), new NpgsqlTypes.NpgsqlPoint(x: 0.13337357529757932d, y: 0.5923830060309548d), new NpgsqlTypes.NpgsqlPoint(x: 0.31015598387327714d, y: 0.12995984382036763d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6351999293630501d, y: 0.28773208692411967d), new NpgsqlTypes.NpgsqlPoint(x: 0.36090087097193524d, y: 0.5674278205953074d), new NpgsqlTypes.NpgsqlPoint(x: 0.15281045503707602d, y: 0.5806586852756834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17699019190058218d, y: 0.5658968055914808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5587250405478124d, y: 0.46516141437302705d), new NpgsqlTypes.NpgsqlPoint(x: 0.25110840553746405d, y: 0.9122360887106511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08623259056466615d, y: 0.1686107221331462d), new NpgsqlTypes.NpgsqlPoint(x: 0.22074757607168505d, y: 0.7703998153544696d), new NpgsqlTypes.NpgsqlPoint(x: 0.3130490644301338d, y: 0.24590733891489946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6466160485397832d, y: 0.9510647275019978d), new NpgsqlTypes.NpgsqlPoint(x: 0.21756337387664582d, y: 0.7180117053465435d), new NpgsqlTypes.NpgsqlPoint(x: 0.7471565098927005d, y: 0.49148381813226605d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28063526815208684d, y: 0.780822984749253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3366953422002057d, y: 0.4096426184485099d), new NpgsqlTypes.NpgsqlPoint(x: 0.021597044130216125d, y: 0.20887015304501177d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8659096074550277d, y: 0.8320005624508612d), new NpgsqlTypes.NpgsqlPoint(x: 0.679932239538895d, y: 0.5092569585634935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705048481072877d, y: 0.13859104841903414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04255447998325268d, y: 0.11218395146525484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832140416522462d, y: 0.28826881290420514d), new NpgsqlTypes.NpgsqlPoint(x: 0.15641127761887985d, y: 0.6605927064043515d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6791514878485967d, y: 0.2622032867378955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8229577286642689d, y: 0.09475193771641899d), new NpgsqlTypes.NpgsqlPoint(x: 0.8295896984062753d, y: 0.18565310503323829d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5544522619743345d, y: 0.5799966594595901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6282097390124989d, y: 0.4132697972692768d), new NpgsqlTypes.NpgsqlPoint(x: 0.1600638215273268d, y: 0.03216573552803981d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03921351287052588d, y: 0.7900747543240644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851636218788104d, y: 0.17534078099067163d), new NpgsqlTypes.NpgsqlPoint(x: 0.27752144082583186d, y: 0.030162754052443286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8017729334210402d, y: 0.5617142978693997d), new NpgsqlTypes.NpgsqlPoint(x: 0.2191464332833588d, y: 0.3349653934817105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07009571312521201d, y: 0.3773652287282062d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6897792003059303d, y: 0.5426753527629679d), new NpgsqlTypes.NpgsqlPoint(x: 0.37663593301962983d, y: 0.7805686778099118d), new NpgsqlTypes.NpgsqlPoint(x: 0.30751142721828517d, y: 0.43940291793520136d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16442707800735945d, y: 0.8445546709980409d), new NpgsqlTypes.NpgsqlPoint(x: 0.6980511300420089d, y: 0.8571390437462877d), new NpgsqlTypes.NpgsqlPoint(x: 0.09061056986341642d, y: 0.9061532406618507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4531633955709766d, y: 0.2556573019474149d), new NpgsqlTypes.NpgsqlPoint(x: 0.3316555264195462d, y: 0.060604329233416854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4316303519973399d, y: 0.06927192874200383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21377818992247932d, y: 0.7495734012330098d), new NpgsqlTypes.NpgsqlPoint(x: 0.1964807887317246d, y: 0.21342097964257722d), new NpgsqlTypes.NpgsqlPoint(x: 0.38225540000027425d, y: 0.9163857418988804d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8056260618044183d, y: 0.6631870761103351d), new NpgsqlTypes.NpgsqlPoint(x: 0.26699246969467116d, y: 0.4022363685575112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243096263102276d, y: 0.15916260409556915d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8070052041103889d, y: 0.020275982263124326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5653908425199825d, y: 0.7952942730532626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859620860121362d, y: 0.22348515450444517d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4674961966189237d, y: 0.2439675396374419d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020649240252306d, y: 0.5404307034332148d), new NpgsqlTypes.NpgsqlPoint(x: 0.351577068526038d, y: 0.14851217123043703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21194330644393633d, y: 0.9858202883455505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5946682170828559d, y: 0.3285453508812918d), new NpgsqlTypes.NpgsqlPoint(x: 0.9820617956872509d, y: 0.4783602759543031d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48876899214293046d, y: 0.9690075844970498d), new NpgsqlTypes.NpgsqlPoint(x: 0.4568475774515264d, y: 0.9451677547944016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6269291285561835d, y: 0.8469452167357708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7463788306938706d, y: 0.4495290320806882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7946436777081421d, y: 0.010980335459125357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9723787571033878d, y: 0.6607018426171963d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6553209987986849d, y: 0.027485218935253686d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326983406687355d, y: 0.6222741567895416d), new NpgsqlTypes.NpgsqlPoint(x: 0.011738340342547171d, y: 0.9849631692045806d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20710761855757487d, y: 0.2835851494774134d), new NpgsqlTypes.NpgsqlPoint(x: 0.2426552237965669d, y: 0.7800477243862538d), new NpgsqlTypes.NpgsqlPoint(x: 0.23112458079857268d, y: 0.5397874255927626d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9407785298335871d, y: 0.8016645864519147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863156059062177d, y: 0.5451806140485432d), new NpgsqlTypes.NpgsqlPoint(x: 0.15782683480984172d, y: 0.6105383009567732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8475978633909164d, y: 0.050174523629990975d), new NpgsqlTypes.NpgsqlPoint(x: 0.4674611797292957d, y: 0.9210946440919253d), new NpgsqlTypes.NpgsqlPoint(x: 0.24452962009542112d, y: 0.30863569435362836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9635384960416274d, y: 0.7867729743971102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702451444106457d, y: 0.2768506630789612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566828304088257d, y: 0.035490246528756875d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16905747395215953d, y: 0.3756780474995376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899598365874649d, y: 0.6826294744681063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6509937784424834d, y: 0.9176913674163846d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35116557329190234d, y: 0.38545086314512056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926993255720794d, y: 0.09716720656728872d), new NpgsqlTypes.NpgsqlPoint(x: 0.4310089189368921d, y: 0.2741295321926812d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9583330928200586d, y: 0.6366932797831923d), new NpgsqlTypes.NpgsqlPoint(x: 0.07228848304049162d, y: 0.6903215427387381d), new NpgsqlTypes.NpgsqlPoint(x: 0.1984871050265079d, y: 0.23279399407189727d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4641116095400918d, y: 0.33379062539191484d), new NpgsqlTypes.NpgsqlPoint(x: 0.3891051804414407d, y: 0.6506616289504406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6304300742056113d, y: 0.22343752074952572d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35899549621753835d, y: 0.4131687707184747d), new NpgsqlTypes.NpgsqlPoint(x: 0.4088723591703307d, y: 0.8050260251068629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150453877131147d, y: 0.1598716728542804d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9075426525214381d, y: 0.2631306775145452d), new NpgsqlTypes.NpgsqlPoint(x: 0.3124611597508504d, y: 0.19406457329334414d), new NpgsqlTypes.NpgsqlPoint(x: 0.025603420204968086d, y: 0.555448625645708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.781894077867428d, y: 0.22188863677374338d), new NpgsqlTypes.NpgsqlPoint(x: 0.526912594338066d, y: 0.01954444359316454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3560134428059283d, y: 0.2176293044914327d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10720015715493547d, y: 0.6544657839952616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6970163311525197d, y: 0.959031453942061d), new NpgsqlTypes.NpgsqlPoint(x: 0.6492348928204644d, y: 0.9623071834266288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.832975207053352d, y: 0.325464171706376d), new NpgsqlTypes.NpgsqlPoint(x: 0.6432533650436558d, y: 0.4008382513893658d), new NpgsqlTypes.NpgsqlPoint(x: 0.13889102767124117d, y: 0.9971952685967195d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22422222445735285d, y: 0.5271993363105708d), new NpgsqlTypes.NpgsqlPoint(x: 0.594845713652807d, y: 0.4112656402645195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8206017192304105d, y: 0.8756624033564061d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33873595539397816d, y: 0.6305913703884156d), new NpgsqlTypes.NpgsqlPoint(x: 0.2185072285743178d, y: 0.3285015528067624d), new NpgsqlTypes.NpgsqlPoint(x: 0.2049081257761427d, y: 0.9734804239867949d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22934721999807361d, y: 0.6456417317389808d), new NpgsqlTypes.NpgsqlPoint(x: 0.7497832806789253d, y: 0.6916045675911826d), new NpgsqlTypes.NpgsqlPoint(x: 0.19131055851592083d, y: 0.8602748806497518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2894545713881468d, y: 0.7876952090357424d), new NpgsqlTypes.NpgsqlPoint(x: 0.17317862069419376d, y: 0.7737306612988146d), new NpgsqlTypes.NpgsqlPoint(x: 0.780901480003827d, y: 0.16987303635443585d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20277530943688415d, y: 0.5216658466160774d), new NpgsqlTypes.NpgsqlPoint(x: 0.0879910506476832d, y: 0.16430257338320076d), new NpgsqlTypes.NpgsqlPoint(x: 0.08350255959834019d, y: 0.13667571320979732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1042049416446289d, y: 0.20269060343617562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828858490804739d, y: 0.7043519335723212d), new NpgsqlTypes.NpgsqlPoint(x: 0.90450498577277d, y: 0.6648243837827976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5744484691264492d, y: 0.5499110365274518d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894416134744238d, y: 0.5554790858288687d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717001328507203d, y: 0.7339474099596797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02262550095651683d, y: 0.876933313055599d), new NpgsqlTypes.NpgsqlPoint(x: 0.875254177944505d, y: 0.6093020712000073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292150345920221d, y: 0.370136625110303d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9647266920212204d, y: 0.2146316365642691d), new NpgsqlTypes.NpgsqlPoint(x: 0.49021298199644225d, y: 0.09474489355079885d), new NpgsqlTypes.NpgsqlPoint(x: 0.60808832814073d, y: 0.13990169530826435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4473380043545112d, y: 0.5774727511750964d), new NpgsqlTypes.NpgsqlPoint(x: 0.044944641568245736d, y: 0.2288892533485598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783451953241618d, y: 0.21225307249653969d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18593665056231357d, y: 0.5323088792721099d), new NpgsqlTypes.NpgsqlPoint(x: 0.3913558665230733d, y: 0.6546170989124331d), new NpgsqlTypes.NpgsqlPoint(x: 0.7555789049003038d, y: 0.11376273303908113d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3592844992909895d, y: 0.2947083969395853d), new NpgsqlTypes.NpgsqlPoint(x: 0.20410916791354627d, y: 0.16557268213258014d), new NpgsqlTypes.NpgsqlPoint(x: 0.38886844267058696d, y: 0.9387222868899423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8489877418273734d, y: 0.35021577982933283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769433021269883d, y: 0.966788657243868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943389323179401d, y: 0.33014439795146133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.848757145357351d, y: 0.9301720678745203d), new NpgsqlTypes.NpgsqlPoint(x: 0.6823386361715655d, y: 0.8791815955093408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223743973853696d, y: 0.878556794802081d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7296143143827633d, y: 0.7773094591464257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156349030406269d, y: 0.8539863784409493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239910137078676d, y: 0.4050322706634477d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019300825250789577d, y: 0.22817346568768793d), new NpgsqlTypes.NpgsqlPoint(x: 0.41280362288110717d, y: 0.6579141920455761d), new NpgsqlTypes.NpgsqlPoint(x: 0.1753521907992016d, y: 0.8214300869926935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6354120202299854d, y: 0.11770378573838436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593100111423866d, y: 0.36615973595709805d), new NpgsqlTypes.NpgsqlPoint(x: 0.17579907999534694d, y: 0.15196802327229852d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9742677220000708d, y: 0.05533099512543338d), new NpgsqlTypes.NpgsqlPoint(x: 0.24298312916047404d, y: 0.6663775983404101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462186347442165d, y: 0.21619059085555448d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1280547329183106d, y: 0.012379495925568085d), new NpgsqlTypes.NpgsqlPoint(x: 0.06237374673135221d, y: 0.409200544913655d), new NpgsqlTypes.NpgsqlPoint(x: 0.19805810910160693d, y: 0.47458682968629795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517793576558242d, y: 0.7659491621643658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9298173646698733d, y: 0.1579278394780793d), new NpgsqlTypes.NpgsqlPoint(x: 0.04875410130445468d, y: 0.9754448162961644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49068728805715345d, y: 0.43044517308752206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005468309257686d, y: 0.6965406651639703d), new NpgsqlTypes.NpgsqlPoint(x: 0.430273569965521d, y: 0.1357411199650953d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8367023109881532d, y: 0.29426797241367153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875615833920407d, y: 0.8203804915889997d), new NpgsqlTypes.NpgsqlPoint(x: 0.18737572378661738d, y: 0.2879317563525816d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5962775648664252d, y: 0.43534477649324155d), new NpgsqlTypes.NpgsqlPoint(x: 0.28977020802867537d, y: 0.06303559551914517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415223937454364d, y: 0.4706807924800187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01190649522279319d, y: 0.9704380307503321d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829441276600378d, y: 0.7907330733590899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7305741752913678d, y: 0.37536994787310374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33672927773096417d, y: 0.126549921383719d), new NpgsqlTypes.NpgsqlPoint(x: 0.15782273380435963d, y: 0.8959829598712151d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249466255070832d, y: 0.7050648135699396d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5874439446540072d, y: 0.40845242210034993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735028453529433d, y: 0.7159164182227906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8293622736388925d, y: 0.7727619113420637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2041792003106666d, y: 0.059761034415644954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8951103229209407d, y: 0.8039060653583291d), new NpgsqlTypes.NpgsqlPoint(x: 0.0885278041799955d, y: 0.62256457399666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4019894035031847d, y: 0.024957385196546222d), new NpgsqlTypes.NpgsqlPoint(x: 0.5003718654835536d, y: 0.6365470701662985d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749979108920612d, y: 0.9978201090310446d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8631110618829346d, y: 0.633740587246008d), new NpgsqlTypes.NpgsqlPoint(x: 0.27009991809223854d, y: 0.6163222204638686d), new NpgsqlTypes.NpgsqlPoint(x: 0.07053086210840687d, y: 0.17152324577020506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7626425234133525d, y: 0.7039968854597154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246421062890577d, y: 0.7937701011052924d), new NpgsqlTypes.NpgsqlPoint(x: 0.17900024718516272d, y: 0.7114977198503569d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6706646695011833d, y: 0.39011033921915295d), new NpgsqlTypes.NpgsqlPoint(x: 0.071710421920548d, y: 0.0885649341276038d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162131513907773d, y: 0.6273745539829878d)),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 36;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 101, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 63, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 29, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 84, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 63, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 68, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 9, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

