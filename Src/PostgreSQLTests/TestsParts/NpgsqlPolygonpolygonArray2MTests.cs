

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
    internal partial interface INpgsqlPolygonListpolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonArray : INpgsqlPolygonListpolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray2M[] _testData = new NpgsqlPolygonpolygonArray2M[]
        {
            new NpgsqlPolygonpolygonArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6475703454269488d, y: 0.34159431592022094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933808461884482d, y: 0.9065347378221338d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761551007476716d, y: 0.2383561979928699d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0861239901191353d, y: 0.3348867384260247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038015616146413d, y: 0.5016505123424028d), new NpgsqlTypes.NpgsqlPoint(x: 0.43048962578981176d, y: 0.05222559880805777d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18216988469005346d, y: 0.4410592597262023d), new NpgsqlTypes.NpgsqlPoint(x: 0.31591187611395866d, y: 0.9166645952589907d), new NpgsqlTypes.NpgsqlPoint(x: 0.9488854550694447d, y: 0.350782264330038d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2418057706109289d, y: 0.9134872774376822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9100080535994779d, y: 0.8796408192108204d), new NpgsqlTypes.NpgsqlPoint(x: 0.3837836809293579d, y: 0.9456680255452079d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22824587284533826d, y: 0.3375019933433753d), new NpgsqlTypes.NpgsqlPoint(x: 0.35352469425184063d, y: 0.5395761702756778d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065039599090497d, y: 0.7709884896032498d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18197601711385059d, y: 0.008486778390461414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799476806008096d, y: 0.42256888092944833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7669819263204548d, y: 0.6116375883521721d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.529597375502546d, y: 0.971586197907859d), new NpgsqlTypes.NpgsqlPoint(x: 0.9681247686196133d, y: 0.8031977795010387d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525014933367387d, y: 0.22655956010748057d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20674611458843206d, y: 0.2884909565710506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433216446969654d, y: 0.7068441046754764d), new NpgsqlTypes.NpgsqlPoint(x: 0.944814424588752d, y: 0.465585501566544d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8430123928015213d, y: 0.9804783286575462d), new NpgsqlTypes.NpgsqlPoint(x: 0.31302655386054845d, y: 0.4306249442063643d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474919274844224d, y: 0.12027893851004001d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.329202810749746d, y: 0.7733970130844522d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572229496314568d, y: 0.8327003356616162d), new NpgsqlTypes.NpgsqlPoint(x: 0.24026929250000084d, y: 0.7196551370374382d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9701797551207417d, y: 0.10652300370035617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7669273378307704d, y: 0.21043590200136308d), new NpgsqlTypes.NpgsqlPoint(x: 0.45599513038477435d, y: 0.8371859597720308d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8400150065834472d, y: 0.37995549739468626d), new NpgsqlTypes.NpgsqlPoint(x: 0.3099028403257228d, y: 0.8046787120602454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813830274853913d, y: 0.13077777014133762d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6859433922455695d, y: 0.2502469025717312d), new NpgsqlTypes.NpgsqlPoint(x: 0.1983338850190126d, y: 0.7331357797027789d), new NpgsqlTypes.NpgsqlPoint(x: 0.1746476020008526d, y: 0.7029312848874686d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20204905506191517d, y: 0.9010289585631823d), new NpgsqlTypes.NpgsqlPoint(x: 0.5898790030976648d, y: 0.9256877957747459d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836475834330281d, y: 0.43976961068914955d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45943307408193934d, y: 0.12319405480932677d), new NpgsqlTypes.NpgsqlPoint(x: 0.26783100333080123d, y: 0.0684407548955609d), new NpgsqlTypes.NpgsqlPoint(x: 0.5594566142536391d, y: 0.6432946858145313d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4053748557598894d, y: 0.5915312090102359d), new NpgsqlTypes.NpgsqlPoint(x: 0.592228011922656d, y: 0.9980055587858279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9699964393025974d, y: 0.6761981637045528d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8235704642297258d, y: 0.8716143484166876d), new NpgsqlTypes.NpgsqlPoint(x: 0.258789384901956d, y: 0.0955006740764418d), new NpgsqlTypes.NpgsqlPoint(x: 0.5892619220657159d, y: 0.5511848078869009d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21637231463246298d, y: 0.7358134720939936d), new NpgsqlTypes.NpgsqlPoint(x: 0.08324687836982214d, y: 0.35326781232407845d), new NpgsqlTypes.NpgsqlPoint(x: 0.207177780767134d, y: 0.948710743581803d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9741108000514818d, y: 0.08727822809999009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473598434940106d, y: 0.22652062871468737d), new NpgsqlTypes.NpgsqlPoint(x: 0.24718085970356007d, y: 0.4291326654913321d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7312494435827022d, y: 0.4889806845890521d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557189698774652d, y: 0.8877180031282559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475067190848172d, y: 0.6687213364635742d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26924651136037736d, y: 0.9645874548862037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234119954409406d, y: 0.7812847303752923d), new NpgsqlTypes.NpgsqlPoint(x: 0.30468001929725663d, y: 0.8305235388466801d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41252768381002913d, y: 0.6173030929432519d), new NpgsqlTypes.NpgsqlPoint(x: 0.7049857430159012d, y: 0.8383574357582797d), new NpgsqlTypes.NpgsqlPoint(x: 0.24526819169437097d, y: 0.7995541406919566d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09667246553663d, y: 0.8246745728890859d), new NpgsqlTypes.NpgsqlPoint(x: 0.1796534956665482d, y: 0.2650450775977736d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590144231849357d, y: 0.24948099666246015d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5605370022878121d, y: 0.001027440541407243d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065326191648278d, y: 0.4262290200976211d), new NpgsqlTypes.NpgsqlPoint(x: 0.2226374879606725d, y: 0.9691608242488263d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8760419177609716d, y: 0.16421082555804067d), new NpgsqlTypes.NpgsqlPoint(x: 0.1632520156518863d, y: 0.08859041460891437d), new NpgsqlTypes.NpgsqlPoint(x: 0.3077093214098763d, y: 0.8100863766873285d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6625317553709599d, y: 0.7166502879695731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286032205354602d, y: 0.6103344229444568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420560382722767d, y: 0.6350021368928861d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4486250440783829d, y: 0.7007217381058416d), new NpgsqlTypes.NpgsqlPoint(x: 0.27387642014713387d, y: 0.37484979059847945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5936007080809466d, y: 0.5519185598714603d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8368239217047012d, y: 0.019425430333990912d), new NpgsqlTypes.NpgsqlPoint(x: 0.36601124398000284d, y: 0.2808024237066076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9450708377116136d, y: 0.188345720040612d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.846524851019773d, y: 0.04387594343167467d), new NpgsqlTypes.NpgsqlPoint(x: 0.3126666295703424d, y: 0.8843074150771386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774299038136627d, y: 0.860134810520459d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6340296106303682d, y: 0.2375733700227558d), new NpgsqlTypes.NpgsqlPoint(x: 0.54484088850628d, y: 0.9360019088028196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651220266226404d, y: 0.13662624209078844d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5596515884507953d, y: 0.35244789895616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805981116771177d, y: 0.9398442575737986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3103708701323121d, y: 0.12145230631934611d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.614981926387235d, y: 0.9562781725363403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934734776803755d, y: 0.0922507068258932d), new NpgsqlTypes.NpgsqlPoint(x: 0.006216168321088622d, y: 0.6001187028025318d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15144046471976136d, y: 0.6792048474449286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204576986829706d, y: 0.00014960949439979387d), new NpgsqlTypes.NpgsqlPoint(x: 0.44601497831672865d, y: 0.6583639746638643d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.040586681763158605d, y: 0.7635141642411631d), new NpgsqlTypes.NpgsqlPoint(x: 0.9655745417706844d, y: 0.09315445849190518d), new NpgsqlTypes.NpgsqlPoint(x: 0.796928184672838d, y: 0.9982512655347802d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5063611131085934d, y: 0.0759201205218265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251683185691944d, y: 0.6354411333527934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6158904553270937d, y: 0.7196338701725161d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9493401035035625d, y: 0.10967614890597854d), new NpgsqlTypes.NpgsqlPoint(x: 0.054319684190685114d, y: 0.6739959773220332d), new NpgsqlTypes.NpgsqlPoint(x: 0.01768203912469779d, y: 0.5985970455332058d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.681622384329699d, y: 0.8590288321696328d), new NpgsqlTypes.NpgsqlPoint(x: 0.02019963906240063d, y: 0.3009061606258997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9409039896283491d, y: 0.2403664722841078d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9508467299838534d, y: 0.9905520236078648d), new NpgsqlTypes.NpgsqlPoint(x: 0.36663046720283d, y: 0.5328072484152557d), new NpgsqlTypes.NpgsqlPoint(x: 0.18010787654035232d, y: 0.3696839993592661d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9361872080253053d, y: 0.2808072251957069d), new NpgsqlTypes.NpgsqlPoint(x: 0.22078501417001328d, y: 0.4134060721937661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715474915288493d, y: 0.36929490974231427d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5339279059714326d, y: 0.9129270016823116d), new NpgsqlTypes.NpgsqlPoint(x: 0.1374799004053625d, y: 0.3297912297157566d), new NpgsqlTypes.NpgsqlPoint(x: 0.3771891436062833d, y: 0.9377485021699742d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5453826280344835d, y: 0.047931644245861715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343723675787857d, y: 0.7465566739977172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705798609693319d, y: 0.8573455447619475d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.888511045772935d, y: 0.48855490216997244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7430836362670392d, y: 0.2572078831136969d), new NpgsqlTypes.NpgsqlPoint(x: 0.701612375228756d, y: 0.7424683283130722d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8243927229973759d, y: 0.13779417106278802d), new NpgsqlTypes.NpgsqlPoint(x: 0.9546774431402507d, y: 0.4649717441920903d), new NpgsqlTypes.NpgsqlPoint(x: 0.08215526500373926d, y: 0.6932031765432316d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5481037686291126d, y: 0.3856762662491797d), new NpgsqlTypes.NpgsqlPoint(x: 0.08894201861126694d, y: 0.5889364438542517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9715780607926923d, y: 0.5980396693658182d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3146198711079198d, y: 0.10744272227775176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784599943962185d, y: 0.7940398653249017d), new NpgsqlTypes.NpgsqlPoint(x: 0.1549130888174548d, y: 0.2613670318696556d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.995422060643041d, y: 0.8514979240890498d), new NpgsqlTypes.NpgsqlPoint(x: 0.6010641910961935d, y: 0.9827315586473534d), new NpgsqlTypes.NpgsqlPoint(x: 0.495904082385769d, y: 0.02608779169999942d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6338375856172913d, y: 0.7079985614269589d), new NpgsqlTypes.NpgsqlPoint(x: 0.10880268178425878d, y: 0.6939813367706379d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731516593763606d, y: 0.38489144943372633d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9150683817977697d, y: 0.4676821210186759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142324934903877d, y: 0.7771433822131341d), new NpgsqlTypes.NpgsqlPoint(x: 0.05460274903908835d, y: 0.8364736341115486d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7569161055539867d, y: 0.4742952709371029d), new NpgsqlTypes.NpgsqlPoint(x: 0.4156341312692724d, y: 0.655330821485851d), new NpgsqlTypes.NpgsqlPoint(x: 0.07997624478886134d, y: 0.1118226245252516d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9086437145205122d, y: 0.30968696326525424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631069032146751d, y: 0.6255773102007502d), new NpgsqlTypes.NpgsqlPoint(x: 0.32487175915421296d, y: 0.7712197046612348d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3249248565063554d, y: 0.8549009099474708d), new NpgsqlTypes.NpgsqlPoint(x: 0.46821501063979787d, y: 0.7028051698863904d), new NpgsqlTypes.NpgsqlPoint(x: 0.9019629062710237d, y: 0.6904065715842134d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18257259574675444d, y: 0.8240929142077884d), new NpgsqlTypes.NpgsqlPoint(x: 0.3001916177341506d, y: 0.9905539841288183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848101019440806d, y: 0.3334354718542295d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5182352416186896d, y: 0.5846399253837845d), new NpgsqlTypes.NpgsqlPoint(x: 0.848923285169071d, y: 0.1258695514782664d), new NpgsqlTypes.NpgsqlPoint(x: 0.18342799398236675d, y: 0.17112252539707629d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7266539812163694d, y: 0.7052716689649379d), new NpgsqlTypes.NpgsqlPoint(x: 0.387303682707437d, y: 0.6690676381494635d), new NpgsqlTypes.NpgsqlPoint(x: 0.3526434011421721d, y: 0.5526831707775659d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5627963938736408d, y: 0.5743365558346538d), new NpgsqlTypes.NpgsqlPoint(x: 0.3550369900407766d, y: 0.008959732971075662d), new NpgsqlTypes.NpgsqlPoint(x: 0.12697266400842633d, y: 0.43289827127416725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3774583635324201d, y: 0.7509615656046779d), new NpgsqlTypes.NpgsqlPoint(x: 0.20014960423907835d, y: 0.8407326606286465d), new NpgsqlTypes.NpgsqlPoint(x: 0.30758326757405907d, y: 0.8535085589897043d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3663810032740984d, y: 0.6353591545961925d), new NpgsqlTypes.NpgsqlPoint(x: 0.1125746051943588d, y: 0.10311375796200539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726038247589491d, y: 0.4828234942402029d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.787616363088125d, y: 0.19799043816925455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7232651050626984d, y: 0.3466458344697825d), new NpgsqlTypes.NpgsqlPoint(x: 0.0752051975389888d, y: 0.9092571952258033d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8176406881278182d, y: 0.43825047797734773d), new NpgsqlTypes.NpgsqlPoint(x: 0.604460899571395d, y: 0.4580798012809477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733885790504751d, y: 0.7317809906082077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31958367524353726d, y: 0.7202693868388397d), new NpgsqlTypes.NpgsqlPoint(x: 0.4734972989785833d, y: 0.718338788672855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874339096254518d, y: 0.5778247818955712d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30515687358183363d, y: 0.23683600535311677d), new NpgsqlTypes.NpgsqlPoint(x: 0.18705369938345906d, y: 0.611770967708261d), new NpgsqlTypes.NpgsqlPoint(x: 0.11224235102612012d, y: 0.7074769716467878d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8472687059014357d, y: 0.6746250241061786d), new NpgsqlTypes.NpgsqlPoint(x: 0.953316790711303d, y: 0.162307324502728d), new NpgsqlTypes.NpgsqlPoint(x: 0.781086766975397d, y: 0.7161811433146618d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37545864264171314d, y: 0.9713421851016112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800059542392294d, y: 0.3560494152453427d), new NpgsqlTypes.NpgsqlPoint(x: 0.1311198889700601d, y: 0.16926332385889498d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30340667446259173d, y: 0.45087558555016594d), new NpgsqlTypes.NpgsqlPoint(x: 0.1542521999772618d, y: 0.9577409816322462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707264332251107d, y: 0.9577424625950152d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08137537121192717d, y: 0.18982219121101573d), new NpgsqlTypes.NpgsqlPoint(x: 0.03426858494992158d, y: 0.8361865946670116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6326022964843452d, y: 0.20572634490573727d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13525599153787604d, y: 0.12663656293648273d), new NpgsqlTypes.NpgsqlPoint(x: 0.6608367745936866d, y: 0.9234472413919272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211722239346352d, y: 0.15872183284258012d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5254820087623776d, y: 0.37651196437739365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779205439818281d, y: 0.37056367332893825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450011845823928d, y: 0.9274833557579615d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7154489775451626d, y: 0.6219463060648847d), new NpgsqlTypes.NpgsqlPoint(x: 0.23407397415687337d, y: 0.5890183757853015d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694138532507639d, y: 0.37942166955177015d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3422057290384751d, y: 0.9835141348663266d), new NpgsqlTypes.NpgsqlPoint(x: 0.32072465942000294d, y: 0.2777499277706196d), new NpgsqlTypes.NpgsqlPoint(x: 0.067250791895478d, y: 0.9443808550037316d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09633560083119819d, y: 0.43176731165408244d), new NpgsqlTypes.NpgsqlPoint(x: 0.2668585897296256d, y: 0.5578124098124236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4960637628689333d, y: 0.19227978041762694d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25963874887577587d, y: 0.4133639817431076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7986788936070487d, y: 0.7872505097281417d), new NpgsqlTypes.NpgsqlPoint(x: 0.7481946837976691d, y: 0.4151061466662753d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28269377559485165d, y: 0.040937308390979865d), new NpgsqlTypes.NpgsqlPoint(x: 0.34666168658971763d, y: 0.13098390084273925d), new NpgsqlTypes.NpgsqlPoint(x: 0.12984321061073867d, y: 0.6007916822345728d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.720929946844776d, y: 0.8850913664335196d), new NpgsqlTypes.NpgsqlPoint(x: 0.002180866034081297d, y: 0.18666345021204467d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060538780282847d, y: 0.6011933771838077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4327797188081909d, y: 0.8279133434004445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7950320628503911d, y: 0.601534649590049d), new NpgsqlTypes.NpgsqlPoint(x: 0.2489931513763748d, y: 0.6629548574868149d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08084693506854945d, y: 0.18159702181580195d), new NpgsqlTypes.NpgsqlPoint(x: 0.4478047132613169d, y: 0.17821232067094572d), new NpgsqlTypes.NpgsqlPoint(x: 0.1714622501020877d, y: 0.9567684331211507d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2551464450911898d, y: 0.17219285181610045d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767514572544197d, y: 0.5203262556057211d), new NpgsqlTypes.NpgsqlPoint(x: 0.5773942915155478d, y: 0.7618140196040034d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3460309435525416d, y: 0.40004219837629484d), new NpgsqlTypes.NpgsqlPoint(x: 0.35469006609539266d, y: 0.1524627874086627d), new NpgsqlTypes.NpgsqlPoint(x: 0.43396564748986255d, y: 0.4546698006505895d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6574350206320513d, y: 0.5580261777855106d), new NpgsqlTypes.NpgsqlPoint(x: 0.08109971285017015d, y: 0.11348245003488888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269649057347673d, y: 0.027245618841754693d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17667007025956272d, y: 0.06011257670853887d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715323051708374d, y: 0.46532659136379617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8553131108209232d, y: 0.35815164790888687d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11416386193782069d, y: 0.332754754796988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550284999792588d, y: 0.22077200892951432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066009977142841d, y: 0.5409787392978953d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5207999823821616d, y: 0.6513284762065061d), new NpgsqlTypes.NpgsqlPoint(x: 0.8894453253083118d, y: 0.5742610503359291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5090672978261298d, y: 0.5145930459931941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.035876553722271276d, y: 0.27641533682637853d), new NpgsqlTypes.NpgsqlPoint(x: 0.3950785363744913d, y: 0.12593663575677128d), new NpgsqlTypes.NpgsqlPoint(x: 0.11699559945794724d, y: 0.27163342939859103d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4725454374789948d, y: 0.1680620516106356d), new NpgsqlTypes.NpgsqlPoint(x: 0.21510265748545498d, y: 0.9381446309421702d), new NpgsqlTypes.NpgsqlPoint(x: 0.07974647841888516d, y: 0.7661900215879991d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5608526875044686d, y: 0.7139510169534174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243259320430968d, y: 0.22256759814046312d), new NpgsqlTypes.NpgsqlPoint(x: 0.1251887979179731d, y: 0.8130720549233d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8435370243744954d, y: 0.7427217552481632d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380326869244631d, y: 0.3778086860985729d), new NpgsqlTypes.NpgsqlPoint(x: 0.018507906460457857d, y: 0.4557697608389387d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6361218192795056d, y: 0.6630271060013178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627732596569142d, y: 0.1464011079267864d), new NpgsqlTypes.NpgsqlPoint(x: 0.22569453442449172d, y: 0.04148818653832209d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7396520100410601d, y: 0.327969992511697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294668079621912d, y: 0.6695775812325325d), new NpgsqlTypes.NpgsqlPoint(x: 0.287715228594685d, y: 0.1286746980894763d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6749823284603492d, y: 0.23478876459433728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050332731509276d, y: 0.5458458993045753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183125120642775d, y: 0.22026079580369107d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5834143501258051d, y: 0.4177515189850164d), new NpgsqlTypes.NpgsqlPoint(x: 0.03836635614719419d, y: 0.7766762109994909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327964220200221d, y: 0.749086026572621d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11931840557808215d, y: 0.9267895485961434d), new NpgsqlTypes.NpgsqlPoint(x: 0.3802050335639523d, y: 0.2267327053891961d), new NpgsqlTypes.NpgsqlPoint(x: 0.22133262309914736d, y: 0.7452610023829616d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20358733322546196d, y: 0.826279437783519d), new NpgsqlTypes.NpgsqlPoint(x: 0.06371130192213137d, y: 0.6993228955132651d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207818432194753d, y: 0.16807447666434494d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5402238217006566d, y: 0.5199281672301648d), new NpgsqlTypes.NpgsqlPoint(x: 0.00733263784126692d, y: 0.06256229504577071d), new NpgsqlTypes.NpgsqlPoint(x: 0.801455050420348d, y: 0.10731829530644743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37729797459741576d, y: 0.44389057683381017d), new NpgsqlTypes.NpgsqlPoint(x: 0.29547491900332046d, y: 0.7342407235341881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260167942459743d, y: 0.27893761935015826d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6832069787641406d, y: 0.9603551056883141d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486759798855992d, y: 0.08510955722005897d), new NpgsqlTypes.NpgsqlPoint(x: 0.35333124774644264d, y: 0.34957280322832174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8380982350086992d, y: 0.16512662933472622d), new NpgsqlTypes.NpgsqlPoint(x: 0.4907706549432078d, y: 0.659510804631104d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762208683070142d, y: 0.11758086818358571d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37802890457646565d, y: 0.4562922659716686d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191237733497725d, y: 0.6362216284180082d), new NpgsqlTypes.NpgsqlPoint(x: 0.7474536459976099d, y: 0.6122333548994363d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33193777933159063d, y: 0.6348123485456212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6191563174452975d, y: 0.7188921976290061d), new NpgsqlTypes.NpgsqlPoint(x: 0.74241031009647d, y: 0.27910707582312944d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8272393071971447d, y: 0.7682740290735417d), new NpgsqlTypes.NpgsqlPoint(x: 0.6522083088487403d, y: 0.4670239294731027d), new NpgsqlTypes.NpgsqlPoint(x: 0.18952265617674147d, y: 0.2673218608996941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4265389947969448d, y: 0.7790195907560312d), new NpgsqlTypes.NpgsqlPoint(x: 0.715275513072284d, y: 0.809829569146258d), new NpgsqlTypes.NpgsqlPoint(x: 0.09585791297745572d, y: 0.21213230796714377d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7645177290829728d, y: 0.3799084803380066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9763649538868361d, y: 0.19952295941728804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103095966574d, y: 0.7678873009831465d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8557546104839212d, y: 0.96763146753782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861395707074973d, y: 0.11358755148594502d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775416424674515d, y: 0.6683070846815469d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.673503221527761d, y: 0.3599592209550071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207355184539688d, y: 0.8678719873263258d), new NpgsqlTypes.NpgsqlPoint(x: 0.32142850767469033d, y: 0.4483059763802695d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7746660090399898d, y: 0.22250852432446533d), new NpgsqlTypes.NpgsqlPoint(x: 0.16350850382535032d, y: 0.692562692099306d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370003050618962d, y: 0.31498326675935917d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5609009703781384d, y: 0.22616491531209504d), new NpgsqlTypes.NpgsqlPoint(x: 0.41165899706930764d, y: 0.5391827978067059d), new NpgsqlTypes.NpgsqlPoint(x: 0.2127125282475063d, y: 0.5970108903479501d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7316418786878842d, y: 0.33751085749737d), new NpgsqlTypes.NpgsqlPoint(x: 0.018214183306374476d, y: 0.3403003247529439d), new NpgsqlTypes.NpgsqlPoint(x: 0.24494818608786717d, y: 0.17589542707316186d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2911891285447904d, y: 0.9134232462549321d), new NpgsqlTypes.NpgsqlPoint(x: 1.854517958477242E-05d, y: 0.1890943613475704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929542923445672d, y: 0.22957166272004603d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7902260232500925d, y: 0.877621918017545d), new NpgsqlTypes.NpgsqlPoint(x: 0.634195139214565d, y: 0.3497781121673462d), new NpgsqlTypes.NpgsqlPoint(x: 0.453755508943843d, y: 0.02866849741583799d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18588640581731475d, y: 0.017807084487661107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5518126022454299d, y: 0.3201684645138497d), new NpgsqlTypes.NpgsqlPoint(x: 0.40152631779660686d, y: 0.2930674873479403d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31100257472627235d, y: 0.7197373653414724d), new NpgsqlTypes.NpgsqlPoint(x: 0.42423319432375395d, y: 0.9581208960399533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989612026265847d, y: 0.8915218560664355d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7506145859477513d, y: 0.6540761834317728d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815133802324194d, y: 0.6119181399986428d), new NpgsqlTypes.NpgsqlPoint(x: 0.10544443180566365d, y: 0.5694240216890598d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2230865342187276d, y: 0.9176961823439252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720451632104941d, y: 0.11307418032074945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5782631485822938d, y: 0.3386882706367479d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22277235608278245d, y: 0.9777851682851255d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779907012284011d, y: 0.14712799421722944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781115413585149d, y: 0.4889640852644873d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9593377308333395d, y: 0.3236971183866685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544189097002014d, y: 0.3131863498657468d), new NpgsqlTypes.NpgsqlPoint(x: 0.389845618979594d, y: 0.8300327506382504d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7888293114816247d, y: 0.3519939605177308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420368810531051d, y: 0.7403360280246571d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653053126313299d, y: 0.8680838157157862d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1922039516471461d, y: 0.7315143403109312d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925982413135616d, y: 0.7783302372287438d), new NpgsqlTypes.NpgsqlPoint(x: 0.16132245004721768d, y: 0.08708953697522237d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19012990547846664d, y: 0.5384561448566946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8556417063339877d, y: 0.6116862415351624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069695192449d, y: 0.7130480128912458d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8937429924350134d, y: 0.21690049787028054d), new NpgsqlTypes.NpgsqlPoint(x: 0.7693601757071074d, y: 0.04690134827560555d), new NpgsqlTypes.NpgsqlPoint(x: 0.10736956514618357d, y: 0.7725209099916047d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7252029235351384d, y: 0.35648757762737504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549413264664372d, y: 0.8592271390549064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9118058062662183d, y: 0.06581202825182886d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8012514575778866d, y: 0.24096005435147272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846876384961523d, y: 0.9638992932833068d), new NpgsqlTypes.NpgsqlPoint(x: 0.958554743110867d, y: 0.7764929462005858d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7240002225090849d, y: 0.019627507443510273d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626734894039757d, y: 0.05122817531110546d), new NpgsqlTypes.NpgsqlPoint(x: 0.01076179662459098d, y: 0.43132237421879493d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1035642948127744d, y: 0.7741345289165643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8309522373637288d, y: 0.08082882260771496d), new NpgsqlTypes.NpgsqlPoint(x: 0.3210879709155662d, y: 0.5601466238025403d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.914632690270854d, y: 0.6489833764051439d), new NpgsqlTypes.NpgsqlPoint(x: 0.08972803358590786d, y: 0.768627342829297d), new NpgsqlTypes.NpgsqlPoint(x: 0.23510785142993784d, y: 0.8698528655739538d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4648455064060909d, y: 0.5457715010674634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5765128913074563d, y: 0.38848395104019884d), new NpgsqlTypes.NpgsqlPoint(x: 0.10905859806132834d, y: 0.6222444601224294d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8815885408208305d, y: 0.8653909316429106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304004349856171d, y: 0.31628410543222585d), new NpgsqlTypes.NpgsqlPoint(x: 0.22099819875003612d, y: 0.39452640840624587d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5492727473416515d, y: 0.16345105759310719d), new NpgsqlTypes.NpgsqlPoint(x: 0.021625140241020135d, y: 0.8979583742729985d), new NpgsqlTypes.NpgsqlPoint(x: 0.11939424048473324d, y: 0.5065373415428776d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.959003225844147d, y: 0.5407061875306386d), new NpgsqlTypes.NpgsqlPoint(x: 0.3318898599750858d, y: 0.2960651144979993d), new NpgsqlTypes.NpgsqlPoint(x: 0.24948278784116662d, y: 0.5286077443942983d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7318404331601247d, y: 0.24452336602299884d), new NpgsqlTypes.NpgsqlPoint(x: 0.0002898930430532687d, y: 0.3889480348606327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8305408103944136d, y: 0.12037611349967392d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.168137717472308d, y: 0.8084171671847591d), new NpgsqlTypes.NpgsqlPoint(x: 0.357834851209455d, y: 0.4746042999279457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893338738492804d, y: 0.9571511597643193d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6445929471167746d, y: 0.4457648819642148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677247660928489d, y: 0.6694253245127345d), new NpgsqlTypes.NpgsqlPoint(x: 0.849540413109352d, y: 0.6016936521186431d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6131535638907823d, y: 0.9233974985735681d), new NpgsqlTypes.NpgsqlPoint(x: 0.6218746158400529d, y: 0.35796126946667073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5804695777036506d, y: 0.6611749728401897d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4527077346673122d, y: 0.001610577659593715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4274468070116617d, y: 0.5611789417452324d), new NpgsqlTypes.NpgsqlPoint(x: 0.46650945938715915d, y: 0.6026493759583531d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.062334843482430013d, y: 0.6773733140934143d), new NpgsqlTypes.NpgsqlPoint(x: 0.3687567302620065d, y: 0.31275728658217283d), new NpgsqlTypes.NpgsqlPoint(x: 0.42946782197690714d, y: 0.3100363496364309d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9739305355467904d, y: 0.5328293893067136d), new NpgsqlTypes.NpgsqlPoint(x: 0.15684154975821663d, y: 0.5776363539072208d), new NpgsqlTypes.NpgsqlPoint(x: 0.9817888639638834d, y: 0.5972001026303583d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06821250339649809d, y: 0.28579905427835994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126286070322932d, y: 0.9492591289001066d), new NpgsqlTypes.NpgsqlPoint(x: 0.21790533484070174d, y: 0.3876942451070189d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9280093443566128d, y: 0.9597541813854689d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378808384744801d, y: 0.232730402242595d), new NpgsqlTypes.NpgsqlPoint(x: 0.716344606741993d, y: 0.5136759182720765d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8358351237337469d, y: 0.5587536108580881d), new NpgsqlTypes.NpgsqlPoint(x: 0.4331755956954354d, y: 0.6241633185014309d), new NpgsqlTypes.NpgsqlPoint(x: 0.5810735181146345d, y: 0.5363517949205414d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17632527419610977d, y: 0.6801789247447227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529142379085991d, y: 0.9359845216594572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3224933758628318d, y: 0.9872545919164629d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4760615921965633d, y: 0.8787973087443953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5490151515823497d, y: 0.23426523394529608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041348914575283d, y: 0.579172236122656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2817829460030996d, y: 0.3502400458027919d), new NpgsqlTypes.NpgsqlPoint(x: 0.050493120069614594d, y: 0.7456595274399347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9444988164458745d, y: 0.11852669810017835d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.055756168579267795d, y: 0.9192553405558437d), new NpgsqlTypes.NpgsqlPoint(x: 0.3589303909954368d, y: 0.7923554593891302d), new NpgsqlTypes.NpgsqlPoint(x: 0.17898440880288202d, y: 0.772926113127855d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3857824175187494d, y: 0.22257162404315822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902512305588145d, y: 0.9954280450443608d), new NpgsqlTypes.NpgsqlPoint(x: 0.8242504308226271d, y: 0.6610618287047955d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06888859883795395d, y: 0.722194912870798d), new NpgsqlTypes.NpgsqlPoint(x: 0.894776702991279d, y: 0.6063563096909753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6717537397435868d, y: 0.5034838293174351d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5857234848757062d, y: 0.44415721984029344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505639107073235d, y: 0.15867790731635412d), new NpgsqlTypes.NpgsqlPoint(x: 0.206613501992993d, y: 0.6769217674356706d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14406513460424575d, y: 0.01643917727417543d), new NpgsqlTypes.NpgsqlPoint(x: 0.4062272315371567d, y: 0.5760881150203082d), new NpgsqlTypes.NpgsqlPoint(x: 0.44778644338258955d, y: 0.44346326471476805d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9481446778622004d, y: 0.28525803822870155d), new NpgsqlTypes.NpgsqlPoint(x: 0.06406237543952675d, y: 0.11302673517571649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205587260094432d, y: 0.5646940687614326d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3957498665477144d, y: 0.7041910522379223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965580836081482d, y: 0.4623284642929114d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571962742691392d, y: 0.7550688833591368d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7745299604608815d, y: 0.8529138432680985d), new NpgsqlTypes.NpgsqlPoint(x: 0.879373547529056d, y: 0.40871907922626016d), new NpgsqlTypes.NpgsqlPoint(x: 0.9687531962785777d, y: 0.9651155356802426d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.63944603434227d, y: 0.5393757119761958d), new NpgsqlTypes.NpgsqlPoint(x: 0.0630466280954608d, y: 0.19092451197864801d), new NpgsqlTypes.NpgsqlPoint(x: 0.09798809609898484d, y: 0.24472352147657006d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9206232927432633d, y: 0.4446052351973775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6157744549181886d, y: 0.17097734646763918d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302939485266515d, y: 0.14178345387363944d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9829261510467246d, y: 0.45954192513865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9208607412013798d, y: 0.44539066447461784d), new NpgsqlTypes.NpgsqlPoint(x: 0.35278796507303967d, y: 0.29533104902314455d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6112827021474343d, y: 0.3381036563113804d), new NpgsqlTypes.NpgsqlPoint(x: 0.06363536620992305d, y: 0.7731301542389688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6100460235697927d, y: 0.3716771220169993d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45417696865470103d, y: 0.8975506483897326d), new NpgsqlTypes.NpgsqlPoint(x: 0.934791295229115d, y: 0.8372911539203198d), new NpgsqlTypes.NpgsqlPoint(x: 0.22470295851037814d, y: 0.47806165310391247d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4286121555234338d, y: 0.6569520151354564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3611351790015638d, y: 0.3267855050213194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976534222843337d, y: 0.9938419767220465d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2656365007033795d, y: 0.4218625286937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8736425340166287d, y: 0.8988864798494965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714668509931818d, y: 0.043395565433002825d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.783746716462057d, y: 0.5556869513682876d), new NpgsqlTypes.NpgsqlPoint(x: 0.1397361633661266d, y: 0.727609355360545d), new NpgsqlTypes.NpgsqlPoint(x: 0.17285938973598014d, y: 0.9375274807335975d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6616754248509834d, y: 0.6933053550567091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4925924977933488d, y: 0.24850476886728168d), new NpgsqlTypes.NpgsqlPoint(x: 0.4169713763082713d, y: 0.8568470267945337d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9578508106395659d, y: 0.20161515371371252d), new NpgsqlTypes.NpgsqlPoint(x: 0.49717252000282d, y: 0.912368899987548d), new NpgsqlTypes.NpgsqlPoint(x: 0.4479968479604255d, y: 0.5247183396687021d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3430917181064914d, y: 0.4745559296980163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4596671493654765d, y: 0.5010693116007914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6981853463461369d, y: 0.87940003688107d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7096893489247544d, y: 0.7641145877656292d), new NpgsqlTypes.NpgsqlPoint(x: 0.7997041449594393d, y: 0.15376016897293443d), new NpgsqlTypes.NpgsqlPoint(x: 0.6252072020647885d, y: 0.5495324604312198d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35014221930092493d, y: 0.6779728002534515d), new NpgsqlTypes.NpgsqlPoint(x: 0.36482680386791233d, y: 0.3109069155937503d), new NpgsqlTypes.NpgsqlPoint(x: 0.22029007335943707d, y: 0.32761120412580524d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38010579567546243d, y: 0.026736292908454917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541011495901537d, y: 0.9373518177216685d), new NpgsqlTypes.NpgsqlPoint(x: 0.790229270178678d, y: 0.35916479574610216d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7491617359634277d, y: 0.3863834559914038d), new NpgsqlTypes.NpgsqlPoint(x: 0.09737373646649572d, y: 0.03940505014273077d), new NpgsqlTypes.NpgsqlPoint(x: 0.12401790137395707d, y: 0.004018988432580417d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030744967879468788d, y: 0.6968764086607937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8070547905943357d, y: 0.6394053614742277d), new NpgsqlTypes.NpgsqlPoint(x: 0.3089864958860379d, y: 0.7892038027292884d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7557314722885771d, y: 0.8634149831716406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876147455184021d, y: 0.6033625252286325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554586436689221d, y: 0.7487051710882678d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2602815366974015d, y: 0.6230735287861816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343655595928523d, y: 0.039143884102380455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4962987572173758d, y: 0.08160798041541562d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9128494560902791d, y: 0.8199648213865184d), new NpgsqlTypes.NpgsqlPoint(x: 0.2585063045167637d, y: 0.9296016800100657d), new NpgsqlTypes.NpgsqlPoint(x: 0.3969814297002341d, y: 0.7491238142443918d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1759211783713438d, y: 0.2662314874508016d), new NpgsqlTypes.NpgsqlPoint(x: 0.45830916107106046d, y: 0.9142457136397427d), new NpgsqlTypes.NpgsqlPoint(x: 0.020926255630954516d, y: 0.8721339617495144d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20611164383072456d, y: 0.013268043934187346d), new NpgsqlTypes.NpgsqlPoint(x: 0.5882256383560384d, y: 0.4889376556775642d), new NpgsqlTypes.NpgsqlPoint(x: 0.8602105944635077d, y: 0.9094953485954831d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7725631519094369d, y: 0.6935090419730149d), new NpgsqlTypes.NpgsqlPoint(x: 0.837528938038911d, y: 0.636998484413996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284700729453921d, y: 0.3097658986891837d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.046757031289690776d, y: 0.6643204852649366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202288128764141d, y: 0.7398186653536764d), new NpgsqlTypes.NpgsqlPoint(x: 0.19297558707465512d, y: 0.9061462920470312d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.631760496956167d, y: 0.5747134905436739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648097431144132d, y: 0.444846018151154d), new NpgsqlTypes.NpgsqlPoint(x: 0.0029388626349201585d, y: 0.8633721038761253d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006990978728392716d, y: 0.04244661063010524d), new NpgsqlTypes.NpgsqlPoint(x: 0.803291538579188d, y: 0.0850300924056101d), new NpgsqlTypes.NpgsqlPoint(x: 0.034766541009544905d, y: 0.1777270361176635d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20811596287503098d, y: 0.4085736072824059d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285429231374008d, y: 0.32151783017217617d), new NpgsqlTypes.NpgsqlPoint(x: 0.35662641160804975d, y: 0.4459978863490752d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37293885814329164d, y: 0.496117856615107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7879139714481743d, y: 0.05671085958729083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6841987532429167d, y: 0.10062417374940102d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6584302697466148d, y: 0.8090666461694548d), new NpgsqlTypes.NpgsqlPoint(x: 0.31959998477891394d, y: 0.7713355996833655d), new NpgsqlTypes.NpgsqlPoint(x: 0.22969330968764567d, y: 0.8898125152420845d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6130796258925786d, y: 0.4539242347324084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265016755529687d, y: 0.5262374591053892d), new NpgsqlTypes.NpgsqlPoint(x: 0.23867174533192248d, y: 0.9254323509689139d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7588510686400437d, y: 0.4243279346650797d), new NpgsqlTypes.NpgsqlPoint(x: 0.866392279468882d, y: 0.36393380793275554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983900401650062d, y: 0.5551294500551053d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33907397870379163d, y: 0.2662383870873374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6312281831309711d, y: 0.09074142519881001d), new NpgsqlTypes.NpgsqlPoint(x: 0.31118070826529465d, y: 0.6190019692257529d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7284207364354289d, y: 0.38408170869947134d), new NpgsqlTypes.NpgsqlPoint(x: 0.17065383944510193d, y: 0.39175703704811227d), new NpgsqlTypes.NpgsqlPoint(x: 0.9819051216025521d, y: 0.28840706574572694d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5716090339762496d, y: 0.7012906656219824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5502306230663911d, y: 0.08232690004949461d), new NpgsqlTypes.NpgsqlPoint(x: 0.24341945299924683d, y: 0.4462246172702051d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1755996194679167d, y: 0.9301161477887993d), new NpgsqlTypes.NpgsqlPoint(x: 0.3558354339908677d, y: 0.7374791983720732d), new NpgsqlTypes.NpgsqlPoint(x: 0.014633032742677687d, y: 0.9976570599969846d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.558303603271719d, y: 0.45553118976624785d), new NpgsqlTypes.NpgsqlPoint(x: 0.633237484508308d, y: 0.8736076761594121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5204206143385405d, y: 0.27785925028143144d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20043567500321335d, y: 0.4179436983353497d), new NpgsqlTypes.NpgsqlPoint(x: 0.4089780325798331d, y: 0.29819674609506786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9850942061027476d, y: 0.5105458177461842d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7450270438789072d, y: 0.36927457414035014d), new NpgsqlTypes.NpgsqlPoint(x: 0.664801768135432d, y: 0.5073712852050807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882235903209242d, y: 0.6020479658400304d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47461334795154686d, y: 0.0246287696198072d), new NpgsqlTypes.NpgsqlPoint(x: 0.1849453989241484d, y: 0.5215168294308928d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126877951196787d, y: 0.7134505167745352d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8393211995215714d, y: 0.6103366114655538d), new NpgsqlTypes.NpgsqlPoint(x: 0.34069027274337305d, y: 0.2980308071600183d), new NpgsqlTypes.NpgsqlPoint(x: 0.2376927073970746d, y: 0.7410736430386793d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37255379415564627d, y: 0.7019878111542828d), new NpgsqlTypes.NpgsqlPoint(x: 0.15560733820225447d, y: 0.7530713148797059d), new NpgsqlTypes.NpgsqlPoint(x: 0.2266436985361181d, y: 0.6728128201800457d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06291521330428651d, y: 0.7549894434230632d), new NpgsqlTypes.NpgsqlPoint(x: 0.266485722303373d, y: 0.5700261411845892d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386922110690988d, y: 0.7958489067638663d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3502400970028535d, y: 0.05294573470303121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8318034774515553d, y: 0.45145678446206183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5890205163481116d, y: 0.15266496794463125d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4309567550066792d, y: 0.9446665559258157d), new NpgsqlTypes.NpgsqlPoint(x: 0.017039145376528286d, y: 0.6129077229036184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571196454398376d, y: 0.1718536540568386d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21537415202407495d, y: 0.29250599214779893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455155643624728d, y: 0.22659798118957997d), new NpgsqlTypes.NpgsqlPoint(x: 0.14560189441184657d, y: 0.7616789625809953d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43386949112937856d, y: 0.054156596985640126d), new NpgsqlTypes.NpgsqlPoint(x: 0.41188342801457933d, y: 0.2792179702862868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850783630164871d, y: 0.005924942734501726d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7481280534262272d, y: 0.12147667247360328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975174183417296d, y: 0.2132090325115754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7284831727698617d, y: 0.30169508824804103d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6564003917241883d, y: 0.37462771650775994d), new NpgsqlTypes.NpgsqlPoint(x: 0.28060391097820847d, y: 0.016793147662469976d), new NpgsqlTypes.NpgsqlPoint(x: 0.667299513136817d, y: 0.04626166832213574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5590859577182989d, y: 0.07864770013597278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283077255362065d, y: 0.7817579112454786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209133419460221d, y: 0.7912039664770288d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6531835524633315d, y: 0.9518136437654633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006015895957097d, y: 0.4017505821075027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6713399174399309d, y: 0.45655827898507817d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.962343672624347d, y: 0.19777802776550757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3303462755319919d, y: 0.25668859008870115d), new NpgsqlTypes.NpgsqlPoint(x: 0.5389241306155423d, y: 0.5639220803438241d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7020540812064433d, y: 0.7942593407580405d), new NpgsqlTypes.NpgsqlPoint(x: 0.1094613166929641d, y: 0.438536612689176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8453102568297931d, y: 0.5654239321995697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7098679236097493d, y: 0.8195199211567799d), new NpgsqlTypes.NpgsqlPoint(x: 0.03934966120934946d, y: 0.7009014921130448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026931026236699d, y: 0.5204567610177251d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3196744867353756d, y: 0.3270361650585366d), new NpgsqlTypes.NpgsqlPoint(x: 0.4884607394480597d, y: 0.292274146977091d), new NpgsqlTypes.NpgsqlPoint(x: 0.23098729610309743d, y: 0.7363120471120311d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5692182349122422d, y: 0.5390279540518494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6064245451004453d, y: 0.6829789611968844d), new NpgsqlTypes.NpgsqlPoint(x: 0.29019395218428645d, y: 0.3058249511748313d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6624796956753719d, y: 0.36665371183923867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836450584178343d, y: 0.08644678038625875d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098723845912832d, y: 0.31272338402698685d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43703885584201196d, y: 0.3533634909756681d), new NpgsqlTypes.NpgsqlPoint(x: 0.30182259494178365d, y: 0.13301544935410436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5385781371403986d, y: 0.5947800197516001d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9570116055460255d, y: 0.029513445374317215d), new NpgsqlTypes.NpgsqlPoint(x: 0.15482548201886548d, y: 0.5388572512104519d), new NpgsqlTypes.NpgsqlPoint(x: 0.32546297139524993d, y: 0.8941637131610084d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9093333391908641d, y: 0.5695535644507318d), new NpgsqlTypes.NpgsqlPoint(x: 0.3303441802012278d, y: 0.9868401397187737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794170809523687d, y: 0.4435144684104044d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33073383290500336d, y: 0.621721401459122d), new NpgsqlTypes.NpgsqlPoint(x: 0.15265427069783044d, y: 0.678126766614097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787323943996632d, y: 0.0013990075858569817d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48782606212029966d, y: 0.6431293982297381d), new NpgsqlTypes.NpgsqlPoint(x: 0.08798842265174633d, y: 0.10845024063558151d), new NpgsqlTypes.NpgsqlPoint(x: 0.2923755704332064d, y: 0.28235980825471174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9275292242820476d, y: 0.33288173796315945d), new NpgsqlTypes.NpgsqlPoint(x: 0.331215626071207d, y: 0.20463526811967758d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638900491653952d, y: 0.21508179757270673d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7114154023645057d, y: 0.4015696667555234d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195699786398342d, y: 0.3688665626728016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7948216588319321d, y: 0.7066653481079249d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7867303945058263d, y: 0.20141890971529253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724028556172632d, y: 0.7097074907183145d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970823131180391d, y: 0.2955246643653262d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14194790809357571d, y: 0.23132099681292573d), new NpgsqlTypes.NpgsqlPoint(x: 0.2720851629537059d, y: 0.8033546029217269d), new NpgsqlTypes.NpgsqlPoint(x: 0.5725819980187413d, y: 0.9406270995226284d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5984074291480685d, y: 0.00559500069715646d), new NpgsqlTypes.NpgsqlPoint(x: 0.44163456266732815d, y: 0.9011630558689017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8515971986595825d, y: 0.3652389324002102d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6875141482276151d, y: 0.2376364628652179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004002164610413d, y: 0.16628234811439746d), new NpgsqlTypes.NpgsqlPoint(x: 0.801118114194189d, y: 0.41956385575242783d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9965074092722144d, y: 0.5456932423734642d), new NpgsqlTypes.NpgsqlPoint(x: 0.4906084384619923d, y: 0.2048823574836064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495545793692343d, y: 0.825269112740575d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7256227273433685d, y: 0.3976479461477658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166652931633859d, y: 0.9293282847138383d), new NpgsqlTypes.NpgsqlPoint(x: 0.41535966694462234d, y: 0.836838596486351d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5361733855552384d, y: 0.7067499830548789d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814292047121949d, y: 0.4930302726877186d), new NpgsqlTypes.NpgsqlPoint(x: 0.1413497136916878d, y: 0.17071803503256644d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6960522873048428d, y: 0.22790141358111604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4753217574501737d, y: 0.9264770634474707d), new NpgsqlTypes.NpgsqlPoint(x: 0.016385258378729728d, y: 0.873499897302429d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9318197947446276d, y: 0.18478555915839967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026119119017152d, y: 0.4970405489991412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6168672081186317d, y: 0.2470891757399014d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1918503234696063d, y: 0.3547990399959108d), new NpgsqlTypes.NpgsqlPoint(x: 0.376301405394154d, y: 0.38350742044262187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9671198189645415d, y: 0.08158818259850731d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1392953184407647d, y: 0.4439700169698384d), new NpgsqlTypes.NpgsqlPoint(x: 0.22543358962023652d, y: 0.603044441246859d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621265485976132d, y: 0.6855152036188376d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3660984698192653d, y: 0.5029374385616988d), new NpgsqlTypes.NpgsqlPoint(x: 0.22953705686172265d, y: 0.5250956082891084d), new NpgsqlTypes.NpgsqlPoint(x: 0.22962304223709185d, y: 0.625127476166473d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7631551288460174d, y: 0.9795978771315395d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935393487980346d, y: 0.2668409743507193d), new NpgsqlTypes.NpgsqlPoint(x: 0.4814484238033184d, y: 0.7344249994073145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07420373892365784d, y: 0.8726688279814117d), new NpgsqlTypes.NpgsqlPoint(x: 0.37247411145437903d, y: 0.3893762558686238d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779329965440316d, y: 0.5844896054488397d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24179183946372662d, y: 0.46907311919018235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8441486615698023d, y: 0.6475947958168011d), new NpgsqlTypes.NpgsqlPoint(x: 0.056568735248962d, y: 0.38869571371160994d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15883203070022767d, y: 0.15664569281912688d), new NpgsqlTypes.NpgsqlPoint(x: 0.26270163160096416d, y: 0.9597896651260679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431900598032486d, y: 0.9506595479742908d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8736929016548981d, y: 0.9854437611249377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9977112107232553d, y: 0.3650782688655956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636962984091997d, y: 0.6124843939720495d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03419062887362201d, y: 0.910237570456624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5887129046289983d, y: 0.598898627908433d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252987776514158d, y: 0.36764358098450955d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7470989008809433d, y: 0.8887051193458642d), new NpgsqlTypes.NpgsqlPoint(x: 0.06173722720378616d, y: 0.1885174851656617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5303037313517461d, y: 0.2765077280763596d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9672585816850954d, y: 0.7543115139627753d), new NpgsqlTypes.NpgsqlPoint(x: 0.1339893558542169d, y: 0.2214197520822695d), new NpgsqlTypes.NpgsqlPoint(x: 0.18032193620192982d, y: 0.7094578524472068d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09612896408532734d, y: 0.8771253816033066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628517102840995d, y: 0.8222510858239698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910542779687525d, y: 0.004722654086930844d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8726214490121842d, y: 0.4066949576624479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6296076643910792d, y: 0.655555787964462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6000256888029056d, y: 0.435592090384462d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49773078598098996d, y: 0.5707310783806736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326434947400939d, y: 0.6497308095739766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5009023916790012d, y: 0.5423437370320403d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5370290643353702d, y: 0.07574917639417611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7996198870989666d, y: 0.5773715460581678d), new NpgsqlTypes.NpgsqlPoint(x: 0.9805091824850188d, y: 0.9004110823313439d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3236330602038241d, y: 0.9972543063536918d), new NpgsqlTypes.NpgsqlPoint(x: 0.19511715410984465d, y: 0.6733123192959584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7865546241304109d, y: 0.6798899778311952d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4895601016610476d, y: 0.49028466479577626d), new NpgsqlTypes.NpgsqlPoint(x: 0.12461187180711408d, y: 0.7746772527888375d), new NpgsqlTypes.NpgsqlPoint(x: 0.237323039207877d, y: 0.6746917650826975d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02709231188877681d, y: 0.018397573750953078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6655925377928965d, y: 0.5573977488899696d), new NpgsqlTypes.NpgsqlPoint(x: 0.347101115560946d, y: 0.3712741880194391d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3698985058364227d, y: 0.12441618816618005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9001780306675812d, y: 0.8053364295504043d), new NpgsqlTypes.NpgsqlPoint(x: 0.020176636028114703d, y: 0.9272105330284186d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.501326075244469d, y: 0.20051069954034173d), new NpgsqlTypes.NpgsqlPoint(x: 0.05060157652072339d, y: 0.7834994742644686d), new NpgsqlTypes.NpgsqlPoint(x: 0.0775315980577842d, y: 0.5830995637028511d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23733667736949393d, y: 0.9568141493871565d), new NpgsqlTypes.NpgsqlPoint(x: 0.21191555990169142d, y: 0.8279914363472122d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733989466265608d, y: 0.27604020698819387d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9438818300889776d, y: 0.9966964331124649d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068113457881209d, y: 0.8716237848061508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7735662483082291d, y: 0.9550513681900451d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 154, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 11, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 81, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[1], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[2], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[3], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatch(connection, 154, 158))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2M>(15);

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
                ((INpgsqlPolygonListpolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

