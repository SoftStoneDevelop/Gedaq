

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
    internal partial interface IBigIntegerListnumericListD1
    {
    }
    
    internal partial class BigIntegerListnumericListD1 : IBigIntegerListnumericListD1
    {


#region TestData

        private readonly BigIntegernumericListD1E2M[] _testData = new BigIntegernumericListD1E2M[]
        {
            new BigIntegernumericListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1014153263396520952L),

new System.Numerics.BigInteger(280120788990566915L),

new System.Numerics.BigInteger(7896835782769663965L),

new System.Numerics.BigInteger(3880555292422867502L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8170625273297969670L),

new System.Numerics.BigInteger(1860250019236793668L),

new System.Numerics.BigInteger(6460762150188229600L),

new System.Numerics.BigInteger(2454702006815820417L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2219556038415306866L),

new System.Numerics.BigInteger(6993388409230750864L),

new System.Numerics.BigInteger(921433079320603546L),

new System.Numerics.BigInteger(3450960765275615254L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6160895385065619370L),

new System.Numerics.BigInteger(403590370055319497L),

new System.Numerics.BigInteger(2998337193733811166L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7467837853224890516L),

new System.Numerics.BigInteger(7917587843679771059L),

new System.Numerics.BigInteger(4411348119715001834L),

new System.Numerics.BigInteger(3841952037856828805L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4652001876491984925L),

new System.Numerics.BigInteger(5295801378555564000L),

new System.Numerics.BigInteger(2224801592231885239L),

new System.Numerics.BigInteger(211352438504621499L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2902562737132345418L),

new System.Numerics.BigInteger(2493265187798125634L),

new System.Numerics.BigInteger(1741335290819974792L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(559087649688247375L),

new System.Numerics.BigInteger(3302636763127784376L),

new System.Numerics.BigInteger(3947591945470667797L),

new System.Numerics.BigInteger(4972705400188326934L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7712351149234793513L),

new System.Numerics.BigInteger(8703030791498302449L),

new System.Numerics.BigInteger(4381199184068506073L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9076571469301555120L),

new System.Numerics.BigInteger(8911020333305074747L),

new System.Numerics.BigInteger(1684696861797235935L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2052439174538250704L),

new System.Numerics.BigInteger(2472442576597662689L),

new System.Numerics.BigInteger(8536612635328167618L),

new System.Numerics.BigInteger(7234821882205019557L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6452672677295985345L),

new System.Numerics.BigInteger(8770546435080458696L),

new System.Numerics.BigInteger(4876894604402177796L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(313337415024668958L),

new System.Numerics.BigInteger(7580488339005895385L),

new System.Numerics.BigInteger(2255723109057293144L),

new System.Numerics.BigInteger(6536826837657466223L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7189829524909568614L),

new System.Numerics.BigInteger(829329899847984177L),

new System.Numerics.BigInteger(6763462792045036109L),

new System.Numerics.BigInteger(7459837472959364495L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5822561392505955690L),

new System.Numerics.BigInteger(5750059451262924309L),

new System.Numerics.BigInteger(6189159759315630898L),

new System.Numerics.BigInteger(7556427692030809869L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4638978613146677808L),

new System.Numerics.BigInteger(7458856894615805416L),

new System.Numerics.BigInteger(3644840854935304687L),

new System.Numerics.BigInteger(343876465868950306L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1665801958008543489L),

new System.Numerics.BigInteger(4966790648714346400L),

new System.Numerics.BigInteger(8219651490486950517L),

new System.Numerics.BigInteger(1890794014898900385L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6031925842746592875L),

new System.Numerics.BigInteger(5845635082773091179L),

new System.Numerics.BigInteger(8992027710200294326L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(392197040563787726L),

new System.Numerics.BigInteger(2593688361664432989L),

new System.Numerics.BigInteger(1021729684676116400L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3685605222291663794L),

new System.Numerics.BigInteger(502656618967237488L),

new System.Numerics.BigInteger(2241002401724792110L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4953933813409554429L),

new System.Numerics.BigInteger(2233044873065286503L),

new System.Numerics.BigInteger(1479541061569951652L),

new System.Numerics.BigInteger(289796510727048503L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(61331716926344732L),

new System.Numerics.BigInteger(7808282972531590985L),

new System.Numerics.BigInteger(8564272404903850221L),

new System.Numerics.BigInteger(4445994006448457833L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1129830410732062042L),

new System.Numerics.BigInteger(4421188657346896641L),

new System.Numerics.BigInteger(3857091361903463059L),

new System.Numerics.BigInteger(2768648379991156895L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5152793403570161165L),

new System.Numerics.BigInteger(38231451624003946L),

new System.Numerics.BigInteger(7559271497694039211L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4954005811105678319L),

new System.Numerics.BigInteger(4202100699866407284L),

new System.Numerics.BigInteger(4191612665081513997L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1253136639401700391L),

new System.Numerics.BigInteger(7635961747384321420L),

new System.Numerics.BigInteger(6573673751428459824L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1193225728309629074L),

new System.Numerics.BigInteger(2799215683266272475L),

new System.Numerics.BigInteger(545136471924632545L),

new System.Numerics.BigInteger(7477241624760406911L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2196105516939925810L),

new System.Numerics.BigInteger(1060098176215320040L),

new System.Numerics.BigInteger(8938581536390100886L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8170664510306692345L),

new System.Numerics.BigInteger(4138255635620060962L),

new System.Numerics.BigInteger(5540260658040137607L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4479276413689444349L),

new System.Numerics.BigInteger(5329606668837135262L),

new System.Numerics.BigInteger(1828652911172170180L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6337744898049770361L),

new System.Numerics.BigInteger(3842467021207015690L),

new System.Numerics.BigInteger(5125841507591905982L),

new System.Numerics.BigInteger(7139178033083661647L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3509206216419052357L),

new System.Numerics.BigInteger(2866543963630463458L),

new System.Numerics.BigInteger(8158105986384907205L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7787783034490591983L),

new System.Numerics.BigInteger(1795713417112719201L),

new System.Numerics.BigInteger(7241433343437121462L),

new System.Numerics.BigInteger(7407274125551785400L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6209782373122689340L),

new System.Numerics.BigInteger(5834432222879344073L),

new System.Numerics.BigInteger(1363082589878619932L),

new System.Numerics.BigInteger(2149348034953985658L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4607216222548505019L),

new System.Numerics.BigInteger(6658734081514112437L),

new System.Numerics.BigInteger(4451609610175258152L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4828334987992795962L),

new System.Numerics.BigInteger(1618037700968717682L),

new System.Numerics.BigInteger(6982162365580651435L),

new System.Numerics.BigInteger(6806868345419835020L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9030145545280091657L),

new System.Numerics.BigInteger(8209158042750142575L),

new System.Numerics.BigInteger(7507548273007163656L),

new System.Numerics.BigInteger(2868847104712935005L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3198271366419324263L),

new System.Numerics.BigInteger(5973166791783805900L),

new System.Numerics.BigInteger(4160082778154815379L),

new System.Numerics.BigInteger(2256780243230800578L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2595324466591716819L),

new System.Numerics.BigInteger(4699583163869945939L),

new System.Numerics.BigInteger(7643093465592389102L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2709394488288925575L),

new System.Numerics.BigInteger(8327645577923527677L),

new System.Numerics.BigInteger(7542936381712472674L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4166054865498778677L),

new System.Numerics.BigInteger(5298691456631667185L),

new System.Numerics.BigInteger(855009582663469225L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7421680955375555944L),

new System.Numerics.BigInteger(5398178654292746658L),

new System.Numerics.BigInteger(1367926635250402488L),

new System.Numerics.BigInteger(6123696638896760187L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(245609600240864087L),

new System.Numerics.BigInteger(2095712288060151864L),

new System.Numerics.BigInteger(5990728027845809978L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4040290756160582065L),

new System.Numerics.BigInteger(3623415071203487399L),

new System.Numerics.BigInteger(6068325916718852924L),

new System.Numerics.BigInteger(8169939768452779822L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7199995478053384171L),

new System.Numerics.BigInteger(7386272565493451521L),

new System.Numerics.BigInteger(515040916766830020L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6840044116499739514L),

new System.Numerics.BigInteger(1730576242579527972L),

new System.Numerics.BigInteger(1534256348693305412L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8183942231481107533L),

new System.Numerics.BigInteger(3629646845976939425L),

new System.Numerics.BigInteger(7138100624000342065L),

new System.Numerics.BigInteger(2328888625643005286L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4183339795454437955L),

new System.Numerics.BigInteger(5441734841944971733L),

new System.Numerics.BigInteger(170443970232219479L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(350816298983245212L),

new System.Numerics.BigInteger(5886491207142630445L),

new System.Numerics.BigInteger(7128917489598382382L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6685877119877881725L),

new System.Numerics.BigInteger(6979583676916278948L),

new System.Numerics.BigInteger(3148165610992489276L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5112550248399354055L),

new System.Numerics.BigInteger(8001696052203439579L),

new System.Numerics.BigInteger(1873707025248744015L),

new System.Numerics.BigInteger(3446617390103801566L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4206159927093952112L),

new System.Numerics.BigInteger(6884319511626304510L),

new System.Numerics.BigInteger(3327463221963880579L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(311957761294833249L),

new System.Numerics.BigInteger(7954444586644783276L),

new System.Numerics.BigInteger(6646328716667977485L),

new System.Numerics.BigInteger(6559258035495324183L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4874781368381573424L),

new System.Numerics.BigInteger(733153362213391660L),

new System.Numerics.BigInteger(2829134223307352572L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(864963335456697150L),

new System.Numerics.BigInteger(3049632838403272259L),

new System.Numerics.BigInteger(1788590581480167500L),

new System.Numerics.BigInteger(3555263137433941746L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8632319661087085199L),

new System.Numerics.BigInteger(3394941382973122214L),

new System.Numerics.BigInteger(4480460415866588689L),

new System.Numerics.BigInteger(7568932251139567594L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8798750585171017229L),

new System.Numerics.BigInteger(1406289909177314303L),

new System.Numerics.BigInteger(6375889874227521349L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6071530967622019460L),

new System.Numerics.BigInteger(3398175264312857756L),

new System.Numerics.BigInteger(7332254639874026616L),

new System.Numerics.BigInteger(8091401988197903178L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6641201725800693745L),

new System.Numerics.BigInteger(6465970009478240143L),

new System.Numerics.BigInteger(1226171624034617907L),

new System.Numerics.BigInteger(6490536264880170597L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4054176813721192361L),

new System.Numerics.BigInteger(4960915257995087492L),

new System.Numerics.BigInteger(7872973229114862833L),

new System.Numerics.BigInteger(5840277943505467729L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8471960213738865277L),

new System.Numerics.BigInteger(5370668769070976803L),

new System.Numerics.BigInteger(189119480786442955L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3884779509603896301L),

new System.Numerics.BigInteger(5831533050356784630L),

new System.Numerics.BigInteger(957034637134557054L),

new System.Numerics.BigInteger(4951171310260628762L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2476226581764184562L),

new System.Numerics.BigInteger(8362989996705087435L),

new System.Numerics.BigInteger(3453946858828034934L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5192399064868905901L),

new System.Numerics.BigInteger(8309397525452208589L),

new System.Numerics.BigInteger(6777320555554534913L),

new System.Numerics.BigInteger(5464764429923488879L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(590447999842845477L),

new System.Numerics.BigInteger(5453079807243142948L),

new System.Numerics.BigInteger(6270250125971821271L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8568615986738739080L),

new System.Numerics.BigInteger(5295718949252071818L),

new System.Numerics.BigInteger(8969255972733075013L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1210330634289220503L),

new System.Numerics.BigInteger(6507463961343765384L),

new System.Numerics.BigInteger(1591234493976033805L),

new System.Numerics.BigInteger(8665029309527357948L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3098669296064358756L),

new System.Numerics.BigInteger(390612214854584019L),

new System.Numerics.BigInteger(1456561072805669796L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(593688479572760024L),

new System.Numerics.BigInteger(1043242724010225835L),

new System.Numerics.BigInteger(3372147866326738947L),

new System.Numerics.BigInteger(1471191143555554330L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(85191372132899116L),

new System.Numerics.BigInteger(6830015745565093848L),

new System.Numerics.BigInteger(2671457233330269690L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1604870513417706693L),

new System.Numerics.BigInteger(3577612764263588874L),

new System.Numerics.BigInteger(2899873654924218971L),

new System.Numerics.BigInteger(5041748732059956474L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8071279338452444854L),

new System.Numerics.BigInteger(3658670497018480264L),

new System.Numerics.BigInteger(8818924339225403841L),

new System.Numerics.BigInteger(884566310773927682L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3209120856608353696L),

new System.Numerics.BigInteger(88588308707984823L),

new System.Numerics.BigInteger(8313826567344393647L),

new System.Numerics.BigInteger(1221955220656827283L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4093354222844990680L),

new System.Numerics.BigInteger(8908287707037160967L),

new System.Numerics.BigInteger(6021263566771929117L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5200136660879734731L),

new System.Numerics.BigInteger(8343843284739474180L),

new System.Numerics.BigInteger(8518611292464493641L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7361915923641292237L),

new System.Numerics.BigInteger(1854416245118366971L),

new System.Numerics.BigInteger(7109042550567146867L),

new System.Numerics.BigInteger(4048712837146755484L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8485299715589889709L),

new System.Numerics.BigInteger(1633952072303372325L),

new System.Numerics.BigInteger(8739597694796499480L),

new System.Numerics.BigInteger(5757524963620313231L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7098709120627317353L),

new System.Numerics.BigInteger(8517270622243742653L),

new System.Numerics.BigInteger(7221074626637591812L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7832287581357083264L),

new System.Numerics.BigInteger(7427261279084601558L),

new System.Numerics.BigInteger(2234696712381948536L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3511602898505837641L),

new System.Numerics.BigInteger(3087615260853577764L),

new System.Numerics.BigInteger(173016336630798087L),

new System.Numerics.BigInteger(4754594419037540782L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3184741525882997295L),

new System.Numerics.BigInteger(9167753127250114248L),

new System.Numerics.BigInteger(8008713645284664974L),

new System.Numerics.BigInteger(2199437441834117215L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8142284533873258263L),

new System.Numerics.BigInteger(677316729144097206L),

new System.Numerics.BigInteger(8864422613961377435L),

new System.Numerics.BigInteger(5858690851607872899L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8773238276046632610L),

new System.Numerics.BigInteger(3264417520186790555L),

new System.Numerics.BigInteger(6161421298885457041L),

new System.Numerics.BigInteger(672815941652658739L),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
INSERT INTO public.bigintegernumericlistd1e2mi(
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
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)), 
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
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
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
                List<BigIntegernumericListD1E2M> models = null;

                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericListD1E2M> models = null;

                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 55;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 119, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 88, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 112, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 46, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 55, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 89, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 68, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 43, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[19], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[20], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[21], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[13],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[14],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[15],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MI),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericListD1E2M),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
FROM public.binary_bigintegernumericlistd1e2m m
LEFT JOIN public.binary_bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models =  ((IBigIntegerListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
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
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI), typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                await ((IBigIntegerListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                ((IBigIntegerListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

