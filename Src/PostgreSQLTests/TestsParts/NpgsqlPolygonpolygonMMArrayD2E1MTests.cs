

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD2
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD2 : INpgsqlPolygonMArraypolygonMMArrayD2
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD2E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD2E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9782793504884827d, y: 0.2297191285653587d), new NpgsqlTypes.NpgsqlPoint(x: 0.12121767086865864d, y: 0.9895148290076403d), new NpgsqlTypes.NpgsqlPoint(x: 0.4981932036771649d, y: 0.6400361865982471d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7471245990817243d, y: 0.19752419558152345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288564259723527d, y: 0.17193603282335534d), new NpgsqlTypes.NpgsqlPoint(x: 0.07048817382885664d, y: 0.20625379129815335d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38001309738954414d, y: 0.7652519081179503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463762697565702d, y: 0.17286393300294156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426365450358799d, y: 0.46586349389641424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6883086846297972d, y: 0.6856371074482501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311243626143649d, y: 0.9347639583175684d), new NpgsqlTypes.NpgsqlPoint(x: 0.022370399872883806d, y: 0.6157895939093307d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5918242579518856d, y: 0.5686856888434207d), new NpgsqlTypes.NpgsqlPoint(x: 0.01106031437206012d, y: 0.5044291142743297d), new NpgsqlTypes.NpgsqlPoint(x: 0.2108849926734898d, y: 0.9096220276359965d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2746301055004583d, y: 0.7556726504803027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6343004423345872d, y: 0.4176658612470371d), new NpgsqlTypes.NpgsqlPoint(x: 0.015339136157355493d, y: 0.4248245289046205d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20693911332620074d, y: 0.5355543014720049d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628027768584633d, y: 0.38273073736492713d), new NpgsqlTypes.NpgsqlPoint(x: 0.37061110097005623d, y: 0.7543274202529773d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4717898269054446d, y: 0.9792868840627986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972568354560055d, y: 0.9047814574952172d), new NpgsqlTypes.NpgsqlPoint(x: 0.2287861935202682d, y: 0.9541558440197891d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5170134393660824d, y: 0.5287652093681783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342530610505851d, y: 0.6286459136714035d), new NpgsqlTypes.NpgsqlPoint(x: 0.46725417607843156d, y: 0.2716961846539172d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.420873558877907d, y: 0.16426218944920268d), new NpgsqlTypes.NpgsqlPoint(x: 0.4270696254564159d, y: 0.3903082152168865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954685757934677d, y: 0.4220405848301958d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7269515278490647d, y: 0.1163848257716038d), new NpgsqlTypes.NpgsqlPoint(x: 0.19721444060288684d, y: 0.34767140140790753d), new NpgsqlTypes.NpgsqlPoint(x: 0.31547417849585013d, y: 0.8173048145610555d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9358553879972948d, y: 0.14628282684826055d), new NpgsqlTypes.NpgsqlPoint(x: 0.4552114551379355d, y: 0.6178027581512199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4185555372896851d, y: 0.5048247473654349d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27459751627607765d, y: 0.196885124368265d), new NpgsqlTypes.NpgsqlPoint(x: 0.48672354562072095d, y: 0.36192031418477677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7830572339545441d, y: 0.25185944856107145d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07542241096259872d, y: 0.1574889892133292d), new NpgsqlTypes.NpgsqlPoint(x: 0.452880107125495d, y: 0.24666605085508186d), new NpgsqlTypes.NpgsqlPoint(x: 0.4507660575737933d, y: 0.6743649747825007d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36310181151329224d, y: 0.009720607223025035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7125475668003651d, y: 0.9637730537951531d), new NpgsqlTypes.NpgsqlPoint(x: 0.14109506899877267d, y: 0.444298637511348d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8731390086074794d, y: 0.11979024798769522d), new NpgsqlTypes.NpgsqlPoint(x: 0.25969237728358907d, y: 0.1825206935995224d), new NpgsqlTypes.NpgsqlPoint(x: 0.04435224819861716d, y: 0.038974838486292906d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7564736574891086d, y: 0.07396626694026853d), new NpgsqlTypes.NpgsqlPoint(x: 0.11006362154914984d, y: 0.12325650724722592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6247554796874376d, y: 0.4956775825959109d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4505836285966578d, y: 0.22533360402231595d), new NpgsqlTypes.NpgsqlPoint(x: 0.03416899841068577d, y: 0.7186127288191706d), new NpgsqlTypes.NpgsqlPoint(x: 0.10339402677942933d, y: 0.936660917674991d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5657982510351359d, y: 0.5988277379144401d), new NpgsqlTypes.NpgsqlPoint(x: 0.887528693491207d, y: 0.6826779712321689d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170659203692455d, y: 0.9975638730785527d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3033077043126817d, y: 0.034476466951991136d), new NpgsqlTypes.NpgsqlPoint(x: 0.33131187260345685d, y: 0.8771585764450924d), new NpgsqlTypes.NpgsqlPoint(x: 0.36129048579610434d, y: 0.40408589012738216d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4644760760386447d, y: 0.6145543765542505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2846937342927426d, y: 0.4156920947785071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718753362824624d, y: 0.41112244028059264d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1807822955281494d, y: 0.05691136414960751d), new NpgsqlTypes.NpgsqlPoint(x: 0.6597714614444445d, y: 0.17049457358863307d), new NpgsqlTypes.NpgsqlPoint(x: 0.3393028232290717d, y: 0.13285130648902732d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32690605295133035d, y: 0.12292720612221242d), new NpgsqlTypes.NpgsqlPoint(x: 0.13626771706162677d, y: 0.6050234116445049d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678826107459411d, y: 0.7852867670483158d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7217037161570073d, y: 0.027738687788224192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3904741623761563d, y: 0.6732363208167843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089452311270236d, y: 0.7857885195741346d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17454669671135759d, y: 0.9545024836168643d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614697266178341d, y: 0.23372947167718694d), new NpgsqlTypes.NpgsqlPoint(x: 0.38893677031171947d, y: 0.2049427180718425d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9618478975276614d, y: 0.8010294184048307d), new NpgsqlTypes.NpgsqlPoint(x: 0.917892280483597d, y: 0.574836701996339d), new NpgsqlTypes.NpgsqlPoint(x: 0.13424123867626447d, y: 0.6674884060327756d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049292858397741446d, y: 0.33964880800177033d), new NpgsqlTypes.NpgsqlPoint(x: 0.062395142600135234d, y: 0.23111548696825002d), new NpgsqlTypes.NpgsqlPoint(x: 0.577838372219681d, y: 0.39625437596754554d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2865735922190501d, y: 0.9002064364762731d), new NpgsqlTypes.NpgsqlPoint(x: 0.26647882627507047d, y: 0.9787788147973833d), new NpgsqlTypes.NpgsqlPoint(x: 0.9092895243037772d, y: 0.9915535560109663d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9574810282741306d, y: 0.49009056862300404d), new NpgsqlTypes.NpgsqlPoint(x: 0.042553191435474313d, y: 0.46736234389023446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996971293281397d, y: 0.33800198712146934d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05429023975730429d, y: 0.9741535834386188d), new NpgsqlTypes.NpgsqlPoint(x: 0.07187879323883939d, y: 0.5246956846964926d), new NpgsqlTypes.NpgsqlPoint(x: 0.14780090573160265d, y: 0.38167778336594393d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1770836708690089d, y: 0.14070222589428139d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239685048055678d, y: 0.31266043165184554d), new NpgsqlTypes.NpgsqlPoint(x: 0.265009114288861d, y: 0.6527268286673258d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7657171945748908d, y: 0.39349064946251855d), new NpgsqlTypes.NpgsqlPoint(x: 0.04688897769367528d, y: 0.9091996005352071d), new NpgsqlTypes.NpgsqlPoint(x: 0.32868822416686927d, y: 0.8490782104788512d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21841865427426588d, y: 0.3966055462111816d), new NpgsqlTypes.NpgsqlPoint(x: 0.30260520822434356d, y: 0.9384007394704688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037422430110612d, y: 0.15710275620124126d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4126720613892615d, y: 0.9814649268346018d), new NpgsqlTypes.NpgsqlPoint(x: 0.019750559715405402d, y: 0.7183367564537255d), new NpgsqlTypes.NpgsqlPoint(x: 0.2493927492692406d, y: 0.9220181617864792d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36302179640779897d, y: 0.3016904387300773d), new NpgsqlTypes.NpgsqlPoint(x: 0.3074924021060206d, y: 0.8716320335678294d), new NpgsqlTypes.NpgsqlPoint(x: 0.18091446212508988d, y: 0.490710472480848d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5715043417036695d, y: 0.8711454381500939d), new NpgsqlTypes.NpgsqlPoint(x: 0.10681604006023138d, y: 0.9284095003304962d), new NpgsqlTypes.NpgsqlPoint(x: 0.2502564874857638d, y: 0.08224273377119096d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8034089676035052d, y: 0.6589095300933994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9857138969016015d, y: 0.41046504432359776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5886159398330892d, y: 0.4778463370496653d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19172136980895949d, y: 0.07663754419077617d), new NpgsqlTypes.NpgsqlPoint(x: 0.2602447193743248d, y: 0.7093984197863759d), new NpgsqlTypes.NpgsqlPoint(x: 0.8405056441609364d, y: 0.9542350301222837d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3762930484739547d, y: 0.19311405986173602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495468499706962d, y: 0.2903717751077366d), new NpgsqlTypes.NpgsqlPoint(x: 0.18565032662913883d, y: 0.641310206452807d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07446012701352389d, y: 0.21176370680750756d), new NpgsqlTypes.NpgsqlPoint(x: 0.004806909327729647d, y: 0.0914302060650285d), new NpgsqlTypes.NpgsqlPoint(x: 0.424190113328319d, y: 0.6222752381189754d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6345997172593786d, y: 0.057315112549797376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134106682065987d, y: 0.6009082447201455d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025614063616082d, y: 0.2371822949463418d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.857795233677031d, y: 0.3677503916296252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874410059247353d, y: 0.5641148629082475d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314945213752004d, y: 0.9839207485802781d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2455950844494016d, y: 0.7133624778011295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231853116600859d, y: 0.8643358292928294d), new NpgsqlTypes.NpgsqlPoint(x: 0.36864886406708575d, y: 0.4040725880998737d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31589935654741685d, y: 0.6064509655133679d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435152938218126d, y: 0.04345638594256385d), new NpgsqlTypes.NpgsqlPoint(x: 0.32011118131298866d, y: 0.4349303874392505d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9383049876127881d, y: 0.35162288632451755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7789283089532135d, y: 0.6192859828412322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8277384679282332d, y: 0.7985607064662055d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7876949726316673d, y: 0.8863552878031188d), new NpgsqlTypes.NpgsqlPoint(x: 0.16879737806446315d, y: 0.10001214694087035d), new NpgsqlTypes.NpgsqlPoint(x: 0.67021263183604d, y: 0.23944738931007647d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12057430991035734d, y: 0.47726967527848974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692462394384615d, y: 0.932555755795808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854449791179693d, y: 0.23724755086559546d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7257081706298399d, y: 0.4772789131592463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541305437897473d, y: 0.9329802997870829d), new NpgsqlTypes.NpgsqlPoint(x: 0.9212861176353777d, y: 0.7497325476428693d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.851848478548091d, y: 0.13100517979782134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4201012813790751d, y: 0.5765899955465883d), new NpgsqlTypes.NpgsqlPoint(x: 0.44301085222689685d, y: 0.02209241899449066d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.766778238570179d, y: 0.13205931518828185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940568859042354d, y: 0.8060119178664238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160889577693721d, y: 0.18753233582505668d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21424289218924242d, y: 0.7001784914537086d), new NpgsqlTypes.NpgsqlPoint(x: 0.04495061965204661d, y: 0.37630890335705114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492380387347891d, y: 0.6777905174615866d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2310408150522576d, y: 0.5418630201539302d), new NpgsqlTypes.NpgsqlPoint(x: 0.4260012170577905d, y: 0.7137989909332076d), new NpgsqlTypes.NpgsqlPoint(x: 0.34127350303881465d, y: 0.4808927150770942d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8360587759881725d, y: 0.026723558605293962d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741714985633118d, y: 0.5377385730437095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6774296324596663d, y: 0.30028388862643685d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7218625356004126d, y: 0.2591889752922365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691603761339745d, y: 0.8088581407505478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806244882916364d, y: 0.474194550309031d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3361085031441533d, y: 0.33152893474446565d), new NpgsqlTypes.NpgsqlPoint(x: 0.1976022842852988d, y: 0.7447365839381581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777017352956162d, y: 0.06069975796931926d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.949396437493939d, y: 0.12243180057059211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6084011834115546d, y: 0.09617393780400485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6944894536013189d, y: 0.41526669941352323d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.387414200774725d, y: 0.5669707603565944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885270689899326d, y: 0.1517008422789884d), new NpgsqlTypes.NpgsqlPoint(x: 0.10324106692255153d, y: 0.03923704508231707d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23892517398148128d, y: 0.9875432117711167d), new NpgsqlTypes.NpgsqlPoint(x: 0.026505789060460527d, y: 0.5809971740740921d), new NpgsqlTypes.NpgsqlPoint(x: 0.07494228679324966d, y: 0.9343519122971056d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7124014952194517d, y: 0.42446995181305136d), new NpgsqlTypes.NpgsqlPoint(x: 0.11519230834228722d, y: 0.8295689446508643d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925969861058542d, y: 0.8649767366480998d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3021020209598356d, y: 0.6788158357804842d), new NpgsqlTypes.NpgsqlPoint(x: 0.7049655653445231d, y: 0.9266313564968387d), new NpgsqlTypes.NpgsqlPoint(x: 0.10307251794471428d, y: 0.9579812610671574d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9903765445177505d, y: 0.8892298172257205d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241525076849987d, y: 0.48632222852366647d), new NpgsqlTypes.NpgsqlPoint(x: 0.03908434418858109d, y: 0.6674432836331672d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09187605387354825d, y: 0.37885384759684304d), new NpgsqlTypes.NpgsqlPoint(x: 0.6205237254931723d, y: 0.9820298593671317d), new NpgsqlTypes.NpgsqlPoint(x: 0.0393858361172722d, y: 0.837101920957384d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7468868163276703d, y: 0.32472690406326d), new NpgsqlTypes.NpgsqlPoint(x: 0.36296766635730116d, y: 0.011408558002240499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797482393028603d, y: 0.6146817561615155d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5445533567141105d, y: 0.8356336583530847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456326808043396d, y: 0.7887034094953538d), new NpgsqlTypes.NpgsqlPoint(x: 0.20964151153366095d, y: 0.2395755287068687d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32040311086935147d, y: 0.7295081176085607d), new NpgsqlTypes.NpgsqlPoint(x: 0.09150262934529552d, y: 0.39574938577164154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5650239150981154d, y: 0.3836139055175998d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9026817030877641d, y: 0.8456863506759476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9757154122706313d, y: 0.01881718651680253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531664291194683d, y: 0.2967187036990576d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23757027340504255d, y: 0.8844655361992932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640984291934548d, y: 0.6590389398073555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868626587974854d, y: 0.697715868385962d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.396349866094441d, y: 0.828297050697011d), new NpgsqlTypes.NpgsqlPoint(x: 0.030364448802020938d, y: 0.44524661304065927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9037465904023363d, y: 0.6685276647219386d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7946700509846496d, y: 0.07776739770034113d), new NpgsqlTypes.NpgsqlPoint(x: 0.00721602744885852d, y: 0.06812721754524953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004048187423338d, y: 0.31470848922062356d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05542844298005778d, y: 0.20383980832221382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298724984971334d, y: 0.9424143112830303d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444961396513713d, y: 0.6000263571890689d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5635678818493057d, y: 0.003354736872629882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6300126900913317d, y: 0.19743841072478407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7673196081652187d, y: 0.7996540096856495d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15865322401904725d, y: 0.9664556547582553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317744613571988d, y: 0.9734461168796454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268953185189417d, y: 0.8548148558492796d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28581106735320594d, y: 0.39178227767378704d), new NpgsqlTypes.NpgsqlPoint(x: 0.44083281538525243d, y: 0.5664368910530788d), new NpgsqlTypes.NpgsqlPoint(x: 0.1679111123439362d, y: 0.19733447173896312d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464475068446486d, y: 0.38121766412172264d), new NpgsqlTypes.NpgsqlPoint(x: 0.026824421745635374d, y: 0.26109087643402096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875858904308014d, y: 0.8692239955933038d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9320468098549877d, y: 0.35944669059288803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253047811936949d, y: 0.6407354601446407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840187304363869d, y: 0.4538251678213231d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3841361773158207d, y: 0.8195358189864964d), new NpgsqlTypes.NpgsqlPoint(x: 0.15946567197367212d, y: 0.5356846476143845d), new NpgsqlTypes.NpgsqlPoint(x: 0.12038232588333497d, y: 0.8849720770460869d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04335986689254723d, y: 0.15094757722578278d), new NpgsqlTypes.NpgsqlPoint(x: 0.10927921455377698d, y: 0.8021283574163899d), new NpgsqlTypes.NpgsqlPoint(x: 0.2495793975864794d, y: 0.7475256242720475d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03021438331206716d, y: 0.2422567146418131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554992939628422d, y: 0.7862572288159182d), new NpgsqlTypes.NpgsqlPoint(x: 0.73911328344947d, y: 0.6577562479610212d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1256613046741486d, y: 0.6014049818480786d), new NpgsqlTypes.NpgsqlPoint(x: 0.18195899400625215d, y: 0.1209200715785439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199903678668999d, y: 0.9650381237300205d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.856006554921569d, y: 0.6453092738392192d), new NpgsqlTypes.NpgsqlPoint(x: 0.06218143575704982d, y: 0.6408448292840888d), new NpgsqlTypes.NpgsqlPoint(x: 0.707855671783249d, y: 0.21111857101375286d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4280784214597261d, y: 0.43001053188555705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086146432464197d, y: 0.22756808992531796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926279302842924d, y: 0.02240728264078351d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47149357012440307d, y: 0.7461120053980176d), new NpgsqlTypes.NpgsqlPoint(x: 0.799545202770429d, y: 0.3072136102755114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7817449933835631d, y: 0.8097023196498353d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5525897081804821d, y: 0.8493247717682538d), new NpgsqlTypes.NpgsqlPoint(x: 0.1764389758007423d, y: 0.647679006270763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5148694338469051d, y: 0.6510622109952687d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8798639721370184d, y: 0.05437227307812631d), new NpgsqlTypes.NpgsqlPoint(x: 0.09726631533777985d, y: 0.5605501346508339d), new NpgsqlTypes.NpgsqlPoint(x: 0.45864902492785764d, y: 0.5605452997888379d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7134302608589623d, y: 0.015620482237059363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164369758074232d, y: 0.3147865837913466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707494723784204d, y: 0.36940842009541d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6156190170795176d, y: 0.0586757234127101d), new NpgsqlTypes.NpgsqlPoint(x: 0.09867435669284308d, y: 0.9545882318905182d), new NpgsqlTypes.NpgsqlPoint(x: 0.036503395976408726d, y: 0.783011009601924d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7984924886524964d, y: 0.5142552358997464d), new NpgsqlTypes.NpgsqlPoint(x: 0.675319440989949d, y: 0.14685675298259615d), new NpgsqlTypes.NpgsqlPoint(x: 0.2638195886522745d, y: 0.20379226821541907d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9597474830703353d, y: 0.38942155898338393d), new NpgsqlTypes.NpgsqlPoint(x: 0.3586606477666838d, y: 0.10094055132733759d), new NpgsqlTypes.NpgsqlPoint(x: 0.27575128431847584d, y: 0.48655896650118635d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9473405086861661d, y: 0.3317420671351218d), new NpgsqlTypes.NpgsqlPoint(x: 0.40926843085972875d, y: 0.39220910788825347d), new NpgsqlTypes.NpgsqlPoint(x: 0.08804661191174257d, y: 0.08715621739630608d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.897566459381272d, y: 0.2848064624068696d), new NpgsqlTypes.NpgsqlPoint(x: 0.575612696209331d, y: 0.42355056235440436d), new NpgsqlTypes.NpgsqlPoint(x: 0.16079842386339105d, y: 0.6549801168573276d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8821664918908704d, y: 0.07007991761656895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727471401139921d, y: 0.4258496052580455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687593045507622d, y: 0.27752207743522994d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17181451113969748d, y: 0.7653328457290486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9379904587120135d, y: 0.7785470677844889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961049379334098d, y: 0.7715622331145531d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14593093036967886d, y: 0.6121606031012009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5090765469981087d, y: 0.691021292203932d), new NpgsqlTypes.NpgsqlPoint(x: 0.8806179650684419d, y: 0.21321301675711113d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5863207813356599d, y: 0.5706923972040213d), new NpgsqlTypes.NpgsqlPoint(x: 0.03254120445001407d, y: 0.027248685769562964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4954403701230805d, y: 0.9896338607477853d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3079270594122402d, y: 0.5156060569471196d), new NpgsqlTypes.NpgsqlPoint(x: 0.48252005989254665d, y: 0.8098651817469669d), new NpgsqlTypes.NpgsqlPoint(x: 0.6913438756491281d, y: 0.7138651765072057d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30586754553891204d, y: 0.48269493327167956d), new NpgsqlTypes.NpgsqlPoint(x: 0.628772565550529d, y: 0.6255273125982408d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465205358182509d, y: 0.8052447711276576d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6480010467590785d, y: 0.4641716968665288d), new NpgsqlTypes.NpgsqlPoint(x: 0.31854255005948307d, y: 0.6482261734246224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233651621331448d, y: 0.6823735315021277d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3501906618821591d, y: 0.6729712610057847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9740161408412354d, y: 0.8792732119149234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968203089521471d, y: 0.6596095688734498d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8667280699026748d, y: 0.8242630198996654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975902612344356d, y: 0.14095862832403627d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440971469822708d, y: 0.4674572067010039d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.660777837135296d, y: 0.524318734632701d), new NpgsqlTypes.NpgsqlPoint(x: 0.6177110041199907d, y: 0.5243039460097898d), new NpgsqlTypes.NpgsqlPoint(x: 0.87754803838793d, y: 0.8168605219206768d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7373170445642917d, y: 0.17497453705553412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063884933640561d, y: 0.8767917490227894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3891965200228883d, y: 0.4926189991217518d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5555550674311378d, y: 0.7991768742331106d), new NpgsqlTypes.NpgsqlPoint(x: 0.20336868112281192d, y: 0.7811377316553589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407550837635086d, y: 0.13624218816066425d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38019983379193156d, y: 0.6495395387681931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875643806008384d, y: 0.06041624130966672d), new NpgsqlTypes.NpgsqlPoint(x: 0.17855931504548295d, y: 0.1863538576355358d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24750432021307234d, y: 0.8487530672367589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526044701965145d, y: 0.7540756599432371d), new NpgsqlTypes.NpgsqlPoint(x: 0.45629834446117634d, y: 0.5944382881076561d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8284207774596797d, y: 0.8085535663691339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019082326243121d, y: 0.9487980392036496d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688962036233583d, y: 0.937600978284235d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9734147653719375d, y: 0.5630862072389287d), new NpgsqlTypes.NpgsqlPoint(x: 0.2059583803858236d, y: 0.5479199943498098d), new NpgsqlTypes.NpgsqlPoint(x: 0.07493567304686055d, y: 0.013442248314553762d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9396467863223162d, y: 0.07143929398475102d), new NpgsqlTypes.NpgsqlPoint(x: 0.0379173946395045d, y: 0.6669244196841267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4368010941853496d, y: 0.8371954507052768d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41318186806652746d, y: 0.04022522602630163d), new NpgsqlTypes.NpgsqlPoint(x: 0.23939013999740122d, y: 0.43010742764358756d), new NpgsqlTypes.NpgsqlPoint(x: 0.15366111806720695d, y: 0.2800148638971066d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3173379596350352d, y: 0.90183480498371d), new NpgsqlTypes.NpgsqlPoint(x: 0.23513852759582476d, y: 0.6185010889227346d), new NpgsqlTypes.NpgsqlPoint(x: 0.20780819127821482d, y: 0.7613794917273493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8984935760362855d, y: 0.6767327559420828d), new NpgsqlTypes.NpgsqlPoint(x: 0.1830310181432354d, y: 0.628263125967717d), new NpgsqlTypes.NpgsqlPoint(x: 0.7380796168829132d, y: 0.3307135666693456d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2288327691969343d, y: 0.6343810063293894d), new NpgsqlTypes.NpgsqlPoint(x: 0.26078478969729624d, y: 0.6416918548626944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7698630817852704d, y: 0.33296292320497967d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.985492856907393d, y: 0.9043099243328543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947912775130059d, y: 0.938803386723038d), new NpgsqlTypes.NpgsqlPoint(x: 0.10196800995165678d, y: 0.7941227214284008d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6845642728735715d, y: 0.8886526228724186d), new NpgsqlTypes.NpgsqlPoint(x: 0.06430131448440102d, y: 0.7208666627448644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465139743666523d, y: 0.5680366831504928d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3995310956895993d, y: 0.16492234091155145d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856381389813872d, y: 0.4294453000237748d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189601633407494d, y: 0.6856064574582085d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5969210364434872d, y: 0.4337463584021455d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280432634989429d, y: 0.14865009569455456d), new NpgsqlTypes.NpgsqlPoint(x: 0.28066810402689024d, y: 0.4032289488487196d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0382193216815202d, y: 0.2715942422938341d), new NpgsqlTypes.NpgsqlPoint(x: 0.18733394219320942d, y: 0.5245172744557757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943249214828528d, y: 0.8457189033959207d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14695225515483512d, y: 0.33235344412375956d), new NpgsqlTypes.NpgsqlPoint(x: 0.7300637603111164d, y: 0.44716348160756947d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754174764438638d, y: 0.25049972901483386d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6022420051433512d, y: 0.31551894385111046d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654034890644934d, y: 0.13530459507777048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4264787693537103d, y: 0.8310236655264723d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12889977401139918d, y: 0.8206933350126948d), new NpgsqlTypes.NpgsqlPoint(x: 0.13047513733939464d, y: 0.8459452051004057d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386428331685952d, y: 0.763830225761018d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8933205702496855d, y: 0.24584923918024115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197724284663063d, y: 0.29880592200112754d), new NpgsqlTypes.NpgsqlPoint(x: 0.47513367705343634d, y: 0.6897148738876148d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.614285585762731d, y: 0.6695406261420936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113617559346488d, y: 0.727683140584745d), new NpgsqlTypes.NpgsqlPoint(x: 0.333354044067509d, y: 0.1295054000398519d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3733794841481072d, y: 0.8783488408468502d), new NpgsqlTypes.NpgsqlPoint(x: 0.028524520347996796d, y: 0.30240843501448744d), new NpgsqlTypes.NpgsqlPoint(x: 0.25823148924668804d, y: 0.4996307201139587d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16895576762631048d, y: 0.852848351756814d), new NpgsqlTypes.NpgsqlPoint(x: 0.46443882958772464d, y: 0.32038817969574584d), new NpgsqlTypes.NpgsqlPoint(x: 0.34122157147806065d, y: 0.12472299332544268d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5504115024602974d, y: 0.35748977990589714d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848093723634402d, y: 0.02608771473573457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7206500669228425d, y: 0.14959025765034506d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9761770647584752d, y: 0.08427076035944181d), new NpgsqlTypes.NpgsqlPoint(x: 0.1174436448372852d, y: 0.10595537311346992d), new NpgsqlTypes.NpgsqlPoint(x: 0.2741174207563266d, y: 0.8065330999299821d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07579807978362363d, y: 0.580645883043016d), new NpgsqlTypes.NpgsqlPoint(x: 0.33617478465095996d, y: 0.6578716808255495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472813364697472d, y: 0.23573147878810108d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9634899297403363d, y: 0.8697743986945812d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204798104399527d, y: 0.2974367650352012d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243588676114187d, y: 0.6287734550450007d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4238422856151096d, y: 0.007533047401249493d), new NpgsqlTypes.NpgsqlPoint(x: 0.451465411250881d, y: 0.5147967112259286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406645117080088d, y: 0.9377110505121302d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9838281754192183d, y: 0.29624103741727625d), new NpgsqlTypes.NpgsqlPoint(x: 0.009977706403079711d, y: 0.5642016384087923d), new NpgsqlTypes.NpgsqlPoint(x: 0.05162186929390522d, y: 0.2973764890151651d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9888822022241059d, y: 0.814832352107634d), new NpgsqlTypes.NpgsqlPoint(x: 0.24605129685745053d, y: 0.26644590535087687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3328979103282559d, y: 0.23356726880172152d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4571152205084138d, y: 0.8176168383678777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5739012161776629d, y: 0.30926343496283704d), new NpgsqlTypes.NpgsqlPoint(x: 0.3515412689289268d, y: 0.13572678891558299d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9717133140087011d, y: 0.06459696023917627d), new NpgsqlTypes.NpgsqlPoint(x: 0.927749297213614d, y: 0.03624867487579175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367502200264687d, y: 0.8275331659236768d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8926550400613276d, y: 0.199566422440683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421560520127762d, y: 0.9060262848350223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1397067723316281d, y: 0.9399250795777183d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7928224372161145d, y: 0.2543952587280688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6492054917908108d, y: 0.3032783080286291d), new NpgsqlTypes.NpgsqlPoint(x: 0.9580965120254363d, y: 0.047317521592802114d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4265525369335005d, y: 0.09834016169521265d), new NpgsqlTypes.NpgsqlPoint(x: 0.30357410196947343d, y: 0.9036567772149884d), new NpgsqlTypes.NpgsqlPoint(x: 0.14404692024595744d, y: 0.797564013504815d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3494876768511498d, y: 0.5690673369885084d), new NpgsqlTypes.NpgsqlPoint(x: 0.13061837991671255d, y: 0.35935455454366094d), new NpgsqlTypes.NpgsqlPoint(x: 0.24732880799297852d, y: 0.8329525314309727d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3273228514581381d, y: 0.722938207954638d), new NpgsqlTypes.NpgsqlPoint(x: 0.19694770131135642d, y: 0.38789520258309773d), new NpgsqlTypes.NpgsqlPoint(x: 0.005675003042045268d, y: 0.3814440830678514d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32709206681476954d, y: 0.9082454462579467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9497279099450257d, y: 0.9474695991613429d), new NpgsqlTypes.NpgsqlPoint(x: 0.4307904965819661d, y: 0.9098684617600883d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2752399057655045d, y: 0.9283268700622169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969167974457539d, y: 0.16057174169830246d), new NpgsqlTypes.NpgsqlPoint(x: 0.26528602139869983d, y: 0.9918872555880552d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.414410846928163d, y: 0.8528254781922346d), new NpgsqlTypes.NpgsqlPoint(x: 0.11714458398527072d, y: 0.7769514295429228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8525868379544551d, y: 0.8539361038809075d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14270179232584457d, y: 0.8199239504239374d), new NpgsqlTypes.NpgsqlPoint(x: 0.33436819188250755d, y: 0.5289532792847066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196794746369592d, y: 0.5645621981135563d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5929794470564796d, y: 0.34549786286862394d), new NpgsqlTypes.NpgsqlPoint(x: 0.24321371373689726d, y: 0.7008778242325339d), new NpgsqlTypes.NpgsqlPoint(x: 0.7222280888676307d, y: 0.7691768530349375d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4591656038915003d, y: 0.06977890490379401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161443839911634d, y: 0.4570720722083107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975453078049979d, y: 0.033239143844899455d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22992871280042138d, y: 0.3590950395686855d), new NpgsqlTypes.NpgsqlPoint(x: 0.4161479786651421d, y: 0.6364194999075526d), new NpgsqlTypes.NpgsqlPoint(x: 0.09252916785168397d, y: 0.3367344247982743d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9835605425558975d, y: 0.4904717356928956d), new NpgsqlTypes.NpgsqlPoint(x: 0.016803582308194787d, y: 0.8378390695250274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050035240690727d, y: 0.3865470095848972d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26112531874428024d, y: 0.2742647686948344d), new NpgsqlTypes.NpgsqlPoint(x: 0.700177384170621d, y: 0.667588849670114d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417625159344833d, y: 0.7008964026817147d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7122359965078443d, y: 0.182606409102405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351486663227868d, y: 0.7157775540806147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198306978391281d, y: 0.002795469773761994d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9152567342675d, y: 0.6494924218262303d), new NpgsqlTypes.NpgsqlPoint(x: 0.141041689484257d, y: 0.8805576692875124d), new NpgsqlTypes.NpgsqlPoint(x: 0.03940557686725976d, y: 0.5725618767487847d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34175714683967684d, y: 0.08843892582343205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6272771813778815d, y: 0.9439827887889474d), new NpgsqlTypes.NpgsqlPoint(x: 0.40043236780544667d, y: 0.5886296898161218d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003532509224186575d, y: 0.08171897728191468d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710597416624173d, y: 0.404191448192186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7429330196122442d, y: 0.5906853119305626d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.060072078301330545d, y: 0.09363096202809662d), new NpgsqlTypes.NpgsqlPoint(x: 0.1309228672137649d, y: 0.18726378926706233d), new NpgsqlTypes.NpgsqlPoint(x: 0.21089527768583116d, y: 0.3774371774144296d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.783712244874057d, y: 0.41667237683560765d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540136038614883d, y: 0.10445664573557034d), new NpgsqlTypes.NpgsqlPoint(x: 0.3197492597209832d, y: 0.3361365607073906d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9438401818966244d, y: 0.30610272479173384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674565035478812d, y: 0.6880573384059847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647643740454539d, y: 0.8854144907160879d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23650311982986016d, y: 0.1165591802716931d), new NpgsqlTypes.NpgsqlPoint(x: 0.40913426078261617d, y: 0.659603829701132d), new NpgsqlTypes.NpgsqlPoint(x: 0.18934420399174012d, y: 0.7499228504789845d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08770757436362808d, y: 0.5082274562596386d), new NpgsqlTypes.NpgsqlPoint(x: 0.3302594904344299d, y: 0.1658752759282619d), new NpgsqlTypes.NpgsqlPoint(x: 0.10741602224641889d, y: 0.4260709239546264d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4741303639430814d, y: 0.8717188662855107d), new NpgsqlTypes.NpgsqlPoint(x: 0.9934032083333681d, y: 0.4821088284734083d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653880342529295d, y: 0.1783782448175486d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3459165493015661d, y: 0.0906295524301246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8745507410544544d, y: 0.015485269779476174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593281312665912d, y: 0.6726502226652717d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21776679300590618d, y: 0.43858073391808106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322932509720952d, y: 0.1444458756089957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977099104038094d, y: 0.629343781750169d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27132435367889685d, y: 0.2950622847045047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5909972077334905d, y: 0.5190938607624184d), new NpgsqlTypes.NpgsqlPoint(x: 0.25437715944376604d, y: 0.44593110234653266d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9917361095360314d, y: 0.11561198465306544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8170147028794129d, y: 0.540973474709919d), new NpgsqlTypes.NpgsqlPoint(x: 0.3891856593689397d, y: 0.3124296371250108d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.716289973382543d, y: 0.5814489916517722d), new NpgsqlTypes.NpgsqlPoint(x: 0.28560659549538925d, y: 0.1823878584497185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231599704821154d, y: 0.33969224472841375d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6843584896525138d, y: 0.24602912117687592d), new NpgsqlTypes.NpgsqlPoint(x: 0.2262607037808534d, y: 0.9420914553109081d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486456843603708d, y: 0.5190168119286621d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35750106063833265d, y: 0.13562313494534484d), new NpgsqlTypes.NpgsqlPoint(x: 0.3438426498750806d, y: 0.8528486886120779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4914343887948145d, y: 0.3943464426133647d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7434335727806619d, y: 0.9964886612945006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5647215107666873d, y: 0.10916078382942906d), new NpgsqlTypes.NpgsqlPoint(x: 0.033019209349343326d, y: 0.5262502959401686d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5584679835068056d, y: 0.8388976760462107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322101838133232d, y: 0.8778361913793502d), new NpgsqlTypes.NpgsqlPoint(x: 0.029304568069913883d, y: 0.28338294947873666d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5097086352378052d, y: 0.205922787127216d), new NpgsqlTypes.NpgsqlPoint(x: 0.05918922545639804d, y: 0.7717616938596025d), new NpgsqlTypes.NpgsqlPoint(x: 0.46616458809471495d, y: 0.1725670944588169d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40011285699358956d, y: 0.842163727034434d), new NpgsqlTypes.NpgsqlPoint(x: 0.11086623789208061d, y: 0.1385604160631334d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033511527308927d, y: 0.19750911269588578d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02053860674573893d, y: 0.08478359965337623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5062100441842972d, y: 0.1554176375570523d), new NpgsqlTypes.NpgsqlPoint(x: 0.07197638500502401d, y: 0.7854358460207661d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5543133773232324d, y: 0.8221350930244674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3615404514373147d, y: 0.11194249130912104d), new NpgsqlTypes.NpgsqlPoint(x: 0.08488914299135664d, y: 0.8184053042768438d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5434769843403088d, y: 0.4330616040039178d), new NpgsqlTypes.NpgsqlPoint(x: 0.7658753332851457d, y: 0.9038083805636749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651251065344187d, y: 0.32882723619380283d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7652524815617762d, y: 0.9131395080905993d), new NpgsqlTypes.NpgsqlPoint(x: 0.3841419159806234d, y: 0.3529029552066758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8597912284805425d, y: 0.06273363493572559d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17512738406464112d, y: 0.6412035752588385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445310633445966d, y: 0.1488667504133866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496748760579911d, y: 0.5580047950772935d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4248650904657252d, y: 0.7091663788397695d), new NpgsqlTypes.NpgsqlPoint(x: 0.1344942383065576d, y: 0.7681888229086826d), new NpgsqlTypes.NpgsqlPoint(x: 0.818439936228491d, y: 0.9877879802721805d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5122073177470459d, y: 0.4183061233875859d), new NpgsqlTypes.NpgsqlPoint(x: 0.22232183666185124d, y: 0.9084577215838489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092028647710678d, y: 0.016115207851363667d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34323414659806295d, y: 0.054421492839272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369534632546543d, y: 0.1567471946909933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6615010176792288d, y: 0.1645369858356872d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9514193241539559d, y: 0.4987880728741334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9081447719861663d, y: 0.47573500943059244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4050381641014621d, y: 0.7310493826826625d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9080623203401412d, y: 0.8643352623677533d), new NpgsqlTypes.NpgsqlPoint(x: 0.3948734551445101d, y: 0.42035325044731975d), new NpgsqlTypes.NpgsqlPoint(x: 0.586754912173104d, y: 0.08537180122644705d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26601286121375023d, y: 0.08055236914893793d), new NpgsqlTypes.NpgsqlPoint(x: 0.9007615208110876d, y: 0.6227358257272995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679041165156651d, y: 0.6145891991864366d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8281826576556784d, y: 0.18584657796835913d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298722318583838d, y: 0.8521668471808661d), new NpgsqlTypes.NpgsqlPoint(x: 0.4597713064370339d, y: 0.7084576987821344d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6593743216909231d, y: 0.8729290072568767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555475069388977d, y: 0.33687643150599234d), new NpgsqlTypes.NpgsqlPoint(x: 0.954008743731359d, y: 0.8768884062002268d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7117774522399046d, y: 0.34161722246964854d), new NpgsqlTypes.NpgsqlPoint(x: 0.47177448995604776d, y: 0.5288566848192765d), new NpgsqlTypes.NpgsqlPoint(x: 0.20227072749534336d, y: 0.6665598872920085d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5226393384992535d, y: 0.09020407009563713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433249889439567d, y: 0.26615276956431977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9647202076429002d, y: 0.3697333308725511d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24052335735841557d, y: 0.8676665587201091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637189121074869d, y: 0.035621338158954075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962214664188519d, y: 0.09061691594854793d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2937146915350718d, y: 0.5475608093204034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584229330197422d, y: 0.45040830589339187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451316225111359d, y: 0.06167994314895231d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5398758583618315d, y: 0.9260305089549022d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843994420085855d, y: 0.48003584180637904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436310893962356d, y: 0.31841387413288713d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17182669039772192d, y: 0.3932989734934995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103778858800695d, y: 0.30401573372551316d), new NpgsqlTypes.NpgsqlPoint(x: 0.7564653839450254d, y: 0.8743499122139592d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9744563622522159d, y: 0.2855713811822773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623526024687049d, y: 0.9012534134527637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6389920824420686d, y: 0.8642914058985527d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10719257332704868d, y: 0.6456589685615486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816208439535647d, y: 0.26759633216506595d), new NpgsqlTypes.NpgsqlPoint(x: 0.17337038496485602d, y: 0.7068000124216116d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2925115401510524d, y: 0.7508277846032453d), new NpgsqlTypes.NpgsqlPoint(x: 0.11465926016622474d, y: 0.2717878583565634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9809246631833063d, y: 0.32849342558171135d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9329236004269337d, y: 0.246791381076912d), new NpgsqlTypes.NpgsqlPoint(x: 0.21851538377214574d, y: 0.06159066299269944d), new NpgsqlTypes.NpgsqlPoint(x: 0.04242760031036674d, y: 0.9071251907281699d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.615574463728688d, y: 0.8879891214375077d), new NpgsqlTypes.NpgsqlPoint(x: 0.04996821681287944d, y: 0.8099665008801188d), new NpgsqlTypes.NpgsqlPoint(x: 0.14262158755370025d, y: 0.23048528779601796d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9642921116590929d, y: 0.35456690087431453d), new NpgsqlTypes.NpgsqlPoint(x: 0.14026752005331578d, y: 0.5161116223675614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590420885312252d, y: 0.5302145190901804d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7354184922247395d, y: 0.6521915353099154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6193186746424783d, y: 0.39518543889299096d), new NpgsqlTypes.NpgsqlPoint(x: 0.2608417484731368d, y: 0.6249645171477969d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989867377700783d, y: 0.600915449369035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216626717726163d, y: 0.4203831011518141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9186040682873859d, y: 0.8053358855045406d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34099817778827035d, y: 0.14945965341993506d), new NpgsqlTypes.NpgsqlPoint(x: 0.47080294220190366d, y: 0.2853757002694738d), new NpgsqlTypes.NpgsqlPoint(x: 0.198493695612881d, y: 0.42409007787127784d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31457092542278586d, y: 0.03310333488765449d), new NpgsqlTypes.NpgsqlPoint(x: 0.5545302897727394d, y: 0.9338378212625279d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080879477013931d, y: 0.08226984696511241d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7004713336429791d, y: 0.6427916729539691d), new NpgsqlTypes.NpgsqlPoint(x: 0.17181357530330266d, y: 0.06635404791220922d), new NpgsqlTypes.NpgsqlPoint(x: 0.1380273179515954d, y: 0.38379147439217387d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.73604358173371d, y: 0.8804755869883095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9615131999481286d, y: 0.45770863972368714d), new NpgsqlTypes.NpgsqlPoint(x: 0.4120029466849816d, y: 0.9810123927615396d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9837537333169045d, y: 0.893632187618083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177703997915987d, y: 0.6895125585079748d), new NpgsqlTypes.NpgsqlPoint(x: 0.06708972641510025d, y: 0.6181016448890639d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8011472758472711d, y: 0.5802086001720874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2028353694420174d, y: 0.4116216664475846d), new NpgsqlTypes.NpgsqlPoint(x: 0.39101758071500525d, y: 0.3373357863377672d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9743844334339365d, y: 0.854165329255517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605374809216407d, y: 0.018413968592459362d), new NpgsqlTypes.NpgsqlPoint(x: 0.37500636184032576d, y: 0.244236576634157d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18224731603306288d, y: 0.9929224812352788d), new NpgsqlTypes.NpgsqlPoint(x: 0.4852977526457315d, y: 0.568759779026427d), new NpgsqlTypes.NpgsqlPoint(x: 0.27018014222956155d, y: 0.8693329143684393d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9432256493127437d, y: 0.4621255972571563d), new NpgsqlTypes.NpgsqlPoint(x: 0.5825558201568146d, y: 0.6970818372852534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395408649329989d, y: 0.9819093710988248d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3150584044502589d, y: 0.17438203489754844d), new NpgsqlTypes.NpgsqlPoint(x: 0.4989263761952816d, y: 0.09269727789996063d), new NpgsqlTypes.NpgsqlPoint(x: 0.1567184508503352d, y: 0.34095401060293784d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.851411124157955d, y: 0.9228872672453797d), new NpgsqlTypes.NpgsqlPoint(x: 0.10032727542691788d, y: 0.9930808153793075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9118305456221442d, y: 0.5421789875104692d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5460790145199962d, y: 0.4472040303685778d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148963099012889d, y: 0.8642367092006606d), new NpgsqlTypes.NpgsqlPoint(x: 0.517208477147088d, y: 0.8664342415896021d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4774806857282027d, y: 0.7951034887821578d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875069613726547d, y: 0.9536021960179407d), new NpgsqlTypes.NpgsqlPoint(x: 0.131366775953217d, y: 0.1543427853746634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6975288164800236d, y: 0.13261184920573033d), new NpgsqlTypes.NpgsqlPoint(x: 0.26803979133135214d, y: 0.8280502564798343d), new NpgsqlTypes.NpgsqlPoint(x: 0.24503329494286397d, y: 0.19566079579472506d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007738405332587739d, y: 0.24986334278852185d), new NpgsqlTypes.NpgsqlPoint(x: 0.1134456658051326d, y: 0.786396803346525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856911603973089d, y: 0.33000169648385236d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45884883741344995d, y: 0.05020615986279586d), new NpgsqlTypes.NpgsqlPoint(x: 0.3962416252715323d, y: 0.9985769684622696d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555726779336414d, y: 0.038379971039265603d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021428481889635864d, y: 0.9126174695491801d), new NpgsqlTypes.NpgsqlPoint(x: 0.30807958793223966d, y: 0.06117181145242934d), new NpgsqlTypes.NpgsqlPoint(x: 0.30665419949285777d, y: 0.5150574286664666d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1754604913695632d, y: 0.8599017302072692d), new NpgsqlTypes.NpgsqlPoint(x: 0.008648978061991275d, y: 0.44923458814939854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5660331244529807d, y: 0.13461664303447463d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03145772497060351d, y: 0.06204613020125249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5276839991488279d, y: 0.32392519473807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796752030032494d, y: 0.2841605171655157d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7867546736226628d, y: 0.28511602297150473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249759912365861d, y: 0.9786308449610926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022316785245524d, y: 0.8373351824817067d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374373829325099d, y: 0.5524864375023193d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372880484220815d, y: 0.8779244170066718d), new NpgsqlTypes.NpgsqlPoint(x: 0.13878598905585926d, y: 0.5134614318134173d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26383842796933166d, y: 0.5146790363759871d), new NpgsqlTypes.NpgsqlPoint(x: 0.21158291309915178d, y: 0.7721232024512243d), new NpgsqlTypes.NpgsqlPoint(x: 0.098352064818228d, y: 0.2820137029407619d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.591265343452381d, y: 0.8976074939834608d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254569974336683d, y: 0.7742774166713304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305362192317612d, y: 0.5650470663179246d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9430824495120766d, y: 0.5684207801411828d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457512958041452d, y: 0.403937513979693d), new NpgsqlTypes.NpgsqlPoint(x: 0.47496874187130167d, y: 0.21972636493051279d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33377636709496517d, y: 0.04939829963436204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9838189070646183d, y: 0.23038262509072505d), new NpgsqlTypes.NpgsqlPoint(x: 0.39812629260984456d, y: 0.14725599569861747d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47705880215324925d, y: 0.6636079432405126d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590568548352614d, y: 0.9076427679628974d), new NpgsqlTypes.NpgsqlPoint(x: 0.9524824202149423d, y: 0.07413700013250568d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7837947689943914d, y: 0.044917689221801504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188628397494036d, y: 0.28355374798784994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7021787623108394d, y: 0.05501462314037253d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7093616119690975d, y: 0.3406770219312666d), new NpgsqlTypes.NpgsqlPoint(x: 0.256846050782243d, y: 0.4941542365274002d), new NpgsqlTypes.NpgsqlPoint(x: 0.0266615377874444d, y: 0.9354899230670222d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006203816445731869d, y: 0.18518577843332074d), new NpgsqlTypes.NpgsqlPoint(x: 0.857513538812182d, y: 0.712985529873d), new NpgsqlTypes.NpgsqlPoint(x: 0.7186197512502166d, y: 0.38362091373124296d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6902246733841209d, y: 0.930500843133526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9526924128632249d, y: 0.4479299656103234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8575985173115193d, y: 0.41862679380899437d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34486202746694283d, y: 0.12182386438848403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3994479410654055d, y: 0.7495984338865047d), new NpgsqlTypes.NpgsqlPoint(x: 0.22995457141096776d, y: 0.8034965421015584d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5908736080936684d, y: 0.5323759390007582d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886256970321427d, y: 0.232041062349011d), new NpgsqlTypes.NpgsqlPoint(x: 0.4510518630002901d, y: 0.30837244225952665d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7026668549346344d, y: 0.18918384074104533d), new NpgsqlTypes.NpgsqlPoint(x: 0.004449988105622582d, y: 0.45732120251998143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6416546347083856d, y: 0.6342026180971092d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6921574880481637d, y: 0.36253430955650334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5750063804552855d, y: 0.8181866977738821d), new NpgsqlTypes.NpgsqlPoint(x: 0.6142489347923189d, y: 0.3599570419182593d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7197214368340521d, y: 0.5992968215536505d), new NpgsqlTypes.NpgsqlPoint(x: 0.49238980859353576d, y: 0.027966271895317307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4958798656429715d, y: 0.9240969801171613d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08753184693068417d, y: 0.5107187070382265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9475230766315648d, y: 0.49597545099300977d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172879576594624d, y: 0.8380210680672358d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16944670332963596d, y: 0.1383515057884116d), new NpgsqlTypes.NpgsqlPoint(x: 0.7846477900317802d, y: 0.8661243404704408d), new NpgsqlTypes.NpgsqlPoint(x: 0.810306199933401d, y: 0.5297622169712849d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36948100184435395d, y: 0.3930207004275553d), new NpgsqlTypes.NpgsqlPoint(x: 0.014759471791840117d, y: 0.7168989379781606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9853298435173272d, y: 0.8706612110950895d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8258205522971935d, y: 0.5858416619570248d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023079819723494d, y: 0.975335894002336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326005887333356d, y: 0.9853481005044055d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4623472582002005d, y: 0.7549733759098107d), new NpgsqlTypes.NpgsqlPoint(x: 0.43983558323016536d, y: 0.505373624662549d), new NpgsqlTypes.NpgsqlPoint(x: 0.3063406656480152d, y: 0.9631784333584448d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20332640535231306d, y: 0.714152963762893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644764654809036d, y: 0.9474551432975987d), new NpgsqlTypes.NpgsqlPoint(x: 0.10282760176686112d, y: 0.9097685629784943d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6612953870755092d, y: 0.1579032534875121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145675583749991d, y: 0.5799326123459488d), new NpgsqlTypes.NpgsqlPoint(x: 0.45171725292236364d, y: 0.11635675439120796d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5498995062700305d, y: 0.6572744264025722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926397566286682d, y: 0.011063806770832185d), new NpgsqlTypes.NpgsqlPoint(x: 0.8949748603280369d, y: 0.12233529588508196d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07149383845675994d, y: 0.4754894251421623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648167965250386d, y: 0.659023638004044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7198138381848401d, y: 0.5172157049162496d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40704843389363266d, y: 0.5683701371099734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524037588429991d, y: 0.6982211015538828d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303748973754499d, y: 0.2237053393150592d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3911427884602914d, y: 0.3257371037576221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6616588077239591d, y: 0.38910321878043275d), new NpgsqlTypes.NpgsqlPoint(x: 0.12418526247456851d, y: 0.7334505160996562d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8232319642698218d, y: 0.1928273193854333d), new NpgsqlTypes.NpgsqlPoint(x: 0.11172033289419803d, y: 0.07843084534322875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201755587456592d, y: 0.042921732805213164d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30785537895983417d, y: 0.8169972689661352d), new NpgsqlTypes.NpgsqlPoint(x: 0.3453907316725343d, y: 0.09682740752965857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522912107190779d, y: 0.8736368855798134d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6989382414580335d, y: 0.2982850034490596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6420806801553994d, y: 0.3644354206691589d), new NpgsqlTypes.NpgsqlPoint(x: 0.284879603733037d, y: 0.733571421667214d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5931030584704348d, y: 0.9108703314042397d), new NpgsqlTypes.NpgsqlPoint(x: 0.1191090170231397d, y: 0.5553051759115443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9226641319224848d, y: 0.6413391305820022d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6500201150588248d, y: 0.6013002977312301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057433658072967d, y: 0.39436277986434454d), new NpgsqlTypes.NpgsqlPoint(x: 0.027085375308381954d, y: 0.7928608505996106d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.061948283586943376d, y: 0.8306789621827937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7288347837896519d, y: 0.595688097056754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2474541525974001d, y: 0.6126138924276582d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8649867778758992d, y: 0.08599573130709959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852025154433398d, y: 0.5023153067099125d), new NpgsqlTypes.NpgsqlPoint(x: 0.2050411546873595d, y: 0.9653721801997531d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4770900371238471d, y: 0.11023254057640686d), new NpgsqlTypes.NpgsqlPoint(x: 0.25554843276375294d, y: 0.052355419833208794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188037165469815d, y: 0.9214335520574368d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6022293933738327d, y: 0.39978206925777027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085544251542265d, y: 0.2694408719898129d), new NpgsqlTypes.NpgsqlPoint(x: 0.7631364358045004d, y: 0.44291344682802347d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7837414664437747d, y: 0.05125638561789847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321474797708589d, y: 0.8166771059091792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188002530131868d, y: 0.11558314597398256d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9905440682558316d, y: 0.19410847690714994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171101300681274d, y: 0.05535806491573425d), new NpgsqlTypes.NpgsqlPoint(x: 0.14783150150843183d, y: 0.7357649807765262d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.058601163090163055d, y: 0.6481034614653982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693857008912352d, y: 0.8731342192318928d), new NpgsqlTypes.NpgsqlPoint(x: 0.358675561976324d, y: 0.5212142633089984d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31366735713179494d, y: 0.20129299012518542d), new NpgsqlTypes.NpgsqlPoint(x: 0.007236190746222171d, y: 0.1587763662147702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6922852843544237d, y: 0.02142155702026194d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7469497888234349d, y: 0.6708186975547401d), new NpgsqlTypes.NpgsqlPoint(x: 0.8832026973289803d, y: 0.8536150745722245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751649685028023d, y: 0.13253977812823203d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10150929165310563d, y: 0.5378249686809083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6903785365550256d, y: 0.9701754281507441d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962616417282337d, y: 0.3174012038703694d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1103234995268334d, y: 0.5526211862249342d), new NpgsqlTypes.NpgsqlPoint(x: 0.17763213458426363d, y: 0.3768388295030002d), new NpgsqlTypes.NpgsqlPoint(x: 0.4192744320279268d, y: 0.6597169853104593d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8348501704780563d, y: 0.8834848243060536d), new NpgsqlTypes.NpgsqlPoint(x: 0.10575170254628241d, y: 0.5469620159629229d), new NpgsqlTypes.NpgsqlPoint(x: 0.8464493378457513d, y: 0.5116074468315164d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10850352448083689d, y: 0.20125295105660435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356635292036776d, y: 0.6144247959678276d), new NpgsqlTypes.NpgsqlPoint(x: 0.33514815145414345d, y: 0.5457955256680946d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14565486599560418d, y: 0.46436063041591724d), new NpgsqlTypes.NpgsqlPoint(x: 0.40131724195222884d, y: 0.4332314143715976d), new NpgsqlTypes.NpgsqlPoint(x: 0.28923508279446275d, y: 0.7350037413129182d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.734743578060989d, y: 0.6190898989486228d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520479420466218d, y: 0.2933440700887111d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675096148009309d, y: 0.2982408387127883d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.780598548232987d, y: 0.5195996132492152d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914587976450423d, y: 0.44602335148934247d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280414497555676d, y: 0.15477606657394571d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9722280192534342d, y: 0.8575843810946094d), new NpgsqlTypes.NpgsqlPoint(x: 0.332674525789032d, y: 0.7322799224731859d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813884499263334d, y: 0.5946733386096703d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1884627620976297d, y: 0.6960409813707231d), new NpgsqlTypes.NpgsqlPoint(x: 0.08421822731791107d, y: 0.6659203757341691d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475079956854664d, y: 0.728180392366466d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7638802899445299d, y: 0.949947394935679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045121735097139d, y: 0.6541914093168546d), new NpgsqlTypes.NpgsqlPoint(x: 0.011918150625730428d, y: 0.20759579520925386d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3861414877639593d, y: 0.9208661059064298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788798861441488d, y: 0.8097254070060786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510470017008871d, y: 0.6291989425227756d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3303587270736984d, y: 0.17669593314347176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8840752164945255d, y: 0.8537949142402146d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321921942439701d, y: 0.7526978432914319d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6986105358886073d, y: 0.7165440141539174d), new NpgsqlTypes.NpgsqlPoint(x: 0.28890340965872296d, y: 0.9467491754200316d), new NpgsqlTypes.NpgsqlPoint(x: 0.12341095398932866d, y: 0.19458551176304562d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5264320765646822d, y: 0.3857312445135116d), new NpgsqlTypes.NpgsqlPoint(x: 0.1474101706427846d, y: 0.525918012865877d), new NpgsqlTypes.NpgsqlPoint(x: 0.8913428484386375d, y: 0.8493193844577929d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9942148674502146d, y: 0.4664901420188079d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331562584186525d, y: 0.8543361418324972d), new NpgsqlTypes.NpgsqlPoint(x: 0.053803391740832596d, y: 0.9848590110587347d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09810537878764847d, y: 0.3972710046550758d), new NpgsqlTypes.NpgsqlPoint(x: 0.3426485169864957d, y: 0.6200210225631512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9192847997751503d, y: 0.1447279205707135d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08367834491716264d, y: 0.9480934992463093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4156868197775081d, y: 0.6520664740599107d), new NpgsqlTypes.NpgsqlPoint(x: 0.18337213392628715d, y: 0.5991308237944333d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03679769036948499d, y: 0.4570849174992846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815688951218428d, y: 0.9843419423467791d), new NpgsqlTypes.NpgsqlPoint(x: 0.6120256358638791d, y: 0.6392522854289571d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4662797641347479d, y: 0.5903514313387332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656889108814908d, y: 0.23908973677269618d), new NpgsqlTypes.NpgsqlPoint(x: 0.29157992538525057d, y: 0.599695306130216d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41955139813398534d, y: 0.20203226612249936d), new NpgsqlTypes.NpgsqlPoint(x: 0.77071012190313d, y: 0.8354654753369756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5083070980857542d, y: 0.8956039068428201d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21889429433030472d, y: 0.14278913885389044d), new NpgsqlTypes.NpgsqlPoint(x: 0.19844998746143827d, y: 0.3997878192105214d), new NpgsqlTypes.NpgsqlPoint(x: 0.15843742265851113d, y: 0.05970211284335725d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5834661383290509d, y: 0.2657177778212664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791006853204621d, y: 0.7870025253430347d), new NpgsqlTypes.NpgsqlPoint(x: 0.23297403930836735d, y: 0.9498658704483808d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43217962304828894d, y: 0.5197202683921563d), new NpgsqlTypes.NpgsqlPoint(x: 0.32286967177716797d, y: 0.9630043688766701d), new NpgsqlTypes.NpgsqlPoint(x: 0.2918187165866598d, y: 0.8687102599021159d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5521088104492979d, y: 0.8992331385961213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616052836782071d, y: 0.5540005728712268d), new NpgsqlTypes.NpgsqlPoint(x: 0.26347119136420194d, y: 0.8111589811499322d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31481439739287465d, y: 0.8864599946095026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172964787958503d, y: 0.5855848935280491d), new NpgsqlTypes.NpgsqlPoint(x: 0.45510219273049823d, y: 0.5319539353548334d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11228912603620256d, y: 0.9162696945500729d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113690207493213d, y: 0.4439748301415055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372780869276187d, y: 0.1250854047145804d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30531077558338904d, y: 0.27760485696536186d), new NpgsqlTypes.NpgsqlPoint(x: 0.4229748246163165d, y: 0.003645242195110532d), new NpgsqlTypes.NpgsqlPoint(x: 0.1649340236498481d, y: 0.001985198938199151d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7446849105809871d, y: 0.7494555308472121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088203721366093d, y: 0.0017838255711889461d), new NpgsqlTypes.NpgsqlPoint(x: 0.5269738924104724d, y: 0.1540247477232738d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32784415235971887d, y: 0.03056474334166004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6744017749395472d, y: 0.7064003955551299d), new NpgsqlTypes.NpgsqlPoint(x: 0.10814873813288117d, y: 0.7283956166337842d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7654325685771399d, y: 0.5985919514242245d), new NpgsqlTypes.NpgsqlPoint(x: 0.920433791643605d, y: 0.10744574484328318d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151949260192122d, y: 0.4255489033816251d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8035572498530832d, y: 0.63563533122759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7665060510656196d, y: 0.12986617458728633d), new NpgsqlTypes.NpgsqlPoint(x: 0.5104111905830676d, y: 0.4849182638070093d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3193967096918293d, y: 0.32466676621937385d), new NpgsqlTypes.NpgsqlPoint(x: 0.898326863727412d, y: 0.5221150509940132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6179004299064604d, y: 0.5424297503018173d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20329277222392783d, y: 0.9185128197479541d), new NpgsqlTypes.NpgsqlPoint(x: 0.30352580318939926d, y: 0.20335059792376697d), new NpgsqlTypes.NpgsqlPoint(x: 0.567618629663891d, y: 0.2915124466951057d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3730608873889626d, y: 0.9830354547258298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828354147799224d, y: 0.5618339537058074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915670999047538d, y: 0.41445523617407953d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47711704677121036d, y: 0.9847996308668464d), new NpgsqlTypes.NpgsqlPoint(x: 0.876098216915318d, y: 0.060496204976127954d), new NpgsqlTypes.NpgsqlPoint(x: 0.22846366636930182d, y: 0.0012360557333264133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8394939797702845d, y: 0.41320830560503374d), new NpgsqlTypes.NpgsqlPoint(x: 0.776900188096762d, y: 0.5598084499489911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078874920525401d, y: 0.6579425653922313d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7137540537345531d, y: 0.6846605387438758d), new NpgsqlTypes.NpgsqlPoint(x: 0.5181372910420412d, y: 0.6113909003645384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899289881613262d, y: 0.6279309921282209d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9653839286231085d, y: 0.1925982962305034d), new NpgsqlTypes.NpgsqlPoint(x: 0.47856728409739735d, y: 0.3423372193765748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820063330429538d, y: 0.7840169313845983d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 185,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2138418383849412d, y: 0.19803325954209106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9946481157256173d, y: 0.8855970310375237d), new NpgsqlTypes.NpgsqlPoint(x: 0.133268468577872d, y: 0.45426952247588126d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.324254451791106d, y: 0.3410740343725095d), new NpgsqlTypes.NpgsqlPoint(x: 0.07328906623503706d, y: 0.7936850214401525d), new NpgsqlTypes.NpgsqlPoint(x: 0.2126086449721426d, y: 0.1840742847364557d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6183602327040527d, y: 0.13198529067357478d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142741914253735d, y: 0.17760232848262092d), new NpgsqlTypes.NpgsqlPoint(x: 0.07790995029833536d, y: 0.0979405288747408d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8296117114132081d, y: 0.2544942028077023d), new NpgsqlTypes.NpgsqlPoint(x: 0.33832109581515424d, y: 0.8808018263873916d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688291555224071d, y: 0.881033668666761d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5777687344439077d, y: 0.6797530396530912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360003541091617d, y: 0.173651724614326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8716313749641912d, y: 0.6652109213561966d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5164568911060521d, y: 0.7401459545269347d), new NpgsqlTypes.NpgsqlPoint(x: 0.04269120603826815d, y: 0.9930749519668259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6512254445282301d, y: 0.8542368934890757d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7968614999496934d, y: 0.22512183746266268d), new NpgsqlTypes.NpgsqlPoint(x: 0.434681768157436d, y: 0.279130766331661d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598063557192086d, y: 0.5224446748493832d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9210702336844961d, y: 0.3869011971649128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9602096490413689d, y: 0.06575098735957052d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514932196452373d, y: 0.4752881404032946d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 192,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17030552331612703d, y: 0.8279119740308687d), new NpgsqlTypes.NpgsqlPoint(x: 0.08692087209657962d, y: 0.29068523826812886d), new NpgsqlTypes.NpgsqlPoint(x: 0.6173371439692942d, y: 0.4837898720100743d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24098937707521695d, y: 0.3991626143837158d), new NpgsqlTypes.NpgsqlPoint(x: 0.06697647544284202d, y: 0.08601010738834969d), new NpgsqlTypes.NpgsqlPoint(x: 0.4107642136755981d, y: 0.0779892819574779d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9581820110307744d, y: 0.9877962938322408d), new NpgsqlTypes.NpgsqlPoint(x: 0.19365830560823338d, y: 0.5206075780570535d), new NpgsqlTypes.NpgsqlPoint(x: 0.972402395767896d, y: 0.43909590534335174d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15180045283936527d, y: 0.31185206410887867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5909792338260875d, y: 0.44285734611212724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231241792269479d, y: 0.12186550629814064d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9978310083833952d, y: 0.6921540435894779d), new NpgsqlTypes.NpgsqlPoint(x: 0.033315952162280116d, y: 0.3621267018347547d), new NpgsqlTypes.NpgsqlPoint(x: 0.04485095673168704d, y: 0.03204935304590695d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9540948184602411d, y: 0.6354657482964531d), new NpgsqlTypes.NpgsqlPoint(x: 0.07386851370699954d, y: 0.2079305676051566d), new NpgsqlTypes.NpgsqlPoint(x: 0.49115910040739663d, y: 0.6799615058051871d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7910920314015404d, y: 0.630818911710668d), new NpgsqlTypes.NpgsqlPoint(x: 0.4952719149898046d, y: 0.45122778970315836d), new NpgsqlTypes.NpgsqlPoint(x: 0.965704527437673d, y: 0.7284228883465941d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006119295770673938d, y: 0.9040721832753177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288310295143869d, y: 0.4301494116703616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7659121212022013d, y: 0.6945737575853131d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 195,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9980178948339136d, y: 0.7945759309118501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761437480313266d, y: 0.20832985147436545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271599854094426d, y: 0.047024673427047636d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2468034234857548d, y: 0.06342262425681622d), new NpgsqlTypes.NpgsqlPoint(x: 0.21670551234103175d, y: 0.6890456671537508d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211139476299215d, y: 0.9360624725921384d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9847695150342766d, y: 0.9890554844226317d), new NpgsqlTypes.NpgsqlPoint(x: 0.5598881455926666d, y: 0.9007128714531231d), new NpgsqlTypes.NpgsqlPoint(x: 0.17949095983657926d, y: 0.4172455546941596d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7330933346031946d, y: 0.1506249288324979d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172372248141968d, y: 0.7754523464162771d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688736819784952d, y: 0.6713416990958583d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9124851162616133d, y: 0.4410043439875406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799443320345017d, y: 0.1666062522480154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760043520102701d, y: 0.4607679512531573d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4282155210306927d, y: 0.9057964330159339d), new NpgsqlTypes.NpgsqlPoint(x: 0.4367508320559804d, y: 0.9325048866618781d), new NpgsqlTypes.NpgsqlPoint(x: 0.10490338499917562d, y: 0.1917249491273454d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4159698980198917d, y: 0.12496831563046873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350213154062786d, y: 0.6552730044736901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2992919336440364d, y: 0.960963496727134d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07117074027066084d, y: 0.8115242277054528d), new NpgsqlTypes.NpgsqlPoint(x: 0.6597302794039278d, y: 0.5199818365199967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6262522433426143d, y: 0.6500988417380036d)), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.851848478548091d, y: 0.13100517979782134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4201012813790751d, y: 0.5765899955465883d), new NpgsqlTypes.NpgsqlPoint(x: 0.44301085222689685d, y: 0.02209241899449066d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.766778238570179d, y: 0.13205931518828185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940568859042354d, y: 0.8060119178664238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160889577693721d, y: 0.18753233582505668d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21424289218924242d, y: 0.7001784914537086d), new NpgsqlTypes.NpgsqlPoint(x: 0.04495061965204661d, y: 0.37630890335705114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492380387347891d, y: 0.6777905174615866d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2310408150522576d, y: 0.5418630201539302d), new NpgsqlTypes.NpgsqlPoint(x: 0.4260012170577905d, y: 0.7137989909332076d), new NpgsqlTypes.NpgsqlPoint(x: 0.34127350303881465d, y: 0.4808927150770942d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4280784214597261d, y: 0.43001053188555705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086146432464197d, y: 0.22756808992531796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926279302842924d, y: 0.02240728264078351d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47149357012440307d, y: 0.7461120053980176d), new NpgsqlTypes.NpgsqlPoint(x: 0.799545202770429d, y: 0.3072136102755114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7817449933835631d, y: 0.8097023196498353d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5525897081804821d, y: 0.8493247717682538d), new NpgsqlTypes.NpgsqlPoint(x: 0.1764389758007423d, y: 0.647679006270763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5148694338469051d, y: 0.6510622109952687d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8798639721370184d, y: 0.05437227307812631d), new NpgsqlTypes.NpgsqlPoint(x: 0.09726631533777985d, y: 0.5605501346508339d), new NpgsqlTypes.NpgsqlPoint(x: 0.45864902492785764d, y: 0.5605452997888379d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 176;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 185;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 185;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 165, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 176, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 117, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 167, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 83, query1, 86, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 92, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 167))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 55, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI), typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

