

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
    internal partial interface IUInt64MArrayMArrayD1
    {
    }
    
    internal partial class UInt64MArrayMArrayD1 : IUInt64MArrayMArrayD1
    {


#region TestData

        private readonly UInt64MArrayD1E1M[] _testData = new UInt64MArrayD1E1M[]
        {
            new UInt64MArrayD1E1M
{
    Id = 1,
    Value = 
new System.UInt64[4]
{
2844690118832307019L,
617497181243020853L,
1081871334196535853L,
589509851799301094L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt64[4]
{
4881412865863950687L,
1984380426188784631L,
995811978679644529L,
1273197648182664477L,
},
    NullableValue = 
new System.UInt64[3]
{
6835345437433775253L,
9111366866170674293L,
2758591705646399528L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 4,
    Value = 
new System.UInt64[4]
{
1928987119898875710L,
4860292866187506987L,
6502921209936014081L,
8889099501219024863L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 14,
    Value = 
new System.UInt64[3]
{
6500000062418932822L,
156880663147953450L,
3949133031869221084L,
},
    NullableValue = 
new System.UInt64[3]
{
7152584284234570987L,
1675422871070130304L,
6496846319926260564L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 9,
    Value = 
new System.UInt64[4]
{
603349032287032096L,
3011520542272996459L,
1222961172797152763L,
4073219544891914884L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.UInt64[4]
{
4598380774001961371L,
2419977090097414237L,
3693555371799201960L,
5929228437054965361L,
},
    NullableValue = 
new System.UInt64[4]
{
8303608355589075023L,
3033115784916211638L,
9032583508779247260L,
3388988246480242828L,
},
},
    NullableValue = 
new System.UInt64[4]
{
3331343053036970102L,
5262396678587335233L,
316480340241943863L,
1899707433602574860L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 11,
    Value = 
new System.UInt64[3]
{
8701247432444862485L,
3532425604767849300L,
8879130002083157532L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.UInt64[3]
{
6942448688215876141L,
5576515660711549474L,
1956868727664149327L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 13,
    Value = 
new System.UInt64[3]
{
476915323573452765L,
5165020304790344200L,
8778404108867736886L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 31,
    Value = 
new System.UInt64[3]
{
2642975019181627393L,
4113557314883238547L,
763730545961444962L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 21,
    Value = 
new System.UInt64[3]
{
1017202285047935129L,
3598987980604370240L,
7986751820461942022L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.UInt64[3]
{
3502859055313975972L,
1035382387716540897L,
8866795287574668479L,
},
    NullableValue = 
new System.UInt64[4]
{
4448213949074263126L,
4100901414191612923L,
4571351065091903487L,
779409215805258789L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 30,
    Value = 
new System.UInt64[4]
{
7946040688450916276L,
7128080255470033964L,
5938266970992757518L,
1082312205012093912L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.UInt64[3]
{
2357271713901580125L,
8435986252347098466L,
5441604538443543629L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 33,
    Value = 
new System.UInt64[3]
{
8562041734936674659L,
835274850629152460L,
5566170301773071924L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 48,
    Value = 
new System.UInt64[4]
{
1362306656686845084L,
1734547770083466L,
72293046182141417L,
8680922135286193686L,
},
    NullableValue = 
new System.UInt64[4]
{
4954360070988179899L,
5634238223071468019L,
5951651489187025014L,
7548190153547790024L,
},
},
    NullableValue = 
new System.UInt64[3]
{
3027955231906774414L,
4274488651728956287L,
6640419741322156944L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 36,
    Value = 
new System.UInt64[4]
{
8632980663057307706L,
4322161595732262168L,
2206768698072418371L,
8546518858226035030L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt64[3]
{
1793275117571839982L,
160285748087374645L,
5411414794528042219L,
},
    NullableValue = 
new System.UInt64[4]
{
4593757047528495092L,
4247895268338932646L,
2045785171317569465L,
446515844376805995L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 37,
    Value = 
new System.UInt64[3]
{
7313435972103163533L,
6132257834239507509L,
6345058105165691588L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 55,
    Value = 
new System.UInt64[4]
{
2839419350626656841L,
6826309729904128916L,
3018098712513926014L,
6082469421810660383L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
4535614617007047971L,
7770820897771461280L,
7475284062198873351L,
4979872392004888765L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 44,
    Value = 
new System.UInt64[3]
{
6378599120435792526L,
6858815704448034981L,
938367339852746439L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.UInt64[4]
{
9174686937825607711L,
2670798251246061785L,
8760992765244367807L,
7399828671481299309L,
},
    NullableValue = 
new System.UInt64[3]
{
290700577061435552L,
1335066500146016367L,
7744268431781279170L,
},
},
    NullableValue = 
new System.UInt64[3]
{
8313668537904581515L,
145655027803944643L,
258315899868008644L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 49,
    Value = 
new System.UInt64[4]
{
6798541426866720993L,
759571501700128080L,
6423659368779678281L,
3200790719808193325L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.UInt64[4]
{
1995958246586905285L,
431080713244216288L,
2643999740722097605L,
8953665490363870660L,
},
    NullableValue = 
new System.UInt64[3]
{
4708997524994775965L,
7753545300286424844L,
8798479323495583569L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt64[4]
{
4446024056671284384L,
3940347556953915982L,
8544236341563477265L,
1027797830916419105L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.UInt64[4]
{
2125930141676938213L,
6698133315940466022L,
6991058718427862723L,
3496038975756430287L,
},
    NullableValue = 
new System.UInt64[4]
{
6148335847843972873L,
3732359142795909696L,
2509595788347111942L,
8617323970183031775L,
},
},
    NullableValue = 
new System.UInt64[3]
{
8835671180708272970L,
985506781311282735L,
6362158262594536742L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 59,
    Value = 
new System.UInt64[4]
{
2926339042031063426L,
1709361445766311637L,
5810305209633644562L,
3781666763085671473L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.UInt64[4]
{
8180489053164942820L,
8062303794115960771L,
7271943161516660047L,
1910365402376964111L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 61,
    Value = 
new System.UInt64[4]
{
3405412516036325662L,
4575428194894837678L,
2089573065355789784L,
3081510835169950327L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.UInt64[3]
{
5149039950454987575L,
1544368756725049187L,
6486351390983975746L,
},
    NullableValue = 
new System.UInt64[3]
{
8246906759414069906L,
2377623786266657897L,
7685578548063033413L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 66,
    Value = 
new System.UInt64[3]
{
4323818491563645395L,
4260335036629775455L,
4452031542559382263L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.UInt64[4]
{
3362644749759541855L,
8886882599380248504L,
5276603253297075910L,
8875053401191171900L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 74,
    Value = 
new System.UInt64[4]
{
4868720636506328101L,
1868925454598896390L,
6544737649719400048L,
8931500485581103136L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 91,
    Value = 
new System.UInt64[3]
{
2585933765468567355L,
1403513603248805989L,
3338061793896904769L,
},
    NullableValue = 
new System.UInt64[4]
{
2216149210333679488L,
2157923421318368459L,
480262787917640801L,
3427627492854456846L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 83,
    Value = 
new System.UInt64[4]
{
2653299778586038062L,
4042353241266269547L,
3520830186602336002L,
8542960595517304942L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt64[3]
{
627555692448346553L,
7148060512972306016L,
1546223107652740702L,
},
    NullableValue = 
new System.UInt64[4]
{
7047408186828252204L,
1072243285514246050L,
4534357290746510935L,
2566120231648874738L,
},
},
    NullableValue = 
new System.UInt64[3]
{
481179416911373546L,
5329611098083418569L,
5782717807679149585L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 86,
    Value = 
new System.UInt64[4]
{
3919118181757242401L,
7669834880455984687L,
5780250508410490908L,
8485182761625822590L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 103,
    Value = 
new System.UInt64[4]
{
6740264544273855323L,
2129998633783104516L,
6195977474852532450L,
1459602742069036403L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
266227616901695518L,
5850938354222585955L,
6013423804316125091L,
530895729407562015L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 94,
    Value = 
new System.UInt64[3]
{
5860402610344914568L,
711591649680021009L,
2879511610490159167L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt64[4]
{
7622810293593188383L,
1776970484283724772L,
6400147116842971039L,
3342598632514897677L,
},
    NullableValue = 
new System.UInt64[3]
{
5173537654985708363L,
3704031427984212586L,
6554247949126276636L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 103,
    Value = 
new System.UInt64[4]
{
5589626248702300926L,
651725634716391256L,
8278494247100520720L,
5545246705013793949L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.UInt64[4]
{
7576015769664046224L,
231385526586785748L,
7459620552885764311L,
8256720653367057370L,
},
    NullableValue = 
new System.UInt64[4]
{
7112831265718430477L,
5252289369502450950L,
6637694667570718450L,
1999495967766828808L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 107,
    Value = 
new System.UInt64[4]
{
5933304750461626804L,
2474158058604491383L,
4521559174797459807L,
5352669201757231209L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 119,
    Value = 
new System.UInt64[3]
{
1026665200805472019L,
6761375247045888941L,
274355509668185232L,
},
    NullableValue = 
new System.UInt64[3]
{
6477605693177259721L,
7690472278194220364L,
585313559451657381L,
},
},
    NullableValue = 
new System.UInt64[4]
{
7863409953416708258L,
6052656367969251228L,
6356514300587815077L,
8015093672990034132L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 116,
    Value = 
new System.UInt64[4]
{
8146624120803474383L,
8158971952667899622L,
2106149530336991801L,
118963274104895628L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 125,
    Value = 
new System.UInt64[3]
{
4288749964374826405L,
4224156276677580076L,
8622295655933589817L,
},
    NullableValue = 
new System.UInt64[3]
{
4474847087072000231L,
753152515648760656L,
6360437789965008554L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 121,
    Value = 
new System.UInt64[4]
{
1853259218584113864L,
4871632303471234102L,
2002799754406908286L,
5607657581728517923L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.UInt64[3]
{
968262807943204766L,
2055069220278574213L,
4674994109115904974L,
},
    NullableValue = 
new System.UInt64[3]
{
3299482650591904773L,
7558027207563268054L,
2877998921870292795L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 125,
    Value = 
new System.UInt64[4]
{
1750153615883807510L,
7405731970339607856L,
6648909966818642791L,
2577187675661955981L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.UInt64[4]
{
8512529677470433636L,
6555809442215684041L,
6499750348145379671L,
2199466951755578393L,
},
    NullableValue = 
new System.UInt64[3]
{
8166884892202595996L,
3264912215885123390L,
2786234947414352991L,
},
},
    NullableValue = 
new System.UInt64[3]
{
7075341391899238041L,
6588169950622184953L,
63796645273039745L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 127,
    Value = 
new System.UInt64[4]
{
314158792889760292L,
8311774778537954989L,
1387966132924293341L,
4926258905069798272L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 134,
    Value = 
new System.UInt64[3]
{
9067254059117914376L,
5164327535406852455L,
8533228781371692556L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 130,
    Value = 
new System.UInt64[4]
{
6946124975254165306L,
7077289685619581125L,
7363414398656401044L,
8214365906336787765L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 141,
    Value = 
new System.UInt64[3]
{
4040500510067602977L,
7267726040448972061L,
4734753638572858316L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
2609082882068549425L,
7294226203745731960L,
2367159397737905971L,
7998235820788386948L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 136,
    Value = 
new System.UInt64[3]
{
4588903993608454890L,
8786944846547905881L,
7761118502581083899L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt64[3]
{
8341912866664771347L,
6958127371551050710L,
9125831860505651224L,
},
    NullableValue = 
new System.UInt64[4]
{
796672665514643960L,
4105439152206086209L,
2495934025028286098L,
3457256672281975435L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 138,
    Value = 
new System.UInt64[3]
{
2963803231723283721L,
5280141160286879765L,
9109073040020284523L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.UInt64[3]
{
8686746425258150387L,
7179971405383518833L,
253024868307907126L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 141,
    Value = 
new System.UInt64[4]
{
2783313979197436979L,
1929191608595959520L,
6495396651607224932L,
2918065555431145214L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 161,
    Value = 
new System.UInt64[3]
{
9099789886531038588L,
1579654017679149071L,
4837497342309890856L,
},
    NullableValue = 
new System.UInt64[3]
{
3017715057537357408L,
2571412128902481792L,
7741115379030277060L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 148,
    Value = 
new System.UInt64[4]
{
2205847984374335581L,
5422281710358829531L,
5228394875235075953L,
409948363223197641L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 165,
    Value = 
new System.UInt64[3]
{
391294258684781382L,
7029337022397633113L,
448963883406655940L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
822497064145265313L,
2160480656893708948L,
316097792717646214L,
8931522551688661204L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 157,
    Value = 
new System.UInt64[3]
{
8216587803492445568L,
5313982143818299473L,
1627495876975498577L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 167,
    Value = 
new System.UInt64[4]
{
1384628027086351187L,
1318535900543945789L,
81852985135825L,
2085671100445430691L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
5962964785059786886L,
1397126199982513645L,
6337345788930068990L,
1296465458659015769L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 166,
    Value = 
new System.UInt64[4]
{
8811789943094828519L,
1797361672292259895L,
6338833762464699325L,
4595093273089436610L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.UInt64[4]
{
393867662868386556L,
4662435263850074619L,
5696132649793785098L,
1261240227858743377L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 168,
    Value = 
new System.UInt64[3]
{
6344699380957036356L,
7378503329304882223L,
7253804183327107878L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 173,
    Value = 
new System.UInt64[4]
{
6499869203709251122L,
2924171061192619124L,
9155849258660119225L,
4715929559850741340L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 174,
    Value = 
new System.UInt64[4]
{
6565985685861335133L,
3415542459810284678L,
90557284595429958L,
8819011404702972712L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 176,
    Value = 
new System.UInt64[3]
{
622080933867453076L,
2068618565709158000L,
4432255080438088627L,
},
    NullableValue = 
new System.UInt64[4]
{
3230049053084246202L,
2551707312652017130L,
5277923449644935917L,
5301605808596445384L,
},
},
    NullableValue = 
new System.UInt64[4]
{
1105958790520713503L,
6335419777589507786L,
6321858336042737873L,
1537923582571296302L,
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt64)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
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
                    await ((IUInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64MArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
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
                    var models = await ((IUInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

