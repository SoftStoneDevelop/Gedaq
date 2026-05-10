

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6059476819904571219L),
new System.Numerics.BigInteger(2260577439545784880L),
new System.Numerics.BigInteger(324172806370673503L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2723708869470874446L),
new System.Numerics.BigInteger(2705397389324686745L),
new System.Numerics.BigInteger(3677747352409398337L),
new System.Numerics.BigInteger(2687317578617706515L),
},
},
            new BigIntegernumericArray1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(203723761451954668L),
new System.Numerics.BigInteger(7124006278109643497L),
new System.Numerics.BigInteger(8616085234630383346L),
new System.Numerics.BigInteger(8741580164774259311L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4520016247620702573L),
new System.Numerics.BigInteger(7018806668071025736L),
new System.Numerics.BigInteger(4813326960892871259L),
new System.Numerics.BigInteger(2201041974210170394L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2938249595451890066L),
new System.Numerics.BigInteger(6504965815087094523L),
new System.Numerics.BigInteger(1716235590601816943L),
new System.Numerics.BigInteger(9184648917937434450L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 24,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8867131240431363406L),
new System.Numerics.BigInteger(5691417456650916572L),
new System.Numerics.BigInteger(6673178158414154236L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1706161157617525730L),
new System.Numerics.BigInteger(5077673218658899435L),
new System.Numerics.BigInteger(6088466285460545928L),
new System.Numerics.BigInteger(4368822955409977828L),
},
},
            new BigIntegernumericArray1M
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7785937023567114655L),
new System.Numerics.BigInteger(892500153790933266L),
new System.Numerics.BigInteger(8010384695976967195L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6214184320132517929L),
new System.Numerics.BigInteger(8014643373210225698L),
new System.Numerics.BigInteger(7770661202374812780L),
new System.Numerics.BigInteger(293297044799513319L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6783846158342984566L),
new System.Numerics.BigInteger(4134406542153983408L),
new System.Numerics.BigInteger(4807328326421928615L),
new System.Numerics.BigInteger(2304319229011190637L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3981490813511602567L),
new System.Numerics.BigInteger(8838059976047140010L),
new System.Numerics.BigInteger(8231531485795566429L),
new System.Numerics.BigInteger(4474644180071940657L),
},
},
            new BigIntegernumericArray1M
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8101675361985943031L),
new System.Numerics.BigInteger(5284235122151607416L),
new System.Numerics.BigInteger(8235341014930016745L),
new System.Numerics.BigInteger(1937475448324021098L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3936694352339101429L),
new System.Numerics.BigInteger(4977468284325821626L),
new System.Numerics.BigInteger(2896124783913503751L),
new System.Numerics.BigInteger(3411871607599141695L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4772293161946861360L),
new System.Numerics.BigInteger(6574845430238297615L),
new System.Numerics.BigInteger(2337959955765332982L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1385603749699471494L),
new System.Numerics.BigInteger(200576066578663808L),
new System.Numerics.BigInteger(1581437319013382248L),
new System.Numerics.BigInteger(5850296898513994425L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1898483290315312970L),
new System.Numerics.BigInteger(8617523267751486605L),
new System.Numerics.BigInteger(3771924084981633437L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8746337355826403183L),
new System.Numerics.BigInteger(7436404519409722073L),
new System.Numerics.BigInteger(7873645306373193078L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1357473538918092043L),
new System.Numerics.BigInteger(3725121945198986035L),
new System.Numerics.BigInteger(5258952243609656176L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1641977067487250397L),
new System.Numerics.BigInteger(6878042256280676168L),
new System.Numerics.BigInteger(3083223182547323911L),
},
},
            new BigIntegernumericArray1M
{
    Id = 57,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1466205326379202902L),
new System.Numerics.BigInteger(2035218022079678452L),
new System.Numerics.BigInteger(7812505239112639419L),
new System.Numerics.BigInteger(3986448136470697574L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3640827382565288781L),
new System.Numerics.BigInteger(3015287566967416622L),
new System.Numerics.BigInteger(8753975222147429585L),
},
},
            new BigIntegernumericArray1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4736974642234356592L),
new System.Numerics.BigInteger(972762179598976263L),
new System.Numerics.BigInteger(7317037049030417555L),
new System.Numerics.BigInteger(1000758617061797501L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2559715466303455998L),
new System.Numerics.BigInteger(2467847793952902172L),
new System.Numerics.BigInteger(3086170630928501891L),
new System.Numerics.BigInteger(3712809593573422806L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4496532972903462926L),
new System.Numerics.BigInteger(3757152814704344141L),
new System.Numerics.BigInteger(3644405812641708754L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7089005854862101669L),
new System.Numerics.BigInteger(451834095496002934L),
new System.Numerics.BigInteger(5339986052964266193L),
},
},
            new BigIntegernumericArray1M
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8080848389934777859L),
new System.Numerics.BigInteger(6260663585292531099L),
new System.Numerics.BigInteger(6805539061620554993L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(582013480768311060L),
new System.Numerics.BigInteger(6225136349438879357L),
new System.Numerics.BigInteger(2456208956583133925L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5506055240179282339L),
new System.Numerics.BigInteger(1735262542645677313L),
new System.Numerics.BigInteger(682098134655804899L),
new System.Numerics.BigInteger(1812428079695795635L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7854925405669260682L),
new System.Numerics.BigInteger(2977282673926992016L),
new System.Numerics.BigInteger(7308412233920565236L),
},
},
            new BigIntegernumericArray1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5443489954357426938L),
