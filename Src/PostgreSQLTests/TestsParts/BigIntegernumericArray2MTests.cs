

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
    internal partial interface IBigIntegerListnumericArray
    {
    }
    
    internal partial class BigIntegerListnumericArray : IBigIntegerListnumericArray
    {


#region TestData

        private readonly BigIntegernumericArray2M[] _testData = new BigIntegernumericArray2M[]
        {
            new BigIntegernumericArray2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9084560021907504303L),

new System.Numerics.BigInteger(1052399296685559644L),

new System.Numerics.BigInteger(1075818889566138532L),

new System.Numerics.BigInteger(4067856051636339022L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7118908946457055225L),

new System.Numerics.BigInteger(4568463089658229382L),

new System.Numerics.BigInteger(5426859467536910246L),

new System.Numerics.BigInteger(7153036678353261009L),

},
},
            new BigIntegernumericArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4367713415006609105L),

new System.Numerics.BigInteger(904422042964071690L),

new System.Numerics.BigInteger(2190343038664374815L),

new System.Numerics.BigInteger(1981031592216972225L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6930419699517114437L),

new System.Numerics.BigInteger(5846176286822383135L),

new System.Numerics.BigInteger(1991972509817857797L),

new System.Numerics.BigInteger(1911943652903355542L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1017258869112397707L),

new System.Numerics.BigInteger(6462423944086628769L),

new System.Numerics.BigInteger(518298350029348369L),

new System.Numerics.BigInteger(8955191639520313561L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5185882153244165278L),

new System.Numerics.BigInteger(826951140722038578L),

new System.Numerics.BigInteger(3431582448146917869L),

new System.Numerics.BigInteger(3937344447046418783L),

},
},
            new BigIntegernumericArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2542626680131385959L),

new System.Numerics.BigInteger(5879599008625645093L),

new System.Numerics.BigInteger(2930761710457388097L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5435633201897102069L),

new System.Numerics.BigInteger(69454732675692640L),

new System.Numerics.BigInteger(5461570308623157036L),

new System.Numerics.BigInteger(1686068764443302275L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6196239378370741734L),

new System.Numerics.BigInteger(6658516048697451121L),

new System.Numerics.BigInteger(7579258141064035487L),

new System.Numerics.BigInteger(7966237050900318093L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5751922117051930170L),

new System.Numerics.BigInteger(9051461467790541447L),

new System.Numerics.BigInteger(5649481089561907856L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3461177998630066870L),

new System.Numerics.BigInteger(6562880743054497951L),

new System.Numerics.BigInteger(8427506748765081024L),

new System.Numerics.BigInteger(656153618411611951L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7974506696792964284L),

new System.Numerics.BigInteger(4675064688715174831L),

new System.Numerics.BigInteger(8838793206065260972L),

new System.Numerics.BigInteger(6328415785821678060L),

},
},
            new BigIntegernumericArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3512335247587118832L),

new System.Numerics.BigInteger(3567867921061307883L),

new System.Numerics.BigInteger(6726779620951520223L),

new System.Numerics.BigInteger(7825265320438150525L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6793230173435568850L),

new System.Numerics.BigInteger(7798008463217947649L),

new System.Numerics.BigInteger(4863394784102260108L),

new System.Numerics.BigInteger(7822501576247273333L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4304381767448993303L),

new System.Numerics.BigInteger(7688057584306573267L),

new System.Numerics.BigInteger(5087365155478544760L),

new System.Numerics.BigInteger(5839191855902707869L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1204415471894413800L),

new System.Numerics.BigInteger(471496703507737649L),

new System.Numerics.BigInteger(7005294423189772325L),

},
},
            new BigIntegernumericArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1889863191938145163L),

new System.Numerics.BigInteger(572240141774036968L),

new System.Numerics.BigInteger(5295693854178959804L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1701902746552611346L),

new System.Numerics.BigInteger(6098248693401902967L),

new System.Numerics.BigInteger(8253400197969864259L),

},
},
            new BigIntegernumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(462314624794719111L),

new System.Numerics.BigInteger(5179162192693864165L),

new System.Numerics.BigInteger(3759336959825520234L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1031126917916253728L),

new System.Numerics.BigInteger(1830441676432146601L),

new System.Numerics.BigInteger(2189883862439208779L),

new System.Numerics.BigInteger(7235616311108881538L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4180025774350339672L),

new System.Numerics.BigInteger(393143009282682411L),

new System.Numerics.BigInteger(3409875660317546480L),

new System.Numerics.BigInteger(7758114217853073737L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6765529377300260156L),

