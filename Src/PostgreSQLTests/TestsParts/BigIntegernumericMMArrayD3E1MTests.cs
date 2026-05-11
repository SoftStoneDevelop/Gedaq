

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
    internal partial interface IBigIntegerMArraynumericMMArrayD3
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD3 : IBigIntegerMArraynumericMMArrayD3
    {


#region TestData

        private readonly BigIntegernumericMMArrayD3E1M[] _testData = new BigIntegernumericMMArrayD3E1M[]
        {
            new BigIntegernumericMMArrayD3E1M
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2909582589285835640L), new System.Numerics.BigInteger(470476571142584185L), new System.Numerics.BigInteger(8943532274421847457L), }, { new System.Numerics.BigInteger(6776014331325413088L), new System.Numerics.BigInteger(3574557102732865594L), new System.Numerics.BigInteger(97474839057284039L), }, { new System.Numerics.BigInteger(3753177256324884042L), new System.Numerics.BigInteger(5907620894706479101L), new System.Numerics.BigInteger(6734496408834033045L), }, }, { { new System.Numerics.BigInteger(7560905352305982847L), new System.Numerics.BigInteger(3421291045580133684L), new System.Numerics.BigInteger(1259215605114304245L), }, { new System.Numerics.BigInteger(6403997751857306259L), new System.Numerics.BigInteger(2865782948926128602L), new System.Numerics.BigInteger(603308996911072554L), }, { new System.Numerics.BigInteger(302509471887648826L), new System.Numerics.BigInteger(918571156319749374L), new System.Numerics.BigInteger(6958759292341723600L), }, }, { { new System.Numerics.BigInteger(2644714175769097720L), new System.Numerics.BigInteger(4798062942178372411L), new System.Numerics.BigInteger(6339809441232923032L), }, { new System.Numerics.BigInteger(1719999891278811220L), new System.Numerics.BigInteger(3164961841308306575L), new System.Numerics.BigInteger(1164818406253736562L), }, { new System.Numerics.BigInteger(3164613767291116079L), new System.Numerics.BigInteger(8278111081633939852L), new System.Numerics.BigInteger(707637555661463112L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6222796543066265105L), new System.Numerics.BigInteger(7427843741168026435L), new System.Numerics.BigInteger(4571665571329773261L), }, { new System.Numerics.BigInteger(5639351888313994893L), new System.Numerics.BigInteger(4833980986732268808L), new System.Numerics.BigInteger(715114862007333967L), }, { new System.Numerics.BigInteger(576777886958467378L), new System.Numerics.BigInteger(3549859452657619029L), new System.Numerics.BigInteger(783623270295600618L), }, }, { { new System.Numerics.BigInteger(3455941160124731333L), new System.Numerics.BigInteger(927717800882405216L), new System.Numerics.BigInteger(2597718567917239986L), }, { new System.Numerics.BigInteger(295774458722968772L), new System.Numerics.BigInteger(5885046370534628556L), new System.Numerics.BigInteger(1344134847399150414L), }, { new System.Numerics.BigInteger(1713189386984024952L), new System.Numerics.BigInteger(3185441900608070430L), new System.Numerics.BigInteger(4791908373056405045L), }, }, { { new System.Numerics.BigInteger(5068804889663241156L), new System.Numerics.BigInteger(8688057347231916876L), new System.Numerics.BigInteger(213439177204544959L), }, { new System.Numerics.BigInteger(7748528079071104499L), new System.Numerics.BigInteger(2449956746820507696L), new System.Numerics.BigInteger(9104185546959727448L), }, { new System.Numerics.BigInteger(3801198007053054895L), new System.Numerics.BigInteger(4023112002265411343L), new System.Numerics.BigInteger(6240861556903768919L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6712259726913307405L), new System.Numerics.BigInteger(6495739241074240312L), new System.Numerics.BigInteger(161384587233233795L), }, { new System.Numerics.BigInteger(7524043327301882981L), new System.Numerics.BigInteger(8336313265472525407L), new System.Numerics.BigInteger(7736852298071580580L), }, { new System.Numerics.BigInteger(4081621533324550285L), new System.Numerics.BigInteger(4296718085828432412L), new System.Numerics.BigInteger(3235088379968771007L), }, }, { { new System.Numerics.BigInteger(5084578784838697127L), new System.Numerics.BigInteger(7116802253715545357L), new System.Numerics.BigInteger(1077943396836534423L), }, { new System.Numerics.BigInteger(9181969133796613340L), new System.Numerics.BigInteger(6522797457604019863L), new System.Numerics.BigInteger(8311672429310620741L), }, { new System.Numerics.BigInteger(3464634786990314557L), new System.Numerics.BigInteger(2527786722502524686L), new System.Numerics.BigInteger(3814261698589187439L), }, }, { { new System.Numerics.BigInteger(3445150680156451464L), new System.Numerics.BigInteger(909634658127041615L), new System.Numerics.BigInteger(5515331254001395528L), }, { new System.Numerics.BigInteger(8721217438280443763L), new System.Numerics.BigInteger(1576634724167149001L), new System.Numerics.BigInteger(5313143391665205386L), }, { new System.Numerics.BigInteger(1448997425035223559L), new System.Numerics.BigInteger(3089696820695353301L), new System.Numerics.BigInteger(9102323726786913863L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6579110022211703671L), new System.Numerics.BigInteger(459673891155892060L), new System.Numerics.BigInteger(1754983289707229910L), }, { new System.Numerics.BigInteger(6273083864021640340L), new System.Numerics.BigInteger(12942927947808731L), new System.Numerics.BigInteger(1167354943103869734L), }, { new System.Numerics.BigInteger(7917635339811573707L), new System.Numerics.BigInteger(8070707445175765876L), new System.Numerics.BigInteger(7914013875103305400L), }, }, { { new System.Numerics.BigInteger(3803478469510742520L), new System.Numerics.BigInteger(8208626551671339175L), new System.Numerics.BigInteger(4778403747921600107L), }, { new System.Numerics.BigInteger(7470266597953895768L), new System.Numerics.BigInteger(2973472536313584958L), new System.Numerics.BigInteger(3446636020510416691L), }, { new System.Numerics.BigInteger(1296616192684290827L), new System.Numerics.BigInteger(7840078463271145528L), new System.Numerics.BigInteger(3292713306269015438L), }, }, { { new System.Numerics.BigInteger(4042535921015675678L), new System.Numerics.BigInteger(1030791607177758149L), new System.Numerics.BigInteger(3727122811602354666L), }, { new System.Numerics.BigInteger(1963733350211032637L), new System.Numerics.BigInteger(8699023520514513154L), new System.Numerics.BigInteger(5960766924505618657L), }, { new System.Numerics.BigInteger(5200158588948834916L), new System.Numerics.BigInteger(177662824442682096L), new System.Numerics.BigInteger(525809343529999247L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(7763718598996071699L), new System.Numerics.BigInteger(610443359650647003L), new System.Numerics.BigInteger(3350676606460722835L), }, { new System.Numerics.BigInteger(7862299012728135351L), new System.Numerics.BigInteger(7409140125388677554L), new System.Numerics.BigInteger(9093809690193858877L), }, { new System.Numerics.BigInteger(2341186877103459557L), new System.Numerics.BigInteger(2160567946339942015L), new System.Numerics.BigInteger(4268634999134703728L), }, }, { { new System.Numerics.BigInteger(8243927575975428883L), new System.Numerics.BigInteger(265058811987842423L), new System.Numerics.BigInteger(3079871521595053471L), }, { new System.Numerics.BigInteger(2863022869299211700L), new System.Numerics.BigInteger(5597271094317126316L), new System.Numerics.BigInteger(8570763517813891344L), }, { new System.Numerics.BigInteger(4275821092188704850L), new System.Numerics.BigInteger(1564371459811219020L), new System.Numerics.BigInteger(5122568928597521147L), }, }, { { new System.Numerics.BigInteger(5367650969135892595L), new System.Numerics.BigInteger(6463037488462696479L), new System.Numerics.BigInteger(8584946930257638417L), }, { new System.Numerics.BigInteger(1728373537963467508L), new System.Numerics.BigInteger(5579798997526977645L), new System.Numerics.BigInteger(6955739010749101472L), }, { new System.Numerics.BigInteger(758416833596929618L), new System.Numerics.BigInteger(2419402322432819863L), new System.Numerics.BigInteger(6990329405409434476L), }, }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1298634425727751847L), new System.Numerics.BigInteger(7040695165583943657L), new System.Numerics.BigInteger(4916350162008027788L), }, { new System.Numerics.BigInteger(1012373338553314936L), new System.Numerics.BigInteger(229205188560796449L), new System.Numerics.BigInteger(462286486660951318L), }, { new System.Numerics.BigInteger(1406577182407329925L), new System.Numerics.BigInteger(2095579269851676078L), new System.Numerics.BigInteger(8295429571390180739L), }, }, { { new System.Numerics.BigInteger(434343851676532021L), new System.Numerics.BigInteger(7722124750948370957L), new System.Numerics.BigInteger(7262387856163183469L), }, { new System.Numerics.BigInteger(383568461438226276L), new System.Numerics.BigInteger(3602152602681216184L), new System.Numerics.BigInteger(3633645180552262687L), }, { new System.Numerics.BigInteger(2307727553435429123L), new System.Numerics.BigInteger(4505352659761390912L), new System.Numerics.BigInteger(1504876675890632237L), }, }, { { new System.Numerics.BigInteger(4832498322235271052L), new System.Numerics.BigInteger(425734343395568073L), new System.Numerics.BigInteger(3570212963930536511L), }, { new System.Numerics.BigInteger(731329408824264057L), new System.Numerics.BigInteger(254273295018552348L), new System.Numerics.BigInteger(5211288457507884193L), }, { new System.Numerics.BigInteger(5505253514946837173L), new System.Numerics.BigInteger(9108447418062907451L), new System.Numerics.BigInteger(1733935569973187040L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2750271821656619045L), new System.Numerics.BigInteger(3916846288149126114L), new System.Numerics.BigInteger(582431018405929068L), }, { new System.Numerics.BigInteger(6042232880615159062L), new System.Numerics.BigInteger(261444543315254628L), new System.Numerics.BigInteger(1629702691864705717L), }, { new System.Numerics.BigInteger(3362331317048598272L), new System.Numerics.BigInteger(5732139016201016500L), new System.Numerics.BigInteger(4408581818872939476L), }, }, { { new System.Numerics.BigInteger(1809364629419452950L), new System.Numerics.BigInteger(5290560873712499512L), new System.Numerics.BigInteger(2163213582609550252L), }, { new System.Numerics.BigInteger(2715854697156202963L), new System.Numerics.BigInteger(5179732929348109686L), new System.Numerics.BigInteger(4796919253532153898L), }, { new System.Numerics.BigInteger(2875672757266448604L), new System.Numerics.BigInteger(8872696072390418460L), new System.Numerics.BigInteger(2356748450988084776L), }, }, { { new System.Numerics.BigInteger(8926356026511443664L), new System.Numerics.BigInteger(7748818014558160275L), new System.Numerics.BigInteger(7292718756625831029L), }, { new System.Numerics.BigInteger(6613787033318011029L), new System.Numerics.BigInteger(7650865830626299954L), new System.Numerics.BigInteger(5986720096714682130L), }, { new System.Numerics.BigInteger(4219769819228869293L), new System.Numerics.BigInteger(4185980900018456458L), new System.Numerics.BigInteger(1527183810265083190L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8061365779038678379L), new System.Numerics.BigInteger(8043767694457773214L), new System.Numerics.BigInteger(4433095206436643019L), }, { new System.Numerics.BigInteger(2146751870023602072L), new System.Numerics.BigInteger(2508195550203398183L), new System.Numerics.BigInteger(5932855918437683760L), }, { new System.Numerics.BigInteger(1510743341092843309L), new System.Numerics.BigInteger(934649058433042685L), new System.Numerics.BigInteger(5781924876477903637L), }, }, { { new System.Numerics.BigInteger(565418417847730973L), new System.Numerics.BigInteger(405794245140367406L), new System.Numerics.BigInteger(9178603061756753689L), }, { new System.Numerics.BigInteger(7463324658500597768L), new System.Numerics.BigInteger(7578688235393509212L), new System.Numerics.BigInteger(4843436388511231298L), }, { new System.Numerics.BigInteger(3556834814908157545L), new System.Numerics.BigInteger(1705448632550811158L), new System.Numerics.BigInteger(4935186402886184090L), }, }, { { new System.Numerics.BigInteger(3742147304860296918L), new System.Numerics.BigInteger(3666617149283489180L), new System.Numerics.BigInteger(8062609431752947063L), }, { new System.Numerics.BigInteger(4385750534430725900L), new System.Numerics.BigInteger(4448964222052071625L), new System.Numerics.BigInteger(6235858254926845641L), }, { new System.Numerics.BigInteger(4459264711608271119L), new System.Numerics.BigInteger(4229643815970976904L), new System.Numerics.BigInteger(205677275441610642L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2050053216470785795L), new System.Numerics.BigInteger(1678618430745930357L), new System.Numerics.BigInteger(5823696669148068349L), }, { new System.Numerics.BigInteger(2820435460925015739L), new System.Numerics.BigInteger(6988383483516003609L), new System.Numerics.BigInteger(7017486520858477524L), }, { new System.Numerics.BigInteger(161598277510036196L), new System.Numerics.BigInteger(7853599933345760298L), new System.Numerics.BigInteger(1676140652290719721L), }, }, { { new System.Numerics.BigInteger(8843466702759364213L), new System.Numerics.BigInteger(2991761120937484931L), new System.Numerics.BigInteger(2071934475492531747L), }, { new System.Numerics.BigInteger(3396858732299757041L), new System.Numerics.BigInteger(8904687505345524434L), new System.Numerics.BigInteger(3131349583095369991L), }, { new System.Numerics.BigInteger(2498493296287895503L), new System.Numerics.BigInteger(550399918707749146L), new System.Numerics.BigInteger(8710830913975777744L), }, }, { { new System.Numerics.BigInteger(2887789906016241867L), new System.Numerics.BigInteger(8686994369498211979L), new System.Numerics.BigInteger(9147160277243077867L), }, { new System.Numerics.BigInteger(8183358038828670865L), new System.Numerics.BigInteger(2211456826069711280L), new System.Numerics.BigInteger(6706572887941275318L), }, { new System.Numerics.BigInteger(384049642054093986L), new System.Numerics.BigInteger(6572884886030937832L), new System.Numerics.BigInteger(1949942445264563309L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(4664200007767397168L), new System.Numerics.BigInteger(4199288557635423120L), new System.Numerics.BigInteger(7341034114592382999L), }, { new System.Numerics.BigInteger(8831835925188085543L), new System.Numerics.BigInteger(7653401815564906467L), new System.Numerics.BigInteger(4442526598074426901L), }, { new System.Numerics.BigInteger(6696440530486188860L), new System.Numerics.BigInteger(3829799964591527503L), new System.Numerics.BigInteger(2659563734973160853L), }, }, { { new System.Numerics.BigInteger(4537238069015608148L), new System.Numerics.BigInteger(4512192873149470387L), new System.Numerics.BigInteger(1345526041089209350L), }, { new System.Numerics.BigInteger(7580737568699806189L), new System.Numerics.BigInteger(4539267430604361595L), new System.Numerics.BigInteger(6218244482008446099L), }, { new System.Numerics.BigInteger(9189033000859155133L), new System.Numerics.BigInteger(7074390981107078063L), new System.Numerics.BigInteger(9049032745409105606L), }, }, { { new System.Numerics.BigInteger(3086910665979631867L), new System.Numerics.BigInteger(538346035187253860L), new System.Numerics.BigInteger(6116219673732661511L), }, { new System.Numerics.BigInteger(4581529942378087211L), new System.Numerics.BigInteger(4116404550161368224L), new System.Numerics.BigInteger(5765888279756875634L), }, { new System.Numerics.BigInteger(4744395472188136850L), new System.Numerics.BigInteger(4179981419565535775L), new System.Numerics.BigInteger(3127744234812882463L), }, }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(768132944373052934L), new System.Numerics.BigInteger(4344706325699343016L), new System.Numerics.BigInteger(3557083122256998796L), }, { new System.Numerics.BigInteger(7979948090295023236L), new System.Numerics.BigInteger(2804657570760956222L), new System.Numerics.BigInteger(9120377513126131511L), }, { new System.Numerics.BigInteger(4341580880048293564L), new System.Numerics.BigInteger(8884213126802110576L), new System.Numerics.BigInteger(3179323997341805229L), }, }, { { new System.Numerics.BigInteger(8591025803212725084L), new System.Numerics.BigInteger(8258376113095752034L), new System.Numerics.BigInteger(2224137298251727563L), }, { new System.Numerics.BigInteger(6475462575686067472L), new System.Numerics.BigInteger(7374282855259984517L), new System.Numerics.BigInteger(7966120069014137234L), }, { new System.Numerics.BigInteger(7781830748859005532L), new System.Numerics.BigInteger(4901361632725172345L), new System.Numerics.BigInteger(5657591535105446694L), }, }, { { new System.Numerics.BigInteger(8879874686934414141L), new System.Numerics.BigInteger(1266778667192740240L), new System.Numerics.BigInteger(802592251988109314L), }, { new System.Numerics.BigInteger(8768805832801273323L), new System.Numerics.BigInteger(1894828337893740765L), new System.Numerics.BigInteger(8807026737209349431L), }, { new System.Numerics.BigInteger(7792414953975551485L), new System.Numerics.BigInteger(8287271247087404534L), new System.Numerics.BigInteger(1841031960697250915L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(7353357674478933471L), new System.Numerics.BigInteger(5237725586872274386L), new System.Numerics.BigInteger(5636739309792920847L), }, { new System.Numerics.BigInteger(2433192582863594755L), new System.Numerics.BigInteger(2424745684523217275L), new System.Numerics.BigInteger(293085666781259962L), }, { new System.Numerics.BigInteger(5378207258948769941L), new System.Numerics.BigInteger(7462655812427495685L), new System.Numerics.BigInteger(2685153279243514641L), }, }, { { new System.Numerics.BigInteger(7638545699731326738L), new System.Numerics.BigInteger(4304662023578207189L), new System.Numerics.BigInteger(3695249008535622561L), }, { new System.Numerics.BigInteger(9030917939361006344L), new System.Numerics.BigInteger(2192555416964524795L), new System.Numerics.BigInteger(119511069432237165L), }, { new System.Numerics.BigInteger(581899941442914638L), new System.Numerics.BigInteger(520122049588244089L), new System.Numerics.BigInteger(7567452968473692149L), }, }, { { new System.Numerics.BigInteger(6908451209855248998L), new System.Numerics.BigInteger(6257129314340700419L), new System.Numerics.BigInteger(2612930555302452198L), }, { new System.Numerics.BigInteger(1644400124338788545L), new System.Numerics.BigInteger(7238499141120938609L), new System.Numerics.BigInteger(4963309415390472212L), }, { new System.Numerics.BigInteger(2246841097230237661L), new System.Numerics.BigInteger(8812674767339730154L), new System.Numerics.BigInteger(9139578930831624210L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8237902546051934818L), new System.Numerics.BigInteger(6080492606182622849L), new System.Numerics.BigInteger(1936484012078108484L), }, { new System.Numerics.BigInteger(8218224094375359269L), new System.Numerics.BigInteger(8324998220623551290L), new System.Numerics.BigInteger(1137648301891760278L), }, { new System.Numerics.BigInteger(4078581157555832466L), new System.Numerics.BigInteger(3992765812511567881L), new System.Numerics.BigInteger(2588573802835848294L), }, }, { { new System.Numerics.BigInteger(8458037226124897626L), new System.Numerics.BigInteger(8839838109758730718L), new System.Numerics.BigInteger(5243067990958569037L), }, { new System.Numerics.BigInteger(6241165481051763926L), new System.Numerics.BigInteger(7394365694168286430L), new System.Numerics.BigInteger(2837703959000073174L), }, { new System.Numerics.BigInteger(509775930626654387L), new System.Numerics.BigInteger(8957337415826804398L), new System.Numerics.BigInteger(8960380196544914377L), }, }, { { new System.Numerics.BigInteger(2226582998722047859L), new System.Numerics.BigInteger(4048894352545755192L), new System.Numerics.BigInteger(6462281829326694991L), }, { new System.Numerics.BigInteger(2629740171710554585L), new System.Numerics.BigInteger(212705686812589901L), new System.Numerics.BigInteger(3372301758875760845L), }, { new System.Numerics.BigInteger(5721519418485428419L), new System.Numerics.BigInteger(6773312580379984664L), new System.Numerics.BigInteger(2547069341585868591L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6574867802676265600L), new System.Numerics.BigInteger(9197014252105231430L), new System.Numerics.BigInteger(1100923385286719758L), }, { new System.Numerics.BigInteger(6946938107032555160L), new System.Numerics.BigInteger(6788449886786368581L), new System.Numerics.BigInteger(4212736117285603335L), }, { new System.Numerics.BigInteger(2045614199951368254L), new System.Numerics.BigInteger(8669009619684453196L), new System.Numerics.BigInteger(8256535010812470222L), }, }, { { new System.Numerics.BigInteger(6550458307116289654L), new System.Numerics.BigInteger(812941553622393466L), new System.Numerics.BigInteger(2065086728248561707L), }, { new System.Numerics.BigInteger(7021559035492776569L), new System.Numerics.BigInteger(2349461127041082795L), new System.Numerics.BigInteger(8666384955140429415L), }, { new System.Numerics.BigInteger(8684038981396258671L), new System.Numerics.BigInteger(1756859258839842885L), new System.Numerics.BigInteger(7172568063876184406L), }, }, { { new System.Numerics.BigInteger(2583412665439983472L), new System.Numerics.BigInteger(6295204028231021008L), new System.Numerics.BigInteger(1331508572989338165L), }, { new System.Numerics.BigInteger(5634640685525940122L), new System.Numerics.BigInteger(1506115491978481706L), new System.Numerics.BigInteger(7993710106693690430L), }, { new System.Numerics.BigInteger(6162641764779478907L), new System.Numerics.BigInteger(2992530637532034091L), new System.Numerics.BigInteger(191629085126008519L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(4319772237893736161L), new System.Numerics.BigInteger(1654461566093410988L), new System.Numerics.BigInteger(8266056137890037878L), }, { new System.Numerics.BigInteger(3549541147859802924L), new System.Numerics.BigInteger(2933251344205978128L), new System.Numerics.BigInteger(6125149520427481583L), }, { new System.Numerics.BigInteger(862992793972348356L), new System.Numerics.BigInteger(1430040645634686718L), new System.Numerics.BigInteger(2784968705875001669L), }, }, { { new System.Numerics.BigInteger(5877218838723577092L), new System.Numerics.BigInteger(4086798063227627622L), new System.Numerics.BigInteger(6455664808825649760L), }, { new System.Numerics.BigInteger(2413449691930054151L), new System.Numerics.BigInteger(2705293913726345416L), new System.Numerics.BigInteger(4206247794546170948L), }, { new System.Numerics.BigInteger(7766825615300260034L), new System.Numerics.BigInteger(9167875671900940839L), new System.Numerics.BigInteger(2524671333359387087L), }, }, { { new System.Numerics.BigInteger(5409712444294035054L), new System.Numerics.BigInteger(5918924072891874704L), new System.Numerics.BigInteger(6344823933618710176L), }, { new System.Numerics.BigInteger(4644770182813988508L), new System.Numerics.BigInteger(5460228682839712606L), new System.Numerics.BigInteger(7256843893145095625L), }, { new System.Numerics.BigInteger(6111716155421110986L), new System.Numerics.BigInteger(5269289298011072646L), new System.Numerics.BigInteger(5660185970016442447L), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8796884211561427912L), new System.Numerics.BigInteger(1345067171364401763L), new System.Numerics.BigInteger(1148795888345795660L), }, { new System.Numerics.BigInteger(8031198229893503741L), new System.Numerics.BigInteger(6567798968653059772L), new System.Numerics.BigInteger(2930700229697389546L), }, { new System.Numerics.BigInteger(2110034348022467576L), new System.Numerics.BigInteger(5723514097004941614L), new System.Numerics.BigInteger(1995653831609920802L), }, }, { { new System.Numerics.BigInteger(7061291086929465673L), new System.Numerics.BigInteger(3049349162794083560L), new System.Numerics.BigInteger(2333103044730313768L), }, { new System.Numerics.BigInteger(126257502268956981L), new System.Numerics.BigInteger(5161605814849398520L), new System.Numerics.BigInteger(8613635545808772653L), }, { new System.Numerics.BigInteger(1502377738906426813L), new System.Numerics.BigInteger(7691634162200567726L), new System.Numerics.BigInteger(3959600780124982724L), }, }, { { new System.Numerics.BigInteger(7379296422276863037L), new System.Numerics.BigInteger(133879139444244611L), new System.Numerics.BigInteger(9096811080975363271L), }, { new System.Numerics.BigInteger(1879947198625985527L), new System.Numerics.BigInteger(3083128346984760800L), new System.Numerics.BigInteger(1955875801352242327L), }, { new System.Numerics.BigInteger(2156817480888066386L), new System.Numerics.BigInteger(8357515846714135519L), new System.Numerics.BigInteger(8539671878785955076L), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2388366471353295931L), new System.Numerics.BigInteger(5316721149891847713L), new System.Numerics.BigInteger(4128681570566555054L), }, { new System.Numerics.BigInteger(409483521133667158L), new System.Numerics.BigInteger(8929918514341347414L), new System.Numerics.BigInteger(5714214271915565756L), }, { new System.Numerics.BigInteger(8466334944913269952L), new System.Numerics.BigInteger(3801120469152877176L), new System.Numerics.BigInteger(6284963050269601053L), }, }, { { new System.Numerics.BigInteger(2511228883064048600L), new System.Numerics.BigInteger(3383267551967895114L), new System.Numerics.BigInteger(8027238900554337356L), }, { new System.Numerics.BigInteger(4161308497563886674L), new System.Numerics.BigInteger(3196455783684144280L), new System.Numerics.BigInteger(9216512571571732292L), }, { new System.Numerics.BigInteger(215202725627843097L), new System.Numerics.BigInteger(8283512665972580305L), new System.Numerics.BigInteger(3617660033408429909L), }, }, { { new System.Numerics.BigInteger(1734719509661994505L), new System.Numerics.BigInteger(8093566280368037254L), new System.Numerics.BigInteger(7248633200031927933L), }, { new System.Numerics.BigInteger(7526201359795792844L), new System.Numerics.BigInteger(7312838111910543781L), new System.Numerics.BigInteger(8929698100484615365L), }, { new System.Numerics.BigInteger(889968390378020423L), new System.Numerics.BigInteger(3006255804342763122L), new System.Numerics.BigInteger(4590410819365517516L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1162833671889496249L), new System.Numerics.BigInteger(8783290756242130240L), new System.Numerics.BigInteger(164644030031613478L), }, { new System.Numerics.BigInteger(2681675205097162737L), new System.Numerics.BigInteger(222043102034558498L), new System.Numerics.BigInteger(9163071477861539752L), }, { new System.Numerics.BigInteger(9122895783491696721L), new System.Numerics.BigInteger(1996611782076216930L), new System.Numerics.BigInteger(102247710175285028L), }, }, { { new System.Numerics.BigInteger(3983577807945247857L), new System.Numerics.BigInteger(8219861323851455242L), new System.Numerics.BigInteger(8944740908661192248L), }, { new System.Numerics.BigInteger(7401534543330211491L), new System.Numerics.BigInteger(3186515506566141170L), new System.Numerics.BigInteger(6089279638842365988L), }, { new System.Numerics.BigInteger(5962049658174306967L), new System.Numerics.BigInteger(6114705868244596418L), new System.Numerics.BigInteger(5303353237620535543L), }, }, { { new System.Numerics.BigInteger(8663735192254087456L), new System.Numerics.BigInteger(6093181177156126198L), new System.Numerics.BigInteger(8608480327509550479L), }, { new System.Numerics.BigInteger(1942492189729286590L), new System.Numerics.BigInteger(7996610515108981621L), new System.Numerics.BigInteger(58585035631000901L), }, { new System.Numerics.BigInteger(9128544678624204267L), new System.Numerics.BigInteger(8653232430727413663L), new System.Numerics.BigInteger(3337570599547113041L), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2559884550577950811L), new System.Numerics.BigInteger(5654953903775494717L), new System.Numerics.BigInteger(8632180274544475046L), }, { new System.Numerics.BigInteger(7319641834098021455L), new System.Numerics.BigInteger(3745868013885258401L), new System.Numerics.BigInteger(5692875930031153543L), }, { new System.Numerics.BigInteger(4579267744180216428L), new System.Numerics.BigInteger(7134326726590364973L), new System.Numerics.BigInteger(5197293135525295692L), }, }, { { new System.Numerics.BigInteger(8810100136161155076L), new System.Numerics.BigInteger(4515911259568492869L), new System.Numerics.BigInteger(5457307664684308293L), }, { new System.Numerics.BigInteger(4236769764123334061L), new System.Numerics.BigInteger(8612828713110887552L), new System.Numerics.BigInteger(7008277421483793144L), }, { new System.Numerics.BigInteger(4869237917442186297L), new System.Numerics.BigInteger(8208805398719484621L), new System.Numerics.BigInteger(5828176135304738177L), }, }, { { new System.Numerics.BigInteger(5362553468449156305L), new System.Numerics.BigInteger(7202822022717855388L), new System.Numerics.BigInteger(5334492821046575628L), }, { new System.Numerics.BigInteger(7662312561187631718L), new System.Numerics.BigInteger(4038991372441009011L), new System.Numerics.BigInteger(2452619770313135671L), }, { new System.Numerics.BigInteger(3059360170934513752L), new System.Numerics.BigInteger(2872317261261228992L), new System.Numerics.BigInteger(544199308183063546L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(5389590427678618685L), new System.Numerics.BigInteger(1976322854926486003L), new System.Numerics.BigInteger(3777226423555326820L), }, { new System.Numerics.BigInteger(7766642801996124570L), new System.Numerics.BigInteger(5374302003669770032L), new System.Numerics.BigInteger(3326437646955109282L), }, { new System.Numerics.BigInteger(2810443044181379200L), new System.Numerics.BigInteger(3708430272227408635L), new System.Numerics.BigInteger(5066598980590961325L), }, }, { { new System.Numerics.BigInteger(2348935618587072043L), new System.Numerics.BigInteger(2000457542768061586L), new System.Numerics.BigInteger(1297452624931632963L), }, { new System.Numerics.BigInteger(4503197729955380771L), new System.Numerics.BigInteger(3835733150631453738L), new System.Numerics.BigInteger(8522515736116452593L), }, { new System.Numerics.BigInteger(1017810622714803055L), new System.Numerics.BigInteger(1366289432962453639L), new System.Numerics.BigInteger(6102860273870481272L), }, }, { { new System.Numerics.BigInteger(618914885908931973L), new System.Numerics.BigInteger(9194212852572652991L), new System.Numerics.BigInteger(4587846293444397545L), }, { new System.Numerics.BigInteger(5697552833009436828L), new System.Numerics.BigInteger(8752897867212122432L), new System.Numerics.BigInteger(7883114879754134965L), }, { new System.Numerics.BigInteger(1605471436323209475L), new System.Numerics.BigInteger(5543827014439671752L), new System.Numerics.BigInteger(7647667391830095111L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3074802768891227876L), new System.Numerics.BigInteger(5261902518270739243L), new System.Numerics.BigInteger(806764307220543376L), }, { new System.Numerics.BigInteger(4775327178390676926L), new System.Numerics.BigInteger(1220537879052836650L), new System.Numerics.BigInteger(9099745637674542937L), }, { new System.Numerics.BigInteger(268059029546890312L), new System.Numerics.BigInteger(2947364223997711374L), new System.Numerics.BigInteger(3879000499869015602L), }, }, { { new System.Numerics.BigInteger(1636109324732586928L), new System.Numerics.BigInteger(3197801468373837723L), new System.Numerics.BigInteger(4049739463125832572L), }, { new System.Numerics.BigInteger(6966698000390274888L), new System.Numerics.BigInteger(8615084181062381845L), new System.Numerics.BigInteger(3573384972345075343L), }, { new System.Numerics.BigInteger(2930626695770098720L), new System.Numerics.BigInteger(530525740135400876L), new System.Numerics.BigInteger(2224661424812024212L), }, }, { { new System.Numerics.BigInteger(4064056215387479574L), new System.Numerics.BigInteger(2100495759789547585L), new System.Numerics.BigInteger(6983305272393132560L), }, { new System.Numerics.BigInteger(8820162766867926256L), new System.Numerics.BigInteger(5208848945713765230L), new System.Numerics.BigInteger(66834484665254715L), }, { new System.Numerics.BigInteger(6472217059425684067L), new System.Numerics.BigInteger(4063930932503490099L), new System.Numerics.BigInteger(3257357287070710691L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8138257540816208757L), new System.Numerics.BigInteger(6341869244744679495L), new System.Numerics.BigInteger(194616201859766289L), }, { new System.Numerics.BigInteger(498197447653138231L), new System.Numerics.BigInteger(985703561803070667L), new System.Numerics.BigInteger(6624114584987762024L), }, { new System.Numerics.BigInteger(5666106110941579098L), new System.Numerics.BigInteger(334556854015276308L), new System.Numerics.BigInteger(7991007701802722495L), }, }, { { new System.Numerics.BigInteger(5662841827962156035L), new System.Numerics.BigInteger(9140391759217382926L), new System.Numerics.BigInteger(4281400134863880983L), }, { new System.Numerics.BigInteger(6975475103706661089L), new System.Numerics.BigInteger(7001998954427655208L), new System.Numerics.BigInteger(9218391050972845907L), }, { new System.Numerics.BigInteger(1755095065486017066L), new System.Numerics.BigInteger(7867732323033269802L), new System.Numerics.BigInteger(5176199903031189172L), }, }, { { new System.Numerics.BigInteger(6252757451513088103L), new System.Numerics.BigInteger(728486199610264938L), new System.Numerics.BigInteger(193143094023584256L), }, { new System.Numerics.BigInteger(4688587867686943202L), new System.Numerics.BigInteger(6723543808640847706L), new System.Numerics.BigInteger(164256243014602617L), }, { new System.Numerics.BigInteger(8055138550137489908L), new System.Numerics.BigInteger(5087982650666606933L), new System.Numerics.BigInteger(7327414538729525825L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1891299955008034210L), new System.Numerics.BigInteger(8735236887350970741L), new System.Numerics.BigInteger(338180377924142256L), }, { new System.Numerics.BigInteger(6624588360791115146L), new System.Numerics.BigInteger(8827976877112270084L), new System.Numerics.BigInteger(5994270604876597005L), }, { new System.Numerics.BigInteger(8842790945255214073L), new System.Numerics.BigInteger(9164757077487318160L), new System.Numerics.BigInteger(8933887485837290499L), }, }, { { new System.Numerics.BigInteger(2021384869629936956L), new System.Numerics.BigInteger(8145114170186584473L), new System.Numerics.BigInteger(1978750887201741389L), }, { new System.Numerics.BigInteger(5016152305364783814L), new System.Numerics.BigInteger(5818633641392519244L), new System.Numerics.BigInteger(3014223380003633246L), }, { new System.Numerics.BigInteger(7375107632649373734L), new System.Numerics.BigInteger(5152175397670492210L), new System.Numerics.BigInteger(5371079924188811856L), }, }, { { new System.Numerics.BigInteger(12914392765574104L), new System.Numerics.BigInteger(4623203006722322729L), new System.Numerics.BigInteger(6191650294550877429L), }, { new System.Numerics.BigInteger(8970083803812928217L), new System.Numerics.BigInteger(3507405434414116297L), new System.Numerics.BigInteger(2997834741613930753L), }, { new System.Numerics.BigInteger(5571086315685540338L), new System.Numerics.BigInteger(6037795305795370616L), new System.Numerics.BigInteger(340879184090958210L), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1194537956141356899L), new System.Numerics.BigInteger(1599039572724234243L), new System.Numerics.BigInteger(8423125230935780883L), }, { new System.Numerics.BigInteger(8113129549461075040L), new System.Numerics.BigInteger(6453301576278116541L), new System.Numerics.BigInteger(6282742000437045114L), }, { new System.Numerics.BigInteger(2543000719934576194L), new System.Numerics.BigInteger(4160312370819780208L), new System.Numerics.BigInteger(7398298004231614042L), }, }, { { new System.Numerics.BigInteger(7892230740071603063L), new System.Numerics.BigInteger(8799217839471057711L), new System.Numerics.BigInteger(8047817862086867527L), }, { new System.Numerics.BigInteger(4661971475776372375L), new System.Numerics.BigInteger(2016733590066611999L), new System.Numerics.BigInteger(1857462671549607948L), }, { new System.Numerics.BigInteger(4871348166266597400L), new System.Numerics.BigInteger(8574972375252749173L), new System.Numerics.BigInteger(5241691158230124737L), }, }, { { new System.Numerics.BigInteger(5923782452929790355L), new System.Numerics.BigInteger(7291011808421928488L), new System.Numerics.BigInteger(4489842167062727506L), }, { new System.Numerics.BigInteger(2133315950420927735L), new System.Numerics.BigInteger(5328420015030590575L), new System.Numerics.BigInteger(1091723582425431669L), }, { new System.Numerics.BigInteger(6101048631834091593L), new System.Numerics.BigInteger(9155837904302255140L), new System.Numerics.BigInteger(3175543331611066447L), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8311332455221526020L), new System.Numerics.BigInteger(3489761785746201236L), new System.Numerics.BigInteger(3639596873776449976L), }, { new System.Numerics.BigInteger(2341886626939414768L), new System.Numerics.BigInteger(5393647666287985765L), new System.Numerics.BigInteger(387897283611349061L), }, { new System.Numerics.BigInteger(362203298891849047L), new System.Numerics.BigInteger(8250443390792242165L), new System.Numerics.BigInteger(3368904449537042800L), }, }, { { new System.Numerics.BigInteger(7482079014816987618L), new System.Numerics.BigInteger(265337551308236918L), new System.Numerics.BigInteger(4994710774378914076L), }, { new System.Numerics.BigInteger(9173379371971602895L), new System.Numerics.BigInteger(9115299525593365721L), new System.Numerics.BigInteger(4603970214875846711L), }, { new System.Numerics.BigInteger(1548350703448162247L), new System.Numerics.BigInteger(7432312877335929238L), new System.Numerics.BigInteger(1108716036875283613L), }, }, { { new System.Numerics.BigInteger(6529987675997920597L), new System.Numerics.BigInteger(5008628643527506096L), new System.Numerics.BigInteger(6487493728520605430L), }, { new System.Numerics.BigInteger(1749618512287591142L), new System.Numerics.BigInteger(2662785874935751419L), new System.Numerics.BigInteger(5218579207373495203L), }, { new System.Numerics.BigInteger(506955833078002086L), new System.Numerics.BigInteger(4547392387035526674L), new System.Numerics.BigInteger(1136836821450367379L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8813397006013996888L), new System.Numerics.BigInteger(54613167728236791L), new System.Numerics.BigInteger(9126809698390799648L), }, { new System.Numerics.BigInteger(4886936574997640725L), new System.Numerics.BigInteger(668347992374513478L), new System.Numerics.BigInteger(8292031385932193840L), }, { new System.Numerics.BigInteger(1870025831222355563L), new System.Numerics.BigInteger(4739277013616784760L), new System.Numerics.BigInteger(7504542737552954516L), }, }, { { new System.Numerics.BigInteger(4683021533714371922L), new System.Numerics.BigInteger(3357091443937609117L), new System.Numerics.BigInteger(7940063725908517189L), }, { new System.Numerics.BigInteger(1357818874798385931L), new System.Numerics.BigInteger(348365573972545389L), new System.Numerics.BigInteger(7270868701545619782L), }, { new System.Numerics.BigInteger(4523185161864567803L), new System.Numerics.BigInteger(8123300035297778869L), new System.Numerics.BigInteger(6432226558940463774L), }, }, { { new System.Numerics.BigInteger(6036900585286919532L), new System.Numerics.BigInteger(7398079574659409278L), new System.Numerics.BigInteger(7738614160355648726L), }, { new System.Numerics.BigInteger(5336486618715888052L), new System.Numerics.BigInteger(7113137412348091447L), new System.Numerics.BigInteger(7582514663781681076L), }, { new System.Numerics.BigInteger(8149084910059614165L), new System.Numerics.BigInteger(6606088061076757596L), new System.Numerics.BigInteger(5672044281204622115L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8754091771433667560L), new System.Numerics.BigInteger(1005367566004867421L), new System.Numerics.BigInteger(358725294528522582L), }, { new System.Numerics.BigInteger(6104573331149184852L), new System.Numerics.BigInteger(83910795256834242L), new System.Numerics.BigInteger(3531681136928532953L), }, { new System.Numerics.BigInteger(4381221117076030921L), new System.Numerics.BigInteger(7965744599979654337L), new System.Numerics.BigInteger(5001185678370402803L), }, }, { { new System.Numerics.BigInteger(7230521993588448792L), new System.Numerics.BigInteger(2947521474883142444L), new System.Numerics.BigInteger(5888825796337577332L), }, { new System.Numerics.BigInteger(1969714168020525518L), new System.Numerics.BigInteger(1149598879408711673L), new System.Numerics.BigInteger(7309082325743093182L), }, { new System.Numerics.BigInteger(1541683334552305413L), new System.Numerics.BigInteger(4020082710741626448L), new System.Numerics.BigInteger(1948201529048817084L), }, }, { { new System.Numerics.BigInteger(4287781186520268038L), new System.Numerics.BigInteger(598763912658937392L), new System.Numerics.BigInteger(2864067455557102624L), }, { new System.Numerics.BigInteger(6811954766895849186L), new System.Numerics.BigInteger(6901790449319740774L), new System.Numerics.BigInteger(930545005458810043L), }, { new System.Numerics.BigInteger(3320108340160836551L), new System.Numerics.BigInteger(452093515002700457L), new System.Numerics.BigInteger(4804615310103736531L), }, }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2175725788791467354L), new System.Numerics.BigInteger(1662359272701911589L), new System.Numerics.BigInteger(8011831580669126306L), }, { new System.Numerics.BigInteger(4263938269306903628L), new System.Numerics.BigInteger(5640550919430003105L), new System.Numerics.BigInteger(4547152962291677340L), }, { new System.Numerics.BigInteger(462098550527696164L), new System.Numerics.BigInteger(7810808745492579308L), new System.Numerics.BigInteger(8153914714117727871L), }, }, { { new System.Numerics.BigInteger(671969387136720796L), new System.Numerics.BigInteger(3751155125602133055L), new System.Numerics.BigInteger(8623084521700154565L), }, { new System.Numerics.BigInteger(1784028266361734375L), new System.Numerics.BigInteger(5986380809307411938L), new System.Numerics.BigInteger(6458525571344756735L), }, { new System.Numerics.BigInteger(5304629601615085978L), new System.Numerics.BigInteger(7792795531075131985L), new System.Numerics.BigInteger(8266525348304081198L), }, }, { { new System.Numerics.BigInteger(2859784875502401054L), new System.Numerics.BigInteger(520441421357052336L), new System.Numerics.BigInteger(1544195403408237966L), }, { new System.Numerics.BigInteger(8517304659365113738L), new System.Numerics.BigInteger(8251815650686446527L), new System.Numerics.BigInteger(5747842945202543839L), }, { new System.Numerics.BigInteger(1715127046267690866L), new System.Numerics.BigInteger(296065656312492698L), new System.Numerics.BigInteger(8750939378177197636L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(5410528103223017145L), new System.Numerics.BigInteger(4051343489859706959L), new System.Numerics.BigInteger(8173436454499039422L), }, { new System.Numerics.BigInteger(754193801854846122L), new System.Numerics.BigInteger(2786975881580794538L), new System.Numerics.BigInteger(7157656627190414106L), }, { new System.Numerics.BigInteger(7744381154598411811L), new System.Numerics.BigInteger(4903923436031944040L), new System.Numerics.BigInteger(5552485948115816868L), }, }, { { new System.Numerics.BigInteger(8855962692214903614L), new System.Numerics.BigInteger(5702534180806237939L), new System.Numerics.BigInteger(6141699042361548112L), }, { new System.Numerics.BigInteger(3705452714714931122L), new System.Numerics.BigInteger(3410968666361506743L), new System.Numerics.BigInteger(1869549441344629570L), }, { new System.Numerics.BigInteger(5313041762546670819L), new System.Numerics.BigInteger(4959807157269854123L), new System.Numerics.BigInteger(3858276778324287994L), }, }, { { new System.Numerics.BigInteger(1534551608525826069L), new System.Numerics.BigInteger(2365069593811871382L), new System.Numerics.BigInteger(7234518781887393049L), }, { new System.Numerics.BigInteger(2851466749139372242L), new System.Numerics.BigInteger(3580164343670175086L), new System.Numerics.BigInteger(4725067692876535630L), }, { new System.Numerics.BigInteger(4595562283064647796L), new System.Numerics.BigInteger(4912020775846939315L), new System.Numerics.BigInteger(6520710256124943188L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3131383794232584179L), new System.Numerics.BigInteger(5752619804306569949L), new System.Numerics.BigInteger(4241103291238049642L), }, { new System.Numerics.BigInteger(4185092137483619467L), new System.Numerics.BigInteger(2704264221868059502L), new System.Numerics.BigInteger(1985993723517229192L), }, { new System.Numerics.BigInteger(3775260659689828499L), new System.Numerics.BigInteger(4702631942480647922L), new System.Numerics.BigInteger(5498272560432191175L), }, }, { { new System.Numerics.BigInteger(2279213951046420131L), new System.Numerics.BigInteger(2325124333227661640L), new System.Numerics.BigInteger(1457543191295251053L), }, { new System.Numerics.BigInteger(7836680003015458312L), new System.Numerics.BigInteger(8449540968901242445L), new System.Numerics.BigInteger(7551785688680525577L), }, { new System.Numerics.BigInteger(3949409172724949828L), new System.Numerics.BigInteger(7479352688621675449L), new System.Numerics.BigInteger(7526628028245371261L), }, }, { { new System.Numerics.BigInteger(4076870712409797993L), new System.Numerics.BigInteger(1822042074893531144L), new System.Numerics.BigInteger(1815943235965768855L), }, { new System.Numerics.BigInteger(4987284371345495532L), new System.Numerics.BigInteger(3091464064642970127L), new System.Numerics.BigInteger(5659461017996771610L), }, { new System.Numerics.BigInteger(4236697040464510240L), new System.Numerics.BigInteger(7754413553466039864L), new System.Numerics.BigInteger(417219988889306044L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2214247450017451068L), new System.Numerics.BigInteger(1414874116945905553L), new System.Numerics.BigInteger(7522306925938472324L), }, { new System.Numerics.BigInteger(2535530612949020477L), new System.Numerics.BigInteger(1662250265649076877L), new System.Numerics.BigInteger(8622211748494733936L), }, { new System.Numerics.BigInteger(3737180931587065346L), new System.Numerics.BigInteger(2683184621643639400L), new System.Numerics.BigInteger(5025499044450479819L), }, }, { { new System.Numerics.BigInteger(1945311620863195603L), new System.Numerics.BigInteger(503633453095830702L), new System.Numerics.BigInteger(3263603382371244546L), }, { new System.Numerics.BigInteger(5039054095651920682L), new System.Numerics.BigInteger(956861743141691337L), new System.Numerics.BigInteger(2335967122491939948L), }, { new System.Numerics.BigInteger(577945392745249792L), new System.Numerics.BigInteger(3192294599956506847L), new System.Numerics.BigInteger(4508562843617319161L), }, }, { { new System.Numerics.BigInteger(1124815098726228872L), new System.Numerics.BigInteger(1181513986168402199L), new System.Numerics.BigInteger(313521898042354978L), }, { new System.Numerics.BigInteger(8770894535162159413L), new System.Numerics.BigInteger(8516263315039984430L), new System.Numerics.BigInteger(646978743135775397L), }, { new System.Numerics.BigInteger(4072139028447791239L), new System.Numerics.BigInteger(8250085005607241590L), new System.Numerics.BigInteger(6743562590665542887L), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(5122545647147249826L), new System.Numerics.BigInteger(4981090814661524594L), new System.Numerics.BigInteger(3046664732045668926L), }, { new System.Numerics.BigInteger(3157685047916449477L), new System.Numerics.BigInteger(8469085761778939848L), new System.Numerics.BigInteger(4161684079511558178L), }, { new System.Numerics.BigInteger(4084884912181854648L), new System.Numerics.BigInteger(210405111856995459L), new System.Numerics.BigInteger(708349026652878851L), }, }, { { new System.Numerics.BigInteger(1999483536417671025L), new System.Numerics.BigInteger(4384605935129241666L), new System.Numerics.BigInteger(7624905150247738846L), }, { new System.Numerics.BigInteger(2393644032574757275L), new System.Numerics.BigInteger(4984031101473411245L), new System.Numerics.BigInteger(2817342092434662911L), }, { new System.Numerics.BigInteger(559765047273637370L), new System.Numerics.BigInteger(2555263384293739683L), new System.Numerics.BigInteger(6038366925925495946L), }, }, { { new System.Numerics.BigInteger(6689515642973430743L), new System.Numerics.BigInteger(6914684736823711548L), new System.Numerics.BigInteger(4546843340174370291L), }, { new System.Numerics.BigInteger(8503322681603172117L), new System.Numerics.BigInteger(5665671758417858332L), new System.Numerics.BigInteger(6228657508115169300L), }, { new System.Numerics.BigInteger(1419468940740494183L), new System.Numerics.BigInteger(4305420580029084183L), new System.Numerics.BigInteger(4143126380766841613L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(155681478663871338L), new System.Numerics.BigInteger(2018442954276955017L), new System.Numerics.BigInteger(6252147371208280972L), }, { new System.Numerics.BigInteger(4394100726484406783L), new System.Numerics.BigInteger(7015560665835815809L), new System.Numerics.BigInteger(1181770159520769117L), }, { new System.Numerics.BigInteger(8172143806325477469L), new System.Numerics.BigInteger(8801145640927623966L), new System.Numerics.BigInteger(1215043046447818673L), }, }, { { new System.Numerics.BigInteger(526417965770707885L), new System.Numerics.BigInteger(3577403506115106625L), new System.Numerics.BigInteger(5121961310288846479L), }, { new System.Numerics.BigInteger(4255780402709956830L), new System.Numerics.BigInteger(3263552188715215531L), new System.Numerics.BigInteger(456883877956087774L), }, { new System.Numerics.BigInteger(4549046593611854074L), new System.Numerics.BigInteger(2420129267729656315L), new System.Numerics.BigInteger(2236421323513171825L), }, }, { { new System.Numerics.BigInteger(7485971974209315444L), new System.Numerics.BigInteger(2236708348605245510L), new System.Numerics.BigInteger(4566029213862473214L), }, { new System.Numerics.BigInteger(6524945467091135402L), new System.Numerics.BigInteger(6554092134060079256L), new System.Numerics.BigInteger(8306443919347507788L), }, { new System.Numerics.BigInteger(5989440890335975662L), new System.Numerics.BigInteger(1195029815326931724L), new System.Numerics.BigInteger(173247859660176929L), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6996590148083533116L), new System.Numerics.BigInteger(2555713791054602796L), new System.Numerics.BigInteger(35501945628007567L), }, { new System.Numerics.BigInteger(6289639558980506321L), new System.Numerics.BigInteger(555811906317686443L), new System.Numerics.BigInteger(1726572350365592553L), }, { new System.Numerics.BigInteger(8467941039447317267L), new System.Numerics.BigInteger(1169494923608103716L), new System.Numerics.BigInteger(2942411042285001836L), }, }, { { new System.Numerics.BigInteger(5529679722977194883L), new System.Numerics.BigInteger(5636437620490874843L), new System.Numerics.BigInteger(2526410108542260284L), }, { new System.Numerics.BigInteger(2496961086449613804L), new System.Numerics.BigInteger(1942489069771212888L), new System.Numerics.BigInteger(8988657579277579823L), }, { new System.Numerics.BigInteger(5905181781184500656L), new System.Numerics.BigInteger(4097320424585285644L), new System.Numerics.BigInteger(5987627167949714117L), }, }, { { new System.Numerics.BigInteger(8231667657798771995L), new System.Numerics.BigInteger(3744957302357036460L), new System.Numerics.BigInteger(7835496453519798415L), }, { new System.Numerics.BigInteger(9212819870577723170L), new System.Numerics.BigInteger(9127444960267553166L), new System.Numerics.BigInteger(7300639148282767781L), }, { new System.Numerics.BigInteger(6773369361235636039L), new System.Numerics.BigInteger(4571081048693066560L), new System.Numerics.BigInteger(8815791453029689797L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8240943692900603630L), new System.Numerics.BigInteger(6349592942783676174L), new System.Numerics.BigInteger(8965168919583220181L), }, { new System.Numerics.BigInteger(281309621739041961L), new System.Numerics.BigInteger(4251214439982588416L), new System.Numerics.BigInteger(2129112756869178797L), }, { new System.Numerics.BigInteger(3267109191545618815L), new System.Numerics.BigInteger(4041692127634088969L), new System.Numerics.BigInteger(2908708061693181025L), }, }, { { new System.Numerics.BigInteger(9082931815399685256L), new System.Numerics.BigInteger(4895006446820949902L), new System.Numerics.BigInteger(6329403315879569479L), }, { new System.Numerics.BigInteger(6512210010112348433L), new System.Numerics.BigInteger(993882799249995147L), new System.Numerics.BigInteger(2017369540593414871L), }, { new System.Numerics.BigInteger(748693628519781439L), new System.Numerics.BigInteger(8188931040053305134L), new System.Numerics.BigInteger(910259109060641987L), }, }, { { new System.Numerics.BigInteger(8193205070658009209L), new System.Numerics.BigInteger(8044985653399527260L), new System.Numerics.BigInteger(8633344636019385219L), }, { new System.Numerics.BigInteger(8291936280910850869L), new System.Numerics.BigInteger(4115376887350885926L), new System.Numerics.BigInteger(5136642063944032550L), }, { new System.Numerics.BigInteger(3709601298189875825L), new System.Numerics.BigInteger(4485981604790495668L), new System.Numerics.BigInteger(1734099282715016170L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3691686334750380223L), new System.Numerics.BigInteger(3173457668287756488L), new System.Numerics.BigInteger(6011790245841386414L), }, { new System.Numerics.BigInteger(5748434808632697249L), new System.Numerics.BigInteger(435595305725600797L), new System.Numerics.BigInteger(3265757008509520715L), }, { new System.Numerics.BigInteger(7756935271556169892L), new System.Numerics.BigInteger(5924690811997748953L), new System.Numerics.BigInteger(4629903999394329198L), }, }, { { new System.Numerics.BigInteger(8117295370182956330L), new System.Numerics.BigInteger(4542327753848894738L), new System.Numerics.BigInteger(5568320867070073708L), }, { new System.Numerics.BigInteger(6040713500206904806L), new System.Numerics.BigInteger(7312930548735317330L), new System.Numerics.BigInteger(5786391370854758055L), }, { new System.Numerics.BigInteger(3009684688158805797L), new System.Numerics.BigInteger(806522039354160013L), new System.Numerics.BigInteger(9518451126311301L), }, }, { { new System.Numerics.BigInteger(1936001550198038463L), new System.Numerics.BigInteger(1846326978535296134L), new System.Numerics.BigInteger(1360976408059619652L), }, { new System.Numerics.BigInteger(8937609749764349216L), new System.Numerics.BigInteger(5601997391344991242L), new System.Numerics.BigInteger(4717926789587550602L), }, { new System.Numerics.BigInteger(3770073517926210073L), new System.Numerics.BigInteger(6482571429191121353L), new System.Numerics.BigInteger(2141201310031514167L), }, }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 87,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8849560094581851837L), new System.Numerics.BigInteger(1488888336923988317L), new System.Numerics.BigInteger(4521879588714602531L), }, { new System.Numerics.BigInteger(5368856925651739934L), new System.Numerics.BigInteger(2950169371063453520L), new System.Numerics.BigInteger(5451520454714378783L), }, { new System.Numerics.BigInteger(8815352466056759483L), new System.Numerics.BigInteger(529009004884233920L), new System.Numerics.BigInteger(6388841780707430400L), }, }, { { new System.Numerics.BigInteger(7501932883536230507L), new System.Numerics.BigInteger(7178471723692069255L), new System.Numerics.BigInteger(1967182550373458291L), }, { new System.Numerics.BigInteger(866810880088922001L), new System.Numerics.BigInteger(3978438679306980077L), new System.Numerics.BigInteger(4515486522624682630L), }, { new System.Numerics.BigInteger(5794304854490494225L), new System.Numerics.BigInteger(558048907537618693L), new System.Numerics.BigInteger(8638786374945550218L), }, }, { { new System.Numerics.BigInteger(2865996923185155651L), new System.Numerics.BigInteger(7575098504677965422L), new System.Numerics.BigInteger(5874793314132910388L), }, { new System.Numerics.BigInteger(4140523384953645616L), new System.Numerics.BigInteger(4251286438872291364L), new System.Numerics.BigInteger(2165090679240869353L), }, { new System.Numerics.BigInteger(8694396393309186665L), new System.Numerics.BigInteger(5116121632301979716L), new System.Numerics.BigInteger(2413066700469103186L), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8862743388613321997L), new System.Numerics.BigInteger(8968474222138041793L), new System.Numerics.BigInteger(7629510208960579290L), }, { new System.Numerics.BigInteger(1732627277554298555L), new System.Numerics.BigInteger(120333927402386578L), new System.Numerics.BigInteger(1867216471715125132L), }, { new System.Numerics.BigInteger(6482017672719162305L), new System.Numerics.BigInteger(3245820293321201493L), new System.Numerics.BigInteger(7959402533629399128L), }, }, { { new System.Numerics.BigInteger(849585592318655505L), new System.Numerics.BigInteger(5726716924498885526L), new System.Numerics.BigInteger(2485025491357314465L), }, { new System.Numerics.BigInteger(214374076584656366L), new System.Numerics.BigInteger(196509790672769356L), new System.Numerics.BigInteger(7618059551094720020L), }, { new System.Numerics.BigInteger(1726501082117615006L), new System.Numerics.BigInteger(4850062248049388066L), new System.Numerics.BigInteger(6765558079457603106L), }, }, { { new System.Numerics.BigInteger(5044270766859021947L), new System.Numerics.BigInteger(2527393568348728038L), new System.Numerics.BigInteger(3941085902801369340L), }, { new System.Numerics.BigInteger(1394094953222802049L), new System.Numerics.BigInteger(3369059818185687267L), new System.Numerics.BigInteger(2541540732415877972L), }, { new System.Numerics.BigInteger(735805161943525850L), new System.Numerics.BigInteger(3289043149716063371L), new System.Numerics.BigInteger(5569258580235230175L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 62,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1969771183790255523L), new System.Numerics.BigInteger(3331803948940275722L), new System.Numerics.BigInteger(406229158397609370L), }, { new System.Numerics.BigInteger(3726806985067808112L), new System.Numerics.BigInteger(4202520672854158053L), new System.Numerics.BigInteger(5262820220274064723L), }, { new System.Numerics.BigInteger(5552693880747506897L), new System.Numerics.BigInteger(4087873072169258557L), new System.Numerics.BigInteger(4415995069771204490L), }, }, { { new System.Numerics.BigInteger(9111561717424483783L), new System.Numerics.BigInteger(5155867970615830941L), new System.Numerics.BigInteger(5272424175601744863L), }, { new System.Numerics.BigInteger(2254478179560501137L), new System.Numerics.BigInteger(5717768930014139588L), new System.Numerics.BigInteger(2631978655995514165L), }, { new System.Numerics.BigInteger(1791969986383324409L), new System.Numerics.BigInteger(7867054456275157461L), new System.Numerics.BigInteger(7763736186318494320L), }, }, { { new System.Numerics.BigInteger(8189674694951495129L), new System.Numerics.BigInteger(248972826688262240L), new System.Numerics.BigInteger(1321082923254338408L), }, { new System.Numerics.BigInteger(5432494514111408186L), new System.Numerics.BigInteger(5082281009636264921L), new System.Numerics.BigInteger(5029420707516222636L), }, { new System.Numerics.BigInteger(785256217819152088L), new System.Numerics.BigInteger(3155621310300653288L), new System.Numerics.BigInteger(7517634089696630434L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6247929350484927498L), new System.Numerics.BigInteger(3048704695086942917L), new System.Numerics.BigInteger(1646319895971591944L), }, { new System.Numerics.BigInteger(3468776135042868025L), new System.Numerics.BigInteger(6734382593637390408L), new System.Numerics.BigInteger(982153630445404497L), }, { new System.Numerics.BigInteger(7522219511283234619L), new System.Numerics.BigInteger(14360637822389474L), new System.Numerics.BigInteger(4853537737978090043L), }, }, { { new System.Numerics.BigInteger(157257081191380523L), new System.Numerics.BigInteger(5452114428681466624L), new System.Numerics.BigInteger(3744201221175216431L), }, { new System.Numerics.BigInteger(1076357839514298657L), new System.Numerics.BigInteger(617225410156928773L), new System.Numerics.BigInteger(4004347715947916793L), }, { new System.Numerics.BigInteger(7077910778606409779L), new System.Numerics.BigInteger(6576846294257157336L), new System.Numerics.BigInteger(6216006179730733320L), }, }, { { new System.Numerics.BigInteger(8094535654756244867L), new System.Numerics.BigInteger(8343004254991447191L), new System.Numerics.BigInteger(8568430608411855784L), }, { new System.Numerics.BigInteger(2317422164741875825L), new System.Numerics.BigInteger(7164522166874333680L), new System.Numerics.BigInteger(8094054223120422489L), }, { new System.Numerics.BigInteger(3250614113086352824L), new System.Numerics.BigInteger(1824884635790873021L), new System.Numerics.BigInteger(6387012473242104477L), }, }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8712832882150940885L), new System.Numerics.BigInteger(4766064588433379567L), new System.Numerics.BigInteger(5970408025959361872L), }, { new System.Numerics.BigInteger(8845869416473452777L), new System.Numerics.BigInteger(8034837600270548712L), new System.Numerics.BigInteger(64968112629805664L), }, { new System.Numerics.BigInteger(7962833760027063191L), new System.Numerics.BigInteger(7704921752992504153L), new System.Numerics.BigInteger(1392430398274452711L), }, }, { { new System.Numerics.BigInteger(4476246985629186990L), new System.Numerics.BigInteger(1859439486798485418L), new System.Numerics.BigInteger(2904065107882557430L), }, { new System.Numerics.BigInteger(1221232120505579883L), new System.Numerics.BigInteger(6573864960668595609L), new System.Numerics.BigInteger(5641417447908931422L), }, { new System.Numerics.BigInteger(1982161524583558532L), new System.Numerics.BigInteger(8328878761876978862L), new System.Numerics.BigInteger(8631673329516125299L), }, }, { { new System.Numerics.BigInteger(6094511357092343219L), new System.Numerics.BigInteger(5789229454984826442L), new System.Numerics.BigInteger(6601677217980479778L), }, { new System.Numerics.BigInteger(7226102431616613944L), new System.Numerics.BigInteger(7276644477790602302L), new System.Numerics.BigInteger(626069045546161101L), }, { new System.Numerics.BigInteger(3611931868869252910L), new System.Numerics.BigInteger(5859648205486552653L), new System.Numerics.BigInteger(2716446049181819979L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(7836037020805880756L), new System.Numerics.BigInteger(8087722820867026500L), new System.Numerics.BigInteger(463615348940354567L), }, { new System.Numerics.BigInteger(722052794216913779L), new System.Numerics.BigInteger(3938513283840045718L), new System.Numerics.BigInteger(1203342199859682593L), }, { new System.Numerics.BigInteger(5935488967042254632L), new System.Numerics.BigInteger(1971868190633559200L), new System.Numerics.BigInteger(6726685899605446113L), }, }, { { new System.Numerics.BigInteger(3548494458611658986L), new System.Numerics.BigInteger(5927835107170756032L), new System.Numerics.BigInteger(4264920795996702147L), }, { new System.Numerics.BigInteger(8941912641897364868L), new System.Numerics.BigInteger(4506141514943126197L), new System.Numerics.BigInteger(8385330018556474878L), }, { new System.Numerics.BigInteger(1361740207490163526L), new System.Numerics.BigInteger(3707435103273381559L), new System.Numerics.BigInteger(931358598084982728L), }, }, { { new System.Numerics.BigInteger(4024483762433612632L), new System.Numerics.BigInteger(4597769509030573487L), new System.Numerics.BigInteger(4087884293649640934L), }, { new System.Numerics.BigInteger(8277669296294523769L), new System.Numerics.BigInteger(1066024324534207871L), new System.Numerics.BigInteger(8137196586734752003L), }, { new System.Numerics.BigInteger(7753002775583451639L), new System.Numerics.BigInteger(8926456651785286942L), new System.Numerics.BigInteger(6267251940957355187L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 110,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6898283817691823411L), new System.Numerics.BigInteger(6165761409997022844L), new System.Numerics.BigInteger(4207584178758006023L), }, { new System.Numerics.BigInteger(2887597418744013056L), new System.Numerics.BigInteger(6525113901196110887L), new System.Numerics.BigInteger(8116586641436249289L), }, { new System.Numerics.BigInteger(5213699237214432055L), new System.Numerics.BigInteger(9073706245969131379L), new System.Numerics.BigInteger(6734270067025590112L), }, }, { { new System.Numerics.BigInteger(8528292045879678015L), new System.Numerics.BigInteger(6030273289896063153L), new System.Numerics.BigInteger(166121163942229508L), }, { new System.Numerics.BigInteger(7537025990793962858L), new System.Numerics.BigInteger(5124966912531594464L), new System.Numerics.BigInteger(2549345353684297070L), }, { new System.Numerics.BigInteger(7908569361313079734L), new System.Numerics.BigInteger(7015059616514923016L), new System.Numerics.BigInteger(4692389631804263339L), }, }, { { new System.Numerics.BigInteger(3828084090567865633L), new System.Numerics.BigInteger(6087062098024929960L), new System.Numerics.BigInteger(4731735002786331572L), }, { new System.Numerics.BigInteger(7268119658816997222L), new System.Numerics.BigInteger(1314408187077850063L), new System.Numerics.BigInteger(4008162585736740710L), }, { new System.Numerics.BigInteger(3921363171248367748L), new System.Numerics.BigInteger(2329526631764243501L), new System.Numerics.BigInteger(5831665703715328565L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3520129309905370783L), new System.Numerics.BigInteger(7434762070603416733L), new System.Numerics.BigInteger(1906047112146950603L), }, { new System.Numerics.BigInteger(7752963613943006427L), new System.Numerics.BigInteger(6290122794633750088L), new System.Numerics.BigInteger(5375785432117085906L), }, { new System.Numerics.BigInteger(2968602779861215118L), new System.Numerics.BigInteger(5183664429302949487L), new System.Numerics.BigInteger(4971440424621877641L), }, }, { { new System.Numerics.BigInteger(8041009162820224533L), new System.Numerics.BigInteger(8677205062163556267L), new System.Numerics.BigInteger(8587117759853332830L), }, { new System.Numerics.BigInteger(1051554990489407817L), new System.Numerics.BigInteger(1801124523572646868L), new System.Numerics.BigInteger(6124768169562077127L), }, { new System.Numerics.BigInteger(5740224248695175736L), new System.Numerics.BigInteger(2877957087901771942L), new System.Numerics.BigInteger(558974735453267256L), }, }, { { new System.Numerics.BigInteger(7456390537408585841L), new System.Numerics.BigInteger(8953345597102418676L), new System.Numerics.BigInteger(3832263441298549830L), }, { new System.Numerics.BigInteger(4987402486803174890L), new System.Numerics.BigInteger(6034569173642870151L), new System.Numerics.BigInteger(8568508006055389543L), }, { new System.Numerics.BigInteger(4259192281805805221L), new System.Numerics.BigInteger(4410343006364789133L), new System.Numerics.BigInteger(5576807886516345717L), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1257532585579769791L), new System.Numerics.BigInteger(5064132659786850286L), new System.Numerics.BigInteger(4874186402108746775L), }, { new System.Numerics.BigInteger(4029362437887354423L), new System.Numerics.BigInteger(5703704615712296119L), new System.Numerics.BigInteger(1738950958547227164L), }, { new System.Numerics.BigInteger(8668316889128176888L), new System.Numerics.BigInteger(9166647005926705865L), new System.Numerics.BigInteger(8329253222889621314L), }, }, { { new System.Numerics.BigInteger(2506790414540798484L), new System.Numerics.BigInteger(816612870809874340L), new System.Numerics.BigInteger(8053291587494752139L), }, { new System.Numerics.BigInteger(8308332963822618007L), new System.Numerics.BigInteger(4018520663353589435L), new System.Numerics.BigInteger(3587230327336927688L), }, { new System.Numerics.BigInteger(2057741566234768908L), new System.Numerics.BigInteger(82470893723350014L), new System.Numerics.BigInteger(3926940816225537220L), }, }, { { new System.Numerics.BigInteger(279670262657780570L), new System.Numerics.BigInteger(2771050459736751146L), new System.Numerics.BigInteger(2857168833157398809L), }, { new System.Numerics.BigInteger(1736579616271264804L), new System.Numerics.BigInteger(7005690275347997542L), new System.Numerics.BigInteger(8193532991083340106L), }, { new System.Numerics.BigInteger(717937366354219954L), new System.Numerics.BigInteger(1332812339432997192L), new System.Numerics.BigInteger(4432246365195413664L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 115,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2882040177572957272L), new System.Numerics.BigInteger(4323129752517962624L), new System.Numerics.BigInteger(1566958871822154927L), }, { new System.Numerics.BigInteger(1894831076829795953L), new System.Numerics.BigInteger(3068737363607029961L), new System.Numerics.BigInteger(2002307004539450509L), }, { new System.Numerics.BigInteger(3222778108085310342L), new System.Numerics.BigInteger(5630970030078666636L), new System.Numerics.BigInteger(4334564083754500181L), }, }, { { new System.Numerics.BigInteger(6612367535917276859L), new System.Numerics.BigInteger(1271505822364713722L), new System.Numerics.BigInteger(2459165263109818958L), }, { new System.Numerics.BigInteger(1250730628224528623L), new System.Numerics.BigInteger(2920043621873012096L), new System.Numerics.BigInteger(7252419757065149141L), }, { new System.Numerics.BigInteger(2818065487860677125L), new System.Numerics.BigInteger(6885798869664232025L), new System.Numerics.BigInteger(2824241424766413890L), }, }, { { new System.Numerics.BigInteger(6102070228066600335L), new System.Numerics.BigInteger(714522256934480317L), new System.Numerics.BigInteger(2358970214917717707L), }, { new System.Numerics.BigInteger(1873517638265474736L), new System.Numerics.BigInteger(4275685413178265761L), new System.Numerics.BigInteger(1080060663048160856L), }, { new System.Numerics.BigInteger(2964617988225692939L), new System.Numerics.BigInteger(5105720841465916585L), new System.Numerics.BigInteger(252601256635773756L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6306507056906777877L), new System.Numerics.BigInteger(699249141177214763L), new System.Numerics.BigInteger(2638866912230527863L), }, { new System.Numerics.BigInteger(9022614989377967227L), new System.Numerics.BigInteger(5496375081108584586L), new System.Numerics.BigInteger(4499049435550194369L), }, { new System.Numerics.BigInteger(5425062227673646093L), new System.Numerics.BigInteger(5727266172328036232L), new System.Numerics.BigInteger(8296129477744205826L), }, }, { { new System.Numerics.BigInteger(312996136212154460L), new System.Numerics.BigInteger(2222157388406736976L), new System.Numerics.BigInteger(3884442653342823340L), }, { new System.Numerics.BigInteger(5814314405199715879L), new System.Numerics.BigInteger(5629352114992720033L), new System.Numerics.BigInteger(1154681774416869403L), }, { new System.Numerics.BigInteger(3559458189733797973L), new System.Numerics.BigInteger(6957643561292574374L), new System.Numerics.BigInteger(1941154804960533911L), }, }, { { new System.Numerics.BigInteger(2045997262649938364L), new System.Numerics.BigInteger(9136560879981000231L), new System.Numerics.BigInteger(1829848380329071751L), }, { new System.Numerics.BigInteger(8819640453592882648L), new System.Numerics.BigInteger(7720106142134646880L), new System.Numerics.BigInteger(1575142154751943836L), }, { new System.Numerics.BigInteger(2422669001226249179L), new System.Numerics.BigInteger(8748652051856470931L), new System.Numerics.BigInteger(7457173168416312326L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 122,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(5376732513636477824L), new System.Numerics.BigInteger(4595282972629878421L), new System.Numerics.BigInteger(5006000442565337645L), }, { new System.Numerics.BigInteger(8285227549307098833L), new System.Numerics.BigInteger(2065128829498718528L), new System.Numerics.BigInteger(4183788540744836646L), }, { new System.Numerics.BigInteger(730438299510531560L), new System.Numerics.BigInteger(8327964775182828662L), new System.Numerics.BigInteger(6500764886256058763L), }, }, { { new System.Numerics.BigInteger(6478080953329949550L), new System.Numerics.BigInteger(8188259493384622987L), new System.Numerics.BigInteger(7211998896161137213L), }, { new System.Numerics.BigInteger(5129903864911187628L), new System.Numerics.BigInteger(6677207535985772804L), new System.Numerics.BigInteger(6304044723040858171L), }, { new System.Numerics.BigInteger(1596120325986948981L), new System.Numerics.BigInteger(957433932022656651L), new System.Numerics.BigInteger(5107064231566432526L), }, }, { { new System.Numerics.BigInteger(3935741992465470649L), new System.Numerics.BigInteger(5444620315043057942L), new System.Numerics.BigInteger(7919294297088835097L), }, { new System.Numerics.BigInteger(4827081458185295324L), new System.Numerics.BigInteger(6051998802328749260L), new System.Numerics.BigInteger(7262385062895854124L), }, { new System.Numerics.BigInteger(1312150132207271115L), new System.Numerics.BigInteger(2864245588829087981L), new System.Numerics.BigInteger(8715709786097716881L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3604727891525873410L), new System.Numerics.BigInteger(7644473723259705467L), new System.Numerics.BigInteger(656232179486564231L), }, { new System.Numerics.BigInteger(3852770547330594430L), new System.Numerics.BigInteger(4190132864798626049L), new System.Numerics.BigInteger(6219351043746079837L), }, { new System.Numerics.BigInteger(7442676902227878042L), new System.Numerics.BigInteger(4129924793856286961L), new System.Numerics.BigInteger(313806930045986648L), }, }, { { new System.Numerics.BigInteger(3607434664913583513L), new System.Numerics.BigInteger(6275873736881781189L), new System.Numerics.BigInteger(676007699757793127L), }, { new System.Numerics.BigInteger(1538642434088583043L), new System.Numerics.BigInteger(8698801460839261244L), new System.Numerics.BigInteger(593361096738639516L), }, { new System.Numerics.BigInteger(5014577827501755878L), new System.Numerics.BigInteger(2202772090590853544L), new System.Numerics.BigInteger(8871961005510768673L), }, }, { { new System.Numerics.BigInteger(6564483164532534601L), new System.Numerics.BigInteger(3928571676344086493L), new System.Numerics.BigInteger(7835696532236325983L), }, { new System.Numerics.BigInteger(7428544591100450351L), new System.Numerics.BigInteger(1600984506472210486L), new System.Numerics.BigInteger(5857819426013636754L), }, { new System.Numerics.BigInteger(7932752350782567713L), new System.Numerics.BigInteger(4206930290068491950L), new System.Numerics.BigInteger(5470928100146914602L), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2372053316785650867L), new System.Numerics.BigInteger(3287101103316582580L), new System.Numerics.BigInteger(8406017942149867096L), }, { new System.Numerics.BigInteger(108446258987180173L), new System.Numerics.BigInteger(8298713988016815818L), new System.Numerics.BigInteger(3405527737346292302L), }, { new System.Numerics.BigInteger(6014337802417573048L), new System.Numerics.BigInteger(8147538603235686753L), new System.Numerics.BigInteger(6275381625294581356L), }, }, { { new System.Numerics.BigInteger(7803868044539189174L), new System.Numerics.BigInteger(8167436710261587304L), new System.Numerics.BigInteger(2921745303874808834L), }, { new System.Numerics.BigInteger(5831018228991091184L), new System.Numerics.BigInteger(5684367108655611194L), new System.Numerics.BigInteger(6352751274315889080L), }, { new System.Numerics.BigInteger(3962844945783126088L), new System.Numerics.BigInteger(7160184471022496653L), new System.Numerics.BigInteger(2892845516376378620L), }, }, { { new System.Numerics.BigInteger(7899490158637421856L), new System.Numerics.BigInteger(8193266707005055500L), new System.Numerics.BigInteger(76617919892216358L), }, { new System.Numerics.BigInteger(8398424401434676502L), new System.Numerics.BigInteger(2189675832214280449L), new System.Numerics.BigInteger(5958747050411912476L), }, { new System.Numerics.BigInteger(2753936362441201433L), new System.Numerics.BigInteger(7740183028920032858L), new System.Numerics.BigInteger(5189113475873493025L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 123,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(5688868620901472852L), new System.Numerics.BigInteger(96983832116630616L), new System.Numerics.BigInteger(7859937069360318717L), }, { new System.Numerics.BigInteger(1648293002365758379L), new System.Numerics.BigInteger(1007675938646511937L), new System.Numerics.BigInteger(5228548285705906004L), }, { new System.Numerics.BigInteger(5447401086051126190L), new System.Numerics.BigInteger(7067894465655392013L), new System.Numerics.BigInteger(3352020822845672654L), }, }, { { new System.Numerics.BigInteger(7038224180573083242L), new System.Numerics.BigInteger(6054590831987319112L), new System.Numerics.BigInteger(5100990768850658458L), }, { new System.Numerics.BigInteger(6430385761624082476L), new System.Numerics.BigInteger(4582781794184227031L), new System.Numerics.BigInteger(4192383931735946983L), }, { new System.Numerics.BigInteger(2165240322922285410L), new System.Numerics.BigInteger(2924998914293706434L), new System.Numerics.BigInteger(6220883890719873783L), }, }, { { new System.Numerics.BigInteger(1869816631242980601L), new System.Numerics.BigInteger(3519959556034367754L), new System.Numerics.BigInteger(7540161703492758656L), }, { new System.Numerics.BigInteger(2559517683902681046L), new System.Numerics.BigInteger(6591646363016786756L), new System.Numerics.BigInteger(337823444357397575L), }, { new System.Numerics.BigInteger(6477493247915938876L), new System.Numerics.BigInteger(3734516347033158415L), new System.Numerics.BigInteger(17083967119533404L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8249623216191098978L), new System.Numerics.BigInteger(1091311706052941805L), new System.Numerics.BigInteger(893851232226723506L), }, { new System.Numerics.BigInteger(3670111612260562956L), new System.Numerics.BigInteger(6556976915981430932L), new System.Numerics.BigInteger(1321228720744554522L), }, { new System.Numerics.BigInteger(4340393560113019925L), new System.Numerics.BigInteger(7469206248374386221L), new System.Numerics.BigInteger(8493044302628195184L), }, }, { { new System.Numerics.BigInteger(4005029757214303458L), new System.Numerics.BigInteger(6187902795069107319L), new System.Numerics.BigInteger(7648755908533407805L), }, { new System.Numerics.BigInteger(2053009211348520714L), new System.Numerics.BigInteger(6473934677843444126L), new System.Numerics.BigInteger(6402107145746467145L), }, { new System.Numerics.BigInteger(8358678269966704650L), new System.Numerics.BigInteger(4163132670292639648L), new System.Numerics.BigInteger(3111793284055203213L), }, }, { { new System.Numerics.BigInteger(4585176644485876812L), new System.Numerics.BigInteger(5015465752414304572L), new System.Numerics.BigInteger(5381044127966948022L), }, { new System.Numerics.BigInteger(3581352294383484285L), new System.Numerics.BigInteger(3649002387347622205L), new System.Numerics.BigInteger(8011632797630307169L), }, { new System.Numerics.BigInteger(4042179451581887060L), new System.Numerics.BigInteger(6403321614495709551L), new System.Numerics.BigInteger(5306145763623999256L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2418560555524489566L), new System.Numerics.BigInteger(3719849857504198133L), new System.Numerics.BigInteger(3104537937323391926L), }, { new System.Numerics.BigInteger(8954941600047271403L), new System.Numerics.BigInteger(2316539859640701187L), new System.Numerics.BigInteger(8138782900188722384L), }, { new System.Numerics.BigInteger(5685879649162926559L), new System.Numerics.BigInteger(1611534995017590193L), new System.Numerics.BigInteger(4228571905314178077L), }, }, { { new System.Numerics.BigInteger(2523337644342640721L), new System.Numerics.BigInteger(5707184627042390506L), new System.Numerics.BigInteger(8345978928164026247L), }, { new System.Numerics.BigInteger(2738647632016864253L), new System.Numerics.BigInteger(6391418560084610906L), new System.Numerics.BigInteger(3217379974304408394L), }, { new System.Numerics.BigInteger(785972964816278038L), new System.Numerics.BigInteger(7297717149615786132L), new System.Numerics.BigInteger(7948765954603954181L), }, }, { { new System.Numerics.BigInteger(1854146676990034410L), new System.Numerics.BigInteger(4772561586946845583L), new System.Numerics.BigInteger(5348965855538818752L), }, { new System.Numerics.BigInteger(847660825110127921L), new System.Numerics.BigInteger(7195632372929342428L), new System.Numerics.BigInteger(7419013811861979368L), }, { new System.Numerics.BigInteger(5579689257627684255L), new System.Numerics.BigInteger(5032736979250369356L), new System.Numerics.BigInteger(5906202699000045989L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(4086105716767472701L), new System.Numerics.BigInteger(1497414871853004571L), new System.Numerics.BigInteger(7500137530016386226L), }, { new System.Numerics.BigInteger(7196889970508835325L), new System.Numerics.BigInteger(2502628309022016983L), new System.Numerics.BigInteger(2408179319243262955L), }, { new System.Numerics.BigInteger(8540386855156444543L), new System.Numerics.BigInteger(4264370169039679835L), new System.Numerics.BigInteger(8400701801107079922L), }, }, { { new System.Numerics.BigInteger(3574525862525577652L), new System.Numerics.BigInteger(8162536526851944547L), new System.Numerics.BigInteger(7308288266258404060L), }, { new System.Numerics.BigInteger(732378760725870590L), new System.Numerics.BigInteger(294368913585019694L), new System.Numerics.BigInteger(4702093896522579250L), }, { new System.Numerics.BigInteger(6641464028238553932L), new System.Numerics.BigInteger(3620657018938674175L), new System.Numerics.BigInteger(1464435841273438324L), }, }, { { new System.Numerics.BigInteger(3390568659110285074L), new System.Numerics.BigInteger(6538354233373793883L), new System.Numerics.BigInteger(4126229706839129773L), }, { new System.Numerics.BigInteger(1688963482445408928L), new System.Numerics.BigInteger(8980164883952444553L), new System.Numerics.BigInteger(4859915728308523365L), }, { new System.Numerics.BigInteger(6317760911164488052L), new System.Numerics.BigInteger(488043302567345382L), new System.Numerics.BigInteger(6361776561954012363L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(5762438910326040559L), new System.Numerics.BigInteger(1055420922784560540L), new System.Numerics.BigInteger(2357949077731102815L), }, { new System.Numerics.BigInteger(2236187150227661415L), new System.Numerics.BigInteger(8172979560861142311L), new System.Numerics.BigInteger(4366977962061857866L), }, { new System.Numerics.BigInteger(2514668290366943664L), new System.Numerics.BigInteger(2698429616975212809L), new System.Numerics.BigInteger(8129756997083446118L), }, }, { { new System.Numerics.BigInteger(3068652847134052824L), new System.Numerics.BigInteger(86007536742771083L), new System.Numerics.BigInteger(4365220432083323034L), }, { new System.Numerics.BigInteger(2887552007988913946L), new System.Numerics.BigInteger(6964583419092218070L), new System.Numerics.BigInteger(2057753708821108490L), }, { new System.Numerics.BigInteger(7682724875692298006L), new System.Numerics.BigInteger(143978761477279773L), new System.Numerics.BigInteger(5708910605477122265L), }, }, { { new System.Numerics.BigInteger(2407858914253100945L), new System.Numerics.BigInteger(3806198778190438871L), new System.Numerics.BigInteger(8921023883739188093L), }, { new System.Numerics.BigInteger(4174908717790375730L), new System.Numerics.BigInteger(6219354177777686211L), new System.Numerics.BigInteger(4005431680390536390L), }, { new System.Numerics.BigInteger(8632504483725649092L), new System.Numerics.BigInteger(7264640600116257155L), new System.Numerics.BigInteger(7469233441030125326L), }, }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3751879928898888445L), new System.Numerics.BigInteger(4434881234914633657L), new System.Numerics.BigInteger(5232571810133108478L), }, { new System.Numerics.BigInteger(2345032697845235315L), new System.Numerics.BigInteger(6705094196760466701L), new System.Numerics.BigInteger(6508409915586193571L), }, { new System.Numerics.BigInteger(8969318642870706240L), new System.Numerics.BigInteger(5264603421003841692L), new System.Numerics.BigInteger(7870845831943837375L), }, }, { { new System.Numerics.BigInteger(5739958496360658596L), new System.Numerics.BigInteger(7629110921937262070L), new System.Numerics.BigInteger(3929269732719865108L), }, { new System.Numerics.BigInteger(1063579843901423132L), new System.Numerics.BigInteger(3698498415856650995L), new System.Numerics.BigInteger(2074706884584974923L), }, { new System.Numerics.BigInteger(1129324119694601378L), new System.Numerics.BigInteger(4847586277556322682L), new System.Numerics.BigInteger(4273589031134397845L), }, }, { { new System.Numerics.BigInteger(6902199893589661298L), new System.Numerics.BigInteger(2401006512973174865L), new System.Numerics.BigInteger(3502501110773152531L), }, { new System.Numerics.BigInteger(7849878900994372372L), new System.Numerics.BigInteger(3836047598704940138L), new System.Numerics.BigInteger(2937772318850510747L), }, { new System.Numerics.BigInteger(6293232681458588457L), new System.Numerics.BigInteger(6027310936622443902L), new System.Numerics.BigInteger(7247718569697794868L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 138,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(470592655370445035L), new System.Numerics.BigInteger(1997651451524068981L), new System.Numerics.BigInteger(2046154418657920687L), }, { new System.Numerics.BigInteger(3970692241269024760L), new System.Numerics.BigInteger(3794071984068526410L), new System.Numerics.BigInteger(4158216198682943513L), }, { new System.Numerics.BigInteger(4448533239202262849L), new System.Numerics.BigInteger(4371310577124755459L), new System.Numerics.BigInteger(5875044165149426568L), }, }, { { new System.Numerics.BigInteger(2825161467189818010L), new System.Numerics.BigInteger(3235052473328814959L), new System.Numerics.BigInteger(1661486545576629328L), }, { new System.Numerics.BigInteger(6157078850640765480L), new System.Numerics.BigInteger(2099245644943953278L), new System.Numerics.BigInteger(5197237941223686663L), }, { new System.Numerics.BigInteger(4128046660094528186L), new System.Numerics.BigInteger(4531175250698404872L), new System.Numerics.BigInteger(2467815488026319014L), }, }, { { new System.Numerics.BigInteger(6441494911448389877L), new System.Numerics.BigInteger(8782649955755276108L), new System.Numerics.BigInteger(3024721853692629519L), }, { new System.Numerics.BigInteger(1918921859974825973L), new System.Numerics.BigInteger(7890596074687225412L), new System.Numerics.BigInteger(1738668506488643268L), }, { new System.Numerics.BigInteger(1707381684258754845L), new System.Numerics.BigInteger(5567806202342877976L), new System.Numerics.BigInteger(3576552738445501712L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(4282441730760551279L), new System.Numerics.BigInteger(5370829960503579922L), new System.Numerics.BigInteger(4289275483171471851L), }, { new System.Numerics.BigInteger(3525968940947499513L), new System.Numerics.BigInteger(5126665539666368836L), new System.Numerics.BigInteger(3330334247652085295L), }, { new System.Numerics.BigInteger(4326121627283666959L), new System.Numerics.BigInteger(5324776112710798684L), new System.Numerics.BigInteger(6744521451386284052L), }, }, { { new System.Numerics.BigInteger(6582156669828981547L), new System.Numerics.BigInteger(1275989968168362648L), new System.Numerics.BigInteger(1793799611680596218L), }, { new System.Numerics.BigInteger(4068494988262302539L), new System.Numerics.BigInteger(342730988369156568L), new System.Numerics.BigInteger(2130170463056396102L), }, { new System.Numerics.BigInteger(8373666130308130L), new System.Numerics.BigInteger(6127457345447762655L), new System.Numerics.BigInteger(962712694365409674L), }, }, { { new System.Numerics.BigInteger(141256681642126144L), new System.Numerics.BigInteger(2772860735730431881L), new System.Numerics.BigInteger(8351271896600657020L), }, { new System.Numerics.BigInteger(375167992335692675L), new System.Numerics.BigInteger(1244814508043580018L), new System.Numerics.BigInteger(5698990702266967082L), }, { new System.Numerics.BigInteger(7889572024526881976L), new System.Numerics.BigInteger(3059044081549263710L), new System.Numerics.BigInteger(8860772208253349435L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 146,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3007650797220115814L), new System.Numerics.BigInteger(3664520948347160973L), new System.Numerics.BigInteger(4764171819937650303L), }, { new System.Numerics.BigInteger(5301722228337190106L), new System.Numerics.BigInteger(9134734134278071424L), new System.Numerics.BigInteger(1713348527668158446L), }, { new System.Numerics.BigInteger(8837355545314608364L), new System.Numerics.BigInteger(3339688734086011257L), new System.Numerics.BigInteger(6325530034317806962L), }, }, { { new System.Numerics.BigInteger(6189122471052277668L), new System.Numerics.BigInteger(5130307532286082566L), new System.Numerics.BigInteger(2870308705557659912L), }, { new System.Numerics.BigInteger(8264990370711642160L), new System.Numerics.BigInteger(3398735605771902362L), new System.Numerics.BigInteger(4563144962002151888L), }, { new System.Numerics.BigInteger(9121096383571207507L), new System.Numerics.BigInteger(2538416081025084371L), new System.Numerics.BigInteger(1876429108344843933L), }, }, { { new System.Numerics.BigInteger(7238744492334747414L), new System.Numerics.BigInteger(699477229029552228L), new System.Numerics.BigInteger(3307598822280201768L), }, { new System.Numerics.BigInteger(1056434723353429051L), new System.Numerics.BigInteger(2907308109648242368L), new System.Numerics.BigInteger(963690207116853780L), }, { new System.Numerics.BigInteger(8714592034296807584L), new System.Numerics.BigInteger(6069471651024616704L), new System.Numerics.BigInteger(2836070407543423120L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(4781835848366336772L), new System.Numerics.BigInteger(5158027457141708036L), new System.Numerics.BigInteger(4060078118298088992L), }, { new System.Numerics.BigInteger(7105541220820812865L), new System.Numerics.BigInteger(4253734274824722253L), new System.Numerics.BigInteger(6270593012241734477L), }, { new System.Numerics.BigInteger(6716682737036344880L), new System.Numerics.BigInteger(3721894736741399084L), new System.Numerics.BigInteger(7146453724848047632L), }, }, { { new System.Numerics.BigInteger(5654031113054080515L), new System.Numerics.BigInteger(5619624507375214332L), new System.Numerics.BigInteger(5404411049110563944L), }, { new System.Numerics.BigInteger(1935567674404474364L), new System.Numerics.BigInteger(3816729330140326023L), new System.Numerics.BigInteger(7832770679153824566L), }, { new System.Numerics.BigInteger(3229373630159009302L), new System.Numerics.BigInteger(2960369668971822905L), new System.Numerics.BigInteger(7478532767321724047L), }, }, { { new System.Numerics.BigInteger(5818636434612879265L), new System.Numerics.BigInteger(4220305971318709101L), new System.Numerics.BigInteger(5904007263072513471L), }, { new System.Numerics.BigInteger(93011844567030159L), new System.Numerics.BigInteger(5270886589951134353L), new System.Numerics.BigInteger(9183507791995662509L), }, { new System.Numerics.BigInteger(3895154606783018369L), new System.Numerics.BigInteger(4652697533027502999L), new System.Numerics.BigInteger(3899172342438294740L), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(7979172886120683617L), new System.Numerics.BigInteger(2483052175588680306L), new System.Numerics.BigInteger(646288545920649292L), }, { new System.Numerics.BigInteger(3521652183494338536L), new System.Numerics.BigInteger(3610941808121199683L), new System.Numerics.BigInteger(6373158267959828420L), }, { new System.Numerics.BigInteger(7367925843039730018L), new System.Numerics.BigInteger(7778574403989655973L), new System.Numerics.BigInteger(2421311036683418704L), }, }, { { new System.Numerics.BigInteger(820824664899519271L), new System.Numerics.BigInteger(607670178876875788L), new System.Numerics.BigInteger(4491677069176139242L), }, { new System.Numerics.BigInteger(1746970755581383789L), new System.Numerics.BigInteger(8859240631234107177L), new System.Numerics.BigInteger(4513369034389796375L), }, { new System.Numerics.BigInteger(4500579275945591563L), new System.Numerics.BigInteger(7189168819549615855L), new System.Numerics.BigInteger(8592552579775575049L), }, }, { { new System.Numerics.BigInteger(1423438858394098952L), new System.Numerics.BigInteger(3711266264524671239L), new System.Numerics.BigInteger(6736216726332804689L), }, { new System.Numerics.BigInteger(2697979156431223875L), new System.Numerics.BigInteger(2953451414108708707L), new System.Numerics.BigInteger(152619035677035429L), }, { new System.Numerics.BigInteger(6310878492516114326L), new System.Numerics.BigInteger(9112149150844543120L), new System.Numerics.BigInteger(2522216662776721L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6774177109887178965L), new System.Numerics.BigInteger(7617734346553931035L), new System.Numerics.BigInteger(2478253183548215424L), }, { new System.Numerics.BigInteger(2787465578671952839L), new System.Numerics.BigInteger(1361839598635916910L), new System.Numerics.BigInteger(9078545899308398302L), }, { new System.Numerics.BigInteger(2306939514977419696L), new System.Numerics.BigInteger(304848865629413095L), new System.Numerics.BigInteger(4871201642890325142L), }, }, { { new System.Numerics.BigInteger(1937916302137801845L), new System.Numerics.BigInteger(3535637746906213914L), new System.Numerics.BigInteger(8771015600913082267L), }, { new System.Numerics.BigInteger(4461795973086775103L), new System.Numerics.BigInteger(348171873199148911L), new System.Numerics.BigInteger(6644695665386602087L), }, { new System.Numerics.BigInteger(5916077424774070764L), new System.Numerics.BigInteger(703503300379164319L), new System.Numerics.BigInteger(3996059452139519828L), }, }, { { new System.Numerics.BigInteger(6265306890301508937L), new System.Numerics.BigInteger(2231403387340727626L), new System.Numerics.BigInteger(4155460159456977077L), }, { new System.Numerics.BigInteger(3828802872404743680L), new System.Numerics.BigInteger(2979092432564683566L), new System.Numerics.BigInteger(9093571798585587702L), }, { new System.Numerics.BigInteger(2601707874550436222L), new System.Numerics.BigInteger(8338922474378608496L), new System.Numerics.BigInteger(4874260116001686587L), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 157,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(4259295069473909734L), new System.Numerics.BigInteger(603000625193744230L), new System.Numerics.BigInteger(5884354501460375338L), }, { new System.Numerics.BigInteger(7804806098193847341L), new System.Numerics.BigInteger(4777789268415024874L), new System.Numerics.BigInteger(3877738235396240063L), }, { new System.Numerics.BigInteger(3265413432212233703L), new System.Numerics.BigInteger(1874141867220524189L), new System.Numerics.BigInteger(979555133262403807L), }, }, { { new System.Numerics.BigInteger(2754037792436413282L), new System.Numerics.BigInteger(3990022721065255979L), new System.Numerics.BigInteger(2784415386809313204L), }, { new System.Numerics.BigInteger(5412431953597943030L), new System.Numerics.BigInteger(4509252192131686839L), new System.Numerics.BigInteger(2768601215836603334L), }, { new System.Numerics.BigInteger(5122725824368218404L), new System.Numerics.BigInteger(5461450922127577230L), new System.Numerics.BigInteger(2427243952533547248L), }, }, { { new System.Numerics.BigInteger(10353847562744990L), new System.Numerics.BigInteger(2518936735376446687L), new System.Numerics.BigInteger(4965885585285258759L), }, { new System.Numerics.BigInteger(4633657971298481753L), new System.Numerics.BigInteger(7656711423921513745L), new System.Numerics.BigInteger(2150442912503346725L), }, { new System.Numerics.BigInteger(1250236338536896597L), new System.Numerics.BigInteger(2599819594823665063L), new System.Numerics.BigInteger(5287423124471710756L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 78,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6025553505578929181L), new System.Numerics.BigInteger(3377945754494259584L), new System.Numerics.BigInteger(2946211362252414642L), }, { new System.Numerics.BigInteger(5590820326908587769L), new System.Numerics.BigInteger(1008585227973780359L), new System.Numerics.BigInteger(1142044496731492874L), }, { new System.Numerics.BigInteger(2131913589366578222L), new System.Numerics.BigInteger(8259020754247936755L), new System.Numerics.BigInteger(52335877921313218L), }, }, { { new System.Numerics.BigInteger(7475607058855580236L), new System.Numerics.BigInteger(1202766320353838855L), new System.Numerics.BigInteger(4160649016981823245L), }, { new System.Numerics.BigInteger(6566224797584127780L), new System.Numerics.BigInteger(3016926566704526713L), new System.Numerics.BigInteger(749283548252389802L), }, { new System.Numerics.BigInteger(2682776257666362509L), new System.Numerics.BigInteger(1061023368666676760L), new System.Numerics.BigInteger(7828710802633273605L), }, }, { { new System.Numerics.BigInteger(3114850318902970861L), new System.Numerics.BigInteger(4872931746722018094L), new System.Numerics.BigInteger(8393599738636101149L), }, { new System.Numerics.BigInteger(9153680915540893279L), new System.Numerics.BigInteger(3488829564803422476L), new System.Numerics.BigInteger(1030557707393053392L), }, { new System.Numerics.BigInteger(5829596561576627537L), new System.Numerics.BigInteger(8931247140317637515L), new System.Numerics.BigInteger(3591625707740144596L), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(2514857717864203610L), new System.Numerics.BigInteger(5073137357031664556L), new System.Numerics.BigInteger(2636557554240449203L), }, { new System.Numerics.BigInteger(3059375076533307740L), new System.Numerics.BigInteger(7073066095443618773L), new System.Numerics.BigInteger(7478559187280838744L), }, { new System.Numerics.BigInteger(6820920530216527599L), new System.Numerics.BigInteger(7133775946641216659L), new System.Numerics.BigInteger(4947513884747703406L), }, }, { { new System.Numerics.BigInteger(1467697091037198059L), new System.Numerics.BigInteger(5703375131058804147L), new System.Numerics.BigInteger(2487524851524693344L), }, { new System.Numerics.BigInteger(2822463439504973340L), new System.Numerics.BigInteger(915535809176704900L), new System.Numerics.BigInteger(8780594697915010662L), }, { new System.Numerics.BigInteger(633891885867586712L), new System.Numerics.BigInteger(7367323818645678617L), new System.Numerics.BigInteger(7497887524508808200L), }, }, { { new System.Numerics.BigInteger(4388463119154564699L), new System.Numerics.BigInteger(4476073315549520349L), new System.Numerics.BigInteger(5836859086043843090L), }, { new System.Numerics.BigInteger(459836549997474650L), new System.Numerics.BigInteger(430493226689940773L), new System.Numerics.BigInteger(3911528619746274665L), }, { new System.Numerics.BigInteger(2816845995901421180L), new System.Numerics.BigInteger(5753260545639259483L), new System.Numerics.BigInteger(4744114980361683092L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 158,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8458621398159677390L), new System.Numerics.BigInteger(4206875739171262999L), new System.Numerics.BigInteger(5937977324350551172L), }, { new System.Numerics.BigInteger(1296814084126736856L), new System.Numerics.BigInteger(5511318056420952695L), new System.Numerics.BigInteger(8161743684062103967L), }, { new System.Numerics.BigInteger(4162903000628804431L), new System.Numerics.BigInteger(4551104550000962735L), new System.Numerics.BigInteger(6087727790643653503L), }, }, { { new System.Numerics.BigInteger(8696918407509323359L), new System.Numerics.BigInteger(6969786856891355331L), new System.Numerics.BigInteger(6900655113992183742L), }, { new System.Numerics.BigInteger(3510593108551971967L), new System.Numerics.BigInteger(7419612555808174746L), new System.Numerics.BigInteger(1855962220678966974L), }, { new System.Numerics.BigInteger(3028726630609091102L), new System.Numerics.BigInteger(2174094798106199509L), new System.Numerics.BigInteger(5858543600176652371L), }, }, { { new System.Numerics.BigInteger(7328589120015328953L), new System.Numerics.BigInteger(7676435561380093454L), new System.Numerics.BigInteger(6475347768001700684L), }, { new System.Numerics.BigInteger(2952471599864977105L), new System.Numerics.BigInteger(5120343728069525188L), new System.Numerics.BigInteger(4546078078726910156L), }, { new System.Numerics.BigInteger(4141116073450149715L), new System.Numerics.BigInteger(8272781827426999530L), new System.Numerics.BigInteger(8136651352694353847L), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 161,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3731091665930942393L), new System.Numerics.BigInteger(2249144519068250407L), new System.Numerics.BigInteger(8371579965413508549L), }, { new System.Numerics.BigInteger(238170061468123709L), new System.Numerics.BigInteger(2441182367454721399L), new System.Numerics.BigInteger(5934357532854567270L), }, { new System.Numerics.BigInteger(561463416327905905L), new System.Numerics.BigInteger(839017879195790076L), new System.Numerics.BigInteger(1137007130044937456L), }, }, { { new System.Numerics.BigInteger(8628736094889015022L), new System.Numerics.BigInteger(7234831564184333203L), new System.Numerics.BigInteger(598979499939660895L), }, { new System.Numerics.BigInteger(5632521009359581885L), new System.Numerics.BigInteger(2854550665203507070L), new System.Numerics.BigInteger(8913126638598473694L), }, { new System.Numerics.BigInteger(8310695035899025947L), new System.Numerics.BigInteger(770386659604385705L), new System.Numerics.BigInteger(426339052652688209L), }, }, { { new System.Numerics.BigInteger(7301181953444938693L), new System.Numerics.BigInteger(336895138283249674L), new System.Numerics.BigInteger(1743122677702196865L), }, { new System.Numerics.BigInteger(2999564247810241168L), new System.Numerics.BigInteger(2007127929853708435L), new System.Numerics.BigInteger(5466622130769019915L), }, { new System.Numerics.BigInteger(6367708263653361679L), new System.Numerics.BigInteger(2634777335392607109L), new System.Numerics.BigInteger(5406620849500390108L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 79,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(304493527712658788L), new System.Numerics.BigInteger(2580473790214147577L), new System.Numerics.BigInteger(6951275643468817193L), }, { new System.Numerics.BigInteger(1045136919771948375L), new System.Numerics.BigInteger(1106485025416960629L), new System.Numerics.BigInteger(4469671952754967203L), }, { new System.Numerics.BigInteger(3426128548780025378L), new System.Numerics.BigInteger(5047146845695198743L), new System.Numerics.BigInteger(2038020418695441592L), }, }, { { new System.Numerics.BigInteger(517333825466099218L), new System.Numerics.BigInteger(3539208291404798961L), new System.Numerics.BigInteger(4633900277736342675L), }, { new System.Numerics.BigInteger(8499602394336246166L), new System.Numerics.BigInteger(8349530050215810948L), new System.Numerics.BigInteger(1788940314515258871L), }, { new System.Numerics.BigInteger(4342158424403302799L), new System.Numerics.BigInteger(867302681680849835L), new System.Numerics.BigInteger(8001078598887207771L), }, }, { { new System.Numerics.BigInteger(5723329368345623813L), new System.Numerics.BigInteger(807275722817400387L), new System.Numerics.BigInteger(5825754817316799163L), }, { new System.Numerics.BigInteger(5574783708483380847L), new System.Numerics.BigInteger(2034098363156059166L), new System.Numerics.BigInteger(8764791837107502863L), }, { new System.Numerics.BigInteger(1387895775499999268L), new System.Numerics.BigInteger(7499925247085582682L), new System.Numerics.BigInteger(6386773465445156254L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1874773349334627624L), new System.Numerics.BigInteger(8121452523472444108L), new System.Numerics.BigInteger(4634707427907304750L), }, { new System.Numerics.BigInteger(140620119094817455L), new System.Numerics.BigInteger(6991329198672719375L), new System.Numerics.BigInteger(5351499820349059268L), }, { new System.Numerics.BigInteger(6972771749084428139L), new System.Numerics.BigInteger(5027324613358056672L), new System.Numerics.BigInteger(1644148300578529306L), }, }, { { new System.Numerics.BigInteger(6701834841939635115L), new System.Numerics.BigInteger(688594684390988855L), new System.Numerics.BigInteger(2053094080908850641L), }, { new System.Numerics.BigInteger(3008165877472167541L), new System.Numerics.BigInteger(4655435349234991000L), new System.Numerics.BigInteger(1194624689068515722L), }, { new System.Numerics.BigInteger(2735557608208044830L), new System.Numerics.BigInteger(5500986383934306201L), new System.Numerics.BigInteger(5485551138234115390L), }, }, { { new System.Numerics.BigInteger(3998757260792912070L), new System.Numerics.BigInteger(4379152346145956255L), new System.Numerics.BigInteger(2136693507744041668L), }, { new System.Numerics.BigInteger(6829197847700193639L), new System.Numerics.BigInteger(3953044676555905125L), new System.Numerics.BigInteger(1774437166581260237L), }, { new System.Numerics.BigInteger(7661495147289012166L), new System.Numerics.BigInteger(7874899278987285015L), new System.Numerics.BigInteger(5399614349098396252L), }, }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(4820214085400094216L), new System.Numerics.BigInteger(6891171015741841026L), new System.Numerics.BigInteger(6465532999596205852L), }, { new System.Numerics.BigInteger(811655084988708835L), new System.Numerics.BigInteger(434609827487525613L), new System.Numerics.BigInteger(9071591325222035352L), }, { new System.Numerics.BigInteger(2287671252172513135L), new System.Numerics.BigInteger(3785204142709472853L), new System.Numerics.BigInteger(4936513113637787824L), }, }, { { new System.Numerics.BigInteger(7560213377296921957L), new System.Numerics.BigInteger(4584067136146537663L), new System.Numerics.BigInteger(44826369716498158L), }, { new System.Numerics.BigInteger(4824245538432186902L), new System.Numerics.BigInteger(4140725777435513123L), new System.Numerics.BigInteger(7412410463442091699L), }, { new System.Numerics.BigInteger(6742977083222125577L), new System.Numerics.BigInteger(6308270236017467948L), new System.Numerics.BigInteger(7947427077679382912L), }, }, { { new System.Numerics.BigInteger(731484400498908591L), new System.Numerics.BigInteger(4212389786750957841L), new System.Numerics.BigInteger(5317250549771399338L), }, { new System.Numerics.BigInteger(8214960679768322022L), new System.Numerics.BigInteger(7920573873239263467L), new System.Numerics.BigInteger(2979268217887894295L), }, { new System.Numerics.BigInteger(8159883567800094087L), new System.Numerics.BigInteger(3788885597060731200L), new System.Numerics.BigInteger(583608736981368127L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 169,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(3820161622332968725L), new System.Numerics.BigInteger(3531538275173109678L), new System.Numerics.BigInteger(6774410563282671955L), }, { new System.Numerics.BigInteger(8352434229379874695L), new System.Numerics.BigInteger(3505723095440992736L), new System.Numerics.BigInteger(162221110804755826L), }, { new System.Numerics.BigInteger(3533724366696022815L), new System.Numerics.BigInteger(1182056066352279114L), new System.Numerics.BigInteger(3809883393411639711L), }, }, { { new System.Numerics.BigInteger(7015392137714218864L), new System.Numerics.BigInteger(9170443599793333437L), new System.Numerics.BigInteger(8379525821221865239L), }, { new System.Numerics.BigInteger(3491017340797870523L), new System.Numerics.BigInteger(4106905904226571028L), new System.Numerics.BigInteger(6533166833570175633L), }, { new System.Numerics.BigInteger(2244053504592247976L), new System.Numerics.BigInteger(6670145623274760469L), new System.Numerics.BigInteger(20354891998823614L), }, }, { { new System.Numerics.BigInteger(6760043006630111851L), new System.Numerics.BigInteger(7631341486792794153L), new System.Numerics.BigInteger(4194844841670715714L), }, { new System.Numerics.BigInteger(1787034604069503646L), new System.Numerics.BigInteger(933930176682170331L), new System.Numerics.BigInteger(8163823049993016315L), }, { new System.Numerics.BigInteger(8407192260903668102L), new System.Numerics.BigInteger(5061664020006674338L), new System.Numerics.BigInteger(1401696153713126150L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(991044338033871173L), new System.Numerics.BigInteger(5726442624396147126L), new System.Numerics.BigInteger(6396527788279568097L), }, { new System.Numerics.BigInteger(8143341157296872873L), new System.Numerics.BigInteger(1517408335125803235L), new System.Numerics.BigInteger(5910069110117737655L), }, { new System.Numerics.BigInteger(3438894276190031561L), new System.Numerics.BigInteger(5063196775640586664L), new System.Numerics.BigInteger(7898197235409518439L), }, }, { { new System.Numerics.BigInteger(42951647368650569L), new System.Numerics.BigInteger(1620741353471707860L), new System.Numerics.BigInteger(5230099907246782712L), }, { new System.Numerics.BigInteger(1316871563995100484L), new System.Numerics.BigInteger(1715403214170760738L), new System.Numerics.BigInteger(72586939017264809L), }, { new System.Numerics.BigInteger(8178549185216075711L), new System.Numerics.BigInteger(1523344157767297448L), new System.Numerics.BigInteger(1516932554281060392L), }, }, { { new System.Numerics.BigInteger(7645345733753262273L), new System.Numerics.BigInteger(7624906273480624914L), new System.Numerics.BigInteger(4248579690929064000L), }, { new System.Numerics.BigInteger(516497460339543098L), new System.Numerics.BigInteger(5413522756789479457L), new System.Numerics.BigInteger(2140421514227276653L), }, { new System.Numerics.BigInteger(4933603993883267425L), new System.Numerics.BigInteger(3475650882532047136L), new System.Numerics.BigInteger(1109162197542749354L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 171,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1458795465520334548L), new System.Numerics.BigInteger(831973526726371394L), new System.Numerics.BigInteger(2798443082464937644L), }, { new System.Numerics.BigInteger(2267127353295357438L), new System.Numerics.BigInteger(6695396507287633044L), new System.Numerics.BigInteger(2098420597122615837L), }, { new System.Numerics.BigInteger(2657622580096953604L), new System.Numerics.BigInteger(1744038582997480075L), new System.Numerics.BigInteger(8950569089619139710L), }, }, { { new System.Numerics.BigInteger(554472654749493320L), new System.Numerics.BigInteger(4707479633764061093L), new System.Numerics.BigInteger(3930180111012390828L), }, { new System.Numerics.BigInteger(2315104089634764146L), new System.Numerics.BigInteger(2310996773547288446L), new System.Numerics.BigInteger(5599643853973515921L), }, { new System.Numerics.BigInteger(2447337942631166721L), new System.Numerics.BigInteger(2603056623031577141L), new System.Numerics.BigInteger(3051992464743262381L), }, }, { { new System.Numerics.BigInteger(6281668301283055696L), new System.Numerics.BigInteger(9095563494627407834L), new System.Numerics.BigInteger(6967783560636509791L), }, { new System.Numerics.BigInteger(1246929856185619231L), new System.Numerics.BigInteger(218381094831611990L), new System.Numerics.BigInteger(4084235370272611755L), }, { new System.Numerics.BigInteger(2516393089264239546L), new System.Numerics.BigInteger(9168133583141974197L), new System.Numerics.BigInteger(8974222034508139669L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 85,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(7455006137732983292L), new System.Numerics.BigInteger(2231168587237025345L), new System.Numerics.BigInteger(160453416311083783L), }, { new System.Numerics.BigInteger(8926820623139640549L), new System.Numerics.BigInteger(8154287387582091316L), new System.Numerics.BigInteger(267451556250798549L), }, { new System.Numerics.BigInteger(3228469705520682731L), new System.Numerics.BigInteger(1915781309081267178L), new System.Numerics.BigInteger(5937994917049066184L), }, }, { { new System.Numerics.BigInteger(3381538480269901026L), new System.Numerics.BigInteger(17120053743723874L), new System.Numerics.BigInteger(88583680468160100L), }, { new System.Numerics.BigInteger(6136149767777005085L), new System.Numerics.BigInteger(5726082420652019080L), new System.Numerics.BigInteger(5792203916992597869L), }, { new System.Numerics.BigInteger(8336892074262738146L), new System.Numerics.BigInteger(3999868614501885492L), new System.Numerics.BigInteger(4120083630899319663L), }, }, { { new System.Numerics.BigInteger(4657501173958139035L), new System.Numerics.BigInteger(3611694727468525409L), new System.Numerics.BigInteger(2952678179574268437L), }, { new System.Numerics.BigInteger(5641592124693347003L), new System.Numerics.BigInteger(7653687334848419828L), new System.Numerics.BigInteger(6638205705460694399L), }, { new System.Numerics.BigInteger(951290466140914110L), new System.Numerics.BigInteger(8607746705575624792L), new System.Numerics.BigInteger(5458525255067956231L), }, }, },
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1544385747117238354L), new System.Numerics.BigInteger(4045682117030051008L), new System.Numerics.BigInteger(1696472410517808907L), }, { new System.Numerics.BigInteger(5332531843058494863L), new System.Numerics.BigInteger(7339319128348107788L), new System.Numerics.BigInteger(265222950076458419L), }, { new System.Numerics.BigInteger(814189452301836620L), new System.Numerics.BigInteger(4647134621155610748L), new System.Numerics.BigInteger(5277257432219918258L), }, }, { { new System.Numerics.BigInteger(3853954211062759376L), new System.Numerics.BigInteger(8687565801612073208L), new System.Numerics.BigInteger(6615627071214234444L), }, { new System.Numerics.BigInteger(2620400769917040080L), new System.Numerics.BigInteger(5122822608985343551L), new System.Numerics.BigInteger(1160306032196288406L), }, { new System.Numerics.BigInteger(6643663591922894737L), new System.Numerics.BigInteger(4907221591425737176L), new System.Numerics.BigInteger(4312425725368251953L), }, }, { { new System.Numerics.BigInteger(4719581401638672107L), new System.Numerics.BigInteger(1475902364127089137L), new System.Numerics.BigInteger(7530293205103019748L), }, { new System.Numerics.BigInteger(2427307040976483299L), new System.Numerics.BigInteger(7688356005845935741L), new System.Numerics.BigInteger(8122748931957287311L), }, { new System.Numerics.BigInteger(8765692112868391863L), new System.Numerics.BigInteger(7474104777059201724L), new System.Numerics.BigInteger(5528095070405099842L), }, }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 175,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(7505929952655547976L), new System.Numerics.BigInteger(4856446919726807166L), new System.Numerics.BigInteger(6644954954053339269L), }, { new System.Numerics.BigInteger(5546513336322938973L), new System.Numerics.BigInteger(5476579636101699680L), new System.Numerics.BigInteger(8666054018423119521L), }, { new System.Numerics.BigInteger(3083450032809968349L), new System.Numerics.BigInteger(3953423514080680840L), new System.Numerics.BigInteger(8596423008110700576L), }, }, { { new System.Numerics.BigInteger(3088586104887122628L), new System.Numerics.BigInteger(3269467355088388333L), new System.Numerics.BigInteger(8934081304276940016L), }, { new System.Numerics.BigInteger(8844803812950634277L), new System.Numerics.BigInteger(933875754734886892L), new System.Numerics.BigInteger(9085503265480097317L), }, { new System.Numerics.BigInteger(5662595429087900694L), new System.Numerics.BigInteger(2381927282730879426L), new System.Numerics.BigInteger(8508795617934565641L), }, }, { { new System.Numerics.BigInteger(3243645837601320649L), new System.Numerics.BigInteger(6113050827152181197L), new System.Numerics.BigInteger(5632156457386854075L), }, { new System.Numerics.BigInteger(3272669968890720921L), new System.Numerics.BigInteger(5115682711656771215L), new System.Numerics.BigInteger(3979400251225040878L), }, { new System.Numerics.BigInteger(4674367299601569823L), new System.Numerics.BigInteger(3055951402458254445L), new System.Numerics.BigInteger(5948642333345980345L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(6539843364084036762L), new System.Numerics.BigInteger(6761789425412479715L), new System.Numerics.BigInteger(105413441455014027L), }, { new System.Numerics.BigInteger(4176746362956489344L), new System.Numerics.BigInteger(6266558675562657649L), new System.Numerics.BigInteger(3704705120025194088L), }, { new System.Numerics.BigInteger(5444374804548596192L), new System.Numerics.BigInteger(1199383158174912605L), new System.Numerics.BigInteger(4188689256389602883L), }, }, { { new System.Numerics.BigInteger(4794642402126973253L), new System.Numerics.BigInteger(8606406706707745397L), new System.Numerics.BigInteger(2014408076141704806L), }, { new System.Numerics.BigInteger(6409467345597429605L), new System.Numerics.BigInteger(5173557215813633133L), new System.Numerics.BigInteger(3243256888090503735L), }, { new System.Numerics.BigInteger(5010725200883113843L), new System.Numerics.BigInteger(7211704740765263309L), new System.Numerics.BigInteger(3202746916007157747L), }, }, { { new System.Numerics.BigInteger(4663813015694535096L), new System.Numerics.BigInteger(3981509980832504656L), new System.Numerics.BigInteger(1937263803218838929L), }, { new System.Numerics.BigInteger(5030270551165127973L), new System.Numerics.BigInteger(8214617426088946202L), new System.Numerics.BigInteger(8690570585846838615L), }, { new System.Numerics.BigInteger(6458626183159125589L), new System.Numerics.BigInteger(9044157980246388622L), new System.Numerics.BigInteger(5094520118568569252L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 184,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(7382122257019741208L), new System.Numerics.BigInteger(2483760377402803301L), new System.Numerics.BigInteger(7497417494739398477L), }, { new System.Numerics.BigInteger(5506789435839661417L), new System.Numerics.BigInteger(5609120203677374971L), new System.Numerics.BigInteger(6856253124400891521L), }, { new System.Numerics.BigInteger(8334491670524565775L), new System.Numerics.BigInteger(76641226209393722L), new System.Numerics.BigInteger(2446757718555858504L), }, }, { { new System.Numerics.BigInteger(1186874372078257851L), new System.Numerics.BigInteger(6779231518042366806L), new System.Numerics.BigInteger(7500655279173068402L), }, { new System.Numerics.BigInteger(2020392206910517673L), new System.Numerics.BigInteger(5160065032030360568L), new System.Numerics.BigInteger(6813695432687037259L), }, { new System.Numerics.BigInteger(6447874579421470720L), new System.Numerics.BigInteger(6787995767859920510L), new System.Numerics.BigInteger(6368294161509348149L), }, }, { { new System.Numerics.BigInteger(2050944684576555538L), new System.Numerics.BigInteger(1129332611227546662L), new System.Numerics.BigInteger(7549025243108845821L), }, { new System.Numerics.BigInteger(2033245464446918444L), new System.Numerics.BigInteger(5980990822235144599L), new System.Numerics.BigInteger(8429516190765628142L), }, { new System.Numerics.BigInteger(1176432057472541394L), new System.Numerics.BigInteger(7800474509831717652L), new System.Numerics.BigInteger(8078969876364396918L), }, }, },
    ModelInner = new BigIntegernumericMMArrayD3E1MI
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8345795656072994449L), new System.Numerics.BigInteger(2890663679611702213L), new System.Numerics.BigInteger(7918909636817573219L), }, { new System.Numerics.BigInteger(5485492171741616091L), new System.Numerics.BigInteger(2240794401628788358L), new System.Numerics.BigInteger(7499497261597831122L), }, { new System.Numerics.BigInteger(3048623925082367297L), new System.Numerics.BigInteger(7261161844024938334L), new System.Numerics.BigInteger(1085021166325176968L), }, }, { { new System.Numerics.BigInteger(7866424450961222322L), new System.Numerics.BigInteger(707443263421551252L), new System.Numerics.BigInteger(8404552082423717507L), }, { new System.Numerics.BigInteger(1081551844323327318L), new System.Numerics.BigInteger(5649054916015210204L), new System.Numerics.BigInteger(7393091095880190456L), }, { new System.Numerics.BigInteger(3724483703057444525L), new System.Numerics.BigInteger(819029077222903417L), new System.Numerics.BigInteger(3402833618610041914L), }, }, { { new System.Numerics.BigInteger(5034174900661301648L), new System.Numerics.BigInteger(8719108770200613829L), new System.Numerics.BigInteger(2584723635194979214L), }, { new System.Numerics.BigInteger(7976272732774302690L), new System.Numerics.BigInteger(4783618838907366889L), new System.Numerics.BigInteger(402503801120111744L), }, { new System.Numerics.BigInteger(3423463614675571996L), new System.Numerics.BigInteger(3393586338581388076L), new System.Numerics.BigInteger(7479064082885634936L), }, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(1895062080774380942L), new System.Numerics.BigInteger(5159390575163575078L), new System.Numerics.BigInteger(4811901190879211807L), }, { new System.Numerics.BigInteger(4377561486028166872L), new System.Numerics.BigInteger(7471471327372890993L), new System.Numerics.BigInteger(3123274668004167236L), }, { new System.Numerics.BigInteger(2450372711982060476L), new System.Numerics.BigInteger(4602074957317770303L), new System.Numerics.BigInteger(945445335391450605L), }, }, { { new System.Numerics.BigInteger(677466261565418429L), new System.Numerics.BigInteger(4989002522574383077L), new System.Numerics.BigInteger(7458103491591565721L), }, { new System.Numerics.BigInteger(474066786392672618L), new System.Numerics.BigInteger(586856942784910584L), new System.Numerics.BigInteger(5866943771780195143L), }, { new System.Numerics.BigInteger(9097631033174570876L), new System.Numerics.BigInteger(853619654857503837L), new System.Numerics.BigInteger(8965685517483298166L), }, }, { { new System.Numerics.BigInteger(8464117208822804274L), new System.Numerics.BigInteger(9083562259336920760L), new System.Numerics.BigInteger(7594358545955099269L), }, { new System.Numerics.BigInteger(6702609928865295113L), new System.Numerics.BigInteger(2283808475679697330L), new System.Numerics.BigInteger(4096467798288942692L), }, { new System.Numerics.BigInteger(8648945948780644622L), new System.Numerics.BigInteger(1991917503122806291L), new System.Numerics.BigInteger(6744588910247584677L), }, }, },
},
            new BigIntegernumericMMArrayD3E1M
{
    Id = 185,
    Value = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(9136541892780523907L), new System.Numerics.BigInteger(158547424042553440L), new System.Numerics.BigInteger(5909804180990510866L), }, { new System.Numerics.BigInteger(6703719656390757742L), new System.Numerics.BigInteger(6493527153982865583L), new System.Numerics.BigInteger(5799197220124497027L), }, { new System.Numerics.BigInteger(8584299650453161699L), new System.Numerics.BigInteger(3448150933084242811L), new System.Numerics.BigInteger(1552147199693136710L), }, }, { { new System.Numerics.BigInteger(8162808988970567014L), new System.Numerics.BigInteger(1611565699967314099L), new System.Numerics.BigInteger(6406151634643275312L), }, { new System.Numerics.BigInteger(5219090567756595524L), new System.Numerics.BigInteger(6978743373668452876L), new System.Numerics.BigInteger(1269179017413369910L), }, { new System.Numerics.BigInteger(6571079259203697209L), new System.Numerics.BigInteger(1326262804088764298L), new System.Numerics.BigInteger(293640027904293603L), }, }, { { new System.Numerics.BigInteger(7481567029667414871L), new System.Numerics.BigInteger(6945055726809464009L), new System.Numerics.BigInteger(5620524974941974259L), }, { new System.Numerics.BigInteger(2889748683930097980L), new System.Numerics.BigInteger(155453350942955242L), new System.Numerics.BigInteger(988298873871840141L), }, { new System.Numerics.BigInteger(8136114996560544062L), new System.Numerics.BigInteger(3832006270011479204L), new System.Numerics.BigInteger(2742322562465337735L), }, }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,,] { { { new System.Numerics.BigInteger(8946463541987000766L), new System.Numerics.BigInteger(6725883040614433307L), new System.Numerics.BigInteger(1748428189958524736L), }, { new System.Numerics.BigInteger(3373063097624490757L), new System.Numerics.BigInteger(2320420261400164843L), new System.Numerics.BigInteger(4237816556984772790L), }, { new System.Numerics.BigInteger(2974816429172266522L), new System.Numerics.BigInteger(5567721962665477984L), new System.Numerics.BigInteger(2033392351105820563L), }, }, { { new System.Numerics.BigInteger(2779393976992089127L), new System.Numerics.BigInteger(6208064314824076699L), new System.Numerics.BigInteger(3326305119706742238L), }, { new System.Numerics.BigInteger(7380640743260361851L), new System.Numerics.BigInteger(118979260031323822L), new System.Numerics.BigInteger(6690779317673806447L), }, { new System.Numerics.BigInteger(1401187279674232563L), new System.Numerics.BigInteger(3169852539686014701L), new System.Numerics.BigInteger(7382295761345404452L), }, }, { { new System.Numerics.BigInteger(2096009041151124173L), new System.Numerics.BigInteger(7050611968061240440L), new System.Numerics.BigInteger(4210605295254533977L), }, { new System.Numerics.BigInteger(1332514200605700361L), new System.Numerics.BigInteger(7955839963158111070L), new System.Numerics.BigInteger(3827917753783933268L), }, { new System.Numerics.BigInteger(7482393049708439709L), new System.Numerics.BigInteger(7693065469284351999L), new System.Numerics.BigInteger(7448622381405880215L), }, }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd3e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd3e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]), 
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd3e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd3e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd3e1mi_id
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
    bigintegernumericmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