new System.Numerics.BigInteger(4723490087760727455L),
new System.Numerics.BigInteger(1199728936921031532L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3188993331826339484L),
new System.Numerics.BigInteger(3782715714187263860L),
new System.Numerics.BigInteger(5174995184004515792L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(536112759001427587L),
new System.Numerics.BigInteger(4559668316327001744L),
new System.Numerics.BigInteger(4631545764120511148L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3982020204329757194L),
new System.Numerics.BigInteger(8359998071993727880L),
new System.Numerics.BigInteger(6261404542249943641L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(719528911226548889L),
new System.Numerics.BigInteger(4384214997318528369L),
new System.Numerics.BigInteger(2802048978626323201L),
},
},
            new BigIntegernumericArray1M
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5239165287876334958L),
new System.Numerics.BigInteger(3553000145622501796L),
new System.Numerics.BigInteger(7690301762252014796L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4859258854379203935L),
new System.Numerics.BigInteger(1399361167679584244L),
new System.Numerics.BigInteger(3326289825867150626L),
new System.Numerics.BigInteger(8090697349434907535L),
},
},
            new BigIntegernumericArray1M
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3129686993603480759L),
new System.Numerics.BigInteger(3029799026046787517L),
new System.Numerics.BigInteger(4342258351605851L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 36,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3110182410479543687L),
new System.Numerics.BigInteger(4257319479310909594L),
new System.Numerics.BigInteger(5930141824155206636L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7320544074612547854L),
new System.Numerics.BigInteger(947696664918806960L),
new System.Numerics.BigInteger(9002289417654971184L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 95,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8349075407326317963L),
new System.Numerics.BigInteger(5573466087385851156L),
new System.Numerics.BigInteger(5853818403621994763L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 96,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2886184530853927306L),
new System.Numerics.BigInteger(7078918293591152931L),
new System.Numerics.BigInteger(2229074414212346177L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9028896418654893278L),
new System.Numerics.BigInteger(2209040409607039087L),
new System.Numerics.BigInteger(4091657290347544058L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9101284217082442848L),
new System.Numerics.BigInteger(3278793246078941992L),
new System.Numerics.BigInteger(2512120938167954607L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2251991142115055958L),
new System.Numerics.BigInteger(6743813270658695139L),
new System.Numerics.BigInteger(1183940111934739588L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(969549213318736376L),
new System.Numerics.BigInteger(8628481011397928508L),
new System.Numerics.BigInteger(8394289616999920817L),
},
},
            new BigIntegernumericArray1M
{
    Id = 110,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3213216105129300409L),
new System.Numerics.BigInteger(7182099874283266603L),
new System.Numerics.BigInteger(5549822087776529001L),
new System.Numerics.BigInteger(5261747389108613521L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4628088994008396411L),
new System.Numerics.BigInteger(689138265249243811L),
new System.Numerics.BigInteger(1542118387719108701L),
new System.Numerics.BigInteger(148703403786864382L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(537341594748606053L),
new System.Numerics.BigInteger(8405190139123806171L),
new System.Numerics.BigInteger(4012273103322186377L),
new System.Numerics.BigInteger(974906268742432075L),
},
},
            new BigIntegernumericArray1M
{
    Id = 113,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1948756197815220172L),
new System.Numerics.BigInteger(6191172874657102185L),
new System.Numerics.BigInteger(4597680224348050319L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 117,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(817386538487132562L),
new System.Numerics.BigInteger(1722897625522262763L),
new System.Numerics.BigInteger(6565279209499259078L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7574423644435959007L),
new System.Numerics.BigInteger(4344997597730039253L),
new System.Numerics.BigInteger(329078351470468694L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7570229516044201484L),
new System.Numerics.BigInteger(4945099454814015360L),
new System.Numerics.BigInteger(792113854056269813L),
new System.Numerics.BigInteger(2526927277603448158L),
},
},
            new BigIntegernumericArray1M
{
    Id = 119,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8421763261054939301L),
new System.Numerics.BigInteger(4805279710814825453L),
new System.Numerics.BigInteger(1154787976254587720L),
new System.Numerics.BigInteger(7817144609835518140L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(158380376358596617L),
new System.Numerics.BigInteger(718158409677071751L),
new System.Numerics.BigInteger(2626853120764182478L),
new System.Numerics.BigInteger(8951467543639529758L),
},
},
            new BigIntegernumericArray1M
{
    Id = 121,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8848376570670714142L),