new System.Numerics.BigInteger(1549764408916707704L),

new System.Numerics.BigInteger(5826393459316386183L),

new System.Numerics.BigInteger(3077762419586950297L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4714095707397209700L),

new System.Numerics.BigInteger(7925401406302052357L),

new System.Numerics.BigInteger(7526416717695037335L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6903705448284625326L),

new System.Numerics.BigInteger(1804957225655347260L),

new System.Numerics.BigInteger(2521625315748192188L),

new System.Numerics.BigInteger(5070107147920446208L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(392290611776955099L),

new System.Numerics.BigInteger(6827636992587514104L),

new System.Numerics.BigInteger(2867733519738194759L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7589392422856844080L),

new System.Numerics.BigInteger(2331404040814993577L),

new System.Numerics.BigInteger(8824769719750843847L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6169135039121288209L),

new System.Numerics.BigInteger(5393600549262579440L),

new System.Numerics.BigInteger(1314476089219590113L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6377394500336935827L),

new System.Numerics.BigInteger(4944175089165793277L),

new System.Numerics.BigInteger(6220110948383002879L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5448135748190669856L),

new System.Numerics.BigInteger(811010476427386953L),

new System.Numerics.BigInteger(5774288748100649353L),

},
},
            new BigIntegernumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5683506904424815520L),

new System.Numerics.BigInteger(5234323793106060537L),

new System.Numerics.BigInteger(4705304080513184625L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4819904869794133679L),

new System.Numerics.BigInteger(7319461372477760619L),

new System.Numerics.BigInteger(7095335917513247648L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1441150659141994514L),

new System.Numerics.BigInteger(7546028798234525831L),

new System.Numerics.BigInteger(8607675342317120419L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6502153627244747886L),

new System.Numerics.BigInteger(8862432452756089955L),

new System.Numerics.BigInteger(8690230373443293603L),

},
},
            new BigIntegernumericArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7075519646162514569L),

new System.Numerics.BigInteger(4541493992559090846L),

new System.Numerics.BigInteger(4719000519613561203L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1165059604109962793L),

new System.Numerics.BigInteger(963209724973017583L),

new System.Numerics.BigInteger(936989033551411304L),

new System.Numerics.BigInteger(8253625876735766725L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1452609048002529658L),

new System.Numerics.BigInteger(897502010269681388L),

new System.Numerics.BigInteger(1265616050959832268L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2404115942134225004L),

new System.Numerics.BigInteger(1119000596583050463L),

new System.Numerics.BigInteger(8484754584377551686L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9088315441164492060L),

new System.Numerics.BigInteger(2978003497577665166L),

new System.Numerics.BigInteger(5485268384182289688L),

},
},
            new BigIntegernumericArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6388894706208143399L),

new System.Numerics.BigInteger(5831038039231967439L),

new System.Numerics.BigInteger(3653721641098694207L),

new System.Numerics.BigInteger(6441154818344185012L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8513557301315465642L),

new System.Numerics.BigInteger(8197337551083969568L),

new System.Numerics.BigInteger(2902671179684363692L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7354444351965546910L),

new System.Numerics.BigInteger(3963254924583479547L),

new System.Numerics.BigInteger(6980786766407132640L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8817863739246177162L),

new System.Numerics.BigInteger(4369002388266572618L),

new System.Numerics.BigInteger(7035725232446427637L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5733696488056335506L),

new System.Numerics.BigInteger(6984356279532225363L),

new System.Numerics.BigInteger(7089909864270522053L),

new System.Numerics.BigInteger(8575522703101668718L),

},
},
            new BigIntegernumericArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7566472710633615579L),

new System.Numerics.BigInteger(6296691962981753251L),

new System.Numerics.BigInteger(1991398046948821641L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4611013832821612406L),

new System.Numerics.BigInteger(1714932018117706914L),

new System.Numerics.BigInteger(1673378445044877890L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1756508521093822L),

new System.Numerics.BigInteger(6019952068779023309L),

new System.Numerics.BigInteger(4187067944425195773L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6851987223902585443L),

new System.Numerics.BigInteger(3763781918348432758L),

new System.Numerics.BigInteger(8746506035774922018L),

new System.Numerics.BigInteger(281123353750054172L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2380720016886965875L),

new System.Numerics.BigInteger(8655240605578494712L),

new System.Numerics.BigInteger(1018403864816073243L),

new System.Numerics.BigInteger(3349672868500009040L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3283646558327469925L),

new System.Numerics.BigInteger(7154100286493629280L),

