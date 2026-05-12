

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
    internal partial interface IInt64MArrayMArrayD2
    {
    }
    
    internal partial class Int64MArrayMArrayD2 : IInt64MArrayMArrayD2
    {


#region TestData

        private readonly Int64MArrayD2E1M[] _testData = new Int64MArrayD2E1M[]
        {
            new Int64MArrayD2E1M
{
    Id = 5,
    Value = 
new System.Int64[,] { { 2972463521942473550L, 240762929855378903L, }, { 7756933248462237890L, 1821817664774811630L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Int64[,] { { 5599400953881425879L, 2143645453361457743L, }, { 7634878098079247728L, 6159779820881712652L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 12,
    Value = 
new System.Int64[,] { { 4665815260069160206L, 8694471255724459586L, }, { 142796365774409867L, 9054264015772910336L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Int64[,] { { 1547434744807535349L, 8510457553094916379L, }, { 7940188877584529470L, 6269785034192024838L, }, },
    NullableValue = 
new System.Int64[,] { { 3738958279020572284L, 9119991406350792503L, }, { 4559130654120562831L, 8559424380056830949L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 17,
    Value = 
new System.Int64[,] { { 9190063079153944373L, 5142582173093883299L, }, { 7266455703493566338L, 1870408242914609526L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int64[,] { { 2009961561596081289L, 3456469239547122930L, }, { 4341091960072518851L, 5343700949604043663L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int64[,] { { 5725110675587344439L, 665752596364597745L, }, { 7161338011741539983L, 1854515519850939085L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int64[,] { { 8973598518765847700L, 9077745458256733089L, }, { 6270998610426032145L, 5361763631885905637L, }, },
    NullableValue = 
new System.Int64[,] { { 1286251382976585934L, 7684316577374940280L, }, { 7312358392880066736L, 2520251214395258776L, }, },
},
    NullableValue = 
new System.Int64[,] { { 7806248670733280221L, 2509911264734799202L, }, { 5452756544287020112L, 3328538665897666294L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 24,
    Value = 
new System.Int64[,] { { 4120984137861386832L, 2318379582496015475L, }, { 8601610645580552058L, 7271588923691875307L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 20,
    Value = 
new System.Int64[,] { { 3427080545770285068L, 5453021242276188023L, }, { 2019627607547371801L, 3509467554261815666L, }, },
    NullableValue = 
new System.Int64[,] { { 5134416370025199720L, 4956573130237734715L, }, { 2279563306063544251L, 4236355139736163403L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 30,
    Value = 
new System.Int64[,] { { 6726374452423411025L, 4671895671453710869L, }, { 2708467709770736053L, 1526432473089887921L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Int64[,] { { 6299145000344299101L, 901743887981685671L, }, { 3552722461555277936L, 4570605694813520049L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 39,
    Value = 
new System.Int64[,] { { 5634797750817700796L, 5410488685714223329L, }, { 6601782909449869017L, 7896151689049590027L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Int64[,] { { 795140086896165740L, 6157492090308167570L, }, { 6501622017999715838L, 3059120342060461285L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6829023975231410434L, 6867971673194478183L, }, { 2168895550603631270L, 1907945346764245326L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int64[,] { { 3289170739468132430L, 3848079822168489192L, }, { 2087834631800033571L, 5039216274124865658L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Int64[,] { { 5406656135223853289L, 4583482637254518497L, }, { 5402758888899217869L, 2071980929920907614L, }, },
    NullableValue = 
new System.Int64[,] { { 3933786180898845259L, 8791919981975597654L, }, { 3051285421726034347L, 2239776278172794079L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 42,
    Value = 
new System.Int64[,] { { 2756509290357439499L, 3081260003709143512L, }, { 2253099223634418941L, 7191507033340769997L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int64[,] { { 2319523974057046784L, 6988784622215961163L, }, { 1225551515803509201L, 5244474422723561790L, }, },
    NullableValue = 
new System.Int64[,] { { 6988891539446056114L, 7786409014860743257L, }, { 7186109620930114849L, 5525970824759600619L, }, },
},
    NullableValue = 
new System.Int64[,] { { 1954887524001007910L, 578231149433167987L, }, { 372076698543674972L, 3570033220555490122L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 43,
    Value = 
new System.Int64[,] { { 5555462465197891942L, 3500782412504572159L, }, { 8999713318895386849L, 8392920599116737376L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Int64[,] { { 2514380056179011461L, 4573594272896260957L, }, { 372033451905641740L, 8290438289850908297L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6006039899698280352L, 4759888898113207211L, }, { 8513751010861002016L, 5040539882851193054L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 50,
    Value = 
new System.Int64[,] { { 5629829439291991040L, 4684216225345806038L, }, { 5627047211224868085L, 5895109822811148229L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int64[,] { { 183162747175232900L, 6222090392059484409L, }, { 4170240412440486019L, 8491720824937032960L, }, },
    NullableValue = 
new System.Int64[,] { { 1956108326587315804L, 6047986036642769122L, }, { 761800159103132328L, 1267409478310147804L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 58,
    Value = 
new System.Int64[,] { { 7384000758853162302L, 4717020290278185082L, }, { 170260323115340969L, 6809412357176292668L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Int64[,] { { 5364998177119998756L, 2815414048878523031L, }, { 9001083447086060323L, 7609870594324841494L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 61,
    Value = 
new System.Int64[,] { { 5211963357117388257L, 1922423122327785756L, }, { 6903051326572451261L, 2260387118078473220L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Int64[,] { { 404462485047128089L, 1499310204946630646L, }, { 3926197280460561062L, 5171480395096186547L, }, },
    NullableValue = 
new System.Int64[,] { { 6697638639350028767L, 3718833002344714623L, }, { 7845333550990537821L, 5826315750150574023L, }, },
},
    NullableValue = 
new System.Int64[,] { { 8190248585178481119L, 8124954053585571824L, }, { 876408176881710277L, 4637101059540099327L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 67,
    Value = 
new System.Int64[,] { { 8321478597454385971L, 8251715015413592771L, }, { 3484596827180659123L, 410470913472666142L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { { 4999210261130385061L, 8797164979452136606L, }, { 1966895648196480517L, 7388656211367983124L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1863599273165564969L, 6572132673351497962L, }, { 7680759139801603762L, 3497854586162999509L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 68,
    Value = 
new System.Int64[,] { { 1441911952053011653L, 4697801412261911221L, }, { 5608744864031914807L, 5271035946562754815L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int64[,] { { 1932070678692621119L, 8888442177074095047L, }, { 5699294882285390206L, 8395372012091670552L, }, },
    NullableValue = 
new System.Int64[,] { { 8126879168242959618L, 2000816156012119205L, }, { 6603365082860071749L, 8444185500804146059L, }, },
},
    NullableValue = 
new System.Int64[,] { { 8700248249465764259L, 3117811966490187585L, }, { 5558598633065560902L, 440834903478299116L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int64[,] { { 501198577090011985L, 537199345626996160L, }, { 5183115284861840161L, 5127746226717858812L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int64[,] { { 4971981593191276685L, 4627227097986605354L, }, { 7577175574834001479L, 8592879671789247135L, }, },
    NullableValue = 
new System.Int64[,] { { 4172016036100228360L, 6289164043850526186L, }, { 7895320887714439054L, 4443762369749007157L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 80,
    Value = 
new System.Int64[,] { { 3501017444788771765L, 1671533396893056622L, }, { 7226510901485742603L, 5986828961672820910L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Int64[,] { { 5186495333531571848L, 5510498415674196083L, }, { 8330198857201682077L, 1069302481233045409L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5863071832020932275L, 4057048908710712416L, }, { 1851906361740088226L, 2009086517781433114L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int64[,] { { 3412956217188016345L, 5727668913939222784L, }, { 8547962270059971769L, 8453970778276475515L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Int64[,] { { 5412098123038743426L, 171608845251587209L, }, { 7199448635424084703L, 2171858441909788051L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 91,
    Value = 
new System.Int64[,] { { 8375193738832379654L, 7527616916679107570L, }, { 291420951273397206L, 8567317400185189204L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Int64[,] { { 7820724965928496525L, 6294325782688179181L, }, { 3378009391835195253L, 7518091900389683402L, }, },
    NullableValue = 
new System.Int64[,] { { 2893749295871878353L, 8790465902489688505L, }, { 7568986169859415787L, 7483457766424783529L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2756671916579768908L, 6083644615264019931L, }, { 6142159600192921816L, 7528417824008578862L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int64[,] { { 4826372545842934656L, 3108565622772999463L, }, { 577847098645860001L, 5371320169160698325L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Int64[,] { { 2219948420541223859L, 2001066399893802400L, }, { 3144427875749151161L, 771520756207797147L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int64[,] { { 625977654442240595L, 93286583581167361L, }, { 4282026560746320414L, 7988586416282192684L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Int64[,] { { 135361103764853164L, 8542646725371262178L, }, { 4327399189295728148L, 912884930012169502L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 109,
    Value = 
new System.Int64[,] { { 4177583931148879691L, 587902619738479631L, }, { 895780042009191621L, 3777019503598263093L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Int64[,] { { 4802835262721354207L, 5661792733361831865L, }, { 7229849221179163142L, 790942992519937268L, }, },
    NullableValue = 
new System.Int64[,] { { 8801915422571452573L, 2870614782023416269L, }, { 1518452808381160083L, 7215372070007903113L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int64[,] { { 3838258699483094943L, 1889244061359630L, }, { 4596311494908735333L, 1587051728611162232L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Int64[,] { { 3167857849514859650L, 5555891699490597781L, }, { 1814321291343400265L, 6038861919280466200L, }, },
    NullableValue = 
new System.Int64[,] { { 4929993130714096931L, 2444288692647634517L, }, { 5568603481085171308L, 5774061692514595988L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int64[,] { { 8106867759549540108L, 6956687952893428658L, }, { 2138601043087698192L, 7555277877428842461L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Int64[,] { { 3391986086054996852L, 3431494496868438278L, }, { 252303747967934179L, 2742168829317377232L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 129,
    Value = 
new System.Int64[,] { { 5372110328412654748L, 8002158266126679334L, }, { 3779308165932345346L, 3356836800703557429L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Int64[,] { { 3563111757896551110L, 8582554086942460771L, }, { 6396581252893642933L, 5329674796385576262L, }, },
    NullableValue = 
new System.Int64[,] { { 3868908198349261196L, 4149496718456479441L, }, { 7988146683760720579L, 6090166665643884376L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int64[,] { { 642200028890775154L, 6330086693061881478L, }, { 8612713143877411673L, 1681522651783396087L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Int64[,] { { 3667671671235943161L, 6602492458802506127L, }, { 4857241608548060243L, 6397014947770044050L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 9121428696612088982L, 587182779496104237L, }, { 1663213711691970665L, 3158373091486535933L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 131,
    Value = 
new System.Int64[,] { { 7695003905927782191L, 1940156708266839943L, }, { 1809302987406990263L, 8078725962833807366L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 112,
    Value = 
new System.Int64[,] { { 6400183790314522031L, 5822466447890131955L, }, { 3446996645973775448L, 5734847568337557883L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 138,
    Value = 
new System.Int64[,] { { 636560535864689913L, 7021212601511965878L, }, { 8596652778391348758L, 1589846560225925267L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Int64[,] { { 4467945052979434986L, 5252748429274365862L, }, { 284524114739306259L, 2106024976081124893L, }, },
    NullableValue = 
new System.Int64[,] { { 1402362490048334380L, 4932855945083675624L, }, { 8479941693880835526L, 3147814586726811726L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4594242651552290653L, 2826403202548915356L, }, { 9058748164713248882L, 789140374527740672L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 142,
    Value = 
new System.Int64[,] { { 8116125917069476220L, 4977658656732857895L, }, { 8618709741174301086L, 5848514286335986582L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Int64[,] { { 6731501542188405387L, 5874630227719639802L, }, { 2908576260447255589L, 2086036702176633302L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 7471705001566514939L, 3245547918857048747L, }, { 4013119901568363833L, 8274302258971053503L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 143,
    Value = 
new System.Int64[,] { { 2502603047099198378L, 4839416052033134853L, }, { 6447829353511871890L, 5011312238193277681L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 131,
    Value = 
new System.Int64[,] { { 6733027319874614070L, 5879516680585113062L, }, { 3910239033858428017L, 9214201008539618834L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int64[,] { { 6281368551517149792L, 7246423269399976533L, }, { 2241518646281530373L, 8160081872486165437L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Int64[,] { { 6262322736098939587L, 5989666107967737728L, }, { 2291623115669431415L, 3115838244060538600L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2639496174672117518L, 8950678026793686138L, }, { 8450372234392436781L, 8326749714954134462L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 152,
    Value = 
new System.Int64[,] { { 8210002105958420389L, 2145174844217838923L, }, { 8756067838519430313L, 5473168151368225633L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 140,
    Value = 
new System.Int64[,] { { 5511904740444307116L, 5311554543456607241L, }, { 6053543649002483504L, 7770333713983093750L, }, },
    NullableValue = 
new System.Int64[,] { { 2207732341592846939L, 9054253820189312032L, }, { 6512419873082956220L, 3501731359839419990L, }, },
},
    NullableValue = 
new System.Int64[,] { { 8235805945223245536L, 6962717997544027575L, }, { 8830851021163561408L, 6754240499053407148L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 153,
    Value = 
new System.Int64[,] { { 1184171705540534291L, 167498975460180105L, }, { 7636659783358478882L, 5474943647681111263L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Int64[,] { { 6430682730193993890L, 922290730240098977L, }, { 4741368883109703963L, 3933257918977665781L, }, },
    NullableValue = 
new System.Int64[,] { { 2935439439930880078L, 8620435200246534502L, }, { 4846513449813432582L, 7974364492200918743L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 162,
    Value = 
new System.Int64[,] { { 2194813617077998332L, 6763201252571058702L, }, { 8296597966326370259L, 5735834118839289351L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int64[,] { { 6367486013801313893L, 9165278177759235733L, }, { 1306267070183998785L, 7455384329806852281L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 3567168872553042277L, 6134213830862801641L, }, { 616493521617497561L, 2151101450439165557L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 167,
    Value = 
new System.Int64[,] { { 1563303489736616618L, 2454800133283838469L, }, { 3407752144119961788L, 4586026052468079669L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.Int64[,] { { 3753999618472823196L, 3293909394335578883L, }, { 8365754682917127111L, 9055930807009614007L, }, },
    NullableValue = 
new System.Int64[,] { { 5967381129030111199L, 4773466032312326456L, }, { 4115047670481392419L, 6861790618728300783L, }, },
},
    NullableValue = 
new System.Int64[,] { { 5344992318004115840L, 1898852059831087339L, }, { 5493553470076559559L, 1314053541608941783L, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
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
                    await ((IInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IInt64MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.int64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
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
                    var models = await ((IInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

