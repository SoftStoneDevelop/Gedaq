

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
    Id = 5,
    Value = 
new System.Int64[3]
{
8030065198680551492L,
6049573032010135269L,
1521001460706543208L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Int64[4]
{
1668897483450702485L,
7084552878731581683L,
2982010131913538689L,
227609217350622798L,
},
    NullableValue = 
new System.Int64[3]
{
4495733304544281536L,
9054239180471778337L,
6329933244772673206L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 11,
    Value = 
new System.Int64[3]
{
9030165228391463562L,
112326908977393544L,
8864566301464432875L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int64[4]
{
3427449276150821416L,
5767723408528512148L,
2644938876549400077L,
2691338839996577005L,
},
    NullableValue = 
new System.Int64[4]
{
2578763926801845212L,
5035269222804938532L,
7387895699858283492L,
7461346507313260560L,
},
},
    NullableValue = 
new System.Int64[3]
{
3090234699041141403L,
6033806065174621541L,
7880786374535723974L,
},
},
            new Int64MArrayD1E1M
{
    Id = 13,
    Value = 
new System.Int64[3]
{
2565415272494703045L,
5576563311357956380L,
7908085757913873269L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int64[3]
{
2812440757569427385L,
4781667555673716318L,
1076930804271263177L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2801673789400913498L,
5350384047760518629L,
2520231273719264678L,
8010790268476735357L,
},
},
            new Int64MArrayD1E1M
{
    Id = 14,
    Value = 
new System.Int64[3]
{
8669455789765233003L,
2610163733941270525L,
6904635652775322230L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int64[3]
{
1172555156665410562L,
6231167648323879804L,
4349075398204578320L,
},
    NullableValue = 
new System.Int64[3]
{
5642309976949224671L,
2645129064905287445L,
1793392105836034001L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int64[4]
{
4800710696660623868L,
5418238002798476546L,
4509548950083019263L,
3390270450710733261L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Int64[4]
{
206768737124501187L,
6435196075193846571L,
6917893729334424059L,
1348965298020548018L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 23,
    Value = 
new System.Int64[3]
{
3887267418771140160L,
189987391099743554L,
2397410389404049414L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Int64[4]
{
4446559097725763259L,
5815415742295565607L,
4463527210528036567L,
5048769142301620745L,
},
    NullableValue = 
new System.Int64[3]
{
6553037101269694482L,
3602212101609561275L,
4217906923148591517L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 24,
    Value = 
new System.Int64[4]
{
1390486031821716231L,
3423003963379573125L,
1400368877711018122L,
8286215219995586116L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Int64[4]
{
1879017844065038086L,
3079080700779981154L,
7077273595542926389L,
1446753253999720639L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 29,
    Value = 
new System.Int64[4]
{
982469420509087202L,
5214541687999206134L,
8539256085034128900L,
1806171302068750509L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int64[3]
{
8593255994936401396L,
3450216720461503202L,
3692610170601021716L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int64[3]
{
7901045329299583208L,
7810506905326164624L,
6036548440011528953L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int64[3]
{
7326150082453613963L,
3297613473404477510L,
1847049532079038857L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int64[3]
{
6188513825165553368L,
674811298090911754L,
7717976699718280289L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Int64[3]
{
8335900616541223170L,
436038125072839523L,
5668705712032372034L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5946830879930414630L,
2252494855809552072L,
3086858601024360021L,
},
},
            new Int64MArrayD1E1M
{
    Id = 45,
    Value = 
new System.Int64[3]
{
4630327580969577523L,
4149424817280486893L,
6803852922797117292L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Int64[3]
{
5853370014294699815L,
7587023821342945297L,
7286092376342631441L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int64[4]
{
2801785960410551727L,
172124309679902851L,
3874234717427863799L,
6634517498830929086L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int64[4]
{
2684071710184677728L,
2941649842938946005L,
8847842479671583983L,
4879891046701615073L,
},
    NullableValue = 
new System.Int64[3]
{
6214493673089216663L,
451833257374050852L,
2708286135763654957L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 52,
    Value = 
new System.Int64[4]
{
2909100943899466102L,
2039760037223951517L,
5382320540411517903L,
6900009122507529289L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int64[4]
{
2580271425289637199L,
4089365374527601893L,
8902460154769404088L,
7276594583674196047L,
},
    NullableValue = 
new System.Int64[3]
{
4133095149365247281L,
2646831704439285263L,
8259812588360844882L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 61,
    Value = 
new System.Int64[4]
{
1625943011917632615L,
1818085443623993855L,
5446143254665165676L,
4116130938710046770L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Int64[4]
{
4847043944673496414L,
1337388952700586561L,
9073293180042400119L,
7117365874744341807L,
},
    NullableValue = 
new System.Int64[4]
{
4158514260693239610L,
1788905638439863990L,
4301498648634154107L,
5977846986712860470L,
},
},
    NullableValue = 
new System.Int64[3]
{
587397846817310656L,
6198201098167220524L,
5333620952656999984L,
},
},
            new Int64MArrayD1E1M
{
    Id = 68,
    Value = 
new System.Int64[4]
{
1522033119248438065L,
3603773084907063876L,
6652447330509963611L,
3702140535596472586L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Int64[4]
{
5763787205224431579L,
8560320375468303134L,
1274519559686269281L,
6664420414980590318L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4279042382040599038L,
6595431619909600572L,
8965078688636732227L,
2487077099800797269L,
},
},
            new Int64MArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int64[3]
{
2310573893008960196L,
5976935949308101530L,
5363243459938764211L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int64[4]
{
894287232997026986L,
7711375293983258638L,
1527421362591829521L,
626499267111763490L,
},
    NullableValue = 
new System.Int64[3]
{
3265848384042869613L,
1088596794988536213L,
5259015557229971536L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int64[3]
{
8966020017264037472L,
8506258704222079028L,
3574785694909260377L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Int64[4]
{
5809010632214149238L,
2223391712821081212L,
3330385982634380820L,
6661154717636462765L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7359980126684041005L,
9106953737142180002L,
9150291559616927454L,
1272972490266577199L,
},
},
            new Int64MArrayD1E1M
{
    Id = 76,
    Value = 
new System.Int64[3]
{
6390719333391238756L,
7765997433604240173L,
3836051082648808357L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Int64[4]
{
6441761667782648522L,
1832008351831176017L,
5293159766645449884L,
8261751976520033369L,
},
    NullableValue = 
new System.Int64[4]
{
5212897724962027585L,
4367730853343175668L,
4888346471929253728L,
5277271388842541946L,
},
},
    NullableValue = 
new System.Int64[3]
{
6180192742020037092L,
2142831336537913847L,
2797525910285944121L,
},
},
            new Int64MArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int64[3]
{
1059481086317130452L,
2454639303701067717L,
1582954673181495114L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Int64[3]
{
3874613308865027857L,
5970497058015931821L,
8649868617092535315L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1050562868450957391L,
179966362342548059L,
147863666703256471L,
},
},
            new Int64MArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int64[4]
{
2738556259365181093L,
2731117011628593128L,
6194437866737996153L,
3642958616062723270L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Int64[4]
{
6377362357001968494L,
4292380192699294548L,
5323752329211426876L,
1472154490044459560L,
},
    NullableValue = 
new System.Int64[4]
{
2878757095153169265L,
7416723840387886089L,
3198487757260057666L,
2564620764005050824L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 93,
    Value = 
new System.Int64[4]
{
1405988885631223520L,
9134126328902262702L,
9026807390290684830L,
3518743272490116859L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 104,
    Value = 
new System.Int64[4]
{
3108138999020323944L,
3316188004371638181L,
6285117141538549303L,
766382352423474847L,
},
    NullableValue = 
new System.Int64[4]
{
2003207381756764405L,
6346127320419937659L,
5799117023480205132L,
8165278084320500529L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
3454906295576249818L,
3679538798422368853L,
3500297898531785206L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Int64[4]
{
7878494924600802711L,
6024361904182412272L,
4454731365132383660L,
7744520075262257541L,
},
    NullableValue = 
new System.Int64[3]
{
5877245845434177397L,
7424125832716193379L,
2428662386070136977L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 96,
    Value = 
new System.Int64[4]
{
8473019593337161474L,
2585078329894754193L,
7742415466723192883L,
350059847618864700L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Int64[4]
{
8667191106474350261L,
735969467826957164L,
4711597259915158371L,
4674734036339333754L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
380277449617738750L,
6913413110186359556L,
5658430237730286083L,
},
},
            new Int64MArrayD1E1M
{
    Id = 103,
    Value = 
new System.Int64[3]
{
6242283953336113841L,
5547187142970134283L,
3543969832071456871L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int64[4]
{
1389617349325640774L,
5816242280930601351L,
1594145133359920478L,
2478127538217403626L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1607554869158037842L,
8372085983548107222L,
6256258973295256586L,
},
},
            new Int64MArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int64[4]
{
7367214314908127664L,
3672736314336187496L,
2176725618895193536L,
8240110727467387009L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.Int64[3]
{
5685230233204698009L,
7659977866762682171L,
8265999666935085733L,
},
    NullableValue = 
new System.Int64[3]
{
5707932094977083195L,
6242404924941533227L,
1953443297610525785L,
},
},
    NullableValue = 
new System.Int64[4]
{
8919599798662039116L,
920018735914403929L,
6035810827108610133L,
8779102954880815453L,
},
},
            new Int64MArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int64[3]
{
6210882135027371045L,
3952224198355091920L,
607317798411538675L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Int64[4]
{
9068640930999281532L,
3718497645329104022L,
6968835559035155736L,
4000147692943764986L,
},
    NullableValue = 
new System.Int64[3]
{
2523270103783068430L,
7385615439410922601L,
3461022528613429660L,
},
},
    NullableValue = 
new System.Int64[4]
{
2791946931597005525L,
5226531201155062728L,
6563492244929554373L,
4667135885241899416L,
},
},
            new Int64MArrayD1E1M
{
    Id = 122,
    Value = 
new System.Int64[3]
{
7953207097513722369L,
8610139690861801824L,
5220714938228863095L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.Int64[4]
{
77043631849342968L,
7361675055062756798L,
3118029541723133176L,
1785930492887512485L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 128,
    Value = 
new System.Int64[4]
{
6111819006372580890L,
3297085586053775348L,
8574618458273582658L,
3691073638649305505L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 145,
    Value = 
new System.Int64[3]
{
4725410684721986640L,
9222258232925340929L,
7543477894310860190L,
},
    NullableValue = 
new System.Int64[3]
{
1859008792964444567L,
6499604960458496809L,
7994611398733293486L,
},
},
    NullableValue = 
new System.Int64[3]
{
2931926958898065740L,
1882097597044887105L,
3541816466518089704L,
},
},
            new Int64MArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int64[4]
{
3539373336652496926L,
7859764549908886850L,
3601461307432821717L,
1724827831956393702L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Int64[3]
{
3667399445613627048L,
4581305604381764908L,
2546445183978229012L,
},
    NullableValue = 
new System.Int64[4]
{
4173050078923409860L,
8527368502711016395L,
5802044680849925106L,
5961179389428011448L,
},
},
    NullableValue = 
new System.Int64[4]
{
573857635294488252L,
8557653763004065708L,
5894291380938313755L,
4046623545953709211L,
},
},
            new Int64MArrayD1E1M
{
    Id = 139,
    Value = 
new System.Int64[3]
{
6422836627413446212L,
7488730985931625434L,
8762326614507283580L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 161,
    Value = 
new System.Int64[3]
{
2141196563438257240L,
2255304024573570788L,
3506124432423448989L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6019998997086905544L,
1801911467929362713L,
3438803651118455642L,
8763494365430236004L,
},
},
            new Int64MArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int64[3]
{
4600874108214009294L,
402535411789887388L,
7681743475498434806L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 170,
    Value = 
new System.Int64[3]
{
7096469053360591617L,
3751847931578522148L,
3800734291185949715L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
46019764653863863L,
304826403463132494L,
9123273274338805361L,
4176387110451278635L,
},
},
            new Int64MArrayD1E1M
{
    Id = 145,
    Value = 
new System.Int64[4]
{
3826167103400396077L,
5441739738307738114L,
186068997308113001L,
4031545593484792458L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 176,
    Value = 
new System.Int64[3]
{
14508495923229771L,
4590000077794674111L,
4934554325010739562L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
3754589697765323561L,
552367139635583573L,
4340597672011234857L,
},
},
            new Int64MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int64[4]
{
2707685289081882498L,
7259327004914072374L,
578523841857769267L,
3646299897648576375L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 179,
    Value = 
new System.Int64[4]
{
1586613691165613289L,
8598381450755458846L,
4831042706854679736L,
8590811617662841663L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 157,
    Value = 
new System.Int64[3]
{
818479220853204959L,
5452143284918159185L,
484363954579962411L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 188,
    Value = 
new System.Int64[3]
{
987666452821129531L,
662072656433127682L,
1238417837207474536L,
},
    NullableValue = 
new System.Int64[4]
{
6910848377075937767L,
5260829395136953319L,
1618172958689139003L,
6007158397606964665L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 163,
    Value = 
new System.Int64[3]
{
7393792414980333025L,
2780000225972190974L,
2679012423300315142L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 193,
    Value = 
new System.Int64[3]
{
201983284345099276L,
3076247577817091526L,
5620509344969453516L,
},
    NullableValue = 
new System.Int64[3]
{
5625035308885756056L,
8750347369679046435L,
2423336676414629850L,
},
},
    NullableValue = 
new System.Int64[4]
{
7220888574128081475L,
400846678385041660L,
8661745780127474368L,
4329144119276586027L,
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