new System.Numerics.BigInteger(3494377756656839231L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3261441483196173864L),

new System.Numerics.BigInteger(7468801971113349117L),

new System.Numerics.BigInteger(4801030996758446415L),

},
},
            new BigIntegernumericArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6159176255570777067L),

new System.Numerics.BigInteger(5376676606820448601L),

new System.Numerics.BigInteger(4702078514099442149L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(926592780169843464L),

new System.Numerics.BigInteger(3037820199223329574L),

new System.Numerics.BigInteger(4391328275595690065L),

new System.Numerics.BigInteger(5291759917867914297L),

},
},
            new BigIntegernumericArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(368290528154184265L),

new System.Numerics.BigInteger(8182240100868199878L),

new System.Numerics.BigInteger(8116348191382011873L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7107071748929502492L),

new System.Numerics.BigInteger(436489405065805921L),

new System.Numerics.BigInteger(6509073201919598837L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8308902082654110356L),

new System.Numerics.BigInteger(3677451791921356882L),

new System.Numerics.BigInteger(2167664337161238951L),

},
},
            new BigIntegernumericArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1222179394838309203L),

new System.Numerics.BigInteger(5589357095182550611L),

new System.Numerics.BigInteger(940178559059958339L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(729395020340290042L),

new System.Numerics.BigInteger(8044032308163383026L),

new System.Numerics.BigInteger(4545230979008017436L),

new System.Numerics.BigInteger(1378671839183338845L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2528842805922206539L),

new System.Numerics.BigInteger(1408715074217232859L),

new System.Numerics.BigInteger(2545909405770769516L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4017449344757460341L),

new System.Numerics.BigInteger(7917188769420013456L),

new System.Numerics.BigInteger(4950728666637913398L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1641538559907811416L),

new System.Numerics.BigInteger(7487286725537535667L),

new System.Numerics.BigInteger(7037090300453188171L),

new System.Numerics.BigInteger(5977407554609136799L),

},
},
            new BigIntegernumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6138264840625139048L),

new System.Numerics.BigInteger(7962601055814982260L),

new System.Numerics.BigInteger(1094536735729576580L),

new System.Numerics.BigInteger(4249546407746977074L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2998974296329976459L),

new System.Numerics.BigInteger(4694935416661563940L),

new System.Numerics.BigInteger(7472538142609952052L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8615881660854548507L),

new System.Numerics.BigInteger(7984349079467286167L),

new System.Numerics.BigInteger(3143078043031983677L),

new System.Numerics.BigInteger(6760877202946487413L),

},
},
            new BigIntegernumericArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3195517752716048496L),

new System.Numerics.BigInteger(5759082561118229712L),

new System.Numerics.BigInteger(1115098767117188007L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8653895322996804659L),

new System.Numerics.BigInteger(2387392934074445784L),

new System.Numerics.BigInteger(4835544466482520996L),

},
},
            new BigIntegernumericArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1591045129195586328L),

new System.Numerics.BigInteger(521038779236572249L),

new System.Numerics.BigInteger(1306448436645779507L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5246211826462803883L),

new System.Numerics.BigInteger(1735308593671294141L),

new System.Numerics.BigInteger(1120334577263626862L),

new System.Numerics.BigInteger(7955557516109154522L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5131311862055011325L),

new System.Numerics.BigInteger(249862632551598583L),

new System.Numerics.BigInteger(4694218542013471285L),

new System.Numerics.BigInteger(8140458571653773863L),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
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

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray2M> models = null;

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray2M> models = null;

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[29], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M), typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                await((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray2M>();
                var models2 = new List<FlatBigIntegernumericArray2M>();
                ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 125, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var firstItems2 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 92, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 93, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
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
FROM public.bigintegernumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems1 = new List<FlatBigIntegernumericArray2M>();
                var secondItems2 = new List<FlatBigIntegernumericArray2M>();
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 33, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await((IBigIntegerListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 61, 2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((IBigIntegerListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 12, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[29], false);
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
                await using var cmd = await ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
BigIntegernumericArray2M.AssertModel(models[0],_testData[2], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[3], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[4], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[5], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[6], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[7], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[23],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[24],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[25],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[26],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
BigIntegernumericArray2M.AssertModel(models[0],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[29], false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray2M),
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
FROM public.binary_bigintegernumericarray2m m
LEFT JOIN public.binary_bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IBigIntegerListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IBigIntegerListnumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IBigIntegerListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[0], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[1], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[2], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[3], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[4], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[5], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[23],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[24],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[25],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[26],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[27],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[28],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray2M)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
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
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

