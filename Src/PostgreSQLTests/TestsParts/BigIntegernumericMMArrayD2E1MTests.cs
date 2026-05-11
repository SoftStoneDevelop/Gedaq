

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
    internal partial interface IBigIntegerMArraynumericMMArrayD2
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD2 : IBigIntegerMArraynumericMMArrayD2
    {


#region TestData

        private readonly BigIntegernumericMMArrayD2E1M[] _testData = new BigIntegernumericMMArrayD2E1M[]
        {
            new BigIntegernumericMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5646450827509522547L), new System.Numerics.BigInteger(1310511518397199790L), }, { new System.Numerics.BigInteger(6676700110202583575L), new System.Numerics.BigInteger(6209353181324619956L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7891004424889299520L), new System.Numerics.BigInteger(8145175187499182028L), }, { new System.Numerics.BigInteger(5112668462739829361L), new System.Numerics.BigInteger(7621890818874023040L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8510616003772608140L), new System.Numerics.BigInteger(8921174842866732637L), }, { new System.Numerics.BigInteger(1910801931884656795L), new System.Numerics.BigInteger(2385942573521026131L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7672523593902989667L), new System.Numerics.BigInteger(2522479199806378189L), }, { new System.Numerics.BigInteger(482506135887523916L), new System.Numerics.BigInteger(2417968579210548035L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8588773485683678766L), new System.Numerics.BigInteger(9070948652604428383L), }, { new System.Numerics.BigInteger(6248255872225305789L), new System.Numerics.BigInteger(4017281796300919868L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7792303178904908513L), new System.Numerics.BigInteger(6570830847571608026L), }, { new System.Numerics.BigInteger(4639278380648417165L), new System.Numerics.BigInteger(1682389146353388560L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4054355233992429018L), new System.Numerics.BigInteger(2496303477149390471L), }, { new System.Numerics.BigInteger(1249402038295084485L), new System.Numerics.BigInteger(7410059839782685060L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4686363725568133865L), new System.Numerics.BigInteger(805821952500305998L), }, { new System.Numerics.BigInteger(676233969536986794L), new System.Numerics.BigInteger(4166181936768678245L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5559920593364055396L), new System.Numerics.BigInteger(6502432031686577935L), }, { new System.Numerics.BigInteger(2514592660100397902L), new System.Numerics.BigInteger(743490255713846022L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7327482306976666088L), new System.Numerics.BigInteger(6907567222147825143L), }, { new System.Numerics.BigInteger(6894772369839000855L), new System.Numerics.BigInteger(4331384271568303597L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8496803415136556516L), new System.Numerics.BigInteger(4632057384018380999L), }, { new System.Numerics.BigInteger(1828880741299206568L), new System.Numerics.BigInteger(5483791627269644747L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7235406975619108154L), new System.Numerics.BigInteger(2090187322971429602L), }, { new System.Numerics.BigInteger(1157969732742762813L), new System.Numerics.BigInteger(2626641278841034566L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5125208757469032097L), new System.Numerics.BigInteger(1129988240154017903L), }, { new System.Numerics.BigInteger(750270547367891357L), new System.Numerics.BigInteger(6025926556444657778L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(843447033454275741L), new System.Numerics.BigInteger(4934352178777786203L), }, { new System.Numerics.BigInteger(8760782791149236399L), new System.Numerics.BigInteger(6014526918672724623L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4226977583765595556L), new System.Numerics.BigInteger(7703851839478379575L), }, { new System.Numerics.BigInteger(5307125483371786954L), new System.Numerics.BigInteger(2064647335115561558L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7586090378642682826L), new System.Numerics.BigInteger(6895361671792762757L), }, { new System.Numerics.BigInteger(6650118689352245135L), new System.Numerics.BigInteger(4753387530066372667L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2775883937429460364L), new System.Numerics.BigInteger(186171229759341075L), }, { new System.Numerics.BigInteger(3540783444049608895L), new System.Numerics.BigInteger(2886938560264023523L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4977511534882266939L), new System.Numerics.BigInteger(4081324871945240058L), }, { new System.Numerics.BigInteger(3881612425884246304L), new System.Numerics.BigInteger(1189693850962868166L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3477355312397815923L), new System.Numerics.BigInteger(5820779021908171698L), }, { new System.Numerics.BigInteger(6266368092992380326L), new System.Numerics.BigInteger(308763529584422926L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7421540712744274145L), new System.Numerics.BigInteger(1538808216487679411L), }, { new System.Numerics.BigInteger(4706501200114629959L), new System.Numerics.BigInteger(5847013500457240622L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7917410107272563804L), new System.Numerics.BigInteger(4280465095501541519L), }, { new System.Numerics.BigInteger(7516721141964694766L), new System.Numerics.BigInteger(1941875026718057336L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7079240725356617408L), new System.Numerics.BigInteger(3894601535786535723L), }, { new System.Numerics.BigInteger(7322257806151348574L), new System.Numerics.BigInteger(4430721827938203179L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8398814556137350383L), new System.Numerics.BigInteger(8793640055012933868L), }, { new System.Numerics.BigInteger(895055881204773909L), new System.Numerics.BigInteger(8514610470016624166L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1787245879990472102L), new System.Numerics.BigInteger(3462632585095277628L), }, { new System.Numerics.BigInteger(6417904598600947132L), new System.Numerics.BigInteger(3974519176402809701L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1454956422675709059L), new System.Numerics.BigInteger(6724275418812228790L), }, { new System.Numerics.BigInteger(3435358035556204609L), new System.Numerics.BigInteger(7859134127205947398L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8972275345270020887L), new System.Numerics.BigInteger(8087801312411668238L), }, { new System.Numerics.BigInteger(5143854742118542943L), new System.Numerics.BigInteger(4201688356759116077L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7805806586097041776L), new System.Numerics.BigInteger(5687756804135714747L), }, { new System.Numerics.BigInteger(4485951504373273559L), new System.Numerics.BigInteger(1981363606191352279L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6686739339334642634L), new System.Numerics.BigInteger(1093995243090356518L), }, { new System.Numerics.BigInteger(297520580145130804L), new System.Numerics.BigInteger(4028788238726301608L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1729298387037609261L), new System.Numerics.BigInteger(6617289086681774099L), }, { new System.Numerics.BigInteger(1931217901458859793L), new System.Numerics.BigInteger(2006858991882626585L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6786316358556512369L), new System.Numerics.BigInteger(5710149089674437898L), }, { new System.Numerics.BigInteger(9024226097858318327L), new System.Numerics.BigInteger(4412693593070195422L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6475660092635756762L), new System.Numerics.BigInteger(1093253703106323583L), }, { new System.Numerics.BigInteger(7045658710455873255L), new System.Numerics.BigInteger(6347202850087323350L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8685654374347686870L), new System.Numerics.BigInteger(1549009353862831165L), }, { new System.Numerics.BigInteger(6456822611704963327L), new System.Numerics.BigInteger(7855364356176522243L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4561601188193228430L), new System.Numerics.BigInteger(2516299403128663189L), }, { new System.Numerics.BigInteger(8903186509390480951L), new System.Numerics.BigInteger(5846323144642988798L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7133096020963628591L), new System.Numerics.BigInteger(8689779891576889212L), }, { new System.Numerics.BigInteger(6299171435408087835L), new System.Numerics.BigInteger(9158413400980083917L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4910408419744427567L), new System.Numerics.BigInteger(1220339335457080479L), }, { new System.Numerics.BigInteger(4311713262076563770L), new System.Numerics.BigInteger(1204345309649083306L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2231034062061892910L), new System.Numerics.BigInteger(2813397996326070212L), }, { new System.Numerics.BigInteger(9203256716603510675L), new System.Numerics.BigInteger(3969350916235560716L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4622606509208757917L), new System.Numerics.BigInteger(1949886012680756494L), }, { new System.Numerics.BigInteger(2758433198636034786L), new System.Numerics.BigInteger(8503753052687439019L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7036857300871142382L), new System.Numerics.BigInteger(7211651092660367854L), }, { new System.Numerics.BigInteger(8230338387039981177L), new System.Numerics.BigInteger(3221332192652155905L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5440571594104126521L), new System.Numerics.BigInteger(4437412542506135798L), }, { new System.Numerics.BigInteger(6339567333165651826L), new System.Numerics.BigInteger(3696356212836418987L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(994861527426840862L), new System.Numerics.BigInteger(4650326471862670293L), }, { new System.Numerics.BigInteger(9035531095017534565L), new System.Numerics.BigInteger(3019100936011631864L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(751415684949021531L), new System.Numerics.BigInteger(1878183649826266985L), }, { new System.Numerics.BigInteger(150943041540352922L), new System.Numerics.BigInteger(8069590952335632226L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2629927256195176879L), new System.Numerics.BigInteger(8859192296759056038L), }, { new System.Numerics.BigInteger(8134262421114489812L), new System.Numerics.BigInteger(5102770587428166175L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(96900643466197031L), new System.Numerics.BigInteger(7452781672141632787L), }, { new System.Numerics.BigInteger(4524345442187947800L), new System.Numerics.BigInteger(3628183660356645286L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6802698614005029152L), new System.Numerics.BigInteger(5204333267570781468L), }, { new System.Numerics.BigInteger(6991725743856128272L), new System.Numerics.BigInteger(2924998641044226513L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1026855221357687218L), new System.Numerics.BigInteger(3675307013224609288L), }, { new System.Numerics.BigInteger(7190236625219244915L), new System.Numerics.BigInteger(8272331959773576978L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3559255872554143588L), new System.Numerics.BigInteger(8610782267863006375L), }, { new System.Numerics.BigInteger(1236646345478520847L), new System.Numerics.BigInteger(3766670410905635720L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1360382982024522950L), new System.Numerics.BigInteger(7439997170027305865L), }, { new System.Numerics.BigInteger(4334193888250011822L), new System.Numerics.BigInteger(346527542112158387L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5898086946810824847L), new System.Numerics.BigInteger(6990478983953284895L), }, { new System.Numerics.BigInteger(3250757263975706952L), new System.Numerics.BigInteger(8359065876956919141L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(804573934911323842L), new System.Numerics.BigInteger(710044046772833639L), }, { new System.Numerics.BigInteger(4187303177078109407L), new System.Numerics.BigInteger(3565163771139245582L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3619272522713312584L), new System.Numerics.BigInteger(1706156465936950227L), }, { new System.Numerics.BigInteger(2983377426230087148L), new System.Numerics.BigInteger(9217384456807917275L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6906589425660304400L), new System.Numerics.BigInteger(5531096321831525379L), }, { new System.Numerics.BigInteger(741004149422495522L), new System.Numerics.BigInteger(3855538870283133433L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4272467860037600025L), new System.Numerics.BigInteger(4269280302527788371L), }, { new System.Numerics.BigInteger(4688757739340405062L), new System.Numerics.BigInteger(2080609370980125826L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2218242820120659567L), new System.Numerics.BigInteger(1679379926802417056L), }, { new System.Numerics.BigInteger(8619539844275305433L), new System.Numerics.BigInteger(7312024373175586555L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1615182425731445690L), new System.Numerics.BigInteger(5165628891699224162L), }, { new System.Numerics.BigInteger(8871142040114350742L), new System.Numerics.BigInteger(3153416289479833595L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5359877224268950414L), new System.Numerics.BigInteger(6188920366530984298L), }, { new System.Numerics.BigInteger(3278400284113763649L), new System.Numerics.BigInteger(4115075409668818637L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5732270764664692989L), new System.Numerics.BigInteger(5830071579663499274L), }, { new System.Numerics.BigInteger(1739352490521939424L), new System.Numerics.BigInteger(5439216856219668874L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1551882262657969740L), new System.Numerics.BigInteger(5473108326212801126L), }, { new System.Numerics.BigInteger(4564464376422759244L), new System.Numerics.BigInteger(7862421700323406187L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2236176179565710647L), new System.Numerics.BigInteger(2752561447155933724L), }, { new System.Numerics.BigInteger(3138538415564182234L), new System.Numerics.BigInteger(8749156979132173032L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8893755613684442195L), new System.Numerics.BigInteger(635608557281661764L), }, { new System.Numerics.BigInteger(3320123625639159444L), new System.Numerics.BigInteger(7673898420444750449L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1100412749344999109L), new System.Numerics.BigInteger(8111647631774183191L), }, { new System.Numerics.BigInteger(8620062406879085558L), new System.Numerics.BigInteger(2673393127332825666L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4142603791061790916L), new System.Numerics.BigInteger(4788085363041844740L), }, { new System.Numerics.BigInteger(5053346335267863631L), new System.Numerics.BigInteger(4468839708371569230L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1432288590877493551L), new System.Numerics.BigInteger(4441350081646246037L), }, { new System.Numerics.BigInteger(9147082719069461087L), new System.Numerics.BigInteger(4896144302048845150L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(667599501751060862L), new System.Numerics.BigInteger(4153509118235930090L), }, { new System.Numerics.BigInteger(2722158735604463474L), new System.Numerics.BigInteger(768847782471959286L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2751716313483543004L), new System.Numerics.BigInteger(4737809426346581368L), }, { new System.Numerics.BigInteger(2511725202304231770L), new System.Numerics.BigInteger(6226226298344647473L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(310259112856063161L), new System.Numerics.BigInteger(8470592786803688134L), }, { new System.Numerics.BigInteger(2624217406081108961L), new System.Numerics.BigInteger(4155480794845351333L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(420680374355750007L), new System.Numerics.BigInteger(960316778169849998L), }, { new System.Numerics.BigInteger(684452925401816787L), new System.Numerics.BigInteger(5746100747406786393L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8501498285177759423L), new System.Numerics.BigInteger(384877501747386037L), }, { new System.Numerics.BigInteger(484451515316471245L), new System.Numerics.BigInteger(6718924495532454199L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(311950002432286034L), new System.Numerics.BigInteger(6671949069053087519L), }, { new System.Numerics.BigInteger(8505183467607420764L), new System.Numerics.BigInteger(8654305853474094175L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6246815532446627344L), new System.Numerics.BigInteger(2602420575769841859L), }, { new System.Numerics.BigInteger(6271036652788830213L), new System.Numerics.BigInteger(7977211734183694007L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9053662052147001959L), new System.Numerics.BigInteger(5702462261486469061L), }, { new System.Numerics.BigInteger(5925436078372570005L), new System.Numerics.BigInteger(3464014759151228103L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2114496669352098137L), new System.Numerics.BigInteger(6486326327077531262L), }, { new System.Numerics.BigInteger(6539984831591862316L), new System.Numerics.BigInteger(2435411567375391299L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1270218926198081172L), new System.Numerics.BigInteger(660272646417607654L), }, { new System.Numerics.BigInteger(3968085069204778850L), new System.Numerics.BigInteger(1152928300254754520L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2273725199043701024L), new System.Numerics.BigInteger(651381544279156171L), }, { new System.Numerics.BigInteger(3814280831958578236L), new System.Numerics.BigInteger(5181797611220174087L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4245027720259714047L), new System.Numerics.BigInteger(6368001521218017895L), }, { new System.Numerics.BigInteger(2228911309535945413L), new System.Numerics.BigInteger(2066628577782536440L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1621862527395514770L), new System.Numerics.BigInteger(1034607058120523285L), }, { new System.Numerics.BigInteger(5602509227110551563L), new System.Numerics.BigInteger(3442186248373778462L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3466813364255458942L), new System.Numerics.BigInteger(4059822561123157657L), }, { new System.Numerics.BigInteger(9060554043194707559L), new System.Numerics.BigInteger(1626801015125029304L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 182,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2288376899638929190L), new System.Numerics.BigInteger(9200392921167386675L), }, { new System.Numerics.BigInteger(2519119482768311875L), new System.Numerics.BigInteger(5829281153069988516L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6229638701096714067L), new System.Numerics.BigInteger(5315384220756775401L), }, { new System.Numerics.BigInteger(6761036672689247593L), new System.Numerics.BigInteger(3805506674055468026L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2290302825521087579L), new System.Numerics.BigInteger(1509490250189878894L), }, { new System.Numerics.BigInteger(5235176697368789529L), new System.Numerics.BigInteger(4690892809457240753L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(713952670248571086L), new System.Numerics.BigInteger(7872002888510017270L), }, { new System.Numerics.BigInteger(3820336479960993067L), new System.Numerics.BigInteger(3661560947934028648L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 188,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4112438274735714870L), new System.Numerics.BigInteger(2578207286480669220L), }, { new System.Numerics.BigInteger(7694693285341560604L), new System.Numerics.BigInteger(5404743033088218624L), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 150;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 144;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 111;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 140, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 23, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 160, query1, 166, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 173, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 130, 150))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 102, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 23);
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
FROM public.binary_bigintegernumericmmarrayd2e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI), typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