new System.Numerics.BigInteger(7928529837604355873L),
new System.Numerics.BigInteger(4755624526080055232L),
new System.Numerics.BigInteger(3487949002484201498L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7932449368677581882L),
new System.Numerics.BigInteger(5961471777680149875L),
new System.Numerics.BigInteger(7687453761348062114L),
new System.Numerics.BigInteger(6740478122222061567L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7807170840713465406L),
new System.Numerics.BigInteger(7783313148816343590L),
new System.Numerics.BigInteger(3494061593778334406L),
new System.Numerics.BigInteger(6166139562793791804L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 132,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8053569210339777825L),
new System.Numerics.BigInteger(2723855861353805601L),
new System.Numerics.BigInteger(4534003079533174634L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1616816313529136680L),
new System.Numerics.BigInteger(7835259395244418567L),
new System.Numerics.BigInteger(2387772623412577209L),
new System.Numerics.BigInteger(4228962961075492972L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2557077198253099668L),
new System.Numerics.BigInteger(1143812379528592L),
new System.Numerics.BigInteger(7468166388186969780L),
new System.Numerics.BigInteger(1886382856670567064L),
},
},
            new BigIntegernumericArray1M
{
    Id = 140,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3580232560664509805L),
new System.Numerics.BigInteger(4448018099859390920L),
new System.Numerics.BigInteger(573884327303303338L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4213647863292192493L),
new System.Numerics.BigInteger(6982691860689982704L),
new System.Numerics.BigInteger(3995781148443417175L),
},
},
            new BigIntegernumericArray1M
{
    Id = 142,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(694638818220960142L),
new System.Numerics.BigInteger(1541926684899981840L),
new System.Numerics.BigInteger(4404096418590723027L),
new System.Numerics.BigInteger(3451173973359307575L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5868502849882043804L),
new System.Numerics.BigInteger(1523564267257943167L),
new System.Numerics.BigInteger(2069468010777255210L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 151,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4461342509866054715L),
new System.Numerics.BigInteger(2048476209035553693L),
new System.Numerics.BigInteger(7820203093073043799L),
new System.Numerics.BigInteger(3482588164125085980L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 158,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5635165805480390684L),
new System.Numerics.BigInteger(744447240913595695L),
new System.Numerics.BigInteger(5003706798957169888L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4971166438609262123L),
new System.Numerics.BigInteger(352305788919420070L),
new System.Numerics.BigInteger(1208959077195651915L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2439810024482338263L),
new System.Numerics.BigInteger(2374197522642138850L),
new System.Numerics.BigInteger(6455047638160685939L),
new System.Numerics.BigInteger(3094086308549591689L),
},
},
            new BigIntegernumericArray1M
{
    Id = 160,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8764959053170472128L),
new System.Numerics.BigInteger(2021264950663898067L),
new System.Numerics.BigInteger(5049032096579628110L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 167,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7256183181102012832L),
new System.Numerics.BigInteger(8097145804610474621L),
new System.Numerics.BigInteger(8213201442804752791L),
new System.Numerics.BigInteger(2202864352034756900L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 82,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6680744011915391754L),
new System.Numerics.BigInteger(211439962437214756L),
new System.Numerics.BigInteger(6162322776389012209L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7983628645274460775L),
new System.Numerics.BigInteger(7138116154536527194L),
new System.Numerics.BigInteger(8583225355654483634L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 171,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(29081468954398913L),
new System.Numerics.BigInteger(1458368807486602358L),
new System.Numerics.BigInteger(4377052660093213104L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 175,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4632293089703676998L),
new System.Numerics.BigInteger(3341627525450137010L),
new System.Numerics.BigInteger(6977552281477835277L),
new System.Numerics.BigInteger(8524035139709845589L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3069929250522323406L),
new System.Numerics.BigInteger(255428788548324313L),
new System.Numerics.BigInteger(1730627448513942806L),
new System.Numerics.BigInteger(4856546138470168546L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 176,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3968098514676037795L),
new System.Numerics.BigInteger(3815690532524985760L),
new System.Numerics.BigInteger(3251086803283054310L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4937064538964842662L),
new System.Numerics.BigInteger(6478971505548148471L),
new System.Numerics.BigInteger(5360327260820047424L),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 88, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 27, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 110, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 27, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 119, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 57, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 27, 24))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 53, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);
                BigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);
                BigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);
                BigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);
                BigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);
                BigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);
                BigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
                BigIntegernumericArray1M.AssertModel(models[7],_testData[30], false);
                BigIntegernumericArray1M.AssertModel(models[8],_testData[31], false);
                BigIntegernumericArray1M.AssertModel(models[9],_testData[32], false);
                BigIntegernumericArray1M.AssertModel(models[10],_testData[33], false);
                BigIntegernumericArray1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI), typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                await ((IBigIntegerArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                ((IBigIntegerArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

