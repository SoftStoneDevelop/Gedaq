

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7236101940390243d, y: 0.3729665989891483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468780839376855d, y: 0.9611783633776868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972152996685746d, y: 0.11460988482514001d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6998028415408193d, y: 0.4546732930119797d), new NpgsqlTypes.NpgsqlPoint(x: 0.23419833655527988d, y: 0.3398195192132104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680179840534884d, y: 0.3531557557992505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20992543351914972d, y: 0.8528095449985555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4113936406236697d, y: 0.06243628451034744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946273589842942d, y: 0.1360238934554855d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7992344609240244d, y: 0.17418679331025622d), new NpgsqlTypes.NpgsqlPoint(x: 0.9167793561255637d, y: 0.6681583690457863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6753089912825943d, y: 0.23858403766967962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4704637535438485d, y: 0.4275433622410394d), new NpgsqlTypes.NpgsqlPoint(x: 0.003313851945610291d, y: 0.42996778110509204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4803793526613488d, y: 0.08952986854303302d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42105659307339616d, y: 0.8091615610114538d), new NpgsqlTypes.NpgsqlPoint(x: 0.593626992354476d, y: 0.02991964453290097d), new NpgsqlTypes.NpgsqlPoint(x: 0.15286073467080785d, y: 0.8684421996742898d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38326198949491486d, y: 0.5991074202769083d), new NpgsqlTypes.NpgsqlPoint(x: 0.52663399085819d, y: 0.001558537549554262d), new NpgsqlTypes.NpgsqlPoint(x: 0.24110068059239376d, y: 0.32981118976043633d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7136782915554706d, y: 0.8662585037115185d), new NpgsqlTypes.NpgsqlPoint(x: 0.45439468464422506d, y: 0.20201181498187448d), new NpgsqlTypes.NpgsqlPoint(x: 0.09452011895923296d, y: 0.8359109471283485d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6870509583950626d, y: 0.4732693992552425d), new NpgsqlTypes.NpgsqlPoint(x: 0.19637865532308874d, y: 0.9456516226624184d), new NpgsqlTypes.NpgsqlPoint(x: 0.03718119746823978d, y: 0.1149412655931985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8872843014575208d, y: 0.23954376295848645d), new NpgsqlTypes.NpgsqlPoint(x: 0.4845926345514633d, y: 0.5827534329766951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480948018435603d, y: 0.6792246543053022d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6672257943700929d, y: 0.86586375018312d), new NpgsqlTypes.NpgsqlPoint(x: 0.983488045881459d, y: 0.476941581330654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3328520880222068d, y: 0.6385928477397178d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021987759904564363d, y: 0.9422176730039659d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299253647625794d, y: 0.8190244032548425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2808537857169703d, y: 0.15201580360692324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34510029278430576d, y: 0.22660634803190394d), new NpgsqlTypes.NpgsqlPoint(x: 0.05402528632430492d, y: 0.9476001217976928d), new NpgsqlTypes.NpgsqlPoint(x: 0.2965962710836182d, y: 0.8512587075322443d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7975360687592682d, y: 0.4207600172266187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8949337069994935d, y: 0.8058493417216889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449148620317765d, y: 0.39421809653759843d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11499082375327008d, y: 0.4775382437063166d), new NpgsqlTypes.NpgsqlPoint(x: 0.30882076187821805d, y: 0.3563057165935738d), new NpgsqlTypes.NpgsqlPoint(x: 0.11653683041483442d, y: 0.39134857906787823d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5434009806916537d, y: 0.5341673065081277d), new NpgsqlTypes.NpgsqlPoint(x: 0.2073691640001717d, y: 0.7685460916187477d), new NpgsqlTypes.NpgsqlPoint(x: 0.10102684497839653d, y: 0.2443011367809813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8775765044871333d, y: 0.5482716192232143d), new NpgsqlTypes.NpgsqlPoint(x: 0.03982305946811793d, y: 0.15543619519805585d), new NpgsqlTypes.NpgsqlPoint(x: 0.10407319870857257d, y: 0.32486224593211077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5700549615730135d, y: 0.6703540463849332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7907457094397246d, y: 0.784738790358221d), new NpgsqlTypes.NpgsqlPoint(x: 0.41350633069501785d, y: 0.9449714977219839d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11720251715411423d, y: 0.018807249847209606d), new NpgsqlTypes.NpgsqlPoint(x: 0.821520520237042d, y: 0.7133452793853109d), new NpgsqlTypes.NpgsqlPoint(x: 0.27474293715893205d, y: 0.9809178142243554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20346656742699643d, y: 0.15814379639406018d), new NpgsqlTypes.NpgsqlPoint(x: 0.38260356086788816d, y: 0.5320677527595087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668288835856989d, y: 0.4136296632511358d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9470449380066269d, y: 0.5407459275867811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7684103406349212d, y: 0.35948152196013217d), new NpgsqlTypes.NpgsqlPoint(x: 0.17118928056865979d, y: 0.2966802742787359d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40589374328375105d, y: 0.18778053501909098d), new NpgsqlTypes.NpgsqlPoint(x: 0.08868830145994766d, y: 0.9421204073033881d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674619790808714d, y: 0.35024655694686146d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11800260016023267d, y: 0.8503073872999103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994040727799543d, y: 0.8410328039579688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128500506794766d, y: 0.0013727207055628243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9290881202801723d, y: 0.08401479997931516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1618880362033629d, y: 0.25756436128151716d), new NpgsqlTypes.NpgsqlPoint(x: 0.36110289071221646d, y: 0.7652231833759563d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21529068847362254d, y: 0.28369219406283175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6247525287306395d, y: 0.8565106081234182d), new NpgsqlTypes.NpgsqlPoint(x: 0.827103434140744d, y: 0.8976043994183177d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8565915407458023d, y: 0.8798280141633833d), new NpgsqlTypes.NpgsqlPoint(x: 0.1749890811076612d, y: 0.058116154836313494d), new NpgsqlTypes.NpgsqlPoint(x: 0.17012875329535904d, y: 0.4315095450476435d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18499846808411435d, y: 0.2898910587376432d), new NpgsqlTypes.NpgsqlPoint(x: 0.897209303206287d, y: 0.833480820030514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4004845904201717d, y: 0.16922188240455138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9930776047476458d, y: 0.3983123674385123d), new NpgsqlTypes.NpgsqlPoint(x: 0.4696116345353675d, y: 0.7935379806659456d), new NpgsqlTypes.NpgsqlPoint(x: 0.23509476816740627d, y: 0.5904748111475672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46518826277578973d, y: 0.9362280438253866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5561857859910526d, y: 0.6427927315297122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8160911162090093d, y: 0.5857065500185817d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4179257812795415d, y: 0.22968202758724177d), new NpgsqlTypes.NpgsqlPoint(x: 0.03991344366921301d, y: 0.969531659228994d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930886056229901d, y: 0.2010005504557334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8213361002578758d, y: 0.7392975248833878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971439818931565d, y: 0.7821525474098786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8181954343984107d, y: 0.0009379853208506539d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4894454265448934d, y: 0.9059629697209985d), new NpgsqlTypes.NpgsqlPoint(x: 0.22182571735937018d, y: 0.2256825864704448d), new NpgsqlTypes.NpgsqlPoint(x: 0.27448308879339745d, y: 0.630672410730736d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8857205864560891d, y: 0.3057349411482966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5630809002881592d, y: 0.20410462714430821d), new NpgsqlTypes.NpgsqlPoint(x: 0.23838630000781424d, y: 0.874458402551231d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2106225529585677d, y: 0.32121114100353d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286669057094914d, y: 0.7383042981373942d), new NpgsqlTypes.NpgsqlPoint(x: 0.2053945857597098d, y: 0.8278684034695049d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3458206255207713d, y: 0.5521280272672067d), new NpgsqlTypes.NpgsqlPoint(x: 0.2919376057898646d, y: 0.022738362539020174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826314899990912d, y: 0.5135459199200962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.656081791526853d, y: 0.33527448712863583d), new NpgsqlTypes.NpgsqlPoint(x: 0.965370366680587d, y: 0.9134242461238941d), new NpgsqlTypes.NpgsqlPoint(x: 0.05150784579506651d, y: 0.19553273813174787d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5294372791641635d, y: 0.8300599816561267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9774979858883096d, y: 0.9556427711717878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6534803552825157d, y: 0.5158866960388675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16153560865463423d, y: 0.4717497498162757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3105313242121168d, y: 0.7731994829613794d), new NpgsqlTypes.NpgsqlPoint(x: 0.041948945976142404d, y: 0.16911700717460532d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6009532667823327d, y: 0.3715641090299511d), new NpgsqlTypes.NpgsqlPoint(x: 0.4024268473600183d, y: 0.05069011999701978d), new NpgsqlTypes.NpgsqlPoint(x: 0.4070567408525667d, y: 0.927390702918633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12198937222141315d, y: 0.45882074284945096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787505813146379d, y: 0.760104380130954d), new NpgsqlTypes.NpgsqlPoint(x: 0.17742145709591528d, y: 0.5944122465996025d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23270873181271357d, y: 0.2998976000029957d), new NpgsqlTypes.NpgsqlPoint(x: 0.3980772459986006d, y: 0.39665740452509346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287471313990405d, y: 0.13257932783468618d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7627540748178605d, y: 0.9091476019624167d), new NpgsqlTypes.NpgsqlPoint(x: 0.309637664529842d, y: 0.4693669911144833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5882188667215442d, y: 0.7882779024380538d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39073273283162124d, y: 0.12065880503781679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7090782096745641d, y: 0.17948790683961935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734878321678625d, y: 0.2100344353695479d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8801292536310558d, y: 0.5070901416264546d), new NpgsqlTypes.NpgsqlPoint(x: 0.26606757649866575d, y: 0.854770389942408d), new NpgsqlTypes.NpgsqlPoint(x: 0.9912254151864197d, y: 0.3684369452524807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550104878406896d, y: 0.11503395514132375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272476524865871d, y: 0.8418623111120916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762525327687035d, y: 0.12248583094822763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4255017535031991d, y: 0.16059118410705087d), new NpgsqlTypes.NpgsqlPoint(x: 0.22216077499866183d, y: 0.10646912805109643d), new NpgsqlTypes.NpgsqlPoint(x: 0.31270198610256283d, y: 0.6140150387297107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6015721874930723d, y: 0.9196644167873095d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364040425949232d, y: 0.143176126097601d), new NpgsqlTypes.NpgsqlPoint(x: 0.9383051147536358d, y: 0.6110025631041551d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5479348707386006d, y: 0.45286726199756744d), new NpgsqlTypes.NpgsqlPoint(x: 0.022420760758345648d, y: 0.07840086471297913d), new NpgsqlTypes.NpgsqlPoint(x: 0.43373840559361587d, y: 0.08446867657531587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6979131964410996d, y: 0.7334662645332923d), new NpgsqlTypes.NpgsqlPoint(x: 0.2777288871915289d, y: 0.9584682091598161d), new NpgsqlTypes.NpgsqlPoint(x: 0.29503731344505757d, y: 0.851274370595171d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09542489679355759d, y: 0.6363012402977651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8328172911456568d, y: 0.8267534125757844d), new NpgsqlTypes.NpgsqlPoint(x: 0.3549862355786686d, y: 0.9208457465788036d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41801937946244017d, y: 0.934874012802344d), new NpgsqlTypes.NpgsqlPoint(x: 0.058130420638479174d, y: 0.3604379060371681d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406636838662481d, y: 0.04682356248326114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05550805262615044d, y: 0.597653662693302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9246828896599216d, y: 0.9481753179826261d), new NpgsqlTypes.NpgsqlPoint(x: 0.0552689466848042d, y: 0.333420914340948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6104310417724558d, y: 0.30209912007036466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156070926986716d, y: 0.42350466539733045d), new NpgsqlTypes.NpgsqlPoint(x: 0.32810638107119994d, y: 0.43106269582370127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.195523786237778d, y: 0.1185359929371641d), new NpgsqlTypes.NpgsqlPoint(x: 0.08764378207611545d, y: 0.23431528684184166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6046754362976077d, y: 0.6562798933148972d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.73264612790698d, y: 0.8078299224451406d), new NpgsqlTypes.NpgsqlPoint(x: 0.06105702266657154d, y: 0.6652824655224022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703801988516439d, y: 0.029771613603369662d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6600929385293812d, y: 0.7850740086996375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215560874653244d, y: 0.8925927598050701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421661621652016d, y: 0.5813305562728722d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3922218806629979d, y: 0.8478770659600668d), new NpgsqlTypes.NpgsqlPoint(x: 0.863828502275734d, y: 0.5501771539164775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6458883244979032d, y: 0.964105245000078d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06130282104026108d, y: 0.8041574307914433d), new NpgsqlTypes.NpgsqlPoint(x: 0.45181506294902807d, y: 0.9891994342596705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383050886050732d, y: 0.16561753697967296d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006589539085023688d, y: 0.7038258460691801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711799947619941d, y: 0.38265913311748734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9561037082471758d, y: 0.6432901914218019d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19421960066411037d, y: 0.33681584192815284d), new NpgsqlTypes.NpgsqlPoint(x: 0.495026114231894d, y: 0.8769344224612995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6263158970792221d, y: 0.6621570980917008d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30372549611004984d, y: 0.8872256686396714d), new NpgsqlTypes.NpgsqlPoint(x: 0.7868172789749822d, y: 0.10783067909630661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972028780650095d, y: 0.8837501587279514d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5818580761909613d, y: 0.7247932791605705d), new NpgsqlTypes.NpgsqlPoint(x: 0.1892240278761691d, y: 0.7877442111940871d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286984845246331d, y: 0.890151369868639d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19793186940697172d, y: 0.6860028968192147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033562570194829d, y: 0.360571299149659d), new NpgsqlTypes.NpgsqlPoint(x: 0.46459369510948245d, y: 0.8275026785018731d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.881676084158273d, y: 0.5764993624253669d), new NpgsqlTypes.NpgsqlPoint(x: 0.5467218920003097d, y: 0.3721664949127852d), new NpgsqlTypes.NpgsqlPoint(x: 0.5064088423366737d, y: 0.2838633704250222d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8534617003949008d, y: 0.27680476299343193d), new NpgsqlTypes.NpgsqlPoint(x: 0.05998932779545385d, y: 0.5980158500738736d), new NpgsqlTypes.NpgsqlPoint(x: 0.732101693891178d, y: 0.3984668909889286d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17309234554458985d, y: 0.3801101894746448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6617522126399492d, y: 0.3861342408412095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437000047834086d, y: 0.7591357166963676d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9688133089738017d, y: 0.2931296277262322d), new NpgsqlTypes.NpgsqlPoint(x: 0.40446950335821996d, y: 0.8280742632697428d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158852436009849d, y: 0.655782353170643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2469291754489541d, y: 0.38624096231175986d), new NpgsqlTypes.NpgsqlPoint(x: 0.38750460428777234d, y: 0.26883738581838434d), new NpgsqlTypes.NpgsqlPoint(x: 0.19583113460496937d, y: 0.5781715072359055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8543706320493488d, y: 0.7827670492683467d), new NpgsqlTypes.NpgsqlPoint(x: 0.23139742684572118d, y: 0.16907525779798915d), new NpgsqlTypes.NpgsqlPoint(x: 0.887136719251724d, y: 0.2601945069249013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7606518566562662d, y: 0.9473216861170185d), new NpgsqlTypes.NpgsqlPoint(x: 0.49868365888189836d, y: 0.246541956377356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982704307054772d, y: 0.17415145978315305d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004635026350918059d, y: 0.8264363250218756d), new NpgsqlTypes.NpgsqlPoint(x: 0.2883149602310293d, y: 0.2531470341182911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565024491191222d, y: 0.974268257614238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6120764854638561d, y: 0.44813976753573825d), new NpgsqlTypes.NpgsqlPoint(x: 0.39220140235347467d, y: 0.05405214269462777d), new NpgsqlTypes.NpgsqlPoint(x: 0.92220351787875d, y: 0.4424850871538113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6312308681409505d, y: 0.11781847791486377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688749513545345d, y: 0.19048726257719362d), new NpgsqlTypes.NpgsqlPoint(x: 0.980353493190198d, y: 0.052500398501454826d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6002319250414476d, y: 0.2676993450895856d), new NpgsqlTypes.NpgsqlPoint(x: 0.29160005915815346d, y: 0.5795823607764924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414769634189622d, y: 0.4877976692367354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6217425313059185d, y: 0.7506047101541781d), new NpgsqlTypes.NpgsqlPoint(x: 0.014131250324905142d, y: 0.2118197245866945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7381799472804358d, y: 0.9500881702524004d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3170097447144714d, y: 0.9557800875367062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162445006108934d, y: 0.23186042168278975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855682977973802d, y: 0.5206340174477929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7325748820520674d, y: 0.33477013366722863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340507768391508d, y: 0.5873314851785937d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328812306225713d, y: 0.43730556766796036d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027656073808196235d, y: 0.28652273369983583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4499916175845786d, y: 0.9037028865984725d), new NpgsqlTypes.NpgsqlPoint(x: 0.22670444477535046d, y: 0.015056885042909252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7238882200272376d, y: 0.6439248889272173d), new NpgsqlTypes.NpgsqlPoint(x: 0.001099618931153401d, y: 0.11561213159363604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9363037199937126d, y: 0.7213321262130588d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4130529323873331d, y: 0.9736324500450095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8691128899220969d, y: 0.7770785913946577d), new NpgsqlTypes.NpgsqlPoint(x: 0.769093292395533d, y: 0.20504029612858599d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7718999717665986d, y: 0.7701473708919587d), new NpgsqlTypes.NpgsqlPoint(x: 0.09591053543194317d, y: 0.6009229438514793d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789466621756626d, y: 0.4076169062480962d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8698217232440237d, y: 0.5221448673742696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8877070054139894d, y: 0.1115599689112945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7461102246374292d, y: 0.38414275129423137d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4341945509177617d, y: 0.19465219777114362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965499546020694d, y: 0.6444278366966362d), new NpgsqlTypes.NpgsqlPoint(x: 0.9649938220519858d, y: 0.4743972648417848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.96128039335133d, y: 0.29146062204673884d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394991470990751d, y: 0.5202205252196194d), new NpgsqlTypes.NpgsqlPoint(x: 0.997234532135504d, y: 0.7137403850331319d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9753964815137923d, y: 0.7331599541984435d), new NpgsqlTypes.NpgsqlPoint(x: 0.1478687941776593d, y: 0.051134150777149334d), new NpgsqlTypes.NpgsqlPoint(x: 0.06253222446286322d, y: 0.295959513264035d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22157694661910476d, y: 0.32232532652289125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4758679737831598d, y: 0.8629820844644414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528145927591948d, y: 0.3582660351625677d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9698454274715248d, y: 0.5613669088434019d), new NpgsqlTypes.NpgsqlPoint(x: 0.7737695664721899d, y: 0.9833586644513862d), new NpgsqlTypes.NpgsqlPoint(x: 0.2905761841130192d, y: 0.24201345644269112d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8770813866126695d, y: 0.09360529783144889d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987059966271175d, y: 0.16281819066674907d), new NpgsqlTypes.NpgsqlPoint(x: 0.0543888410038873d, y: 0.4502772178275386d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16861189627116902d, y: 0.44576203737170417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8851372437375573d, y: 0.21171627117346126d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594670808943408d, y: 0.898032437456068d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.056496003938664385d, y: 0.7981352824846649d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406240430945334d, y: 0.1989283638713779d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256545149679176d, y: 0.7383246607652257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004148849988600767d, y: 0.7764530416005315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350829401166794d, y: 0.7797162069428263d), new NpgsqlTypes.NpgsqlPoint(x: 0.24187407059155253d, y: 0.613155356291513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6294628212409971d, y: 0.26052412172651596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6690305770931687d, y: 0.2539973251734957d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723274415790834d, y: 0.41039712032522024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011385098044307651d, y: 0.26193204723437513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891666312236293d, y: 0.8828446021267493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7220898996407684d, y: 0.47513715305779336d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15349942127310057d, y: 0.27481067290515937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7814580864740773d, y: 0.8954249770972922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6724636179184498d, y: 0.3715498587583679d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3349706436210559d, y: 0.2721792885725789d), new NpgsqlTypes.NpgsqlPoint(x: 0.2058756180317498d, y: 0.043048542381844634d), new NpgsqlTypes.NpgsqlPoint(x: 0.02991032918815162d, y: 0.0022449184433253055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7558859159938377d, y: 0.3597283013032362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5272458801151887d, y: 0.7258447047080792d), new NpgsqlTypes.NpgsqlPoint(x: 0.28554465631953396d, y: 0.2370324658699029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5708768534804491d, y: 0.26202868381614886d), new NpgsqlTypes.NpgsqlPoint(x: 0.05508231124172802d, y: 0.6209349320057704d), new NpgsqlTypes.NpgsqlPoint(x: 0.18555352658214186d, y: 0.6408807845504996d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16192638857615715d, y: 0.39856620878879323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930638457169939d, y: 0.9288089486231844d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711813260117912d, y: 0.39370872827092085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9788798856762614d, y: 0.5887524318169495d), new NpgsqlTypes.NpgsqlPoint(x: 0.15295825175760436d, y: 0.7989333938978628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7017551893736415d, y: 0.6605903051892053d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33231825091571343d, y: 0.49071268098994025d), new NpgsqlTypes.NpgsqlPoint(x: 0.918551913950227d, y: 0.5900714335047206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7416171802669546d, y: 0.6299412138298621d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8872512311924602d, y: 0.17982981828147215d), new NpgsqlTypes.NpgsqlPoint(x: 0.1114114472466502d, y: 0.22902315361212033d), new NpgsqlTypes.NpgsqlPoint(x: 0.03911868695768539d, y: 0.30108087678119644d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6525667043985002d, y: 0.31515488639677003d), new NpgsqlTypes.NpgsqlPoint(x: 0.34045936916960096d, y: 0.7311416258702872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131026393848996d, y: 0.23321167503050044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5530596441575555d, y: 0.3038125000448454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213142996068578d, y: 0.17199510529742423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570317283117744d, y: 0.1356066571802117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9978089224482232d, y: 0.20306214482643514d), new NpgsqlTypes.NpgsqlPoint(x: 0.22803595412041655d, y: 0.9687183898970863d), new NpgsqlTypes.NpgsqlPoint(x: 0.203891485943141d, y: 0.8841798781710065d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.642305332168829d, y: 0.8234164307421529d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302625348704858d, y: 0.9928022153314809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298898301026078d, y: 0.383022834776239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9275771344748555d, y: 0.0845797380674792d), new NpgsqlTypes.NpgsqlPoint(x: 0.07968781944607861d, y: 0.9962296950612054d), new NpgsqlTypes.NpgsqlPoint(x: 0.24296950268311746d, y: 0.9902186199963127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.95017982785538d, y: 0.840841024479811d), new NpgsqlTypes.NpgsqlPoint(x: 0.022501661700759956d, y: 0.7750023162185139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7282859436495946d, y: 0.2569529289861444d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7174791286278203d, y: 0.6375287710278269d), new NpgsqlTypes.NpgsqlPoint(x: 0.299001559502023d, y: 0.9908298111552161d), new NpgsqlTypes.NpgsqlPoint(x: 0.015773483805442523d, y: 0.6234498981096476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3861933903875566d, y: 0.07868784557122033d), new NpgsqlTypes.NpgsqlPoint(x: 0.37071464404633425d, y: 0.8807269319781913d), new NpgsqlTypes.NpgsqlPoint(x: 0.21774670823808484d, y: 0.8595170152479459d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.252659445019059d, y: 0.764080447641798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063877538313177d, y: 0.9583801330761238d), new NpgsqlTypes.NpgsqlPoint(x: 0.48563981543604706d, y: 0.3841303685528218d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3070755098925142d, y: 0.8392951638907471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7968482294895096d, y: 0.03440022173306301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689205057380281d, y: 0.39508840867699313d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7320520720828698d, y: 0.6896379942882191d), new NpgsqlTypes.NpgsqlPoint(x: 0.6044730905015273d, y: 0.7794940256361214d), new NpgsqlTypes.NpgsqlPoint(x: 0.2667568929146421d, y: 0.791519748958752d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111549270524449d, y: 0.8330858253833361d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829820499311005d, y: 0.9999924167012134d), new NpgsqlTypes.NpgsqlPoint(x: 0.09723146209852296d, y: 0.744775530595612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9929066365887195d, y: 0.9897737648309718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8210461199888985d, y: 0.5817999023597512d), new NpgsqlTypes.NpgsqlPoint(x: 0.522980642103032d, y: 0.1657191196494059d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03857273486195123d, y: 0.23343775010082046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6153746722874107d, y: 0.6075621067304724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9095698298159803d, y: 0.21680808291207543d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13178687889012353d, y: 0.4177069207950247d), new NpgsqlTypes.NpgsqlPoint(x: 0.19826181206428606d, y: 0.07959797764641596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7192276946813612d, y: 0.21259098861514403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9223837475954609d, y: 0.3713514996241005d), new NpgsqlTypes.NpgsqlPoint(x: 0.23356828406467323d, y: 0.913586662019288d), new NpgsqlTypes.NpgsqlPoint(x: 0.35417760987713987d, y: 0.3881675374610716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9334416497899858d, y: 0.3238033857853567d), new NpgsqlTypes.NpgsqlPoint(x: 0.3717412364247017d, y: 0.447130490767109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761568555787482d, y: 0.9776097251026519d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3039019331254418d, y: 0.5442602574791001d), new NpgsqlTypes.NpgsqlPoint(x: 0.39254590371340525d, y: 0.6617940788917268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572916422952143d, y: 0.694879106642981d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37970722375996335d, y: 0.5625207227868834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7730430518852964d, y: 0.06479518443241161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114860809726689d, y: 0.13650094793422085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7345734424497259d, y: 0.7098736635947326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7300981507013372d, y: 0.4424506691889698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6033189541328434d, y: 0.4961952076768321d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45966436783441644d, y: 0.5845035027225842d), new NpgsqlTypes.NpgsqlPoint(x: 0.02762155972614755d, y: 0.13992256104444667d), new NpgsqlTypes.NpgsqlPoint(x: 0.06635598950883792d, y: 0.7982852401572983d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8554411645892239d, y: 0.6803173815319733d), new NpgsqlTypes.NpgsqlPoint(x: 0.23418492319529471d, y: 0.8431210143313749d), new NpgsqlTypes.NpgsqlPoint(x: 0.897931185010991d, y: 0.26943659004467146d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3984250319858569d, y: 0.2457945564435774d), new NpgsqlTypes.NpgsqlPoint(x: 0.14096897880697967d, y: 0.2484993620493292d), new NpgsqlTypes.NpgsqlPoint(x: 0.8282014136346051d, y: 0.5087625072143288d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5360453031478198d, y: 0.7548918625877973d), new NpgsqlTypes.NpgsqlPoint(x: 0.22625103124029355d, y: 0.6314747190961043d), new NpgsqlTypes.NpgsqlPoint(x: 0.21879061876088002d, y: 0.04650240667218675d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9454773488373391d, y: 0.7667694024734775d), new NpgsqlTypes.NpgsqlPoint(x: 0.22711500099168325d, y: 0.8110592854401988d), new NpgsqlTypes.NpgsqlPoint(x: 0.17190933623096105d, y: 0.614830503681292d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6052486354092075d, y: 0.11035103579652306d), new NpgsqlTypes.NpgsqlPoint(x: 0.35398692601040416d, y: 0.8370138892810526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815894678775326d, y: 0.8313895132512445d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8430822549600532d, y: 0.8513787170234011d), new NpgsqlTypes.NpgsqlPoint(x: 0.83907476954762d, y: 0.2888739920498157d), new NpgsqlTypes.NpgsqlPoint(x: 0.3726914537178234d, y: 0.8377033590953299d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9485846940464419d, y: 0.8808171960403538d), new NpgsqlTypes.NpgsqlPoint(x: 0.23091520559355427d, y: 0.7985019929823896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390967636277584d, y: 0.19322764173943885d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12415619898813146d, y: 0.059313585575964556d), new NpgsqlTypes.NpgsqlPoint(x: 0.12306090011535009d, y: 0.769781719390665d), new NpgsqlTypes.NpgsqlPoint(x: 0.02118853016705513d, y: 0.6787114999842343d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6585291686619729d, y: 0.5174362177826727d), new NpgsqlTypes.NpgsqlPoint(x: 0.36183134060980826d, y: 0.09017503724795439d), new NpgsqlTypes.NpgsqlPoint(x: 0.08744154184130237d, y: 0.07901972511676647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9310671309560044d, y: 0.4304893121433515d), new NpgsqlTypes.NpgsqlPoint(x: 0.12527825857994668d, y: 0.6625293889255589d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144946854070909d, y: 0.5739158512832369d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5140568300198676d, y: 0.4993246261623654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3001155411101787d, y: 0.6835578623713806d), new NpgsqlTypes.NpgsqlPoint(x: 0.10287889668190742d, y: 0.7260324987579455d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40877081917975744d, y: 0.9458959120071637d), new NpgsqlTypes.NpgsqlPoint(x: 0.08622336847729117d, y: 0.8378188045149239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728846049655202d, y: 0.6634051549375513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8685463600551174d, y: 0.31393486881157406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465056649090301d, y: 0.8784868673486621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885744431424027d, y: 0.5798327364417678d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4303762349813187d, y: 0.6054792084917209d), new NpgsqlTypes.NpgsqlPoint(x: 0.25239905097210114d, y: 0.7108864018797048d), new NpgsqlTypes.NpgsqlPoint(x: 0.2821019886840459d, y: 0.9337387810369498d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11464044646821292d, y: 0.6300189948517289d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461459599865664d, y: 0.14273895545053206d), new NpgsqlTypes.NpgsqlPoint(x: 0.2172194277767796d, y: 0.12789387834733024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.070069615446678d, y: 0.6864017373825713d), new NpgsqlTypes.NpgsqlPoint(x: 0.6508353039779211d, y: 0.33910380724872646d), new NpgsqlTypes.NpgsqlPoint(x: 0.014548103976950166d, y: 0.09008623236176483d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8658605466654625d, y: 0.4896132161264851d), new NpgsqlTypes.NpgsqlPoint(x: 0.7996194634900131d, y: 0.10223874172640535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074573857481361d, y: 0.5675600196416506d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3888392682439623d, y: 0.26121869787127383d), new NpgsqlTypes.NpgsqlPoint(x: 0.030443740347601556d, y: 0.14279328607567088d), new NpgsqlTypes.NpgsqlPoint(x: 0.4849195109977269d, y: 0.9255600788475005d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047185919211243155d, y: 0.5729710478853877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7755141448792078d, y: 0.8445358086265542d), new NpgsqlTypes.NpgsqlPoint(x: 0.14606923552656148d, y: 0.5210626513200239d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6956401978688638d, y: 0.5249282712300919d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147394787731858d, y: 0.07167915229544286d), new NpgsqlTypes.NpgsqlPoint(x: 0.3093313954481952d, y: 0.9946480761119402d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11312491881367825d, y: 0.6202059279368242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6083837183447529d, y: 0.401859328483686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867755905769304d, y: 0.32484454728274403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5434495059685517d, y: 0.017871925585303927d), new NpgsqlTypes.NpgsqlPoint(x: 0.44438623659501664d, y: 0.42236073582414413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752381046522647d, y: 0.04823522412836201d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942358286524167d, y: 0.2069831397837576d), new NpgsqlTypes.NpgsqlPoint(x: 0.35992942590168153d, y: 0.7848837220894775d), new NpgsqlTypes.NpgsqlPoint(x: 0.06430578436931245d, y: 0.9338550448681346d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6774393416583159d, y: 0.9445879116561724d), new NpgsqlTypes.NpgsqlPoint(x: 0.05490616513831803d, y: 0.47497128789360676d), new NpgsqlTypes.NpgsqlPoint(x: 0.05216154252468108d, y: 0.13790442265005376d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2738544343118108d, y: 0.0468263061293005d), new NpgsqlTypes.NpgsqlPoint(x: 0.958928208226073d, y: 0.7931177739660987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517734464513834d, y: 0.47692045063666066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3822913266346878d, y: 0.2823745506633146d), new NpgsqlTypes.NpgsqlPoint(x: 0.45225974639501887d, y: 0.8301343550214626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7795603206476597d, y: 0.13781632506689d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5407841687755166d, y: 0.1441604398784334d), new NpgsqlTypes.NpgsqlPoint(x: 0.12549196983272248d, y: 0.636757475950781d), new NpgsqlTypes.NpgsqlPoint(x: 0.05446968516639372d, y: 0.8945246566715452d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19478891586241098d, y: 0.25675367623240264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722580699573187d, y: 0.9863925645051016d), new NpgsqlTypes.NpgsqlPoint(x: 0.291511823433831d, y: 0.5515124288333189d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8169313976598939d, y: 0.01830618934889494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930311916139861d, y: 0.3267533434312393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328277952811293d, y: 0.2884764592453064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2738114842572673d, y: 0.6535411812880398d), new NpgsqlTypes.NpgsqlPoint(x: 0.15175221100382408d, y: 0.21549036914236597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740519441601794d, y: 0.2700067336677876d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.794644195272632d, y: 0.9686594869353097d), new NpgsqlTypes.NpgsqlPoint(x: 0.07961009765061022d, y: 0.7523982077467268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267250854280261d, y: 0.4061247379183729d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5747457474896782d, y: 0.9459338449114811d), new NpgsqlTypes.NpgsqlPoint(x: 0.15858027630642757d, y: 0.10299246822445907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7783974822606242d, y: 0.147048786016172d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4628856624416011d, y: 0.3705768934065008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7029876162910884d, y: 0.805192205619789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442644787739057d, y: 0.8536799632116039d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08095355093531631d, y: 0.19217045718618886d), new NpgsqlTypes.NpgsqlPoint(x: 0.859351285627996d, y: 0.08104790934858219d), new NpgsqlTypes.NpgsqlPoint(x: 0.041382146605281944d, y: 0.6833761894801516d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012282335007879897d, y: 0.6268224046669961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9331739470471184d, y: 0.09489901647131449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752579388095834d, y: 0.7710497502413962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3806093909312722d, y: 0.3096511577469907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7354398218038136d, y: 0.21728000042825746d), new NpgsqlTypes.NpgsqlPoint(x: 0.884844639117767d, y: 0.4215112109433855d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9679301988976621d, y: 0.5464707297107565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357675081008125d, y: 0.5385444288986754d), new NpgsqlTypes.NpgsqlPoint(x: 0.4144506486487912d, y: 0.7563404564814716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07263161475013691d, y: 0.22868478074724619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244051205213732d, y: 0.29125179451792393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058955532297331d, y: 0.9905211467003108d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3063971204034207d, y: 0.535374089546166d), new NpgsqlTypes.NpgsqlPoint(x: 0.09890986614896602d, y: 0.9630537640372244d), new NpgsqlTypes.NpgsqlPoint(x: 0.054128617185966954d, y: 0.5178343160712084d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884491180731091d, y: 0.18484543679840226d), new NpgsqlTypes.NpgsqlPoint(x: 0.17441880124879805d, y: 0.755707622711056d), new NpgsqlTypes.NpgsqlPoint(x: 0.76664765746956d, y: 0.9690681919465843d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6115629583075542d, y: 0.6109626105164749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3124968864017551d, y: 0.5440169048616194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587408080658118d, y: 0.5924987777372995d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34198497435770814d, y: 0.24897319515975358d), new NpgsqlTypes.NpgsqlPoint(x: 0.10279232214034784d, y: 0.11005547064042764d), new NpgsqlTypes.NpgsqlPoint(x: 0.215101744299658d, y: 0.9500744069395277d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4852562099660078d, y: 0.4038169598616773d), new NpgsqlTypes.NpgsqlPoint(x: 0.1350432686706261d, y: 0.2878150679484148d), new NpgsqlTypes.NpgsqlPoint(x: 0.4878682391542515d, y: 0.9377841269310587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2635733033130728d, y: 0.16934540456532898d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647222765312297d, y: 0.05796934787264163d), new NpgsqlTypes.NpgsqlPoint(x: 0.5728019891732093d, y: 0.2622131002096092d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08554629885057152d, y: 0.13578447276682504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504106326603825d, y: 0.41702159413182527d), new NpgsqlTypes.NpgsqlPoint(x: 0.42803872409121513d, y: 0.14805352289142037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08106098042827947d, y: 0.2031178827670339d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799662151975004d, y: 0.7347214333256966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7596931068773122d, y: 0.07120953477711012d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08743868599859572d, y: 0.9295159624835873d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895641359844485d, y: 0.540712017455013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6726167014935093d, y: 0.35583322445505616d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7535253811577999d, y: 0.5181277015781698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926574219891905d, y: 0.2252260549888d), new NpgsqlTypes.NpgsqlPoint(x: 0.07690702877405997d, y: 0.8881024500066806d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4642524158840663d, y: 0.10524641546054891d), new NpgsqlTypes.NpgsqlPoint(x: 0.48136198469216473d, y: 0.14759553758371224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4328326404321896d, y: 0.3762223367299372d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25848090485366293d, y: 0.37729250761839883d), new NpgsqlTypes.NpgsqlPoint(x: 0.699672570998134d, y: 0.5885642996801494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318067939561518d, y: 0.7024319990870727d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5896947808248105d, y: 0.5648430310217027d), new NpgsqlTypes.NpgsqlPoint(x: 0.039795153739873856d, y: 0.9507856858951362d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441133652034948d, y: 0.4130078748902336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6368756881370391d, y: 0.6947290962427142d), new NpgsqlTypes.NpgsqlPoint(x: 0.4525583961080707d, y: 0.09322720350218883d), new NpgsqlTypes.NpgsqlPoint(x: 0.963002918004253d, y: 0.9180879743179652d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40196094118691617d, y: 0.28835019556928876d), new NpgsqlTypes.NpgsqlPoint(x: 0.44500173468155d, y: 0.9091299594213949d), new NpgsqlTypes.NpgsqlPoint(x: 0.11947827569832259d, y: 0.6873354219157244d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8957190010079531d, y: 0.7693551611434675d), new NpgsqlTypes.NpgsqlPoint(x: 0.3576695375723119d, y: 0.4849069295770244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278540801474326d, y: 0.11655915053577293d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6303094347588962d, y: 0.2004447099042107d), new NpgsqlTypes.NpgsqlPoint(x: 0.39932366370138983d, y: 0.4858019656805096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747692142708913d, y: 0.9211853547559729d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6236778905524272d, y: 0.7141876826182579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7104804444406096d, y: 0.1817300078879006d), new NpgsqlTypes.NpgsqlPoint(x: 0.20915688516272302d, y: 0.6191504419556991d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40633966109897846d, y: 0.4517774314099898d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603289495412116d, y: 0.7102331322254918d), new NpgsqlTypes.NpgsqlPoint(x: 0.24349123802732153d, y: 0.19464720600519947d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9744152487726291d, y: 0.009919956166895005d), new NpgsqlTypes.NpgsqlPoint(x: 0.07840664743163883d, y: 0.8335598987994786d), new NpgsqlTypes.NpgsqlPoint(x: 0.05809684351191602d, y: 0.8071451344550756d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7699884127481504d, y: 0.5518612822804198d), new NpgsqlTypes.NpgsqlPoint(x: 0.10075451009296976d, y: 0.3781356943495803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259634938529345d, y: 0.3905480418328019d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.643884014435934d, y: 0.310485182059408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201176949420107d, y: 0.6985875419743139d), new NpgsqlTypes.NpgsqlPoint(x: 0.31376059354341035d, y: 0.43193454442334245d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7609580399228101d, y: 0.20856811891248683d), new NpgsqlTypes.NpgsqlPoint(x: 0.19953037454816336d, y: 0.1439711952988968d), new NpgsqlTypes.NpgsqlPoint(x: 0.15202005795243267d, y: 0.7754411348170622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3092523307494517d, y: 0.6237848364140002d), new NpgsqlTypes.NpgsqlPoint(x: 0.0177650603234627d, y: 0.7341954431885894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822499348023757d, y: 0.5568348227047077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05816040297966818d, y: 0.6432522274594287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3174020759221362d, y: 0.4596556144613395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146229071893044d, y: 0.6546309962321215d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5632855824759625d, y: 0.17679635723697584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4442413641292219d, y: 0.16747202479340784d), new NpgsqlTypes.NpgsqlPoint(x: 0.35344170215861526d, y: 0.7692199210570663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2906947148215987d, y: 0.7354737144514649d), new NpgsqlTypes.NpgsqlPoint(x: 0.08326176849093259d, y: 0.6912767862833203d), new NpgsqlTypes.NpgsqlPoint(x: 0.05310666600347014d, y: 0.16262001636002454d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8139119587890833d, y: 0.4663765887368436d), new NpgsqlTypes.NpgsqlPoint(x: 0.4333549184751163d, y: 0.3926270600380902d), new NpgsqlTypes.NpgsqlPoint(x: 0.02171217075671561d, y: 0.26435109396706824d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17596363616208932d, y: 0.48231454408608476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883147136717376d, y: 0.21396766110762555d), new NpgsqlTypes.NpgsqlPoint(x: 0.26380712232675274d, y: 0.4405552079912054d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8481053292543032d, y: 0.1930780232306072d), new NpgsqlTypes.NpgsqlPoint(x: 0.4250392798029331d, y: 0.3085186069215614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5021553417752549d, y: 0.07124982858640994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.977557497821017d, y: 0.12642568612013194d), new NpgsqlTypes.NpgsqlPoint(x: 0.2618557264113055d, y: 0.30278071986924626d), new NpgsqlTypes.NpgsqlPoint(x: 0.40039687256832335d, y: 0.7548246585062247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012095348089976699d, y: 0.8078936893098411d), new NpgsqlTypes.NpgsqlPoint(x: 0.4541420683668578d, y: 0.10853144958647631d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565775936109637d, y: 0.17467484382154463d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3671298928969494d, y: 0.4745453950887054d), new NpgsqlTypes.NpgsqlPoint(x: 0.40817880057362776d, y: 0.36263182860022736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930021132070654d, y: 0.6660811927276804d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5234201311826304d, y: 0.3611592967272649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009827650332875d, y: 0.24378598108461114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147090886039362d, y: 0.3479496353876934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6865469377264699d, y: 0.3485801207042267d), new NpgsqlTypes.NpgsqlPoint(x: 0.16603675029481413d, y: 0.12182120694485488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461135303580168d, y: 0.5148999089035464d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8333585260249063d, y: 0.595308237672503d), new NpgsqlTypes.NpgsqlPoint(x: 0.43257586575220086d, y: 0.43673902401228515d), new NpgsqlTypes.NpgsqlPoint(x: 0.16590294122783333d, y: 0.5937849598120363d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2807930659049951d, y: 0.1760746506313905d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653598331163356d, y: 0.3148355873817741d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534918736041917d, y: 0.3810650954202994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5890679662857707d, y: 0.6441094670071197d), new NpgsqlTypes.NpgsqlPoint(x: 0.021738120058456878d, y: 0.06104249045344423d), new NpgsqlTypes.NpgsqlPoint(x: 0.10691918782181609d, y: 0.9715992321400511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6774384884985106d, y: 0.1829284162100865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490410553826222d, y: 0.8505100287885845d), new NpgsqlTypes.NpgsqlPoint(x: 0.1756013661729069d, y: 0.7843719134579704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9375552397560094d, y: 0.6308543052031478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008300588108399d, y: 0.5635377028323297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140063631049183d, y: 0.30725115834671646d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6789296591742069d, y: 0.2224010641968749d), new NpgsqlTypes.NpgsqlPoint(x: 0.42901343387043567d, y: 0.009420927156605696d), new NpgsqlTypes.NpgsqlPoint(x: 0.4914192498103124d, y: 0.3960999815849616d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5509231454872014d, y: 0.46297749386863485d), new NpgsqlTypes.NpgsqlPoint(x: 0.03471770002742314d, y: 0.20968129924916368d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616270700413207d, y: 0.186161791939085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7829749456997788d, y: 0.6323668971581955d), new NpgsqlTypes.NpgsqlPoint(x: 0.44658289855522804d, y: 0.9902256524952407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6001359975056155d, y: 0.9192183765523967d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.118534061306097d, y: 0.3998293952155899d), new NpgsqlTypes.NpgsqlPoint(x: 0.05662218298289634d, y: 0.09854540662750855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874924556964065d, y: 0.031912408724251606d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4757684424588773d, y: 0.9693049878880242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8203204141045594d, y: 0.9507051199148498d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631438096240135d, y: 0.3771354898880491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.619388938511911d, y: 0.22671893879419924d), new NpgsqlTypes.NpgsqlPoint(x: 0.32602459605714673d, y: 0.15290761859947966d), new NpgsqlTypes.NpgsqlPoint(x: 0.06026958333290089d, y: 0.40810982054999d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5582741750008249d, y: 0.9882633605169059d), new NpgsqlTypes.NpgsqlPoint(x: 0.21873472853043985d, y: 0.21737604124534593d), new NpgsqlTypes.NpgsqlPoint(x: 0.3531243398780337d, y: 0.5130538566636557d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6910432567325026d, y: 0.5422155655942201d), new NpgsqlTypes.NpgsqlPoint(x: 0.48801380928710625d, y: 0.7453307468633033d), new NpgsqlTypes.NpgsqlPoint(x: 0.46155025955192464d, y: 0.23184725873126044d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9867685738572695d, y: 0.7565918439797497d), new NpgsqlTypes.NpgsqlPoint(x: 0.23744339303695638d, y: 0.9765380525445241d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527282859962875d, y: 0.8661103452772045d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8414742191855727d, y: 0.549782631317175d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768260391331382d, y: 0.5159719661198018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968581550699334d, y: 0.27412483594356285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6385569005522154d, y: 0.39782743318624836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828744418685461d, y: 0.45985587271265727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5316743377206851d, y: 0.6310690206994428d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22642221359107662d, y: 0.672199411036819d), new NpgsqlTypes.NpgsqlPoint(x: 0.03995005243795302d, y: 0.4772113332799649d), new NpgsqlTypes.NpgsqlPoint(x: 0.6751901681419651d, y: 0.08069445605917402d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5487803152855331d, y: 0.6703214428124283d), new NpgsqlTypes.NpgsqlPoint(x: 0.4581687320812423d, y: 0.8180839733733531d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026068375917151d, y: 0.6569564983480232d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7288483109858527d, y: 0.9328600936804197d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044064997859202d, y: 0.6427772625041217d), new NpgsqlTypes.NpgsqlPoint(x: 0.8618936961440162d, y: 0.5414382163286745d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.454682045336805d, y: 0.7069954558668026d), new NpgsqlTypes.NpgsqlPoint(x: 0.30230065493403013d, y: 0.8647002480155993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864959386306641d, y: 0.5568688350188599d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1725178404153015d, y: 0.7908824781396441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7427431367571847d, y: 0.6342648864775405d), new NpgsqlTypes.NpgsqlPoint(x: 0.3978924910317748d, y: 0.38632304374550597d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27679226716316563d, y: 0.8678501295276623d), new NpgsqlTypes.NpgsqlPoint(x: 0.16805141204299712d, y: 0.532769812616604d), new NpgsqlTypes.NpgsqlPoint(x: 0.06575207618104228d, y: 0.6166841564099703d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8252046006990741d, y: 0.009438789960211524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995897637869406d, y: 0.7504018491494023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369800390498067d, y: 0.2877860906734303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42256039581845684d, y: 0.9528055215029906d), new NpgsqlTypes.NpgsqlPoint(x: 0.26073544012785743d, y: 0.22122990312628887d), new NpgsqlTypes.NpgsqlPoint(x: 0.46292880387403224d, y: 0.22789702511362264d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7377448196117283d, y: 0.6447154814529612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327724165752898d, y: 0.18158681546532884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9602579395954575d, y: 0.9087624674161986d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7290021423952702d, y: 0.9997473902210883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126470035456245d, y: 0.058625140032733336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358644456293708d, y: 0.20114823755453504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8664070551981944d, y: 0.6914518888994905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495420392804645d, y: 0.6239590885880738d), new NpgsqlTypes.NpgsqlPoint(x: 0.29059598983689705d, y: 0.9874695383088649d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9429406154526635d, y: 0.5582290901434902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9655226251765253d, y: 0.14861589173282286d), new NpgsqlTypes.NpgsqlPoint(x: 0.1260351344076649d, y: 0.44574498961319586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2458629873106868d, y: 0.21746305673140676d), new NpgsqlTypes.NpgsqlPoint(x: 0.1028829603172583d, y: 0.5744007810556573d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164969753190637d, y: 0.40173713085288953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2185493541626945d, y: 0.886579203052351d), new NpgsqlTypes.NpgsqlPoint(x: 0.31474292158152084d, y: 0.6650664278519088d), new NpgsqlTypes.NpgsqlPoint(x: 0.4514158701748492d, y: 0.5733787875893231d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477939489595342d, y: 0.6477348702320241d), new NpgsqlTypes.NpgsqlPoint(x: 0.19923404599732053d, y: 0.8281688008480498d), new NpgsqlTypes.NpgsqlPoint(x: 0.519811777263873d, y: 0.09959268159233292d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00800906552763414d, y: 0.9833202850684389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323552916430124d, y: 0.37687671555499747d), new NpgsqlTypes.NpgsqlPoint(x: 0.04391352261363579d, y: 0.32544067495686746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8698104803551239d, y: 0.7842688235895205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9635595458616526d, y: 0.22387024719106763d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693015792045662d, y: 0.08421560877507084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9938061221433555d, y: 0.9671906303512959d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026996693541688d, y: 0.9812359500558984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268947766760175d, y: 0.1077950667961205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25601257833205027d, y: 0.4856028555705483d), new NpgsqlTypes.NpgsqlPoint(x: 0.35981970764581905d, y: 0.733978346018531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9234968137962338d, y: 0.07189884653141543d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08002504968154522d, y: 0.5249032796392704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5907839379889274d, y: 0.19082943670542973d), new NpgsqlTypes.NpgsqlPoint(x: 0.42204410804937276d, y: 0.9533728445812187d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9247936966291939d, y: 0.4730384249212569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8300760588454564d, y: 0.5501366925018629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361961149776692d, y: 0.6291945221139068d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7179111079974589d, y: 0.2211909223150752d), new NpgsqlTypes.NpgsqlPoint(x: 0.3065362177888836d, y: 0.1608993733113393d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739527088410474d, y: 0.7278880494787845d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6282830843074475d, y: 0.006487291862755873d), new NpgsqlTypes.NpgsqlPoint(x: 0.31352446723343264d, y: 0.44609872629686964d), new NpgsqlTypes.NpgsqlPoint(x: 0.3167127005077526d, y: 0.4081308169235708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900883361773714d, y: 0.8663811048948249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522670400171457d, y: 0.1958933539807557d), new NpgsqlTypes.NpgsqlPoint(x: 0.034655878972790544d, y: 0.24159228552173284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6743279991699569d, y: 0.36749909144830917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013186777122983d, y: 0.03544416310253795d), new NpgsqlTypes.NpgsqlPoint(x: 0.12195470161624056d, y: 0.28162089679177393d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8847288636060499d, y: 0.06775200138481774d), new NpgsqlTypes.NpgsqlPoint(x: 0.46235282508752407d, y: 0.7779741305043439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5963736456308878d, y: 0.30332753993043915d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5779269088386588d, y: 0.31501954609109406d), new NpgsqlTypes.NpgsqlPoint(x: 0.4040260783680929d, y: 0.4217172132716912d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852295195164118d, y: 0.40087311726202557d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36613404334622124d, y: 0.20786953915873418d), new NpgsqlTypes.NpgsqlPoint(x: 0.44131275467803843d, y: 0.8739219590060601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4751984643453996d, y: 0.6260364516989937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30691060953900995d, y: 0.28346917727525867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196804394302098d, y: 0.5283704373379564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3551038963445323d, y: 0.3139249221228546d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7465177588039603d, y: 0.6214912747569477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8376161336589873d, y: 0.668723424326221d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612346862848963d, y: 0.6598545468149777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9363913979176033d, y: 0.4921740704378561d), new NpgsqlTypes.NpgsqlPoint(x: 0.146046500898255d, y: 0.0592253162967894d), new NpgsqlTypes.NpgsqlPoint(x: 0.0940988394824177d, y: 0.09138134273716814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9923945255358984d, y: 0.2650392262792437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4669116162516358d, y: 0.9701499446910383d), new NpgsqlTypes.NpgsqlPoint(x: 0.44093458935286245d, y: 0.05572368923191262d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6094198111687639d, y: 0.5774575395976209d), new NpgsqlTypes.NpgsqlPoint(x: 0.48115251527214986d, y: 0.04793724982587211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144869065870244d, y: 0.35819974797528054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4322357041918523d, y: 0.06533767611060737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207844215972519d, y: 0.4108986539242302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7278254036180651d, y: 0.476554565018824d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007533374179505614d, y: 0.3578179597125507d), new NpgsqlTypes.NpgsqlPoint(x: 0.42199913216281737d, y: 0.5972227072693816d), new NpgsqlTypes.NpgsqlPoint(x: 0.1672079317912788d, y: 0.02059981937918498d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9536171433291389d, y: 0.9451414898726161d), new NpgsqlTypes.NpgsqlPoint(x: 0.23488086630187854d, y: 0.765647252877803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7693165287898699d, y: 0.349646486170495d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1769110926884152d, y: 0.7142080068496186d), new NpgsqlTypes.NpgsqlPoint(x: 0.33679970816176996d, y: 0.9667368339668392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238188000070414d, y: 0.8877050758989569d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8703069246970148d, y: 0.01724406984455229d), new NpgsqlTypes.NpgsqlPoint(x: 0.10819714682228343d, y: 0.5853450844127881d), new NpgsqlTypes.NpgsqlPoint(x: 0.2636052373795237d, y: 0.7429330079799911d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7408336723878395d, y: 0.6419485809134629d), new NpgsqlTypes.NpgsqlPoint(x: 0.8942659491390045d, y: 0.3578620371104888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7684251005791002d, y: 0.9255138059998128d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06999558940916761d, y: 0.0070304789097983544d), new NpgsqlTypes.NpgsqlPoint(x: 0.6054354156204204d, y: 0.12720680649022953d), new NpgsqlTypes.NpgsqlPoint(x: 0.796561979241033d, y: 0.8907801323515611d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6002319250414476d, y: 0.2676993450895856d), new NpgsqlTypes.NpgsqlPoint(x: 0.29160005915815346d, y: 0.5795823607764924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414769634189622d, y: 0.4877976692367354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6217425313059185d, y: 0.7506047101541781d), new NpgsqlTypes.NpgsqlPoint(x: 0.014131250324905142d, y: 0.2118197245866945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7381799472804358d, y: 0.9500881702524004d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3170097447144714d, y: 0.9557800875367062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162445006108934d, y: 0.23186042168278975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855682977973802d, y: 0.5206340174477929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7325748820520674d, y: 0.33477013366722863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340507768391508d, y: 0.5873314851785937d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328812306225713d, y: 0.43730556766796036d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.056496003938664385d, y: 0.7981352824846649d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406240430945334d, y: 0.1989283638713779d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256545149679176d, y: 0.7383246607652257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004148849988600767d, y: 0.7764530416005315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350829401166794d, y: 0.7797162069428263d), new NpgsqlTypes.NpgsqlPoint(x: 0.24187407059155253d, y: 0.613155356291513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6294628212409971d, y: 0.26052412172651596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6690305770931687d, y: 0.2539973251734957d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723274415790834d, y: 0.41039712032522024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011385098044307651d, y: 0.26193204723437513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891666312236293d, y: 0.8828446021267493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7220898996407684d, y: 0.47513715305779336d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.642305332168829d, y: 0.8234164307421529d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302625348704858d, y: 0.9928022153314809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298898301026078d, y: 0.383022834776239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9275771344748555d, y: 0.0845797380674792d), new NpgsqlTypes.NpgsqlPoint(x: 0.07968781944607861d, y: 0.9962296950612054d), new NpgsqlTypes.NpgsqlPoint(x: 0.24296950268311746d, y: 0.9902186199963127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.95017982785538d, y: 0.840841024479811d), new NpgsqlTypes.NpgsqlPoint(x: 0.022501661700759956d, y: 0.7750023162185139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7282859436495946d, y: 0.2569529289861444d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 39;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
                parametr1.Value = 46;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 66, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 137, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 118, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 39, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 15, query1, 88, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 96, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 22, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

