

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
new System.Int64[3]
{
2176193003063801022L,
5583003289447647101L,
8339837333609786397L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Int64[4]
{
506596785002542462L,
7533459248191612848L,
9113067118076280113L,
6636356474703081953L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4555148227276466583L,
2082289797263203374L,
6568790284297919757L,
7138022001017171168L,
},
},
            new Int64MArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int64[3]
{
2020471548067798525L,
5499013456783533492L,
4530809413471480838L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Int64[3]
{
3427435846587989794L,
934224642120338103L,
1761535994409927813L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7275673160685809445L,
8696836139540150835L,
1309212472987440704L,
1521370940601373158L,
},
},
            new Int64MArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int64[3]
{
6743958430980314351L,
3996239848715733819L,
6529554572631790808L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Int64[3]
{
2617080658979770301L,
1782347658539613224L,
2089036186790444858L,
},
    NullableValue = 
new System.Int64[3]
{
8245126795606076188L,
6756156098779755105L,
4696169190462444927L,
},
},
    NullableValue = 
new System.Int64[3]
{
5451609923131926247L,
7939252825709369199L,
5968318416304151252L,
},
},
            new Int64MArrayD1E1M
{
    Id = 25,
    Value = 
new System.Int64[4]
{
832283612910698664L,
6936744720411216743L,
3326208933396153800L,
4693564817401069840L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Int64[3]
{
5931429508564329023L,
5091927216390195105L,
2595551762590402055L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
9145015231154223485L,
2093139927723724521L,
7121624489771180518L,
},
},
            new Int64MArrayD1E1M
{
    Id = 34,
    Value = 
new System.Int64[3]
{
7080753632742885644L,
4278147080707949969L,
7031663787665418077L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Int64[4]
{
2280338000426150910L,
6165425709739198380L,
1605731905625957302L,
8709605546523646538L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7945325433947149089L,
2644726945883394261L,
4457055339415377232L,
2968279798122287274L,
},
},
            new Int64MArrayD1E1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
2536485925272728361L,
7619524880400758589L,
1498997648829097603L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Int64[4]
{
8270781247348577495L,
4082279654814371358L,
6373424798148748712L,
4028881250854879588L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7166317384630965038L,
8512752384150339821L,
8286949240761565814L,
},
},
            new Int64MArrayD1E1M
{
    Id = 44,
    Value = 
new System.Int64[3]
{
9011474586654520418L,
6525467207921803725L,
1007023761801905944L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int64[4]
{
2409103366127220160L,
3286404407959973924L,
5178117686246904530L,
5974752190602344161L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int64[3]
{
103381707992445168L,
4430270162631676986L,
2836266434432174906L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int64[3]
{
2408443793844129700L,
6124546745519078093L,
1380064967744977796L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 52,
    Value = 
new System.Int64[3]
{
40368326241245933L,
3849678791877231784L,
1448781002674116002L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int64[3]
{
8705665405004158792L,
9004449371094654842L,
5036188018751646689L,
},
    NullableValue = 
new System.Int64[4]
{
581136734142227987L,
5683184243279733346L,
9186672611586157658L,
3159644866298982699L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 55,
    Value = 
new System.Int64[3]
{
2543873600899183698L,
5057636278472704629L,
5053827319797819693L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
4419734542443245514L,
7630266381164910722L,
9156538073197935409L,
1000450069472772667L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
9210679555193942694L,
8196514768403398802L,
2605000329349347081L,
},
},
            new Int64MArrayD1E1M
{
    Id = 59,
    Value = 
new System.Int64[3]
{
6260445108530570906L,
5656469993113033532L,
9220873944424596885L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int64[4]
{
2066285111356736562L,
4934997458004286073L,
4599115437904884744L,
4020661821470080454L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6592359691804686989L,
1238165361138010316L,
1986497226406117090L,
5741048451768285535L,
},
},
            new Int64MArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int64[4]
{
1850165954912884312L,
1146250753308746948L,
1375464813268057736L,
8148635521613563404L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int64[3]
{
983276603258847306L,
6586328683051151725L,
7476699415891301236L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 67,
    Value = 
new System.Int64[4]
{
1312819935272731797L,
2278228527170176892L,
811603100319373157L,
666062940781549990L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Int64[3]
{
7005099441662518329L,
7728142767753627532L,
8052494457866600145L,
},
    NullableValue = 
new System.Int64[3]
{
7731210229708577083L,
571470773532649200L,
2586735571981429968L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 74,
    Value = 
new System.Int64[4]
{
8986067612114641914L,
7423615864777898642L,
4841563564013347249L,
2126079385866377297L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int64[4]
{
483269452082382142L,
1823358214585018079L,
6263748137852494577L,
7058843905721899038L,
},
    NullableValue = 
new System.Int64[4]
{
2820972254677042224L,
1002204568172121699L,
3778721403781374906L,
279850390669498526L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 79,
    Value = 
new System.Int64[3]
{
3367711613991544562L,
545021941253417630L,
2029393293946455137L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int64[4]
{
5321521103443261341L,
6785030416872375447L,
4313714488127377491L,
7645338806492927108L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5483747498639465076L,
1044178414816749086L,
6919381028766096570L,
9027386585669463311L,
},
},
            new Int64MArrayD1E1M
{
    Id = 85,
    Value = 
new System.Int64[3]
{
7024735327442080418L,
4503606268558145028L,
1068926899646313841L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Int64[3]
{
4835940375485266021L,
2889077121793917396L,
8598943580026422317L,
},
    NullableValue = 
new System.Int64[3]
{
1560559126255364098L,
6609501837245152506L,
1287171598063275465L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int64[4]
{
7095192983893534242L,
5104006379503841990L,
6430671989912781204L,
5485137086639486297L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Int64[4]
{
2614144475294164299L,
4574323343496731364L,
5279301434622191951L,
8514543742359736158L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
259387594352201054L,
5894919698246962463L,
6195190129674329846L,
437853368956419777L,
},
},
            new Int64MArrayD1E1M
{
    Id = 97,
    Value = 
new System.Int64[3]
{
2578427569628433078L,
3963303350645116307L,
1227553188582195438L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Int64[4]
{
4801335432014764777L,
5259436100023554283L,
2914024378283555243L,
4383734106079058744L,
},
    NullableValue = 
new System.Int64[3]
{
5123186148518085399L,
8924513991362728266L,
3373129127269621839L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int64[3]
{
1896279424269616227L,
2724322780412274942L,
2400913606682026043L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Int64[4]
{
3242754814458942645L,
7620788908872907700L,
2058906497289860449L,
2344046702809661881L,
},
    NullableValue = 
new System.Int64[4]
{
5859586073829841879L,
839737794523609208L,
3153169971063441665L,
2627171835351772883L,
},
},
    NullableValue = 
new System.Int64[3]
{
4014943322978085456L,
4635491120079743500L,
1529833348027860730L,
},
},
            new Int64MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int64[3]
{
2658581770521157111L,
1385046127605772518L,
3636936925202007089L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 115,
    Value = 
new System.Int64[4]
{
4230069032331597622L,
6851963149097832450L,
650224112734688061L,
4410460495110680298L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3435978394529786604L,
5567250163409401919L,
1258694389347084689L,
5141258853948919211L,
},
},
            new Int64MArrayD1E1M
{
    Id = 116,
    Value = 
new System.Int64[4]
{
7146630193912904086L,
4902686840535354864L,
155799317825406309L,
7078758208903625432L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 122,
    Value = 
new System.Int64[3]
{
5936533394008972720L,
3567862263038085864L,
7574447508696981309L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Int64[4]
{
2578597648443898377L,
6192984951469640371L,
2374749582023948922L,
7950176109602941464L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 127,
    Value = 
new System.Int64[3]
{
1837039263832252690L,
1235687702466942362L,
7312181248155068056L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
3288573824144996041L,
3833309566972915060L,
5382655150937332782L,
},
},
            new Int64MArrayD1E1M
{
    Id = 124,
    Value = 
new System.Int64[4]
{
7187299308849944564L,
2601471101070738830L,
7711043161226570095L,
2741063347916389849L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Int64[3]
{
2221090464087147255L,
8257579469710634484L,
3408713626786703915L,
},
    NullableValue = 
new System.Int64[3]
{
4817912294204881794L,
3328630926910735372L,
2971390547957213245L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 126,
    Value = 
new System.Int64[4]
{
208793769721214291L,
4685110985559484199L,
7458401143448150325L,
2854052736476250814L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 132,
    Value = 
new System.Int64[3]
{
6267802135392436097L,
7472571510049866691L,
7028569696104026358L,
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
4930441218133611950L,
8110824789575029377L,
8935086732762579603L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Int64[3]
{
958147415188529149L,
1893067664675222003L,
4503596704255462349L,
},
    NullableValue = 
new System.Int64[3]
{
5087169915348263688L,
3121831118231932799L,
4734064591944470421L,
},
},
    NullableValue = 
new System.Int64[4]
{
7821140048870737964L,
8273717018578317525L,
4607058867849220818L,
8675252766675606777L,
},
},
            new Int64MArrayD1E1M
{
    Id = 139,
    Value = 
new System.Int64[4]
{
8126646972881313370L,
5971538041444652241L,
6513319355733729906L,
1506726835982074192L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Int64[3]
{
6219734529220971913L,
625514890993152904L,
4406198863275010527L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7882178998377926797L,
9173355350828666012L,
1445831246846988092L,
4747786835706869876L,
},
},
            new Int64MArrayD1E1M
{
    Id = 143,
    Value = 
new System.Int64[4]
{
6309004566301794426L,
3162261095179165125L,
1590839202355890687L,
2917985035393751869L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Int64[3]
{
3869160467448565097L,
74999065138319823L,
861331597015320464L,
},
    NullableValue = 
new System.Int64[3]
{
2335618762620309880L,
3921220354854116924L,
8094155184253691408L,
},
},
    NullableValue = 
new System.Int64[3]
{
167864002519708113L,
67012129650908158L,
7315901679797981923L,
},
},
            new Int64MArrayD1E1M
{
    Id = 149,
    Value = 
new System.Int64[3]
{
979020924972163457L,
7841233270402180006L,
4319517660207133683L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Int64[4]
{
6542893013143406247L,
3838160595933525622L,
1023154713768196873L,
597422706657821366L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5393475738036258523L,
3335547933467607703L,
3989644868220061174L,
2233953997155869437L,
},
},
            new Int64MArrayD1E1M
{
    Id = 153,
    Value = 
new System.Int64[4]
{
698985291064195928L,
3178352712664467203L,
5569421937436831262L,
6996585768433507575L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 165,
    Value = 
new System.Int64[4]
{
5880953242433790304L,
4199834228512498975L,
7665608945601862211L,
2864245270640083193L,
},
    NullableValue = 
new System.Int64[4]
{
1011227522210178242L,
4985761216144636676L,
461952929169680834L,
1531381648711776523L,
},
},
    NullableValue = 
new System.Int64[3]
{
2925333855174445867L,
7206214680171140370L,
5268526461547103594L,
},
},
            new Int64MArrayD1E1M
{
    Id = 154,
    Value = 
new System.Int64[3]
{
7798306076348528787L,
4852105947252357029L,
104292032670487310L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 168,
    Value = 
new System.Int64[4]
{
1080693551259947952L,
6390883886415384842L,
6139008244206930438L,
4382872828302534790L,
},
    NullableValue = 
new System.Int64[4]
{
352228423124360821L,
3365475366990942437L,
2159431834515077509L,
6574006354525621567L,
},
},
    NullableValue = 
new System.Int64[3]
{
197578676593234521L,
1140840685821829423L,
1227878980751822838L,
},
},
            new Int64MArrayD1E1M
{
    Id = 156,
    Value = 
new System.Int64[3]
{
1941227324123004375L,
6165100487567508167L,
934111762661064074L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Int64[3]
{
7028610221967752401L,
4147436458631706858L,
4102653492624222216L,
},
    NullableValue = 
new System.Int64[3]
{
3078201346753464356L,
1487226995324569406L,
4762698203565162459L,
},
},
    NullableValue = 
new System.Int64[3]
{
936153650734641391L,
6228324954772488520L,
1704619832305834752L,
},
},
            new Int64MArrayD1E1M
{
    Id = 164,
    Value = 
new System.Int64[3]
{
9074314420053112495L,
1642855527842109768L,
5978071666504523288L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 174,
    Value = 
new System.Int64[3]
{
7818169261755333393L,
2886946850481447568L,
7713357819019788145L,
},
    NullableValue = 
new System.Int64[4]
{
5336188556261021627L,
2625675563380053528L,
1405117536684183611L,
5504311441500251247L,
},
},
    NullableValue = 
new System.Int64[4]
{
4048934398086222403L,
3045050363996296299L,
360224635942837642L,
1910627473247458966L,
},
},
            new Int64MArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int64[4]
{
7652847438060347728L,
7132204957220793348L,
4315129848846325325L,
3209950306190984950L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 182,
    Value = 
new System.Int64[4]
{
6131096955834724616L,
6437663352508541667L,
4501838402318438459L,
1353009424033400832L,
},
    NullableValue = 
new System.Int64[4]
{
3228342760642187573L,
1064461791132281219L,
6397096164800092742L,
7346065939701914309L,
},
},
    NullableValue = 
new System.Int64[3]
{
7693557164637344713L,
3731204524252262178L,
4599681088657301268L,
},
},
            new Int64MArrayD1E1M
{
    Id = 175,
    Value = 
new System.Int64[3]
{
797549980800318662L,
8655671927971647403L,
4333158562181659697L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 189,
    Value = 
new System.Int64[4]
{
3648230147661967061L,
8857153816280325203L,
7488054867413640241L,
5937922162829646118L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5976605224705987751L,
7098533358364396408L,
849761251560594121L,
},
},
            new Int64MArrayD1E1M
{
    Id = 178,
    Value = 
new System.Int64[3]
{
1686846497993585154L,
8792069638092426175L,
6524680750993779469L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 196,
    Value = 
new System.Int64[3]
{
5774426961422849581L,
1364396675952700647L,
7746722575614394224L,
},
    NullableValue = null,
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

