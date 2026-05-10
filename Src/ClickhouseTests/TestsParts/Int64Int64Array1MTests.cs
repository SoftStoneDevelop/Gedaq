

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
    internal partial interface IInt64ArrayInt64Array
    {
    }
    
    internal partial class Int64ArrayInt64Array : IInt64ArrayInt64Array
    {


#region TestData

        private readonly Int64Int64Array1M[] _testData = new Int64Int64Array1M[]
        {
            new Int64Int64Array1M
{
    Id = 7,
    Value = 
new System.Int64[4]
{
950416742455312949L,
8432944993398256850L,
8507981345079358403L,
4454289515990943843L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 4,
    Value = 
new System.Int64[4]
{
8123125648927759798L,
3800575257381849417L,
6300814905710100005L,
8643705845512126678L,
},
    NullableValue = 
new System.Int64[4]
{
6612852548129865241L,
7948086554802937601L,
3816199365673161932L,
8009906199958672175L,
},
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 15,
    Value = 
new System.Int64[3]
{
2516269199807579559L,
5407595739130388340L,
4836534117961861613L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 8,
    Value = 
new System.Int64[3]
{
2241980285576950301L,
1895663343349840657L,
961122987046604264L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 20,
    Value = 
new System.Int64[4]
{
4094782633794656253L,
7368454043642738571L,
5607951404789495755L,
509777083487386997L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 15,
    Value = 
new System.Int64[4]
{
8436537211397000446L,
120655216694061114L,
2984916932116079785L,
3299692533832482330L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8214755170760621812L,
8428174506573926244L,
6003270333328500800L,
3345998628822144252L,
},
},
            new Int64Int64Array1M
{
    Id = 21,
    Value = 
new System.Int64[3]
{
6156150944761331802L,
2157505030622694398L,
3997903557780603318L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 22,
    Value = 
new System.Int64[4]
{
852786400608894265L,
6255771263212625145L,
2681911280432578641L,
2825289744039203327L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3434051616798039247L,
6930244259378366487L,
6139703849891271718L,
428912897139465374L,
},
},
            new Int64Int64Array1M
{
    Id = 28,
    Value = 
new System.Int64[4]
{
8244218376623257733L,
7447980305676358019L,
2912919641334945901L,
1542559160489161893L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 30,
    Value = 
new System.Int64[4]
{
5378560020843529445L,
2617637917370386622L,
4067382229433433566L,
2116911117490397438L,
},
    NullableValue = 
new System.Int64[4]
{
4945561967130509157L,
8940350288577784914L,
1689640794880663540L,
5562220778790213796L,
},
},
    NullableValue = 
new System.Int64[4]
{
5126931779139907302L,
4967468211263446483L,
5353359672114885313L,
6419684513368004945L,
},
},
            new Int64Int64Array1M
{
    Id = 37,
    Value = 
new System.Int64[3]
{
6100097082679895145L,
5748846511327747212L,
7754381438227500885L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 34,
    Value = 
new System.Int64[4]
{
7814342157084672914L,
8891463075750474578L,
6216859999191140971L,
1367966905142940072L,
},
    NullableValue = 
new System.Int64[3]
{
6951995098762947287L,
1635971092210610913L,
9208021508759237766L,
},
},
    NullableValue = 
new System.Int64[4]
{
673250417149931557L,
1001661670100792314L,
277540726150305276L,
562309255700423272L,
},
},
            new Int64Int64Array1M
{
    Id = 40,
    Value = 
new System.Int64[4]
{
5963214123363064755L,
4412544874063096753L,
1673763228982125995L,
2323945874476752279L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 37,
    Value = 
new System.Int64[4]
{
8608006694319462535L,
153366715230360998L,
1951812523666169367L,
4586807308609404803L,
},
    NullableValue = 
new System.Int64[4]
{
8451153912616385658L,
5600886196561263016L,
2645561083178505325L,
462360696450439429L,
},
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 49,
    Value = 
new System.Int64[3]
{
6705486619668418241L,
2484151134476959559L,
7492581707751703904L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 43,
    Value = 
new System.Int64[3]
{
3178937131945994708L,
8296809794025018831L,
7945726665074663090L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8987170258528109553L,
2155945521703650694L,
837678174419379996L,
9126554498466448515L,
},
},
            new Int64Int64Array1M
{
    Id = 52,
    Value = 
new System.Int64[3]
{
1915672970759383120L,
3965632706763873850L,
257187341115193522L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 52,
    Value = 
new System.Int64[3]
{
4769811446121045340L,
8959224043003011279L,
5371513031269753827L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 59,
    Value = 
new System.Int64[4]
{
3404651558297133005L,
2268972304447392640L,
1132449595638641105L,
4228976895065117457L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 59,
    Value = 
new System.Int64[4]
{
6713211745839371700L,
8970803339208289156L,
2448044139133061883L,
7922023069095508163L,
},
    NullableValue = 
new System.Int64[4]
{
5872219769680760066L,
196918804585190836L,
2534783130061606874L,
9111069308660077077L,
},
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 63,
    Value = 
new System.Int64[4]
{
5841663192785999915L,
3209088436656458433L,
3452663318003691048L,
6200537622447695602L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 64,
    Value = 
new System.Int64[3]
{
1472225181510498671L,
2656268487096203567L,
7772479638899751918L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 66,
    Value = 
new System.Int64[3]
{
3713412786115166669L,
8951302927695413896L,
4162382547559980519L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 71,
    Value = 
new System.Int64[3]
{
2381807312257199849L,
276031141863449061L,
1214704294586009071L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 70,
    Value = 
new System.Int64[4]
{
1448021856144753521L,
6294220687660555654L,
7869874608940722486L,
8401260036673827458L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 79,
    Value = 
new System.Int64[3]
{
2368034374392559328L,
1552254387863956226L,
1539732172631475311L,
},
    NullableValue = 
new System.Int64[3]
{
2366299131085736839L,
4258603299081965127L,
4560440766046894734L,
},
},
    NullableValue = 
new System.Int64[3]
{
6667552211703537175L,
7455490696215769829L,
264015771114516915L,
},
},
            new Int64Int64Array1M
{
    Id = 79,
    Value = 
new System.Int64[4]
{
3900635170373860435L,
9062311618329090058L,
6385820184696031806L,
8412476764480715845L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 86,
    Value = 
new System.Int64[4]
{
5445980836552392336L,
8714258133453735508L,
6682548627593103876L,
1500254366467045490L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5356052467020726170L,
8047720780080257091L,
1752631856942896139L,
},
},
            new Int64Int64Array1M
{
    Id = 81,
    Value = 
new System.Int64[4]
{
401114745768137442L,
3898443220143956634L,
3532881481235059748L,
1989385430291076407L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 95,
    Value = 
new System.Int64[3]
{
7225381647478715117L,
8215823788215209908L,
968214758580300597L,
},
    NullableValue = 
new System.Int64[3]
{
8050041569988772936L,
1414695280892950331L,
1608593162287290118L,
},
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 84,
    Value = 
new System.Int64[3]
{
7408612306385982841L,
4091226607127228365L,
1641746048338018616L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 104,
    Value = 
new System.Int64[4]
{
5169012220095129600L,
5216643333611565817L,
3479258764825217426L,
1876330461627332882L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 90,
    Value = 
new System.Int64[4]
{
1006083036554879087L,
2985375058515224676L,
2837949876131681451L,
4228425510781049284L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 107,
    Value = 
new System.Int64[4]
{
6309532481546971791L,
2256151212413485803L,
3117123416346494701L,
214465446014180306L,
},
    NullableValue = 
new System.Int64[3]
{
9136151722891673857L,
1766414242439870562L,
722320376288100676L,
},
},
    NullableValue = 
new System.Int64[4]
{
4905792309642448001L,
6385195143634895348L,
3587331867135190248L,
2719126484774656008L,
},
},
            new Int64Int64Array1M
{
    Id = 98,
    Value = 
new System.Int64[3]
{
5285476254400966903L,
2135450918783714337L,
4043079226979356344L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 108,
    Value = 
new System.Int64[4]
{
2389515073447374947L,
4422868008388379589L,
8575633062036934334L,
8485962508346342117L,
},
    NullableValue = 
new System.Int64[4]
{
6762925435103441468L,
7042571727032246634L,
4012856317929822969L,
5002139217596388751L,
},
},
    NullableValue = 
new System.Int64[3]
{
3461835848730552144L,
5973945040212553224L,
2859408008529215394L,
},
},
            new Int64Int64Array1M
{
    Id = 107,
    Value = 
new System.Int64[3]
{
797933404701152924L,
2284607898895262651L,
139721049615226294L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 111,
    Value = 
new System.Int64[3]
{
9012883322193147338L,
9150959582483172777L,
151007995311225L,
},
    NullableValue = 
new System.Int64[3]
{
8945870783483126704L,
646494344091782417L,
7226009958311021781L,
},
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 112,
    Value = 
new System.Int64[4]
{
4948429839948174852L,
8585871006197718704L,
6161247108231362585L,
4030570037134255220L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 117,
    Value = 
new System.Int64[3]
{
5983424284793969035L,
1718559563941867063L,
4144076226667246150L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4627394084836588105L,
5570937066826315077L,
3787625939258989155L,
},
},
            new Int64Int64Array1M
{
    Id = 121,
    Value = 
new System.Int64[4]
{
140387623508549823L,
5088900426997417788L,
630550553598538097L,
5360588082382029239L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 126,
    Value = 
new System.Int64[4]
{
414910674847593882L,
6802601442980772289L,
8526060952375514759L,
5994582397800519074L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 130,
    Value = 
new System.Int64[4]
{
5444741149682796504L,
4761174321803065691L,
6097680847792688322L,
2203121191690362045L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 128,
    Value = 
new System.Int64[3]
{
3008245987001501168L,
1580584824470732931L,
7350739821282606602L,
},
    NullableValue = 
new System.Int64[3]
{
4482064487064489548L,
3748236029023120102L,
2940860794427316269L,
},
},
    NullableValue = 
new System.Int64[4]
{
3574166761411792450L,
275929058284293356L,
4456096826710871690L,
5182476358158946969L,
},
},
            new Int64Int64Array1M
{
    Id = 137,
    Value = 
new System.Int64[3]
{
7859245418083450236L,
1286118953491679136L,
403577090318731851L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 131,
    Value = 
new System.Int64[4]
{
7342993848384609605L,
6525137332857147681L,
8186463487103841147L,
1395191860368612934L,
},
    NullableValue = 
new System.Int64[3]
{
236419472700907219L,
6000853890255228472L,
5148511191298818809L,
},
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 146,
    Value = 
new System.Int64[4]
{
8697488777058868439L,
7755115801421925290L,
6209864515650914351L,
461172506928374360L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 132,
    Value = 
new System.Int64[3]
{
7408225526074726812L,
6337050327598573201L,
3314467027618100533L,
},
    NullableValue = 
new System.Int64[3]
{
7763683460619342275L,
9027011359439317196L,
573696642767599632L,
},
},
    NullableValue = 
new System.Int64[4]
{
7878295062680090546L,
3244884529043303279L,
3473231972290427659L,
3645987827287198016L,
},
},
            new Int64Int64Array1M
{
    Id = 148,
    Value = 
new System.Int64[3]
{
6410428179233071959L,
2748796520505085109L,
5223187486903632104L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 137,
    Value = 
new System.Int64[3]
{
5693055686191903092L,
7173267901799900390L,
8706704082614132025L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 152,
    Value = 
new System.Int64[3]
{
2302601654511986417L,
8552412925999708839L,
6837718789128178666L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 146,
    Value = 
new System.Int64[3]
{
1891792817369872004L,
4272046738569435083L,
323860384232453510L,
},
    NullableValue = 
new System.Int64[3]
{
6866535442201326605L,
5485108239513801194L,
5937210313713594833L,
},
},
    NullableValue = 
new System.Int64[4]
{
6327741081027265396L,
4352921591151646922L,
7004254455522719624L,
3663054507742787019L,
},
},
            new Int64Int64Array1M
{
    Id = 154,
    Value = 
new System.Int64[4]
{
7682790410898735230L,
7226446601466293562L,
991886531418196976L,
7650453181881011733L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 155,
    Value = 
new System.Int64[3]
{
2282572590021445575L,
4710563926977149073L,
436692505118361997L,
},
    NullableValue = 
new System.Int64[4]
{
5658275427571876213L,
4097257277053670753L,
5236936967454555500L,
3069063129625132265L,
},
},
    NullableValue = 
new System.Int64[3]
{
7283389826311152464L,
8614563595694723013L,
1816579835655966757L,
},
},
            new Int64Int64Array1M
{
    Id = 155,
    Value = 
new System.Int64[3]
{
1635758153595806047L,
4739401879007270415L,
4385800766931304684L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 162,
    Value = 
new System.Int64[4]
{
7847545507393952951L,
6162012475390748647L,
7068760866217433932L,
260468539171949241L,
},
    NullableValue = 
new System.Int64[4]
{
5494416693940151524L,
424627067407263163L,
5061122722889484935L,
7208008353540628180L,
},
},
    NullableValue = 
new System.Int64[3]
{
7586934123486088102L,
3786910040414642202L,
3088033373394363261L,
},
},
            new Int64Int64Array1M
{
    Id = 159,
    Value = 
new System.Int64[3]
{
1628986686564873514L,
7669663527132685742L,
3179466274579522770L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 168,
    Value = 
new System.Int64[3]
{
8985577500531292587L,
2783870521087578393L,
6088545434186622686L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
6603792409869031712L,
2282978626041574611L,
6601511593872440353L,
},
},
            new Int64Int64Array1M
{
    Id = 160,
    Value = 
new System.Int64[3]
{
2260421882737741840L,
3563365354253701533L,
8478443889845911144L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 170,
    Value = 
new System.Int64[3]
{
4215014005317829679L,
8904320267881826811L,
4112443130407812493L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 168,
    Value = 
new System.Int64[3]
{
7535786224055479101L,
4210853182137681330L,
1893831813506098302L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 175,
    Value = 
new System.Int64[4]
{
7348701423544665617L,
7633377945157140274L,
8784134634482108259L,
2662876594891412548L,
},
    NullableValue = 
new System.Int64[4]
{
6341318019090552841L,
8025922979069057303L,
9026488893754417756L,
8314549710654093143L,
},
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 175,
    Value = 
new System.Int64[4]
{
5382066686071492919L,
725718502249593745L,
607228422583673073L,
6885102268685570798L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 182,
    Value = 
new System.Int64[3]
{
8563539945218654806L,
1094885249523181199L,
2513985342008381531L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 176,
    Value = 
new System.Int64[3]
{
6909920844066497613L,
7921827620357360671L,
7152961224158232393L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 186,
    Value = 
new System.Int64[3]
{
5676517208875476774L,
9128710370153593377L,
6232565905426524733L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1953760797828024614L,
9128399996453330876L,
4979147491851369358L,
},
},
            new Int64Int64Array1M
{
    Id = 183,
    Value = 
new System.Int64[4]
{
3711126276775896191L,
3115918202871108637L,
3111004523915382330L,
3123414508513722264L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 193,
    Value = 
new System.Int64[4]
{
5779108834015243172L,
1790185132473331723L,
5572437433181965563L,
8696007402723836646L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64Array1M
{
    Id = 187,
    Value = 
new System.Int64[3]
{
733744077647959214L,
7571542829891429513L,
5884174609319687632L,
},
    ModelInner = new Int64Int64Array1MI
{
    Id = 198,
    Value = 
new System.Int64[3]
{
1622517048626500510L,
7808425864118091290L,
8453604654423093045L,
},
    NullableValue = 
new System.Int64[3]
{
153603149521506083L,
119680991486979742L,
6420894894269318341L,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64int64array1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int64[]}, 
    {mi_id:Int32},
    {mi_value:Int64[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArrayInt64Array)),
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
                    await ((IInt64ArrayInt64Array)this).InsertModelDbConnectionAsync(
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
                     ((IInt64ArrayInt64Array)this).InsertModelDbConnection(
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
FROM gedaqtests.int64int64array1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64Int64Array1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArrayInt64Array)),
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
                    var models = await ((IInt64ArrayInt64Array)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64Int64Array1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64ArrayInt64Array)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64Int64Array1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

