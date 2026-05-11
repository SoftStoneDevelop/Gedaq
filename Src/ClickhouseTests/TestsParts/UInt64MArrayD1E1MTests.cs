

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
    Id = 5,
    Value = 
new System.UInt64[3]
{
7111373522493449918L,
6022833928802315371L,
5081669878798249698L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 6,
    Value = 
new System.UInt64[3]
{
3056633012484611750L,
20612911008456433L,
881975135093977394L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 12,
    Value = 
new System.UInt64[3]
{
6003709634258857449L,
1062523108606745369L,
313680993267337785L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 7,
    Value = 
new System.UInt64[3]
{
6936697814995834635L,
6672664341441803642L,
1316138894526847641L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 20,
    Value = 
new System.UInt64[4]
{
7116494090248213419L,
5813422753384830574L,
3968356823440940102L,
6746874587163492416L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 15,
    Value = 
new System.UInt64[3]
{
3918136343844729429L,
5249054399606201887L,
7789265329473985405L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8525991659155957418L,
7380156068833146246L,
3117550454935157204L,
775187408710957644L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 23,
    Value = 
new System.UInt64[3]
{
7738393389396515422L,
5939971871502850676L,
2147643952745622071L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 16,
    Value = 
new System.UInt64[4]
{
8326497029688507607L,
2504288137526575398L,
4712663884238496991L,
2504744311917657490L,
},
    NullableValue = 
new System.UInt64[4]
{
7891273888262896128L,
7916080496014144046L,
8624749861965101756L,
4375822181329823650L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt64[4]
{
4338391398932953600L,
2758500829857667330L,
3875151701086639725L,
8885025838005834482L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 25,
    Value = 
new System.UInt64[4]
{
2523087282252244272L,
7141622770438561424L,
3174874251653651893L,
3617930745166068753L,
},
    NullableValue = 
new System.UInt64[3]
{
4963336626482196714L,
5323534372011503671L,
6249641745835745127L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 35,
    Value = 
new System.UInt64[4]
{
8883328146550619359L,
2850655591380170119L,
8599584760773958564L,
811454690957209478L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.UInt64[4]
{
4097730796428568691L,
8550534379973989819L,
8783026011074047390L,
3588038454867244581L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 41,
    Value = 
new System.UInt64[3]
{
3896311525467392352L,
7199151189610048294L,
7039945004292223513L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 42,
    Value = 
new System.UInt64[3]
{
4365441450286268309L,
5042650582917290825L,
3555138835576574195L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 42,
    Value = 
new System.UInt64[3]
{
5859692007057364395L,
2070064082083729557L,
1103988350303288422L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt64[4]
{
2352237550556726370L,
5289641161884083493L,
9056908319173843040L,
7214494107322518247L,
},
    NullableValue = 
new System.UInt64[4]
{
3616327870685345638L,
291493403373346092L,
4637630058357970191L,
7000507683418232710L,
},
},
    NullableValue = 
new System.UInt64[4]
{
6884535720627266379L,
6830884221669305872L,
361800952110321735L,
5400793747779204037L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 45,
    Value = 
new System.UInt64[3]
{
7996186051653119777L,
315690791839510847L,
451213967099316565L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 53,
    Value = 
new System.UInt64[3]
{
8958222740886476249L,
6488380822301019669L,
4138125970713694830L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
5236017026980376769L,
4405310244231163291L,
5636403399465491763L,
2905284479334261118L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 49,
    Value = 
new System.UInt64[4]
{
2490960700621239565L,
8053504474630217789L,
8170138409828151351L,
8098218320324387017L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.UInt64[3]
{
3951793026849346368L,
5328900521970917746L,
3033230296359491675L,
},
    NullableValue = 
new System.UInt64[3]
{
787669327734082261L,
3976657530596729658L,
2658397822639647867L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 56,
    Value = 
new System.UInt64[4]
{
3757598076795476359L,
7038259996150244104L,
7198910602784003585L,
662993868232967254L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.UInt64[3]
{
318235410092804542L,
8336876836121997839L,
273202568674476608L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 62,
    Value = 
new System.UInt64[3]
{
475342151643045028L,
1238765981516695565L,
6322093842109620603L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 60,
    Value = 
new System.UInt64[3]
{
490116934052693662L,
6352140676387923042L,
1147148357502412227L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 67,
    Value = 
new System.UInt64[3]
{
6168469444046498530L,
749851302590261921L,
6929591970037962824L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 67,
    Value = 
new System.UInt64[4]
{
3194544136713140544L,
854122170097053166L,
770618536767844589L,
1207185391054358376L,
},
    NullableValue = 
new System.UInt64[4]
{
5084233822313585589L,
7981247735463365829L,
1128049172648778742L,
6108558902685948379L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 72,
    Value = 
new System.UInt64[4]
{
2465011472958242540L,
2116237481037571513L,
7099014618883944987L,
8052984645925746339L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.UInt64[3]
{
4697242538789196258L,
3343004774530217305L,
591022858832280915L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
6233984923418869387L,
52819224701725982L,
9114676355896816478L,
731344955218115661L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 76,
    Value = 
new System.UInt64[3]
{
7898315903912477205L,
8958675338194332336L,
4485298126720783625L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.UInt64[4]
{
4767431791534796155L,
1488041463552197300L,
4842748925406061984L,
1871436191549375968L,
},
    NullableValue = 
new System.UInt64[3]
{
8548475529136415097L,
296211107609906617L,
4579004259852514560L,
},
},
    NullableValue = 
new System.UInt64[4]
{
5447986617489441650L,
6689886374162509687L,
2427392107745208053L,
6988765325007889596L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 77,
    Value = 
new System.UInt64[4]
{
8576755027161030801L,
8667241570943217419L,
816816005350937808L,
1150549009831059171L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 79,
    Value = 
new System.UInt64[4]
{
5999874621239889977L,
1411116911289460770L,
5258647526825463849L,
3650972625638086874L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
5245063620265972550L,
5522909954130819418L,
7287119454845593883L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 86,
    Value = 
new System.UInt64[4]
{
8588972175129639889L,
4300170576483447875L,
3326280739109052090L,
6240832711470924488L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.UInt64[4]
{
7993782683333413770L,
7256417286508165695L,
6927930663980306235L,
4648246382521240693L,
},
    NullableValue = 
new System.UInt64[3]
{
58290240229664804L,
8526094144639200499L,
5022542252895507023L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 91,
    Value = 
new System.UInt64[3]
{
4721157395374640692L,
5593575279461606826L,
1317100959627448092L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.UInt64[4]
{
134733564564920542L,
2072754569543282173L,
6773430830068546417L,
8684529409139318049L,
},
    NullableValue = 
new System.UInt64[3]
{
6289238666308638607L,
2997597009249912021L,
1042760289564048799L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 94,
    Value = 
new System.UInt64[3]
{
6666835070805752635L,
1158985560228740424L,
6030846215000298845L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.UInt64[3]
{
3401115580932077061L,
3391074302216186141L,
1739350467540907607L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
3081249879844638838L,
4635682262478358441L,
852639605968774134L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 97,
    Value = 
new System.UInt64[3]
{
6050348027934632072L,
1386974059392350837L,
6871042542417170831L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt64[3]
{
1557851802327343897L,
5700196522333333669L,
9097525338922776053L,
},
    NullableValue = 
new System.UInt64[3]
{
8871570473512880717L,
2265010688867753321L,
155998879031720036L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 98,
    Value = 
new System.UInt64[4]
{
5839002016619273599L,
2624872537992351611L,
5405924659540383452L,
4437206548524851811L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt64[3]
{
8796234668430661955L,
4456352428752530479L,
4210581594159633230L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
7243781314752439819L,
1576488496683606773L,
1718472791401148083L,
7170072125946845840L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 100,
    Value = 
new System.UInt64[3]
{
1889239146801898685L,
3930682246265706302L,
7390791135800318594L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt64[3]
{
3152579389711535116L,
8459428841489351490L,
21682633293811067L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
7716662484948202759L,
2357941706827964316L,
3097630295679909078L,
6998011665973410507L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 104,
    Value = 
new System.UInt64[3]
{
8390973559200701872L,
7525205999236148552L,
6033232565462077916L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.UInt64[3]
{
2273254231675815000L,
5608584730137647324L,
4255969922385088883L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 111,
    Value = 
new System.UInt64[3]
{
3940470457090147766L,
5191814533996349436L,
4647277678806279656L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.UInt64[3]
{
8691563874242663485L,
1586967533578550228L,
853953092729455230L,
},
    NullableValue = 
new System.UInt64[4]
{
269489525676340018L,
8908451602452547537L,
4394035175254815791L,
4985110689524190226L,
},
},
    NullableValue = 
new System.UInt64[4]
{
5778194177386226645L,
7820976272118928504L,
8586574688723932591L,
1070225935544416819L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 112,
    Value = 
new System.UInt64[3]
{
6862960915807165998L,
4014481781761036670L,
3155115811153313924L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.UInt64[4]
{
5000536554120724472L,
6766276865468534022L,
1377820160948567438L,
1629130507312651115L,
},
    NullableValue = 
new System.UInt64[4]
{
4004655825244853183L,
8556799460858169875L,
8792297149159097746L,
6298941866814678785L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 117,
    Value = 
new System.UInt64[4]
{
4017674455658025977L,
8045871562588917802L,
6506930408215348193L,
2206162736958706369L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 126,
    Value = 
new System.UInt64[4]
{
6942481033862923514L,
2218808612702472727L,
8517450607382491251L,
671402914888616252L,
},
    NullableValue = 
new System.UInt64[3]
{
5249160755532492L,
7611800487057933197L,
7566724223024287205L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 120,
    Value = 
new System.UInt64[3]
{
4602181493775374765L,
5857163662153534460L,
7107344451438355668L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 134,
    Value = 
new System.UInt64[3]
{
14162276535517692L,
7416859057597189234L,
95674469742830852L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 126,
    Value = 
new System.UInt64[3]
{
7228289310755615822L,
6246605400573101648L,
4777863087614323306L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 141,
    Value = 
new System.UInt64[3]
{
536845278768588303L,
4688758294462272610L,
2357275661250362125L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
4167984572027106628L,
8190200952878159357L,
8540108350549614667L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 135,
    Value = 
new System.UInt64[3]
{
1711717457804679238L,
1982245132850085361L,
3355685356918785854L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 145,
    Value = 
new System.UInt64[4]
{
7081372549087890901L,
990831263976102171L,
7727457825834535528L,
8853122676372022395L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
2829856258416377042L,
3174646602294643021L,
7844942746404478111L,
6329631371218969104L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 138,
    Value = 
new System.UInt64[4]
{
1678676854670157967L,
5387047684732534334L,
6774692935959751905L,
6638991740057170303L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 150,
    Value = 
new System.UInt64[4]
{
6450022139506522182L,
2177304133513812172L,
4319096049852440050L,
1101052728549499220L,
},
    NullableValue = 
new System.UInt64[3]
{
3433150520304711137L,
3474644541748838836L,
4927664144225923168L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 139,
    Value = 
new System.UInt64[4]
{
3043633536443079497L,
4858898315701410647L,
7872705677898454097L,
1070345459532948476L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 152,
    Value = 
new System.UInt64[3]
{
8157112855017551968L,
3807671424692103051L,
2000343787887440169L,
},
    NullableValue = 
new System.UInt64[4]
{
202414958176238580L,
2811877060893915535L,
126724077132587976L,
94677908378090197L,
},
},
    NullableValue = 
new System.UInt64[3]
{
8373146338037914026L,
5724192206433840642L,
1542156304338127038L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 146,
    Value = 
new System.UInt64[3]
{
1601030989762779059L,
3902845654715915786L,
5671751783529874609L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt64[4]
{
6894312979040139184L,
6288984934861025257L,
2442253486057798215L,
2962145721526401080L,
},
    NullableValue = 
new System.UInt64[3]
{
5311400932183589565L,
7779866576357157357L,
1631797531702179014L,
},
},
    NullableValue = 
new System.UInt64[3]
{
7293493584259156136L,
6265105924636841778L,
4946490590195914572L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 155,
    Value = 
new System.UInt64[4]
{
8350640351885252106L,
152023913049646942L,
2576134847092419938L,
1908312742457133348L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 160,
    Value = 
new System.UInt64[3]
{
5226658812327835027L,
1699100888573076740L,
4322821589049527071L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
7014843626746466061L,
642928565877878723L,
7595495845461415784L,
8786253405865144003L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 163,
    Value = 
new System.UInt64[3]
{
3092321454500361819L,
1073656728639644326L,
7428428496208662546L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 163,
    Value = 
new System.UInt64[3]
{
7077046436119328389L,
2726902400973253272L,
1513777889378105244L,
},
    NullableValue = 
new System.UInt64[4]
{
8329005739234280571L,
5624691563114391038L,
860731467600399405L,
3533212557067299312L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 164,
    Value = 
new System.UInt64[4]
{
6362900294832369816L,
2330961275367686212L,
3737775655053553993L,
5480694036766989815L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 167,
    Value = 
new System.UInt64[4]
{
6188691849306268328L,
5825121001447815011L,
6849298886806052364L,
1333168362263004822L,
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

