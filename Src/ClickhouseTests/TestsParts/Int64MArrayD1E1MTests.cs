

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
    Id = 4,
    Value = 
new System.Int64[4]
{
1665715995229071322L,
3567679460713096907L,
6291687653536445501L,
8619599014902499289L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Int64[4]
{
5937726375421146622L,
4170740847616394433L,
3302405324055938763L,
7743523756567480350L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 10,
    Value = 
new System.Int64[3]
{
5621926225532771276L,
8693125368813148859L,
3664662768778403882L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Int64[4]
{
6013975508095915050L,
6048501789804738273L,
1158984023592621972L,
8546689943815932554L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 13,
    Value = 
new System.Int64[4]
{
2254851621314882105L,
5494656742424713478L,
5601611866356715312L,
5282757000686112873L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Int64[3]
{
52291684353570757L,
1556297925047106370L,
2503092565245704875L,
},
    NullableValue = 
new System.Int64[3]
{
3110469546779717614L,
7112970355023253554L,
7960451949024831939L,
},
},
    NullableValue = 
new System.Int64[3]
{
592373166903167453L,
741693206186428394L,
838027349404672796L,
},
},
            new Int64MArrayD1E1M
{
    Id = 18,
    Value = 
new System.Int64[3]
{
1238012842855801141L,
8293951568537123517L,
5998140564165087911L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Int64[4]
{
2096030678568602422L,
4963487522849123698L,
2738952187308493106L,
3366753745056169940L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int64[3]
{
7666653021038212930L,
9143459917119346101L,
4053449410430981621L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Int64[3]
{
7163768423719444271L,
4009570539380288879L,
7054071151061565982L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3698565812946994478L,
999678700423610344L,
839808143973192985L,
6961735287387558712L,
},
},
            new Int64MArrayD1E1M
{
    Id = 30,
    Value = 
new System.Int64[3]
{
8667359287408596361L,
9149727897217834250L,
3386230467908537591L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Int64[3]
{
323425889244211260L,
2497322700970675401L,
8196761662114244727L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 33,
    Value = 
new System.Int64[3]
{
5340233402465190727L,
3642552666627165622L,
2693542474609171635L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Int64[4]
{
8015640545895301415L,
575571099018446554L,
6011908970358823804L,
1965492932810957391L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4429646600365390374L,
6973421242753103155L,
5031776377500835298L,
},
},
            new Int64MArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int64[3]
{
9088561757339162604L,
7966600693244297948L,
8772755222840402949L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Int64[4]
{
2703678497010098567L,
8662731921954040370L,
1500444625523579807L,
8888935012534510062L,
},
    NullableValue = 
new System.Int64[3]
{
1954496553278367104L,
6140801624901113285L,
4137714514149632649L,
},
},
    NullableValue = 
new System.Int64[4]
{
9041298683803333653L,
4930449556068201553L,
1365770041155895956L,
5868117804020209127L,
},
},
            new Int64MArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int64[3]
{
6058698874608833038L,
2637339969038258972L,
5106085016195224964L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int64[3]
{
6631631602464059418L,
3149256948775315780L,
1898194101263414692L,
},
    NullableValue = 
new System.Int64[4]
{
3482661429591929520L,
1073405290689623440L,
202287000284453008L,
3172138168114928677L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int64[4]
{
3355431876702555172L,
8966083970514169181L,
9033920718029308753L,
4668525335486950302L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Int64[3]
{
5014088539389834842L,
4383716144578228665L,
2760406179227693086L,
},
    NullableValue = 
new System.Int64[3]
{
7239428982673524348L,
2395914569534392915L,
5821481215749573932L,
},
},
    NullableValue = 
new System.Int64[4]
{
7930696962712471223L,
8080658050266637934L,
3382286714917008041L,
1800834799806538148L,
},
},
            new Int64MArrayD1E1M
{
    Id = 48,
    Value = 
new System.Int64[3]
{
1973523105904754395L,
4862805607081782594L,
5928188959515214623L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Int64[4]
{
957088881124007900L,
4514303004390594595L,
6365400097092238497L,
111050996224703720L,
},
    NullableValue = 
new System.Int64[4]
{
4382137572672265525L,
5255696694503850351L,
5935713913871858450L,
3177777983420550560L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 57,
    Value = 
new System.Int64[4]
{
4253085366595442439L,
1325942161844229407L,
3740188035137481950L,
837443627868239577L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int64[4]
{
7001016837686206000L,
4015783768086868236L,
5050474079247338096L,
1576946801101280681L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 66,
    Value = 
new System.Int64[4]
{
9168259678991234138L,
4660916347548236873L,
6979325603792360641L,
364440902675767996L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Int64[4]
{
1847939800619122934L,
6805469049843497996L,
3062692821037690861L,
2492976804497322835L,
},
    NullableValue = 
new System.Int64[4]
{
42864323729550126L,
9087997923242627779L,
346492757956157120L,
2590005446767040500L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 70,
    Value = 
new System.Int64[4]
{
7877598840255676570L,
3313061963470593315L,
1017194432557639047L,
827964833266664245L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Int64[3]
{
6918957779204253868L,
1096173445328786192L,
6628004211785451266L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int64[3]
{
5959280816082966964L,
1784245667730957389L,
1174660252640424157L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Int64[4]
{
3937290033094161341L,
2251926829434286185L,
6348106518448445918L,
4072311003109835383L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6938116254098030282L,
4048496235401861100L,
1795746897408407204L,
2136540292138189338L,
},
},
            new Int64MArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int64[3]
{
6152723182559255146L,
1850094318947125537L,
3253075911399673326L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int64[4]
{
1458698319709088954L,
398561706794403939L,
2926375293230139582L,
3619381262475186861L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3817335651920052816L,
9078898192872919232L,
8701148961938855427L,
7088891694137068779L,
},
},
            new Int64MArrayD1E1M
{
    Id = 78,
    Value = 
new System.Int64[3]
{
1164801159028346588L,
2010319489834528001L,
3971338050538256046L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int64[3]
{
8031596069644676066L,
5383434000081187998L,
1121911320377767021L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 87,
    Value = 
new System.Int64[3]
{
7687868925488641938L,
6609401093286133326L,
1719760781750964930L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Int64[4]
{
6058811723329593917L,
5016355020110131189L,
41435628103002834L,
8552112479572436668L,
},
    NullableValue = 
new System.Int64[3]
{
2833423669278458526L,
4078760846292248887L,
4280124381069410947L,
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
8138412734994582168L,
7445879184522274217L,
4776364591392734224L,
105251037464817732L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Int64[3]
{
8412962328627877073L,
4677792571188669490L,
2952284986987600575L,
},
    NullableValue = 
new System.Int64[4]
{
3689465412879994453L,
7878026235644754296L,
4132160796663563469L,
409238097786632643L,
},
},
    NullableValue = 
new System.Int64[4]
{
8306139058437320968L,
8545750928494169563L,
6115611421552974301L,
8425419103805783367L,
},
},
            new Int64MArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int64[4]
{
1227162297667870145L,
8229757533067323274L,
8337562835729688619L,
2729306522097593744L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 92,
    Value = 
new System.Int64[3]
{
4173335517015687092L,
5987515258752415760L,
3969268342033659065L,
},
    NullableValue = 
new System.Int64[3]
{
7267139533859524210L,
8373385125010576855L,
2666764677672947476L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 114,
    Value = 
new System.Int64[4]
{
1926364538495152727L,
3933155955085916777L,
1583169988343450398L,
5701510936023181028L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.Int64[4]
{
9078705531393649375L,
7432968742146722170L,
1061902588234766117L,
2118476481985620729L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 117,
    Value = 
new System.Int64[4]
{
1703690286965931012L,
7966101025749956464L,
1910733244931709307L,
5330142702725340741L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 99,
    Value = 
new System.Int64[4]
{
6846538533591183435L,
1750866032507773245L,
8224890069597141525L,
6481068132224056642L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7576728137899256518L,
7291938927529713838L,
5058186443980914326L,
},
},
            new Int64MArrayD1E1M
{
    Id = 118,
    Value = 
new System.Int64[3]
{
8043404902752510375L,
8657662096224929755L,
4922346036106330087L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Int64[3]
{
5530863541053223990L,
6580973509815274051L,
2094984915943559581L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 119,
    Value = 
new System.Int64[3]
{
8281326793100177499L,
7525907066941735373L,
4178389894698462187L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 108,
    Value = 
new System.Int64[4]
{
5235336963715975042L,
4687401458540514503L,
213087852973357890L,
2458512638485273558L,
},
    NullableValue = 
new System.Int64[4]
{
3330320664038652695L,
5606653605285247953L,
5676445869226364759L,
891510896922229822L,
},
},
    NullableValue = 
new System.Int64[3]
{
8740030308787547008L,
4429907519558687331L,
4387287597744891682L,
},
},
            new Int64MArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int64[4]
{
3748066418293042774L,
3797324056367341600L,
7115247733115714252L,
1395714564912648611L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Int64[4]
{
5739117062882769748L,
7942834951174618748L,
7574659403787521969L,
5175965356303995538L,
},
    NullableValue = 
new System.Int64[4]
{
7479936086002584373L,
7268957890679178078L,
5904498424298779732L,
2690967929982049823L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int64[3]
{
5411819654828129L,
6931182372817090726L,
2423432498709004148L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 117,
    Value = 
new System.Int64[4]
{
5212945607988725550L,
8740247761321280507L,
3743998627469461675L,
8681819501450053311L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
66443777294016343L,
3537001941650751327L,
881810999041457592L,
},
},
            new Int64MArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int64[4]
{
3011997203134261308L,
7623395734393054804L,
6859813964074680899L,
6091370989555032771L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 118,
    Value = 
new System.Int64[4]
{
1891146574959089171L,
6008754069598032936L,
6490520928772204600L,
8099822652274309169L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 144,
    Value = 
new System.Int64[3]
{
4857850690244199798L,
1338477085061045597L,
7007955045317501185L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Int64[3]
{
5062754208426300037L,
8831578118887357406L,
8707000692515150496L,
},
    NullableValue = 
new System.Int64[3]
{
8020301726003067113L,
3734620084620089744L,
4373487201659176522L,
},
},
    NullableValue = 
new System.Int64[3]
{
6680366378722624071L,
6641305235014425491L,
7260461369519431546L,
},
},
            new Int64MArrayD1E1M
{
    Id = 146,
    Value = 
new System.Int64[3]
{
7486839718241828953L,
4964764913346862336L,
6924956066957576279L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Int64[3]
{
3061065480925689467L,
2914727897638080201L,
5128428369407249660L,
},
    NullableValue = 
new System.Int64[3]
{
4610724890075987449L,
3766161104850336079L,
4622809738284311937L,
},
},
    NullableValue = 
new System.Int64[4]
{
6755125828312329451L,
6662605414322794171L,
8785115585040336695L,
960115335578741484L,
},
},
            new Int64MArrayD1E1M
{
    Id = 147,
    Value = 
new System.Int64[4]
{
6493671295719348591L,
7091019088559864037L,
3096079371781317101L,
8500065069601268627L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Int64[3]
{
1415183008084686419L,
3251144545807318251L,
9086137656060079049L,
},
    NullableValue = 
new System.Int64[4]
{
2069994078302005304L,
8625542274588185310L,
7699357481132615615L,
1192492484088430353L,
},
},
    NullableValue = 
new System.Int64[3]
{
231597177471991299L,
8044034151896770512L,
7441561341842205055L,
},
},
            new Int64MArrayD1E1M
{
    Id = 151,
    Value = 
new System.Int64[4]
{
8758266796962744795L,
2448874659761984153L,
6133920416300318235L,
4883566916842179985L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Int64[4]
{
3284536548574247791L,
4268423922742225288L,
864625779843738260L,
188532335122006135L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
966979838048839569L,
3127520936005119881L,
7605911346366401673L,
2243918242754825425L,
},
},
            new Int64MArrayD1E1M
{
    Id = 160,
    Value = 
new System.Int64[3]
{
5427119025914799149L,
8416232651979693514L,
2360751473595894751L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 133,
    Value = 
new System.Int64[4]
{
7753766709832320482L,
5519415767545356136L,
5267681222570997012L,
1212589129446552410L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int64[4]
{
6911881347240205745L,
4565884493368206494L,
8285055856329237696L,
4989695190002422522L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 142,
    Value = 
new System.Int64[3]
{
3182255429870471659L,
8545541090796075744L,
3347499213176390393L,
},
    NullableValue = 
new System.Int64[3]
{
1759941610757213880L,
1669898907102191735L,
3179807930407639462L,
},
},
    NullableValue = null,
},
            new Int64MArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int64[3]
{
8473520526455861375L,
5942256292917439503L,
4057639223277888307L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.Int64[3]
{
5309710004363877790L,
4077525805500461418L,
5247150098749647299L,
},
    NullableValue = 
new System.Int64[4]
{
8752199950187003473L,
2317249115918202413L,
4052877229680652928L,
4736504803765799362L,
},
},
    NullableValue = 
new System.Int64[3]
{
5933710124674459079L,
224785018468183458L,
1203574638802147134L,
},
},
            new Int64MArrayD1E1M
{
    Id = 176,
    Value = 
new System.Int64[3]
{
14565237928281623L,
6895876854080259312L,
7021079791510483047L,
},
    ModelInner = new Int64MArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Int64[3]
{
2049584159948273167L,
2936743583264795897L,
8538020793196640930L,
},
    NullableValue = 
new System.Int64[4]
{
5483391587930789432L,
8238946646473267548L,
1003357743663263223L,
6292314657959234797L,
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

