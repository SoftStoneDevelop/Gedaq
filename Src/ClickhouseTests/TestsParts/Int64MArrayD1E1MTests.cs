

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IInt64MArrayMArrayD1
    {
    }
    
    internal partial class Int64MArrayMArrayD1 : IInt64MArrayMArrayD1
    {


#region TestData

        private readonly Int64MArrayD1E1M[] _testData = new Int64MArrayD1E1M[]
        {
            new Int64MArrayD1E1M
{
    Id = 9,
    Value = 
new System.Int64[4]
{
799762638148568920L,
6232337045306259405L,
1906142241676746346L,
520703524228191151L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Int64[4]
{
7217548417440006032L,
6876906321904426167L,
5376892733921350688L,
4657146009214192723L,
},
    NullableValue = 
new System.Int64[4]
{
655242495198010938L,
1851394236447183756L,
3704250869305968810L,
3293045003589871199L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 12,
    Value = 
new System.Int64[4]
{
2779078420801014613L,
5012889729154017380L,
7719016712467947974L,
6011323462659808619L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Int64[3]
{
6409508005933607865L,
5255905050388559534L,
1408430847922829013L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int64[3]
{
1015098990728223262L,
2010196453622553548L,
879614321380747225L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Int64[4]
{
7117666788417762416L,
3428389629980147626L,
3773072523358460070L,
585115369477290656L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 25,
    Value = 
new System.Int64[4]
{
6071033156432739158L,
571527659318903232L,
4774311593187686830L,
4025172102163853173L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Int64[3]
{
2986866406573058213L,
7651001670168325276L,
7016774238756011564L,
},
    NullableValue = 
new System.Int64[4]
{
8324949875348513662L,
6739155112097913148L,
5109933287903573038L,
143627487668024641L,
},
},
    NullableValue = 
new System.Int64[4]
{
8013826811704112505L,
5834927986790887202L,
4430342914010151780L,
2958421044218820413L,
},
},
            new Int64MArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int64[4]
{
6278033743863885376L,
8209352469221908927L,
5631070942254781853L,
1120870323896508605L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Int64[3]
{
8794001005854890396L,
8688404249268537007L,
9151824112782463290L,
},
    NullableValue = 
new System.Int64[3]
{
2289781235868920291L,
6416278041909239442L,
3547171344970722299L,
},
},
    NullableValue = 
new System.Int64[4]
{
5984316958596596715L,
1409996016291203953L,
8712041482860842544L,
4515888062386431040L,
},
},
            new Int64MArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int64[4]
{
4571483991083860523L,
1183235591686787413L,
4377138983859662189L,
4565935450134041395L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Int64[3]
{
7808042089255303226L,
7000552589895787565L,
4949791103935258073L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
6693969868121041894L,
2875424407166508715L,
8688898855647049622L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Int64[4]
{
2430206169186061150L,
7553893124796450298L,
4929711808939941477L,
119441583999452488L,
},
    NullableValue = 
new System.Int64[3]
{
4722411378087097389L,
7782538492489714587L,
6398822794983536780L,
},
},
    NullableValue = 
new System.Int64[4]
{
1111891381956169977L,
8374633120157133977L,
347489521565536609L,
2073146518048605941L,
},
},
            new Int64MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int64[4]
{
5203940177006621112L,
2527226166757226532L,
4682005548568130344L,
7174832985171496258L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int64[4]
{
6375908686803020606L,
6038667229739190458L,
3759301304463401969L,
2244485813368066637L,
},
    NullableValue = 
new System.Int64[3]
{
1275520841868087667L,
7467524870113438327L,
4166623734410393949L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 52,
    Value = 
new System.Int64[3]
{
8996303012121262596L,
1099471441952025648L,
2725072614564448925L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Int64[4]
{
7834622676696641257L,
3024556201965344797L,
2971921991585491534L,
6789362063558570450L,
},
    NullableValue = 
new System.Int64[4]
{
5389681089210724640L,
5196378555910462L,
5270215080769048641L,
4327826082589890276L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int64[3]
{
1822665203791490617L,
6369626655198866717L,
2447276097207622532L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Int64[3]
{
3379738038431967204L,
9188437096503772396L,
3417456259132748923L,
},
    NullableValue = 
new System.Int64[3]
{
8968218861300915001L,
7067054130966151116L,
7242614296720041939L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 63,
    Value = 
new System.Int64[4]
{
2965624273022625428L,
587306021954581463L,
5656071971860851263L,
4684860860276453773L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
2969390054558065326L,
8403236202914006223L,
7618611179075040668L,
7253895887126144438L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5864340645216577675L,
4910962913269654250L,
3337749696509050760L,
4023724373580552421L,
},
},
            new Int64MArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int64[3]
{
6604535346845231173L,
3915529938042564999L,
7450845187233025743L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Int64[4]
{
7420375901961444878L,
902211829332765275L,
4644048690025758445L,
4727046708755841196L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7388516247973456366L,
5215463072537858912L,
7811077785146738905L,
},
},
            new Int64MArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int64[3]
{
4694936334191465570L,
1480422092501779321L,
5590432857867919715L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Int64[3]
{
8686730796731831888L,
6352247556529330676L,
2212451349010347299L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int64[4]
{
7538008033281994138L,
2169714767405033937L,
8330999148996137415L,
2036299245098795367L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Int64[3]
{
1621316083751452428L,
8723928733624561490L,
2294854538410538509L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 79,
    Value = 
new System.Int64[3]
{
3314332682352162555L,
7933206446638463980L,
5061432819456426912L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Int64[3]
{
8678881963256296553L,
1301353351373454343L,
5894190888282401112L,
},
    NullableValue = 
new System.Int64[4]
{
8750208341208533069L,
8071268227713680834L,
1327163473607057856L,
7759767724849403770L,
},
},
    NullableValue = 
new System.Int64[4]
{
3227631557925211508L,
5163362660232225252L,
1244588500036131395L,
3268566305445972831L,
},
},
            new Int64MArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int64[4]
{
2590044782999480208L,
5401899275935375637L,
5845355996389099274L,
7854574268585565553L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int64[4]
{
3635357049334499589L,
991671869915772336L,
7556071420484225946L,
2290711041833908665L,
},
    NullableValue = 
new System.Int64[3]
{
5375968884169028549L,
7101190536364154734L,
1175283621321126233L,
},
},
    NullableValue = 
new System.Int64[4]
{
6080160675067382343L,
1944141307049693134L,
4816284476309506202L,
6887812743109151364L,
},
},
            new Int64MArrayD1E1M
{
    Id = 84,
    Value = 
new System.Int64[3]
{
6683326739242685968L,
4477525427766191405L,
6665333056132965124L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int64[3]
{
2175343662434507884L,
3874024248811365171L,
7472767187724135905L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6221753372474142665L,
4539424300792775904L,
8399037722123331244L,
659155887266479563L,
},
},
            new Int64MArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int64[4]
{
872664360884717927L,
1545170939599947385L,
5305088078041992635L,
8743311258198080460L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Int64[4]
{
1076563752890445664L,
3993979158064550335L,
8593379597019220124L,
604615137719911929L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7055292793034520302L,
1826506241042206697L,
2938944067172670326L,
},
},
            new Int64MArrayD1E1M
{
    Id = 93,
    Value = 
new System.Int64[4]
{
4865502034109002187L,
8340628394881386611L,
2963533440201800194L,
4282750472594115472L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 100,
    Value = 
new System.Int64[3]
{
8140513240649405343L,
2049364217608413962L,
1121693671370959796L,
},
    NullableValue = 
new System.Int64[3]
{
7457711702711917954L,
4504296136448021375L,
4993472927234706783L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 96,
    Value = 
new System.Int64[3]
{
5746445308073568148L,
4631188465342767982L,
8100853699882996110L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Int64[3]
{
2509520276518546511L,
6230314939442636258L,
2987400858705479341L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2446089826022103363L,
7876141668451992605L,
1946710877422056766L,
9141656139968374400L,
},
},
            new Int64MArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int64[3]
{
3120753757590850344L,
6157169199085619831L,
973823332299466465L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 116,
    Value = 
new System.Int64[4]
{
7269500093958812719L,
4758474478728820468L,
8304702100517583273L,
4445122010803075379L,
},
    NullableValue = 
new System.Int64[3]
{
7397403531482328159L,
4812042564602980611L,
1313008001548113822L,
},
},
    NullableValue = 
new System.Int64[4]
{
5359817574901498618L,
5545056089005512581L,
6623619731700160173L,
872428064440114054L,
},
},
            new Int64MArrayD1E1M
{
    Id = 110,
    Value = 
new System.Int64[4]
{
6348633263058436396L,
7683232176828592908L,
5918283729388696527L,
555055939342807408L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int64[3]
{
7500486030895702306L,
8181689775540528113L,
4852583419110142729L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4580043230522271539L,
4765718824222362726L,
4785492808568126439L,
5975929678945939155L,
},
},
            new Int64MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int64[3]
{
2905453392230829738L,
5397498091885314651L,
7114881988044825721L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Int64[4]
{
2666302332647403080L,
1075104100867470119L,
9186888173631470236L,
2577551609946525026L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2397566202131197248L,
4712765930040364145L,
6644884274091766542L,
},
},
            new Int64MArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int64[3]
{
2055098620597797213L,
1958781776022896114L,
4469668347993167116L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Int64[4]
{
1411133827835641440L,
4797144883623625L,
3316970039550704528L,
3240857983372639586L,
},
    NullableValue = 
new System.Int64[4]
{
3863193614686246396L,
5398281165116025932L,
4223211802913747605L,
9055968331783443787L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 122,
    Value = 
new System.Int64[3]
{
2745056470936065849L,
9220547679904352364L,
2780753150103844236L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.Int64[4]
{
176878974827645075L,
4089708184489366513L,
1854361842069272254L,
118149861724134198L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 131,
    Value = 
new System.Int64[3]
{
56540833807782864L,
3621272212834841969L,
6704106673510334686L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Int64[4]
{
6856544747851178013L,
8074110348649119656L,
61706668283487861L,
494587066611111969L,
},
    NullableValue = 
new System.Int64[4]
{
1251059335217315931L,
6159798545079731090L,
9077836274902691127L,
627335479967220204L,
},
},
    NullableValue = 
new System.Int64[3]
{
515074389532134333L,
1862285310828967706L,
3049349079001466687L,
},
},
            new Int64MArrayD1E1M
{
    Id = 137,
    Value = 
new System.Int64[4]
{
7666766147473312448L,
1838430554665342846L,
6344819183237859948L,
5210001442786370053L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 150,
    Value = 
new System.Int64[3]
{
768831764490947618L,
7476049512860955742L,
8923543381601593470L,
},
    NullableValue = 
new System.Int64[3]
{
6651623852975743321L,
9007548617083198110L,
5461182272195244891L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 140,
    Value = 
new System.Int64[3]
{
1809269152057485193L,
5018556129413661096L,
683121041969166250L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.Int64[4]
{
7567322706941106645L,
561239336761696330L,
1209156680279613786L,
3882930891997468400L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8541561542012084718L,
6686411725400240084L,
8785140846987109351L,
8654243378799350684L,
},
},
            new Int64MArrayD1E1M
{
    Id = 143,
    Value = 
new System.Int64[4]
{
8634225512363041677L,
254107304206691075L,
4667083355096377393L,
7968804816100524741L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Int64[4]
{
7868940239442663047L,
4082920717794254142L,
6830062637770185863L,
6969808093867589988L,
},
    NullableValue = 
new System.Int64[4]
{
2120956614504001115L,
4539463467867670301L,
4492113899031144975L,
2353840714165481500L,
},
},
    NullableValue = 
new System.Int64[4]
{
1249891210856057794L,
8970947707749537076L,
6259879939778479950L,
2699893316703958093L,
},
},
            new Int64MArrayD1E1M
{
    Id = 146,
    Value = 
new System.Int64[3]
{
9144908966716588881L,
7738645583791109760L,
3637496407288263069L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Int64[4]
{
8752839320679290265L,
4296426820850899293L,
6268512584256435385L,
3261218445638114103L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7950819655287370320L,
423560598563932356L,
6350114208949718523L,
5584479381419053044L,
},
},
            new Int64MArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int64[3]
{
2892624088269982958L,
3616454569346097367L,
6035664048045781670L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 175,
    Value = 
new System.Int64[3]
{
8726996588334146886L,
89856194839654933L,
1627299718179684945L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1816280750872550454L,
1829393571384318769L,
7701117857678194716L,
2886515526057671453L,
},
},
            new Int64MArrayD1E1M
{
    Id = 159,
    Value = 
new System.Int64[4]
{
1813664893602083081L,
7199923238040906035L,
2261093715369015596L,
5232722475050620768L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 183,
    Value = 
new System.Int64[4]
{
2784340404764713943L,
843370764776748421L,
1231203089788771530L,
2465183327997422830L,
},
    NullableValue = 
new System.Int64[3]
{
3457013234178500066L,
7806544518049528184L,
6354265232031749143L,
},
},
    NullableValue = 
new System.Int64[3]
{
716969483007337125L,
5520833284628123394L,
5788773376786533437L,
},
},
            new Int64MArrayD1E1M
{
    Id = 166,
    Value = 
new System.Int64[3]
{
5990002450527494286L,
1283932286927207529L,
517112652696156176L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 189,
    Value = 
new System.Int64[3]
{
2168280063433220027L,
8086060106197575477L,
6033825667691593267L,
},
    NullableValue = 
new System.Int64[4]
{
9221733488050627047L,
4764064646650248251L,
6563783414877887123L,
8663316849267125861L,
},
},
    NullableValue = 
new System.Int64[3]
{
549404825184862023L,
4721753976410697019L,
2327073610171093459L,
},
},
            new Int64MArrayD1E1M
{
    Id = 175,
    Value = 
new System.Int64[3]
{
7369909533014176978L,
6092890973683062117L,
5883291957338571888L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 195,
    Value = 
new System.Int64[4]
{
1302197737665524318L,
2321155849529460803L,
3829031686853478788L,
2213994477883366689L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 181,
    Value = 
new System.Int64[3]
{
7423800441536432253L,
1093864708365974987L,
740377937778864184L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 204,
    Value = 
new System.Int64[4]
{
805727441793237227L,
4996881047971750070L,
899019774189845855L,
5551449727722574817L,
},
    NullableValue = 
new System.Int64[4]
{
4443930702732032315L,
5713884090908802776L,
113638676990421927L,
595212987040380031L,
},
},
    NullableValue = 
new System.Int64[3]
{
5383950690249407325L,
145120186988185549L,
7217813769678963555L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int64)}, 
    {mi_id:Int32},
    {mi_value:Array(Int64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IInt64MArrayMArrayD1)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.int64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

