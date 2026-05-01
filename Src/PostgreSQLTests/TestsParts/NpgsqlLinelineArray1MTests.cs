

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7100670488453925d, b: 0.0037140830898712007d, c: 0.857025448653295d),
new NpgsqlTypes.NpgsqlLine(a: 0.7396528060117795d, b: 0.07106385483341371d, c: 0.9363429619430899d),
new NpgsqlTypes.NpgsqlLine(a: 0.9593982264830591d, b: 0.08848822127399747d, c: 0.6523872568899659d),
new NpgsqlTypes.NpgsqlLine(a: 0.5046234464066846d, b: 0.8879332816887046d, c: 0.9041218790356841d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7546794479439748d, b: 0.44768648250843845d, c: 0.17696420591964324d),
new NpgsqlTypes.NpgsqlLine(a: 0.5561530326974203d, b: 0.868782375594095d, c: 0.579457847359789d),
new NpgsqlTypes.NpgsqlLine(a: 0.4419351043106182d, b: 0.3918479086654947d, c: 0.34769955901157445d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2608626503378042d, b: 0.6344839087598781d, c: 0.32869751514533674d),
new NpgsqlTypes.NpgsqlLine(a: 0.8698259483054998d, b: 0.8579179265260396d, c: 0.5990248511718361d),
new NpgsqlTypes.NpgsqlLine(a: 0.8085873786175192d, b: 0.9300707371549845d, c: 0.8919452648156003d),
new NpgsqlTypes.NpgsqlLine(a: 0.7248016782951707d, b: 0.5288588432923409d, c: 0.32730621483627753d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39403160743682786d, b: 0.9937245903679005d, c: 0.11747822091105775d),
new NpgsqlTypes.NpgsqlLine(a: 0.5848347285580103d, b: 0.5802636098516629d, c: 0.9852716719904171d),
new NpgsqlTypes.NpgsqlLine(a: 0.14034567076664273d, b: 0.3218764708823064d, c: 0.7477706386537387d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39275287197875186d, b: 0.021755421918396523d, c: 0.7947793052822516d),
new NpgsqlTypes.NpgsqlLine(a: 0.8137710083191331d, b: 0.8664401610605841d, c: 0.03252405434607086d),
new NpgsqlTypes.NpgsqlLine(a: 0.6943570393533373d, b: 0.40662612866867187d, c: 0.06875787898514907d),
new NpgsqlTypes.NpgsqlLine(a: 0.39875144621143777d, b: 0.45228925271782094d, c: 0.33687024187849346d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7097110659985696d, b: 0.35769834340807327d, c: 0.9493016575395757d),
new NpgsqlTypes.NpgsqlLine(a: 0.9576870436555253d, b: 0.8741219799589791d, c: 0.5769930029941236d),
new NpgsqlTypes.NpgsqlLine(a: 0.6966750982594329d, b: 0.9646521938333026d, c: 0.686853740137562d),
new NpgsqlTypes.NpgsqlLine(a: 0.35634867843736606d, b: 0.8210988124237117d, c: 0.9034384991347622d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6181354528996715d, b: 0.8007887238369015d, c: 0.8890686119172578d),
new NpgsqlTypes.NpgsqlLine(a: 0.08176929724636217d, b: 0.00045172329077936d, c: 0.4556802590424587d),
new NpgsqlTypes.NpgsqlLine(a: 0.9734640605594984d, b: 0.6300638041072294d, c: 0.8387005769979238d),
new NpgsqlTypes.NpgsqlLine(a: 0.006268178398539548d, b: 0.12832375122385153d, c: 0.15358030061813033d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6568958080571464d, b: 0.2949226990538475d, c: 0.7200795993161262d),
new NpgsqlTypes.NpgsqlLine(a: 0.2003635924733813d, b: 0.7872018187705376d, c: 0.5727401281023182d),
new NpgsqlTypes.NpgsqlLine(a: 0.5305574706927427d, b: 0.4909979626015374d, c: 0.03847320202839999d),
new NpgsqlTypes.NpgsqlLine(a: 0.4889425612831778d, b: 0.6099687763504199d, c: 0.7738880476091567d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22414374431893314d, b: 0.32044355999301444d, c: 0.3283870375182504d),
new NpgsqlTypes.NpgsqlLine(a: 0.2945507201369464d, b: 0.9038076975034524d, c: 0.8241294255715603d),
new NpgsqlTypes.NpgsqlLine(a: 0.7314520016622351d, b: 0.4945351172619584d, c: 0.5923170871800102d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9218730737139524d, b: 0.807706287687307d, c: 0.08148929555455608d),
new NpgsqlTypes.NpgsqlLine(a: 0.47661721701442883d, b: 0.4803503883279978d, c: 0.896061568400392d),
new NpgsqlTypes.NpgsqlLine(a: 0.3985220045455681d, b: 0.08675099853338952d, c: 0.31674062903881084d),
new NpgsqlTypes.NpgsqlLine(a: 0.29529262065591577d, b: 0.7359702308058861d, c: 0.8294767265442525d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04682614168245791d, b: 0.23712049907845345d, c: 0.2653272592366682d),
new NpgsqlTypes.NpgsqlLine(a: 0.9394018309351369d, b: 0.17368334719612144d, c: 0.007050070791912666d),
new NpgsqlTypes.NpgsqlLine(a: 0.3226500110615449d, b: 0.7012866271687204d, c: 0.8989674630283593d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7830028254163314d, b: 0.08774166477213241d, c: 0.8391699650117687d),
new NpgsqlTypes.NpgsqlLine(a: 0.31157290374186963d, b: 0.3292058680295923d, c: 0.0022358495963176184d),
new NpgsqlTypes.NpgsqlLine(a: 0.7446189447853488d, b: 0.3965265646879239d, c: 0.8320692696755548d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.07306890356995321d, b: 0.3188850926225303d, c: 0.45936593346435506d),
new NpgsqlTypes.NpgsqlLine(a: 0.8669093995127266d, b: 0.9783847247487476d, c: 0.3399444572811049d),
new NpgsqlTypes.NpgsqlLine(a: 0.7816716554794709d, b: 0.9907527899018802d, c: 0.8941482393391732d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19875374541103552d, b: 0.012800213936321359d, c: 0.6945624927940419d),
new NpgsqlTypes.NpgsqlLine(a: 0.976758922217027d, b: 0.498633937600063d, c: 0.07613046238701904d),
new NpgsqlTypes.NpgsqlLine(a: 0.20696306853315927d, b: 0.5848332389217491d, c: 0.9105933032116414d),
new NpgsqlTypes.NpgsqlLine(a: 0.2751754253268792d, b: 0.9539927449875027d, c: 0.6833813899850728d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6420520778091318d, b: 0.7823101630994448d, c: 0.5118163817807893d),
new NpgsqlTypes.NpgsqlLine(a: 0.8142627337061056d, b: 0.24973323867939912d, c: 0.8927555853691419d),
new NpgsqlTypes.NpgsqlLine(a: 0.5787954597357077d, b: 0.07555342539446863d, c: 0.9430817376001136d),
new NpgsqlTypes.NpgsqlLine(a: 0.7691394989958106d, b: 0.896668609465811d, c: 0.8933605598639249d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.918315415008538d, b: 0.3274042507130952d, c: 0.9245597794433236d),
new NpgsqlTypes.NpgsqlLine(a: 0.9394850544971625d, b: 0.7271704215344084d, c: 0.12771412527721926d),
new NpgsqlTypes.NpgsqlLine(a: 0.2225223514435256d, b: 0.7675704577687346d, c: 0.39013686560956995d),
new NpgsqlTypes.NpgsqlLine(a: 0.5359469136552474d, b: 0.2599274455668581d, c: 0.9764496859309874d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5910369691272577d, b: 0.4759664238237933d, c: 0.1609009049818536d),
new NpgsqlTypes.NpgsqlLine(a: 0.683553500991242d, b: 0.37728536722622885d, c: 0.8139910212735416d),
new NpgsqlTypes.NpgsqlLine(a: 0.24786414768958331d, b: 0.2617402925135922d, c: 0.8255859652512504d),
new NpgsqlTypes.NpgsqlLine(a: 0.703770263766687d, b: 0.2893502155953349d, c: 0.2798616134857801d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04919386923196489d, b: 0.26920758849669135d, c: 0.3602850733424642d),
new NpgsqlTypes.NpgsqlLine(a: 0.43431818323780047d, b: 0.23564889132499522d, c: 0.5741770617674982d),
new NpgsqlTypes.NpgsqlLine(a: 0.3659776296868006d, b: 0.6563747049589264d, c: 0.9972734039016754d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8080500560083553d, b: 0.19882633420572893d, c: 0.8785110915554508d),
new NpgsqlTypes.NpgsqlLine(a: 0.7530574839987909d, b: 0.3288692418968514d, c: 0.5686252331175438d),
new NpgsqlTypes.NpgsqlLine(a: 0.6090317277371237d, b: 0.9868394181434417d, c: 0.3103568465346648d),
new NpgsqlTypes.NpgsqlLine(a: 0.8670383782679583d, b: 0.41297804759417645d, c: 0.5963207731855006d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6806481100885742d, b: 0.8292121500910349d, c: 0.8337097908729428d),
new NpgsqlTypes.NpgsqlLine(a: 0.008713495432295604d, b: 0.13322039049474443d, c: 0.8172878470625857d),
new NpgsqlTypes.NpgsqlLine(a: 0.5075787997835389d, b: 0.8951222676695678d, c: 0.8398445897917046d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14925509188962993d, b: 0.4812381191301056d, c: 0.7178939607682946d),
new NpgsqlTypes.NpgsqlLine(a: 0.4864716226772462d, b: 0.5151517170090808d, c: 0.5986990262640297d),
new NpgsqlTypes.NpgsqlLine(a: 0.22380908684422152d, b: 0.36648914038915537d, c: 0.31789157852685257d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7845232605761314d, b: 0.9972564560686973d, c: 0.13853112327936634d),
new NpgsqlTypes.NpgsqlLine(a: 0.12529628508882373d, b: 0.5779062294974343d, c: 0.01672609434768324d),
new NpgsqlTypes.NpgsqlLine(a: 0.755618059892687d, b: 0.3210047228062871d, c: 0.06739047550937949d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6577300945774083d, b: 0.9170288606523822d, c: 0.9342489655888782d),
new NpgsqlTypes.NpgsqlLine(a: 0.6840362118125536d, b: 0.3578745193497037d, c: 0.7515270073078385d),
new NpgsqlTypes.NpgsqlLine(a: 0.493334542696809d, b: 0.550983575849222d, c: 0.34543301004758864d),
new NpgsqlTypes.NpgsqlLine(a: 0.2053033131891222d, b: 0.770385290417069d, c: 0.441055023472116d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3971144848178161d, b: 0.0469888162793215d, c: 0.7774227234936507d),
new NpgsqlTypes.NpgsqlLine(a: 0.8029475728868678d, b: 0.23807051711741722d, c: 0.8724712206978066d),
new NpgsqlTypes.NpgsqlLine(a: 0.7547142651032963d, b: 0.6010568140030762d, c: 0.6910780086385754d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5796049601167506d, b: 0.3756390336145963d, c: 0.0648334520623407d),
new NpgsqlTypes.NpgsqlLine(a: 0.2569861636441657d, b: 0.17333982231024592d, c: 0.9980696507326801d),
new NpgsqlTypes.NpgsqlLine(a: 0.34592098675896565d, b: 0.7594313164907184d, c: 0.6239358280794859d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7936689104374072d, b: 0.6565044128932432d, c: 0.7654067586711233d),
new NpgsqlTypes.NpgsqlLine(a: 0.07392258623039649d, b: 0.6430643733474904d, c: 0.5596085660138874d),
new NpgsqlTypes.NpgsqlLine(a: 0.01412771708286853d, b: 0.730262033296702d, c: 0.6145554812865278d),
new NpgsqlTypes.NpgsqlLine(a: 0.4945377979398121d, b: 0.14530363087175124d, c: 0.02868004533238333d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4000809467576336d, b: 0.7892656437245034d, c: 0.6795785866036121d),
new NpgsqlTypes.NpgsqlLine(a: 0.6602795640650387d, b: 0.8797290481787533d, c: 0.4439359817658538d),
new NpgsqlTypes.NpgsqlLine(a: 0.42650258946764497d, b: 0.9637001748596262d, c: 0.8391188983326199d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3441288994369156d, b: 0.20296500385836902d, c: 0.303178037922484d),
new NpgsqlTypes.NpgsqlLine(a: 0.053397991352551966d, b: 0.4306001625612932d, c: 0.8137272494282278d),
new NpgsqlTypes.NpgsqlLine(a: 0.11153853007395542d, b: 0.07467580329633217d, c: 0.5224783711234579d),
new NpgsqlTypes.NpgsqlLine(a: 0.7557193915330761d, b: 0.5895102177731333d, c: 0.6947424472131005d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6180625578578823d, b: 0.816460926306873d, c: 0.39708907551136563d),
new NpgsqlTypes.NpgsqlLine(a: 0.8025769856941453d, b: 0.20174730864270984d, c: 0.9507151145944217d),
new NpgsqlTypes.NpgsqlLine(a: 0.1506683636200774d, b: 0.9040481936922684d, c: 0.2063819891764913d),
new NpgsqlTypes.NpgsqlLine(a: 0.8391242865514195d, b: 0.5169116087909608d, c: 0.2921574421754407d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6814015259105827d, b: 0.05210268267099871d, c: 0.7679468509628953d),
new NpgsqlTypes.NpgsqlLine(a: 0.5616843075322406d, b: 0.14305997520067038d, c: 0.07898101264243285d),
new NpgsqlTypes.NpgsqlLine(a: 0.22221549052645317d, b: 0.191727435363097d, c: 0.7291697449786539d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8148840558010826d, b: 0.181968896896328d, c: 0.6190837517542302d),
new NpgsqlTypes.NpgsqlLine(a: 0.6793875289820884d, b: 0.5050187817776927d, c: 0.03180165582557937d),
new NpgsqlTypes.NpgsqlLine(a: 0.12166502073369134d, b: 0.8891271192244257d, c: 0.43750716001075796d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05071152524313138d, b: 0.27081717817694684d, c: 0.1878525076984504d),
new NpgsqlTypes.NpgsqlLine(a: 0.5722935329822286d, b: 0.6241120987447143d, c: 0.6665221355459339d),
new NpgsqlTypes.NpgsqlLine(a: 0.21587014009793037d, b: 0.5717710293761644d, c: 0.22660269122153354d),
new NpgsqlTypes.NpgsqlLine(a: 0.9826541839314487d, b: 0.13188877926292042d, c: 0.25651380213287356d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17995955505163386d, b: 0.37102361942459006d, c: 0.17296631241645832d),
new NpgsqlTypes.NpgsqlLine(a: 0.033855984279543394d, b: 0.4906485628014706d, c: 0.020674401012658494d),
new NpgsqlTypes.NpgsqlLine(a: 0.6115100394073105d, b: 0.5349054230396131d, c: 0.6173286916412564d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5719964614763778d, b: 0.3082080736650271d, c: 0.4061547843606641d),
new NpgsqlTypes.NpgsqlLine(a: 0.6044989964508288d, b: 0.855926434799305d, c: 0.5264338974946069d),
new NpgsqlTypes.NpgsqlLine(a: 0.586659951466799d, b: 0.24559805387895461d, c: 0.4450893393729477d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7300964426348862d, b: 0.36455883980369286d, c: 0.5780368762784364d),
new NpgsqlTypes.NpgsqlLine(a: 0.41630990713314875d, b: 0.645840508422936d, c: 0.7566477556497976d),
new NpgsqlTypes.NpgsqlLine(a: 0.2946925543842469d, b: 0.7357834763454745d, c: 0.534989559736419d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19250516674542872d, b: 0.5383698881951341d, c: 0.7631629808423364d),
new NpgsqlTypes.NpgsqlLine(a: 0.1106612324035019d, b: 0.19038547417104057d, c: 0.06122913361799209d),
new NpgsqlTypes.NpgsqlLine(a: 0.5683804231922724d, b: 0.9904140636082538d, c: 0.20832142575105195d),
new NpgsqlTypes.NpgsqlLine(a: 0.5543068847511398d, b: 0.151777660386342d, c: 0.4260183292059745d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7882066685361058d, b: 0.8353831098313212d, c: 0.053564862113057665d),
new NpgsqlTypes.NpgsqlLine(a: 0.7237819606962356d, b: 0.24921914263626976d, c: 0.1074514400597193d),
new NpgsqlTypes.NpgsqlLine(a: 0.7646707604160653d, b: 0.7696802200651165d, c: 0.7876819859018075d),
new NpgsqlTypes.NpgsqlLine(a: 0.7945474847788094d, b: 0.3424266899278394d, c: 0.3930323879279719d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.021162711768520914d, b: 0.014924583330892749d, c: 0.43061153376343453d),
new NpgsqlTypes.NpgsqlLine(a: 0.4514008354480664d, b: 0.1394914354793424d, c: 0.7307730474939746d),
new NpgsqlTypes.NpgsqlLine(a: 0.25163866806508406d, b: 0.7057046797512886d, c: 0.9477138730417874d),
new NpgsqlTypes.NpgsqlLine(a: 0.8192496379723649d, b: 0.7531155138320511d, c: 0.31999926668747714d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5937316551889638d, b: 0.33155460139287496d, c: 0.8019087470887133d),
new NpgsqlTypes.NpgsqlLine(a: 0.21471508661325356d, b: 0.7328649834440428d, c: 0.9382383548699305d),
new NpgsqlTypes.NpgsqlLine(a: 0.8816472069040633d, b: 0.5869550799239462d, c: 0.22887536071993952d),
new NpgsqlTypes.NpgsqlLine(a: 0.6514656366207845d, b: 0.5191227290141197d, c: 0.45756370057816287d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9223785974992672d, b: 0.24360673403519106d, c: 0.764446265728896d),
new NpgsqlTypes.NpgsqlLine(a: 0.15932523022702283d, b: 0.45569724144305834d, c: 0.7279305078415683d),
new NpgsqlTypes.NpgsqlLine(a: 0.5198666165127355d, b: 0.241231789428493d, c: 0.7629327787713512d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09165496731319256d, b: 0.9662113560580288d, c: 0.8558792826759808d),
new NpgsqlTypes.NpgsqlLine(a: 0.9279327405018706d, b: 0.16228060967324476d, c: 0.2687892952679106d),
new NpgsqlTypes.NpgsqlLine(a: 0.48500291157479036d, b: 0.6650253341609155d, c: 0.05299096388328206d),
new NpgsqlTypes.NpgsqlLine(a: 0.8047433010486483d, b: 0.18757857319755944d, c: 0.08031538626851908d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6736601504787274d, b: 0.8917683233524579d, c: 0.8110935422344931d),
new NpgsqlTypes.NpgsqlLine(a: 0.389216594229855d, b: 0.37854898536563364d, c: 0.2725204033202371d),
new NpgsqlTypes.NpgsqlLine(a: 0.9007944781977453d, b: 0.48422401986504593d, c: 0.993511557806696d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32484101991342873d, b: 0.7105925509621094d, c: 0.0563584967314108d),
new NpgsqlTypes.NpgsqlLine(a: 0.99263995383511d, b: 0.06579008373625495d, c: 0.8555012848026404d),
new NpgsqlTypes.NpgsqlLine(a: 0.9782822211489575d, b: 0.20582814701455054d, c: 0.6084860990384685d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.024793440393113708d, b: 0.5336400169015757d, c: 0.5143047632622897d),
new NpgsqlTypes.NpgsqlLine(a: 0.19760146653594302d, b: 0.9089669950927631d, c: 0.4870367985218568d),
new NpgsqlTypes.NpgsqlLine(a: 0.5821190371371024d, b: 0.24373839596020686d, c: 0.23744088585470136d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5877841159785693d, b: 0.8771695419889919d, c: 0.6143390160202526d),
new NpgsqlTypes.NpgsqlLine(a: 0.5434537902344047d, b: 0.8733941141214097d, c: 0.8125649806920964d),
new NpgsqlTypes.NpgsqlLine(a: 0.22693466455756495d, b: 0.6246507203969143d, c: 0.5726570484606693d),
new NpgsqlTypes.NpgsqlLine(a: 0.9359363322197733d, b: 0.5765293091578076d, c: 0.6455181672473423d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.416331460566966d, b: 0.9766706809410866d, c: 0.40196094032331076d),
new NpgsqlTypes.NpgsqlLine(a: 0.977442240926163d, b: 0.2813396641793393d, c: 0.37030773663303596d),
new NpgsqlTypes.NpgsqlLine(a: 0.5272579563533457d, b: 0.06869110754047025d, c: 0.17778619963679865d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.461921191953934d, b: 0.6148995517806009d, c: 0.5390731793690481d),
new NpgsqlTypes.NpgsqlLine(a: 0.6943857379728073d, b: 0.9070700515596372d, c: 0.10978661755080399d),
new NpgsqlTypes.NpgsqlLine(a: 0.44335826669727507d, b: 0.2865345560031404d, c: 0.2728492377115257d),
new NpgsqlTypes.NpgsqlLine(a: 0.8710048838701717d, b: 0.8200700339180332d, c: 0.2938721281472986d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09197488830803235d, b: 0.2105175696247501d, c: 0.8571894546632877d),
new NpgsqlTypes.NpgsqlLine(a: 0.6469389193477788d, b: 0.046531699585474096d, c: 0.2731629638546005d),
new NpgsqlTypes.NpgsqlLine(a: 0.6660520522604599d, b: 0.15659576165188127d, c: 0.32070429673579204d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2820235653792029d, b: 0.25950030438786087d, c: 0.5266012921929751d),
new NpgsqlTypes.NpgsqlLine(a: 0.2910676691288778d, b: 0.940515071281402d, c: 0.1367752177913677d),
new NpgsqlTypes.NpgsqlLine(a: 0.7840645685831992d, b: 0.47154701084839024d, c: 0.42686366087781014d),
new NpgsqlTypes.NpgsqlLine(a: 0.4862359968636357d, b: 0.3426466212647784d, c: 0.7132865168004273d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42975716811691955d, b: 0.3646526313719879d, c: 0.9967788100860665d),
new NpgsqlTypes.NpgsqlLine(a: 0.8111041049535952d, b: 0.8133116937487066d, c: 0.29405328852759316d),
new NpgsqlTypes.NpgsqlLine(a: 0.8590043916432268d, b: 0.530249079634812d, c: 0.25469033110560313d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6334371274202926d, b: 0.21158629440645338d, c: 0.3320701736719357d),
new NpgsqlTypes.NpgsqlLine(a: 0.3836373283815645d, b: 0.2447437943240066d, c: 0.48750922952369047d),
new NpgsqlTypes.NpgsqlLine(a: 0.09285784624817783d, b: 0.10037618421836725d, c: 0.6557036969703977d),
new NpgsqlTypes.NpgsqlLine(a: 0.959500989032924d, b: 0.23069014371108842d, c: 0.9806002077647311d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5613797658221504d, b: 0.8331533304099298d, c: 0.03624269869656582d),
new NpgsqlTypes.NpgsqlLine(a: 0.1109958174720923d, b: 0.07765638447226397d, c: 0.7291541330294464d),
new NpgsqlTypes.NpgsqlLine(a: 0.11165664630328898d, b: 0.5547700919605529d, c: 0.5500849923275622d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4237126089891843d, b: 0.40158044021628714d, c: 0.36020095108826666d),
new NpgsqlTypes.NpgsqlLine(a: 0.4106476357005978d, b: 0.04200772079876691d, c: 0.5291587274009438d),
new NpgsqlTypes.NpgsqlLine(a: 0.8778188871832767d, b: 0.007130862720034936d, c: 0.0640275769223081d),
new NpgsqlTypes.NpgsqlLine(a: 0.44151990257162754d, b: 0.5648469707637999d, c: 0.9618592495302571d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4104021528797377d, b: 0.3430544382258557d, c: 0.35490892638445615d),
new NpgsqlTypes.NpgsqlLine(a: 0.06643209988845711d, b: 0.7566564057972078d, c: 0.5396295924479243d),
new NpgsqlTypes.NpgsqlLine(a: 0.26729952329592555d, b: 0.1383405297614977d, c: 0.1530798001866086d),
new NpgsqlTypes.NpgsqlLine(a: 0.7040826574491843d, b: 0.6288772243299043d, c: 0.8852965417545554d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5737164157507048d, b: 0.30051277836750034d, c: 0.7499347952614426d),
new NpgsqlTypes.NpgsqlLine(a: 0.17227111990148003d, b: 0.31523852733405633d, c: 0.3406090707835452d),
new NpgsqlTypes.NpgsqlLine(a: 0.9926969131872277d, b: 0.4866600081721747d, c: 0.03461723382688686d),
new NpgsqlTypes.NpgsqlLine(a: 0.3996644808953961d, b: 0.6049163373047889d, c: 0.45142583295367766d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5755092999329023d, b: 0.6153915159831214d, c: 0.6691408820956409d),
new NpgsqlTypes.NpgsqlLine(a: 0.7942491570453938d, b: 0.888744819879301d, c: 0.6805204878568685d),
new NpgsqlTypes.NpgsqlLine(a: 0.02361981062183005d, b: 0.8399057677065919d, c: 0.8677431803447476d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4871449821285534d, b: 0.14222599928566326d, c: 0.021930054824293665d),
new NpgsqlTypes.NpgsqlLine(a: 0.35800503862168886d, b: 0.6245175728828014d, c: 0.34363109486710885d),
new NpgsqlTypes.NpgsqlLine(a: 0.4730341001726438d, b: 0.511570669828989d, c: 0.3907932209574464d),
new NpgsqlTypes.NpgsqlLine(a: 0.20524211283625515d, b: 0.7591431535879599d, c: 0.0611898848136726d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08358526907783526d, b: 0.2691827633553794d, c: 0.08809775327736857d),
new NpgsqlTypes.NpgsqlLine(a: 0.4860265692747202d, b: 0.9764121301332892d, c: 0.9820842365929842d),
new NpgsqlTypes.NpgsqlLine(a: 0.7794583198804219d, b: 0.6758947253987145d, c: 0.8496497689307738d),
new NpgsqlTypes.NpgsqlLine(a: 0.8940949918249946d, b: 0.3870379829279852d, c: 0.39873651461000903d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3042896638677124d, b: 0.4143695697722045d, c: 0.1767256466629985d),
new NpgsqlTypes.NpgsqlLine(a: 0.2416674211714026d, b: 0.8662213692363327d, c: 0.16578778158127905d),
new NpgsqlTypes.NpgsqlLine(a: 0.5874672169451235d, b: 0.5905836487241319d, c: 0.6727599064250749d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5346454985436526d, b: 0.8083500642084788d, c: 0.6231931430391264d),
new NpgsqlTypes.NpgsqlLine(a: 0.7201068745418563d, b: 0.23763284184537392d, c: 0.5886433942948224d),
new NpgsqlTypes.NpgsqlLine(a: 0.577772358524558d, b: 0.7567967024852131d, c: 0.4515895394469358d),
new NpgsqlTypes.NpgsqlLine(a: 0.9857231150418149d, b: 0.8189284371402096d, c: 0.0700408742799955d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8390603894998222d, b: 0.9257278522931621d, c: 0.468008196446979d),
new NpgsqlTypes.NpgsqlLine(a: 0.20030242713453317d, b: 0.2882805219131708d, c: 0.668090944125995d),
new NpgsqlTypes.NpgsqlLine(a: 0.8720656603532245d, b: 0.2923436265227496d, c: 0.7304732737487313d),
new NpgsqlTypes.NpgsqlLine(a: 0.6599918754361953d, b: 0.43278330911207386d, c: 0.48045772260395936d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9181333121219987d, b: 0.22273473248789522d, c: 0.8823656966194775d),
new NpgsqlTypes.NpgsqlLine(a: 0.8531086900565498d, b: 0.36603790035222394d, c: 0.18148845332558505d),
new NpgsqlTypes.NpgsqlLine(a: 0.08474349797615488d, b: 0.9430802481804679d, c: 0.5368459250511274d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15777715731600583d, b: 0.5555470684073079d, c: 0.3133159547842763d),
new NpgsqlTypes.NpgsqlLine(a: 0.40281731990813574d, b: 0.46821989078142034d, c: 0.36057235521970543d),
new NpgsqlTypes.NpgsqlLine(a: 0.3434928564277441d, b: 0.8135072768258079d, c: 0.9454402184126764d),
new NpgsqlTypes.NpgsqlLine(a: 0.08360933988781938d, b: 0.8248180234952425d, c: 0.04761475875271548d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17842408560738898d, b: 0.0018741678392686367d, c: 0.2929227722435198d),
new NpgsqlTypes.NpgsqlLine(a: 0.7490651585412067d, b: 0.5213208768026801d, c: 0.7458081639674478d),
new NpgsqlTypes.NpgsqlLine(a: 0.729749710027813d, b: 0.03897916618476116d, c: 0.968993346133549d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5670867005420722d, b: 0.8763511922725775d, c: 0.1429830975829557d),
new NpgsqlTypes.NpgsqlLine(a: 0.20119396995096872d, b: 0.3381997116965303d, c: 0.7191068029619029d),
new NpgsqlTypes.NpgsqlLine(a: 0.9331002553452855d, b: 0.5067497311898711d, c: 0.7518670569540726d),
new NpgsqlTypes.NpgsqlLine(a: 0.2912406000489772d, b: 0.5318239003370402d, c: 0.3850431925915052d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8516920009152563d, b: 0.8790785473905518d, c: 0.029787233021310033d),
new NpgsqlTypes.NpgsqlLine(a: 0.42016151464199425d, b: 0.9488550140774912d, c: 0.6311795229758844d),
new NpgsqlTypes.NpgsqlLine(a: 0.1860626108263016d, b: 0.7678773621287056d, c: 0.25330721806250833d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.698739787683479d, b: 0.9900528413049008d, c: 0.15878587899008034d),
new NpgsqlTypes.NpgsqlLine(a: 0.9694888314636531d, b: 0.28181717256405947d, c: 0.6534376842334894d),
new NpgsqlTypes.NpgsqlLine(a: 0.7636214385106844d, b: 0.6859076803768164d, c: 0.5463600492519984d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8038896696226474d, b: 0.9815235784108379d, c: 0.4537322884768409d),
new NpgsqlTypes.NpgsqlLine(a: 0.21136587749540625d, b: 0.33914686155124973d, c: 0.7878686077599211d),
new NpgsqlTypes.NpgsqlLine(a: 0.16825455047145532d, b: 0.45856880314478177d, c: 0.1919101474117636d),
new NpgsqlTypes.NpgsqlLine(a: 0.05517876901325858d, b: 0.7790939635948644d, c: 0.6556199612540532d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19785650845977654d, b: 0.24470248038010012d, c: 0.7605749464436127d),
new NpgsqlTypes.NpgsqlLine(a: 0.5690907377390274d, b: 0.5141320673809436d, c: 0.6666591261689683d),
new NpgsqlTypes.NpgsqlLine(a: 0.05991221190063467d, b: 0.5267369635419238d, c: 0.42759685041224493d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.680450611837828d, b: 0.0001665935076022862d, c: 0.3461787138483309d),
new NpgsqlTypes.NpgsqlLine(a: 0.5307969555233201d, b: 0.8567058777060029d, c: 0.9443964013863368d),
new NpgsqlTypes.NpgsqlLine(a: 0.9456263822770498d, b: 0.2585662863283251d, c: 0.5183791551733439d),
new NpgsqlTypes.NpgsqlLine(a: 0.5874637318738032d, b: 0.894972145142163d, c: 0.21322886728481183d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9949252493433658d, b: 0.49507363443946995d, c: 0.3916546570719428d),
new NpgsqlTypes.NpgsqlLine(a: 0.7071226273686019d, b: 0.35228128987965146d, c: 0.1680946615466281d),
new NpgsqlTypes.NpgsqlLine(a: 0.553942691745946d, b: 0.1628843924304887d, c: 0.8035214234920214d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6779239609191589d, b: 0.24090058894784372d, c: 0.47135991596978566d),
new NpgsqlTypes.NpgsqlLine(a: 0.8671159559698172d, b: 0.2444402991288449d, c: 0.2500946359775226d),
new NpgsqlTypes.NpgsqlLine(a: 0.3928975380341625d, b: 0.153475693324701d, c: 0.8249011062049607d),
new NpgsqlTypes.NpgsqlLine(a: 0.19995204767425478d, b: 0.09065459743774196d, c: 0.05146440662538698d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12920196858222688d, b: 0.07217484512018457d, c: 0.9211669187835643d),
new NpgsqlTypes.NpgsqlLine(a: 0.25160241644556747d, b: 0.523454701962821d, c: 0.8124479161930047d),
new NpgsqlTypes.NpgsqlLine(a: 0.17374951439601483d, b: 0.10833260923324273d, c: 0.9058327182381061d),
new NpgsqlTypes.NpgsqlLine(a: 0.19763570419370757d, b: 0.8728290343229801d, c: 0.7133823505310138d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4557853179693756d, b: 0.9399358849834857d, c: 0.08139124435386302d),
new NpgsqlTypes.NpgsqlLine(a: 0.7468677482276541d, b: 0.41205899280841807d, c: 0.78626505546076d),
new NpgsqlTypes.NpgsqlLine(a: 0.9436922271685271d, b: 0.3719327279946306d, c: 0.5386464719821249d),
new NpgsqlTypes.NpgsqlLine(a: 0.6650709450065266d, b: 0.5195433421280732d, c: 0.9463998006914294d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6327885815543901d, b: 0.2430630688364076d, c: 0.4731197901938361d),
new NpgsqlTypes.NpgsqlLine(a: 0.5921946667314084d, b: 0.9431984571100256d, c: 0.5929306193397262d),
new NpgsqlTypes.NpgsqlLine(a: 0.05945611855463784d, b: 0.5951757742715567d, c: 0.5596638045886494d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7598126510739793d, b: 0.022404022483360375d, c: 0.059377296842535454d),
new NpgsqlTypes.NpgsqlLine(a: 0.5981845439059982d, b: 0.004391222388432481d, c: 0.9242687422566567d),
new NpgsqlTypes.NpgsqlLine(a: 0.1889657743827946d, b: 0.6473834018503706d, c: 0.8298864889374421d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08748717907479542d, b: 0.048803242320444085d, c: 0.39819482164216247d),
new NpgsqlTypes.NpgsqlLine(a: 0.9458021101019585d, b: 0.4022328017622324d, c: 0.17710069894123304d),
new NpgsqlTypes.NpgsqlLine(a: 0.04683246094350746d, b: 0.9472616776346948d, c: 0.6614403014260474d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22556468053166956d, b: 0.34274547018971413d, c: 0.8258876840152177d),
new NpgsqlTypes.NpgsqlLine(a: 0.23487187735417692d, b: 0.23500218327088462d, c: 0.4519310085541103d),
new NpgsqlTypes.NpgsqlLine(a: 0.10526857138934298d, b: 0.32064397448016013d, c: 0.5194065041364075d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7078031196657997d, b: 0.09688000124205232d, c: 0.8948327966468337d),
new NpgsqlTypes.NpgsqlLine(a: 0.5973145704723972d, b: 0.46010379668252477d, c: 0.6726566100351679d),
new NpgsqlTypes.NpgsqlLine(a: 0.5611193590585787d, b: 0.19343114791914418d, c: 0.9399583149771066d),
new NpgsqlTypes.NpgsqlLine(a: 0.9211194705370289d, b: 0.27237757271487983d, c: 0.943520204903865d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5317282545112083d, b: 0.08214045916641333d, c: 0.7733271560918824d),
new NpgsqlTypes.NpgsqlLine(a: 0.10844940260427272d, b: 0.3210861909107394d, c: 0.9216207251250151d),
new NpgsqlTypes.NpgsqlLine(a: 0.12306972350905598d, b: 0.8336786824456481d, c: 0.32818546713594576d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.13648629013870717d, b: 0.3140373656661918d, c: 0.6473672502819604d),
new NpgsqlTypes.NpgsqlLine(a: 0.8793173979408065d, b: 0.2680928812614246d, c: 0.1598045512543581d),
new NpgsqlTypes.NpgsqlLine(a: 0.3016651165806894d, b: 0.4332146301780171d, c: 0.047535234601844056d),
new NpgsqlTypes.NpgsqlLine(a: 0.1890150148275347d, b: 0.3308086368338118d, c: 0.9765303674087813d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8733516203727957d, b: 0.33802953240674405d, c: 0.9250124995453135d),
new NpgsqlTypes.NpgsqlLine(a: 0.17810330756603698d, b: 0.6839154776558546d, c: 0.2254319419601949d),
new NpgsqlTypes.NpgsqlLine(a: 0.11907227252743369d, b: 0.46651798459362304d, c: 0.843421402110555d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19875374541103552d, b: 0.012800213936321359d, c: 0.6945624927940419d),
new NpgsqlTypes.NpgsqlLine(a: 0.976758922217027d, b: 0.498633937600063d, c: 0.07613046238701904d),
new NpgsqlTypes.NpgsqlLine(a: 0.20696306853315927d, b: 0.5848332389217491d, c: 0.9105933032116414d),
new NpgsqlTypes.NpgsqlLine(a: 0.2751754253268792d, b: 0.9539927449875027d, c: 0.6833813899850728d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.918315415008538d, b: 0.3274042507130952d, c: 0.9245597794433236d),
new NpgsqlTypes.NpgsqlLine(a: 0.9394850544971625d, b: 0.7271704215344084d, c: 0.12771412527721926d),
new NpgsqlTypes.NpgsqlLine(a: 0.2225223514435256d, b: 0.7675704577687346d, c: 0.39013686560956995d),
new NpgsqlTypes.NpgsqlLine(a: 0.5359469136552474d, b: 0.2599274455668581d, c: 0.9764496859309874d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6806481100885742d, b: 0.8292121500910349d, c: 0.8337097908729428d),
new NpgsqlTypes.NpgsqlLine(a: 0.008713495432295604d, b: 0.13322039049474443d, c: 0.8172878470625857d),
new NpgsqlTypes.NpgsqlLine(a: 0.5075787997835389d, b: 0.8951222676695678d, c: 0.8398445897917046d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7845232605761314d, b: 0.9972564560686973d, c: 0.13853112327936634d),
new NpgsqlTypes.NpgsqlLine(a: 0.12529628508882373d, b: 0.5779062294974343d, c: 0.01672609434768324d),
new NpgsqlTypes.NpgsqlLine(a: 0.755618059892687d, b: 0.3210047228062871d, c: 0.06739047550937949d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4000809467576336d, b: 0.7892656437245034d, c: 0.6795785866036121d),
new NpgsqlTypes.NpgsqlLine(a: 0.6602795640650387d, b: 0.8797290481787533d, c: 0.4439359817658538d),
new NpgsqlTypes.NpgsqlLine(a: 0.42650258946764497d, b: 0.9637001748596262d, c: 0.8391188983326199d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8148840558010826d, b: 0.181968896896328d, c: 0.6190837517542302d),
new NpgsqlTypes.NpgsqlLine(a: 0.6793875289820884d, b: 0.5050187817776927d, c: 0.03180165582557937d),
new NpgsqlTypes.NpgsqlLine(a: 0.12166502073369134d, b: 0.8891271192244257d, c: 0.43750716001075796d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 38;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 84, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 21, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 29, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 6, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 117, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 126, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 12, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[30], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[30], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI), typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                await ((INpgsqlLineArraylineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                ((INpgsqlLineArraylineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineArraylineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

