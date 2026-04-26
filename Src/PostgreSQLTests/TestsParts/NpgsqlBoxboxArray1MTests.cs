

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8105339961199474d,right: 0.9596110814475145d,bottom: 0.3110970223758125d,left: 0.2815763199119373d),
new NpgsqlTypes.NpgsqlBox(top: 0.43608403493533143d,right: 0.8525962367737085d,bottom: 0.03370761348033047d,left: 0.14068553977955467d),
new NpgsqlTypes.NpgsqlBox(top: 0.36663416252671577d,right: 0.07426693882684399d,bottom: 0.01488994088460771d,left: 0.03804627984028719d),
new NpgsqlTypes.NpgsqlBox(top: 0.5245231538950578d,right: 0.9299988243452306d,bottom: 0.4909698019550979d,left: 0.2226977072809857d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8593426151192708d,right: 0.5235066880079033d,bottom: 0.3294398534373738d,left: 0.13547101127342376d),
new NpgsqlTypes.NpgsqlBox(top: 0.7358775744716908d,right: 0.794152705315428d,bottom: 0.09789157847241281d,left: 0.7307584258677071d),
new NpgsqlTypes.NpgsqlBox(top: 0.3120381260269105d,right: 0.9408054437551815d,bottom: 0.11901889684665079d,left: 0.13952303785537967d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6785757783153551d,right: 0.5042917937770307d,bottom: 0.5403586681109726d,left: 0.35126290081959033d),
new NpgsqlTypes.NpgsqlBox(top: 0.7428238404733148d,right: 0.46079346521325304d,bottom: 0.19877538817978235d,left: 0.06210742847266304d),
new NpgsqlTypes.NpgsqlBox(top: 0.4020068367448375d,right: 0.71497438197391d,bottom: 0.30961413471525967d,left: 0.09950364189152239d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.36120231867029906d,right: 0.7337334425054358d,bottom: 0.01613285443457413d,left: 0.6261066290343205d),
new NpgsqlTypes.NpgsqlBox(top: 0.8752130687917898d,right: 0.9819466100935491d,bottom: 0.809221837909595d,left: 0.8217328318583869d),
new NpgsqlTypes.NpgsqlBox(top: 0.5674060722983354d,right: 0.5690755459959012d,bottom: 0.12373553584466024d,left: 0.10131278875799266d),
new NpgsqlTypes.NpgsqlBox(top: 0.09903786765515388d,right: 0.7088818353163485d,bottom: 0.07028656026319513d,left: 0.402897576238314d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.84070613370444d,right: 0.5020243017529248d,bottom: 0.7543517504155441d,left: 0.2600697735743285d),
new NpgsqlTypes.NpgsqlBox(top: 0.8103079695261428d,right: 0.9595208662092243d,bottom: 0.48430090677259074d,left: 0.9411070927519987d),
new NpgsqlTypes.NpgsqlBox(top: 0.7645896035416933d,right: 0.7381643428437858d,bottom: 0.47351170213656224d,left: 0.1246130776790294d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9143707602242475d,right: 0.7661868708162852d,bottom: 0.34377858548625595d,left: 0.3030900382769883d),
new NpgsqlTypes.NpgsqlBox(top: 0.691048219421807d,right: 0.4738898988893103d,bottom: 0.10260693018853873d,left: 0.4097139425405125d),
new NpgsqlTypes.NpgsqlBox(top: 0.10346624074986732d,right: 0.6276592357145104d,bottom: 0.009267248430862463d,left: 0.30522003449575774d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6755066571292635d,right: 0.8705654640396232d,bottom: 0.49476759783848945d,left: 0.7216602069262574d),
new NpgsqlTypes.NpgsqlBox(top: 0.5811608788749558d,right: 0.37632989884538126d,bottom: 0.5353549092903395d,left: 0.17551323887480985d),
new NpgsqlTypes.NpgsqlBox(top: 0.6725829175432289d,right: 0.7972333085460237d,bottom: 0.434254118074475d,left: 0.023937219441271362d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9051784167775367d,right: 0.2581805229167602d,bottom: 0.7653923147270696d,left: 0.18991493358769607d),
new NpgsqlTypes.NpgsqlBox(top: 0.6239917173487846d,right: 0.4939297269078159d,bottom: 0.35447632396849793d,left: 0.35777204109867333d),
new NpgsqlTypes.NpgsqlBox(top: 0.9248783702249256d,right: 0.5894486923394154d,bottom: 0.22147783218405515d,left: 0.35129217106327726d),
new NpgsqlTypes.NpgsqlBox(top: 0.6307274726887062d,right: 0.5475261978196604d,bottom: 0.6000886427072251d,left: 0.12817727905656395d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9397994792602997d,right: 0.24469558364821742d,bottom: 0.4009633327075238d,left: 0.009960609550883404d),
new NpgsqlTypes.NpgsqlBox(top: 0.7879204062901924d,right: 0.17215254999350726d,bottom: 0.7032842945140878d,left: 0.06464620331053561d),
new NpgsqlTypes.NpgsqlBox(top: 0.6769340444491495d,right: 0.5170350386366881d,bottom: 0.18501474254741446d,left: 0.04752981517466093d),
new NpgsqlTypes.NpgsqlBox(top: 0.6479659991077784d,right: 0.27560226835456625d,bottom: 0.6260028045956424d,left: 0.23624221601701267d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9513206639480221d,right: 0.3751991466894242d,bottom: 0.6272679153929678d,left: 0.13116464055844324d),
new NpgsqlTypes.NpgsqlBox(top: 0.7478758688725777d,right: 0.9203200975162206d,bottom: 0.05484280639175387d,left: 0.09371327158548526d),
new NpgsqlTypes.NpgsqlBox(top: 0.8460962221325924d,right: 0.7739707668185802d,bottom: 0.5279373103417058d,left: 0.03881511855427444d),
new NpgsqlTypes.NpgsqlBox(top: 0.46856893285331935d,right: 0.9496530458353799d,bottom: 0.21181096887331952d,left: 0.9131329140816696d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9778666486541853d,right: 0.7007926061666208d,bottom: 0.7697773104455742d,left: 0.40391924295790593d),
new NpgsqlTypes.NpgsqlBox(top: 0.9119176433263432d,right: 0.6336535579418072d,bottom: 0.3124874383384203d,left: 0.5151657477670335d),
new NpgsqlTypes.NpgsqlBox(top: 0.8964937655352259d,right: 0.6926959308560151d,bottom: 0.42364022618007235d,left: 0.09539192978787747d),
new NpgsqlTypes.NpgsqlBox(top: 0.8927902474188895d,right: 0.5255682870879564d,bottom: 0.6076109577492519d,left: 0.2599643084949831d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7406802609771435d,right: 0.7328116807852033d,bottom: 0.7328169834871343d,left: 0.6878506148576842d),
new NpgsqlTypes.NpgsqlBox(top: 0.2855791826485523d,right: 0.921666638602661d,bottom: 0.03912620426739788d,left: 0.11882883988249715d),
new NpgsqlTypes.NpgsqlBox(top: 0.8044951021761505d,right: 0.45263740789042617d,bottom: 0.24120172793859662d,left: 0.28189281769201624d),
new NpgsqlTypes.NpgsqlBox(top: 0.7179709297371754d,right: 0.5560526975462002d,bottom: 0.44034551921463283d,left: 0.15472548245751216d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9125375330888568d,right: 0.971775994699891d,bottom: 0.15862356587921467d,left: 0.7789510877390401d),
new NpgsqlTypes.NpgsqlBox(top: 0.904335042135688d,right: 0.9925221146221656d,bottom: 0.11416049586377985d,left: 0.9689862143745922d),
new NpgsqlTypes.NpgsqlBox(top: 0.8547537959205548d,right: 0.8917385622845532d,bottom: 0.7486617855058276d,left: 0.3547440196221108d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8232231812782828d,right: 0.8953510968819393d,bottom: 0.5978745831270754d,left: 0.2827797896742881d),
new NpgsqlTypes.NpgsqlBox(top: 0.41663460620495507d,right: 0.7254412026058226d,bottom: 0.4036207417078683d,left: 0.21521597450498176d),
new NpgsqlTypes.NpgsqlBox(top: 0.8798750667944546d,right: 0.5817401846836683d,bottom: 0.36170726396707076d,left: 0.4486014942181147d),
new NpgsqlTypes.NpgsqlBox(top: 0.3945352788604397d,right: 0.840326678523712d,bottom: 0.2722053501838253d,left: 0.6583348241014496d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6480718622614625d,right: 0.8036266302682202d,bottom: 0.5414541088174417d,left: 0.3520697989029927d),
new NpgsqlTypes.NpgsqlBox(top: 0.27647436093395816d,right: 0.3342864570546251d,bottom: 0.07006811351753661d,left: 0.1984862886397224d),
new NpgsqlTypes.NpgsqlBox(top: 0.9754821181321119d,right: 0.48311320687700987d,bottom: 0.05850613455492537d,left: 0.1815493904405675d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8712248063638728d,right: 0.8086229173499073d,bottom: 0.5807277202014599d,left: 0.6044914248086513d),
new NpgsqlTypes.NpgsqlBox(top: 0.9221766772351488d,right: 0.948868524066945d,bottom: 0.5612792034298987d,left: 0.665648599389417d),
new NpgsqlTypes.NpgsqlBox(top: 0.9164729852364386d,right: 0.7649111921321505d,bottom: 0.5808879214492463d,left: 0.33012780295488287d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4161441307150091d,right: 0.8527364765895568d,bottom: 0.11010780286441502d,left: 0.22374766886628839d),
new NpgsqlTypes.NpgsqlBox(top: 0.9114791090093669d,right: 0.42618443045993315d,bottom: 0.7561193358122942d,left: 0.3189972551905258d),
new NpgsqlTypes.NpgsqlBox(top: 0.7313169454982116d,right: 0.5457887222281163d,bottom: 0.6104161319783108d,left: 0.3833485274971531d),
new NpgsqlTypes.NpgsqlBox(top: 0.7829852062980948d,right: 0.8649353710315969d,bottom: 0.1471424730669746d,left: 0.5649358847398283d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6871541360602854d,right: 0.999835112816353d,bottom: 0.43224599296756416d,left: 0.4427615432991402d),
new NpgsqlTypes.NpgsqlBox(top: 0.9882294852826717d,right: 0.33649277844528924d,bottom: 0.44584819902600725d,left: 0.17247704931502317d),
new NpgsqlTypes.NpgsqlBox(top: 0.9110834354193548d,right: 0.4831900490903326d,bottom: 0.019897253159283257d,left: 0.0965922849022075d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4086619058396912d,right: 0.6788352193819881d,bottom: 0.2802722474997167d,left: 0.4865207153665151d),
new NpgsqlTypes.NpgsqlBox(top: 0.6887892171518419d,right: 0.5596695677866578d,bottom: 0.6686943245453848d,left: 0.42991662235569295d),
new NpgsqlTypes.NpgsqlBox(top: 0.8917432460663933d,right: 0.8639244975754518d,bottom: 0.28909714453579427d,left: 0.11235064315303733d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7569301664596019d,right: 0.2994778640041419d,bottom: 0.6606753622380853d,left: 0.2764580704144374d),
new NpgsqlTypes.NpgsqlBox(top: 0.4731448705290756d,right: 0.6165911215666484d,bottom: 0.4062925850403942d,left: 0.2677850484053498d),
new NpgsqlTypes.NpgsqlBox(top: 0.661510543257552d,right: 0.397247405016497d,bottom: 0.2869176963870176d,left: 0.3490318299606405d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.48684813498434765d,right: 0.4571072921436665d,bottom: 0.2019619959447193d,left: 0.2262922492121192d),
new NpgsqlTypes.NpgsqlBox(top: 0.19576162058110103d,right: 0.5386345355110759d,bottom: 0.11402175095930922d,left: 0.4783717160068949d),
new NpgsqlTypes.NpgsqlBox(top: 0.9205409971012674d,right: 0.5957168193492738d,bottom: 0.1752124542964677d,left: 0.38308437107377136d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6253071705124095d,right: 0.8751618151837274d,bottom: 0.05607215813448063d,left: 0.48251614951287547d),
new NpgsqlTypes.NpgsqlBox(top: 0.3263497867140882d,right: 0.9092424046342501d,bottom: 0.16489137199041037d,left: 0.05922503061191142d),
new NpgsqlTypes.NpgsqlBox(top: 0.7816967520216219d,right: 0.46871010502175126d,bottom: 0.6748588224653236d,left: 0.16945122073217056d),
new NpgsqlTypes.NpgsqlBox(top: 0.6575808963216476d,right: 0.31162458944557225d,bottom: 0.5336490761961832d,left: 0.18956763977196533d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.857431602246007d,right: 0.9454122908294446d,bottom: 0.7046043179715419d,left: 0.8307720549934248d),
new NpgsqlTypes.NpgsqlBox(top: 0.7768502977754088d,right: 0.7336309057412008d,bottom: 0.6864464762066647d,left: 0.4139194034784549d),
new NpgsqlTypes.NpgsqlBox(top: 0.7256205516766878d,right: 0.4360053601992897d,bottom: 0.25446319340227885d,left: 0.2028095733101678d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7494046400930044d,right: 0.7309069875743719d,bottom: 0.24675400827663696d,left: 0.0501929135026693d),
new NpgsqlTypes.NpgsqlBox(top: 0.6000945956034418d,right: 0.685679137615882d,bottom: 0.5093315490395195d,left: 0.04276554004969435d),
new NpgsqlTypes.NpgsqlBox(top: 0.5211867272707935d,right: 0.7423395382920924d,bottom: 0.07049988729875856d,left: 0.38017562759804635d),
new NpgsqlTypes.NpgsqlBox(top: 0.25864356289032264d,right: 0.5481767711393821d,bottom: 0.04240306554468842d,left: 0.41575375089989586d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3496977803901502d,right: 0.906619152485616d,bottom: 0.101595691578107d,left: 0.3495241045639208d),
new NpgsqlTypes.NpgsqlBox(top: 0.8723842283716067d,right: 0.13056965114746544d,bottom: 0.45727707077557744d,left: 0.021279772964865606d),
new NpgsqlTypes.NpgsqlBox(top: 0.4889064855391695d,right: 0.8383313107661494d,bottom: 0.4722209440376486d,left: 0.8234751109832298d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.27343606680966404d,right: 0.9476021182214055d,bottom: 0.2437748246085779d,left: 0.8791015094126317d),
new NpgsqlTypes.NpgsqlBox(top: 0.9614290781218807d,right: 0.6407495249253041d,bottom: 0.9215905242727522d,left: 0.3211176446428651d),
new NpgsqlTypes.NpgsqlBox(top: 0.7652969856766191d,right: 0.6371038445719784d,bottom: 0.5573166294183041d,left: 0.5599394202645134d),
new NpgsqlTypes.NpgsqlBox(top: 0.9350634718035525d,right: 0.9421216706234051d,bottom: 0.48260349999292573d,left: 0.6344713674029802d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.493645650718328d,right: 0.9755115556031551d,bottom: 0.09169538729253002d,left: 0.09286399653935462d),
new NpgsqlTypes.NpgsqlBox(top: 0.8902769340031571d,right: 0.9198986722892497d,bottom: 0.06997896333862452d,left: 0.738177954141125d),
new NpgsqlTypes.NpgsqlBox(top: 0.9331427984379549d,right: 0.30250919391797615d,bottom: 0.013733465160480018d,left: 0.05783656217311428d),
new NpgsqlTypes.NpgsqlBox(top: 0.5303458069995826d,right: 0.9176814166590659d,bottom: 0.10795955973657556d,left: 0.6908224408567453d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8857692834312023d,right: 0.4417256318279822d,bottom: 0.507232250070551d,left: 0.170467461296001d),
new NpgsqlTypes.NpgsqlBox(top: 0.8708709916213182d,right: 0.8664260405968873d,bottom: 0.8330067583570605d,left: 0.3129934999621331d),
new NpgsqlTypes.NpgsqlBox(top: 0.2528729351429795d,right: 0.6335348299418242d,bottom: 0.08573061108276869d,left: 0.43248181427048626d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7812631844421175d,right: 0.481852429798746d,bottom: 0.14261441870249536d,left: 0.3194244312064858d),
new NpgsqlTypes.NpgsqlBox(top: 0.8335715493269829d,right: 0.42433316626562323d,bottom: 0.7504001304515884d,left: 0.15132843240201632d),
new NpgsqlTypes.NpgsqlBox(top: 0.4930476669500582d,right: 0.31610116145260914d,bottom: 0.14273025641429737d,left: 0.1545827539554575d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.90892598873861d,right: 0.4538728775548928d,bottom: 0.6587444959897257d,left: 0.1685954783312812d),
new NpgsqlTypes.NpgsqlBox(top: 0.6100123181175281d,right: 0.375284435452685d,bottom: 0.19814856714243767d,left: 0.26845669523704196d),
new NpgsqlTypes.NpgsqlBox(top: 0.6040281715528746d,right: 0.9639980885062861d,bottom: 0.5882906798794751d,left: 0.7638819864445304d),
new NpgsqlTypes.NpgsqlBox(top: 0.6898815080384063d,right: 0.599455342434846d,bottom: 0.24701129700136792d,left: 0.5018862594222171d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6637164061385797d,right: 0.4166589717315555d,bottom: 0.02050099361263713d,left: 0.07843048183318324d),
new NpgsqlTypes.NpgsqlBox(top: 0.07409757146664664d,right: 0.5853438009454154d,bottom: 0.01037317272807814d,left: 0.43951157594559886d),
new NpgsqlTypes.NpgsqlBox(top: 0.900296886756465d,right: 0.7454487025126295d,bottom: 0.4120448950136316d,left: 0.5429287172851961d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4000840823430307d,right: 0.2566667335149194d,bottom: 0.07106158656797901d,left: 0.20112717720296758d),
new NpgsqlTypes.NpgsqlBox(top: 0.6297352915278437d,right: 0.7946694035477465d,bottom: 0.28547046279902066d,left: 0.5882565445969877d),
new NpgsqlTypes.NpgsqlBox(top: 0.8060026633351491d,right: 0.41518964243177914d,bottom: 0.27185650419348095d,left: 0.2703197299298461d),
new NpgsqlTypes.NpgsqlBox(top: 0.6091023348326716d,right: 0.9627357230040327d,bottom: 0.052285196096027d,left: 0.7150379850234588d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2885685433408589d,right: 0.6640355574868875d,bottom: 0.27245917650795126d,left: 0.46304447480950284d),
new NpgsqlTypes.NpgsqlBox(top: 0.8757624044594737d,right: 0.7151363557419491d,bottom: 0.7603807683249548d,left: 0.5100882695313509d),
new NpgsqlTypes.NpgsqlBox(top: 0.3394935145647099d,right: 0.860100373385903d,bottom: 0.051029122956924855d,left: 0.48160133387218695d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6146383758267093d,right: 0.7939295845040663d,bottom: 0.05853512448309606d,left: 0.4866934741385207d),
new NpgsqlTypes.NpgsqlBox(top: 0.870473332632123d,right: 0.8871346565216346d,bottom: 0.02268702952107038d,left: 0.8398521354872136d),
new NpgsqlTypes.NpgsqlBox(top: 0.7042533757214696d,right: 0.6639584329856774d,bottom: 0.17687001564723626d,left: 0.19512314982916756d),
new NpgsqlTypes.NpgsqlBox(top: 0.8576075278740461d,right: 0.5198355096901096d,bottom: 0.2965565114107447d,left: 0.4843839714149739d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8131393438887419d,right: 0.5265137920205664d,bottom: 0.4102441164445755d,left: 0.5099328787972935d),
new NpgsqlTypes.NpgsqlBox(top: 0.8935693250011992d,right: 0.9089607275315125d,bottom: 0.09361890976974929d,left: 0.6333509326989626d),
new NpgsqlTypes.NpgsqlBox(top: 0.8604015671235993d,right: 0.9754384853063512d,bottom: 0.11157639378980322d,left: 0.03229256282095494d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.994159662460025d,right: 0.4227541432614931d,bottom: 0.7322153156749472d,left: 0.07962693733385529d),
new NpgsqlTypes.NpgsqlBox(top: 0.723482374790359d,right: 0.4880905388795673d,bottom: 0.5673725568738996d,left: 0.24731875259282565d),
new NpgsqlTypes.NpgsqlBox(top: 0.9079741016279214d,right: 0.0842861177396852d,bottom: 0.7074227518914173d,left: 0.013721014002101461d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5747797100664472d,right: 0.44248355980347664d,bottom: 0.022449008234515344d,left: 0.217440013405231d),
new NpgsqlTypes.NpgsqlBox(top: 0.6488338050994024d,right: 0.7884486746829662d,bottom: 0.03334228232924952d,left: 0.19387074261036485d),
new NpgsqlTypes.NpgsqlBox(top: 0.8784126540000434d,right: 0.3325134445002812d,bottom: 0.8374464958132698d,left: 0.2956052440131508d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9357592175718873d,right: 0.746294264032208d,bottom: 0.06307606285792378d,left: 0.7283784243376847d),
new NpgsqlTypes.NpgsqlBox(top: 0.8176520318036493d,right: 0.6946269644544307d,bottom: 0.15009462164867104d,left: 0.57577710859471d),
new NpgsqlTypes.NpgsqlBox(top: 0.2166096049714179d,right: 0.6713333967225146d,bottom: 0.08313995524061257d,left: 0.22683783571160954d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7660997059080297d,right: 0.7363760098725355d,bottom: 0.30997068724479093d,left: 0.2259308687422653d),
new NpgsqlTypes.NpgsqlBox(top: 0.4418740278286133d,right: 0.4075910987948156d,bottom: 0.09362469671976759d,left: 0.09115597878115644d),
new NpgsqlTypes.NpgsqlBox(top: 0.7728942496151056d,right: 0.7108616520746486d,bottom: 0.33756611083115706d,left: 0.027561561325715744d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9028608692309823d,right: 0.8447859437050856d,bottom: 0.8884112123458151d,left: 0.7694317530690612d),
new NpgsqlTypes.NpgsqlBox(top: 0.3317156229599507d,right: 0.6637282478337473d,bottom: 0.2911200901110724d,left: 0.4889067192681159d),
new NpgsqlTypes.NpgsqlBox(top: 0.9670153409128139d,right: 0.7767930387490395d,bottom: 0.5545326289377102d,left: 0.7638316038550726d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9306652285913597d,right: 0.31362278752437955d,bottom: 0.5919058289179779d,left: 0.12358104880729337d),
new NpgsqlTypes.NpgsqlBox(top: 0.6664432929650861d,right: 0.09212037653814831d,bottom: 0.2890857976969943d,left: 0.07980771543620435d),
new NpgsqlTypes.NpgsqlBox(top: 0.9005609781539924d,right: 0.6562187804198851d,bottom: 0.19440536937923092d,left: 0.40426852248816303d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4665292674244702d,right: 0.6823713507794017d,bottom: 0.40718008130499406d,left: 0.06216652597486516d),
new NpgsqlTypes.NpgsqlBox(top: 0.4043776756426941d,right: 0.5679723155077319d,bottom: 0.24548404852142325d,left: 0.07091227440320247d),
new NpgsqlTypes.NpgsqlBox(top: 0.9787219518053719d,right: 0.8256873072802555d,bottom: 0.7197360703237927d,left: 0.781022593146386d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8203484458325846d,right: 0.2348397984464745d,bottom: 0.11571657127430979d,left: 0.11564508256045869d),
new NpgsqlTypes.NpgsqlBox(top: 0.9540418060793344d,right: 0.9865888590055368d,bottom: 0.4424506189054933d,left: 0.5517705762402614d),
new NpgsqlTypes.NpgsqlBox(top: 0.8351291129849477d,right: 0.4038214641543908d,bottom: 0.6739779824681245d,left: 0.036215679461426564d),
new NpgsqlTypes.NpgsqlBox(top: 0.6311242315072163d,right: 0.9085135951662952d,bottom: 0.5473140265530535d,left: 0.880236725462462d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7745065443090147d,right: 0.8379725746488661d,bottom: 0.12602271552279687d,left: 0.03880555971247224d),
new NpgsqlTypes.NpgsqlBox(top: 0.4959733892437149d,right: 0.6199541360629541d,bottom: 0.03882564630509888d,left: 0.3494514430087218d),
new NpgsqlTypes.NpgsqlBox(top: 0.5280605939139608d,right: 0.6207464604214512d,bottom: 0.43666493025089514d,left: 0.2590965117667028d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9974140050064808d,right: 0.9374366353416441d,bottom: 0.9926377400499732d,left: 0.6301334874232284d),
new NpgsqlTypes.NpgsqlBox(top: 0.7896785900507698d,right: 0.9000221793444536d,bottom: 0.10120956339953224d,left: 0.4376542579482724d),
new NpgsqlTypes.NpgsqlBox(top: 0.8831403124516181d,right: 0.8740793667352986d,bottom: 0.3061798965303829d,left: 0.2820979292021688d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7542152453362457d,right: 0.8033026777457467d,bottom: 0.6587817244040609d,left: 0.7629144279158505d),
new NpgsqlTypes.NpgsqlBox(top: 0.6885743814391616d,right: 0.37155652851357435d,bottom: 0.12950700657573433d,left: 0.16572184746959728d),
new NpgsqlTypes.NpgsqlBox(top: 0.08957502777582904d,right: 0.497397511995213d,bottom: 0.06966942492319128d,left: 0.3109738233767807d),
new NpgsqlTypes.NpgsqlBox(top: 0.26691328563298733d,right: 0.6685482404177314d,bottom: 0.0626413922500817d,left: 0.362783829582243d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4047652895703008d,right: 0.47868016292397886d,bottom: 0.10652772810004385d,left: 0.03509615440157787d),
new NpgsqlTypes.NpgsqlBox(top: 0.5599656653388203d,right: 0.8623588091857186d,bottom: 0.049597722086270446d,left: 0.8336299873584536d),
new NpgsqlTypes.NpgsqlBox(top: 0.19532330378255103d,right: 0.5570865855817114d,bottom: 0.16318781840966334d,left: 0.40733218301106966d),
new NpgsqlTypes.NpgsqlBox(top: 0.6124657451792517d,right: 0.5597765652545227d,bottom: 0.09226818424844707d,left: 0.46718800278952455d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4558655228915409d,right: 0.9845846251510979d,bottom: 0.3561877969585987d,left: 0.9618218918746573d),
new NpgsqlTypes.NpgsqlBox(top: 0.5253714534150399d,right: 0.6024157434578926d,bottom: 0.13376758245289022d,left: 0.48556791152301804d),
new NpgsqlTypes.NpgsqlBox(top: 0.7917879614350288d,right: 0.7424552643011032d,bottom: 0.08100165212264543d,left: 0.6644600463825175d),
new NpgsqlTypes.NpgsqlBox(top: 0.8039087668231373d,right: 0.6513983671022863d,bottom: 0.31545265845885884d,left: 0.01889412511233901d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8631718097406571d,right: 0.769591565701982d,bottom: 0.6150552221225059d,left: 0.7071494919948974d),
new NpgsqlTypes.NpgsqlBox(top: 0.9912133396823437d,right: 0.5863614855626091d,bottom: 0.8927518299755481d,left: 0.4452929732254952d),
new NpgsqlTypes.NpgsqlBox(top: 0.7382765963803147d,right: 0.3119617542161117d,bottom: 0.10838388927984677d,left: 0.07596519404259638d),
new NpgsqlTypes.NpgsqlBox(top: 0.44656826385706394d,right: 0.4403943428549726d,bottom: 0.24463909029660558d,left: 0.22863422217120677d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5267519645086115d,right: 0.8521179320776063d,bottom: 0.2074869717335759d,left: 0.5382737905882172d),
new NpgsqlTypes.NpgsqlBox(top: 0.595730220722794d,right: 0.9656629060960094d,bottom: 0.3503136191948224d,left: 0.39251291641017805d),
new NpgsqlTypes.NpgsqlBox(top: 0.8672096817594392d,right: 0.28682562184770655d,bottom: 0.4825963549174336d,left: 0.10349209898362932d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8527328145472529d,right: 0.30808299351306445d,bottom: 0.6901131290442785d,left: 0.20815822641293336d),
new NpgsqlTypes.NpgsqlBox(top: 0.7243727722170328d,right: 0.4051496953124527d,bottom: 0.018094688649519797d,left: 0.2146203711044381d),
new NpgsqlTypes.NpgsqlBox(top: 0.9955179520871764d,right: 0.2835785297031864d,bottom: 0.4297396222075546d,left: 0.21679472367572616d),
new NpgsqlTypes.NpgsqlBox(top: 0.7244069341850883d,right: 0.749181254486919d,bottom: 0.629982839351006d,left: 0.717475858730959d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7835003812372867d,right: 0.7627430651705467d,bottom: 0.09979388455029659d,left: 0.09195058194298977d),
new NpgsqlTypes.NpgsqlBox(top: 0.929493619710424d,right: 0.9947430045980532d,bottom: 0.928486822486893d,left: 0.45257060266559823d),
new NpgsqlTypes.NpgsqlBox(top: 0.821534269955737d,right: 0.5367742155118831d,bottom: 0.22042402185179222d,left: 0.23229096431019525d),
new NpgsqlTypes.NpgsqlBox(top: 0.8501668777262951d,right: 0.4861436859569763d,bottom: 0.7040261142961732d,left: 0.05607202397612632d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8937886672191468d,right: 0.8687681423240856d,bottom: 0.7492060254364272d,left: 0.08228446115336463d),
new NpgsqlTypes.NpgsqlBox(top: 0.3569405853082116d,right: 0.47718196822814285d,bottom: 0.11204421881796034d,left: 0.3683620727278226d),
new NpgsqlTypes.NpgsqlBox(top: 0.8084350483750969d,right: 0.6620020881511286d,bottom: 0.06313582656602967d,left: 0.3365465425295291d),
new NpgsqlTypes.NpgsqlBox(top: 0.8140544524819081d,right: 0.8356486037803277d,bottom: 0.6301002628696675d,left: 0.6091065947794272d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8475573480501685d,right: 0.8587196328592883d,bottom: 0.28237884880649844d,left: 0.5038422004565882d),
new NpgsqlTypes.NpgsqlBox(top: 0.5728800978958557d,right: 0.6182962498832346d,bottom: 0.09019891486980569d,left: 0.35576726242382317d),
new NpgsqlTypes.NpgsqlBox(top: 0.6279068206208158d,right: 0.6955113498884652d,bottom: 0.3478916113853818d,left: 0.6597684482750845d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.844689641526954d,right: 0.8378672270767202d,bottom: 0.35067627860860795d,left: 0.6108522475876477d),
new NpgsqlTypes.NpgsqlBox(top: 0.6349594987080437d,right: 0.5472789119918854d,bottom: 0.0014556981427853444d,left: 0.41202165032238114d),
new NpgsqlTypes.NpgsqlBox(top: 0.4322149742901109d,right: 0.5148142345680585d,bottom: 0.22527592437174848d,left: 0.03118508200202541d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6080346888369583d,right: 0.9183725395462151d,bottom: 0.02141419206373385d,left: 0.16128465406678372d),
new NpgsqlTypes.NpgsqlBox(top: 0.5350065052622713d,right: 0.21447479932400337d,bottom: 0.1172645545010721d,left: 0.010617666416772198d),
new NpgsqlTypes.NpgsqlBox(top: 0.9740030020152995d,right: 0.6213860723819883d,bottom: 0.26835688710047356d,left: 0.4064851064977879d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8838004223249795d,right: 0.4436203954017738d,bottom: 0.1467484514598848d,left: 0.189127867570286d),
new NpgsqlTypes.NpgsqlBox(top: 0.8807153746502024d,right: 0.55198822655878d,bottom: 0.04306381895877476d,left: 0.3481366108267103d),
new NpgsqlTypes.NpgsqlBox(top: 0.16596411419379153d,right: 0.8122166889461772d,bottom: 0.033171522051404945d,left: 0.8030180793687381d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9249543451471215d,right: 0.9781034308609282d,bottom: 0.14460476246293696d,left: 0.7686571806089839d),
new NpgsqlTypes.NpgsqlBox(top: 0.6742337796537105d,right: 0.40666940497516935d,bottom: 0.22076154659960623d,left: 0.11648950195715735d),
new NpgsqlTypes.NpgsqlBox(top: 0.9393236139617631d,right: 0.9546669308773992d,bottom: 0.4389696989795939d,left: 0.5151012525739381d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47506728957346767d,right: 0.5311194239631554d,bottom: 0.07780620190604859d,left: 0.038650642684975534d),
new NpgsqlTypes.NpgsqlBox(top: 0.7285549338410151d,right: 0.6722798238660143d,bottom: 0.6234578131601037d,left: 0.24060554491822383d),
new NpgsqlTypes.NpgsqlBox(top: 0.8237140872329752d,right: 0.8770549550022603d,bottom: 0.5876633065971709d,left: 0.4898648959838845d),
new NpgsqlTypes.NpgsqlBox(top: 0.7242280107289539d,right: 0.6012765211529197d,bottom: 0.2472720595004777d,left: 0.32548400537249567d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4699984458785378d,right: 0.7792791839843061d,bottom: 0.19061196649964074d,left: 0.2088223331598401d),
new NpgsqlTypes.NpgsqlBox(top: 0.6570982407883221d,right: 0.9312719018587396d,bottom: 0.3943156827581418d,left: 0.6867568782139059d),
new NpgsqlTypes.NpgsqlBox(top: 0.6603849720495001d,right: 0.8935707633040091d,bottom: 0.28967888383522855d,left: 0.7221796467569226d),
new NpgsqlTypes.NpgsqlBox(top: 0.678110082015237d,right: 0.6515964750158889d,bottom: 0.6368229805790261d,left: 0.1442500091274178d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8712248063638728d,right: 0.8086229173499073d,bottom: 0.5807277202014599d,left: 0.6044914248086513d),
new NpgsqlTypes.NpgsqlBox(top: 0.9221766772351488d,right: 0.948868524066945d,bottom: 0.5612792034298987d,left: 0.665648599389417d),
new NpgsqlTypes.NpgsqlBox(top: 0.9164729852364386d,right: 0.7649111921321505d,bottom: 0.5808879214492463d,left: 0.33012780295488287d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6871541360602854d,right: 0.999835112816353d,bottom: 0.43224599296756416d,left: 0.4427615432991402d),
new NpgsqlTypes.NpgsqlBox(top: 0.9882294852826717d,right: 0.33649277844528924d,bottom: 0.44584819902600725d,left: 0.17247704931502317d),
new NpgsqlTypes.NpgsqlBox(top: 0.9110834354193548d,right: 0.4831900490903326d,bottom: 0.019897253159283257d,left: 0.0965922849022075d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[30], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 83;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[30], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 32;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 39, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 135, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 30, query1, 5, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[30], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 99, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[30], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 46, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 102, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