INSERT INTO public.bigintegernumericmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd3e1mi_id
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
    bigintegernumericmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd3e1mi_id", 
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
                List<BigIntegernumericMMArrayD3E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD3E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M), typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
LEFT JOIN public.bigintegernumericmmarrayd3e1mi mi ON mi.id = m.bigintegernumericmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M), typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
LEFT JOIN public.bigintegernumericmmarrayd3e1mi mi ON mi.id = m.bigintegernumericmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M), typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                 ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                 ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                 ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
LEFT JOIN public.bigintegernumericmmarrayd3e1mi mi ON mi.id = m.bigintegernumericmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M), typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 171, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                 ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                 ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 40, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 82, query1, 157, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
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
FROM public.bigintegernumericmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD3E1M>();
                 ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 87, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd3e1m m
LEFT JOIN public.bigintegernumericmmarrayd3e1mi mi ON mi.id = m.bigintegernumericmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 3, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[28],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[29],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[30],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[31],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[32],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 138, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[1], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[2], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[3], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[4], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[5], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[6], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[7], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[8], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[9], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[10], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[11], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[12], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[13], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[14], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[15], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[16], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[17], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[18], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[19], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[20], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[21], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[22], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[23], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[24], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[25], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[26], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[27], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[27],_testData[28], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[28],_testData[29], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[29],_testData[30], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[30],_testData[31], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[31],_testData[32], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[32],_testData[33], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models =  ((IBigIntegerMArraynumericMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                BigIntegernumericMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                BigIntegernumericMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD3E1MIWA),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD3E1MI),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD3E1M),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
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
FROM public.binary_bigintegernumericmmarrayd3e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd3e1mi mi ON mi.id = m.bigintegernumericmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models =  ((IBigIntegerMArraynumericMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA), typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
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
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
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
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA), typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
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
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
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
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MI), typeof(BigIntegernumericMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MI>();
                ((IBigIntegerMArraynumericMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA), typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD3E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD3))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

