

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8872105869645284450L),

new System.Numerics.BigInteger(4297680929276519297L),

new System.Numerics.BigInteger(7860242174277766776L),

new System.Numerics.BigInteger(6465374752980573095L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5948420033179732318L),

new System.Numerics.BigInteger(6280781720942475990L),

new System.Numerics.BigInteger(6001045219437172177L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1084359243898987079L),

new System.Numerics.BigInteger(4161876514396608084L),

new System.Numerics.BigInteger(5607736071586544984L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5862889952212716670L),

new System.Numerics.BigInteger(3438577176831664129L),

new System.Numerics.BigInteger(4363616400397418889L),

new System.Numerics.BigInteger(4875981781974044452L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9076833342452882527L),

new System.Numerics.BigInteger(9092500335518552801L),

new System.Numerics.BigInteger(4074007085975647982L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6290337729152547056L),

new System.Numerics.BigInteger(184785178513150016L),

new System.Numerics.BigInteger(2228857711827145882L),

new System.Numerics.BigInteger(7816004076024639985L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1641320892800935066L),

new System.Numerics.BigInteger(2468958440696875965L),

new System.Numerics.BigInteger(6467202747649221787L),

new System.Numerics.BigInteger(4441418628363638115L),

},
},
            new BigIntegernumericArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4984185467579665892L),

new System.Numerics.BigInteger(3819622173851535957L),

new System.Numerics.BigInteger(6805028090867147967L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3807866127167210632L),

new System.Numerics.BigInteger(5040754657638169919L),

new System.Numerics.BigInteger(3627409221360448460L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3699078271628000036L),

new System.Numerics.BigInteger(8985425767861614022L),

new System.Numerics.BigInteger(4664913735936510594L),

new System.Numerics.BigInteger(4724297388030085753L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3746339318565099401L),

new System.Numerics.BigInteger(6872858817810319444L),

new System.Numerics.BigInteger(8859269727362481987L),

new System.Numerics.BigInteger(2069695407361370729L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3797567552152508035L),

new System.Numerics.BigInteger(8340457347980140888L),

new System.Numerics.BigInteger(8995002387250125549L),

new System.Numerics.BigInteger(996654645926712079L),

},
},
            new BigIntegernumericArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4951507505562960690L),

new System.Numerics.BigInteger(3419161480077224116L),

new System.Numerics.BigInteger(1175809729649725559L),

new System.Numerics.BigInteger(1116192848698329916L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5911803010723366537L),

new System.Numerics.BigInteger(8494511084290803950L),

new System.Numerics.BigInteger(505834419130946276L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3211936808881378494L),

new System.Numerics.BigInteger(4580184287934139813L),

new System.Numerics.BigInteger(8212940587542978310L),

new System.Numerics.BigInteger(685495640871421406L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5784218763176247340L),

new System.Numerics.BigInteger(644797736695918100L),

new System.Numerics.BigInteger(5633095364711308516L),

},
},
            new BigIntegernumericArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4331884902035078637L),

new System.Numerics.BigInteger(6132263590513954721L),

new System.Numerics.BigInteger(1390384505623958008L),

new System.Numerics.BigInteger(8689050640243188955L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7179645541094852138L),

new System.Numerics.BigInteger(4321976869813720661L),

new System.Numerics.BigInteger(1879669190214635920L),

},
},
            new BigIntegernumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4448066628847809711L),

new System.Numerics.BigInteger(6879822520779061687L),

new System.Numerics.BigInteger(4454846663933708576L),

new System.Numerics.BigInteger(87976033602377924L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8107569921014253175L),

new System.Numerics.BigInteger(7639629868046411868L),

new System.Numerics.BigInteger(591345646749057547L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1729776296516249228L),

new System.Numerics.BigInteger(9184587430256876957L),

new System.Numerics.BigInteger(1220714925559718886L),

},
},
            new BigIntegernumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3470662070182018359L),

new System.Numerics.BigInteger(1123221420124685878L),

new System.Numerics.BigInteger(4215954701359136115L),

new System.Numerics.BigInteger(7814694671659431834L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6203399996698420884L),

new System.Numerics.BigInteger(1320146482884423304L),

new System.Numerics.BigInteger(5972504540288670657L),

new System.Numerics.BigInteger(7951856456648620998L),

},
},
            new BigIntegernumericArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7222143707778706362L),

new System.Numerics.BigInteger(3372540794689212789L),

new System.Numerics.BigInteger(499423520183084312L),

new System.Numerics.BigInteger(5637782462009534509L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6526406819479481757L),

new System.Numerics.BigInteger(1154747006363307531L),

new System.Numerics.BigInteger(287339120758690859L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6179217266819627570L),

new System.Numerics.BigInteger(2901880935368009334L),

new System.Numerics.BigInteger(2748178054284305617L),

new System.Numerics.BigInteger(5345241463789870364L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8283855966327000218L),

new System.Numerics.BigInteger(1952997780615367915L),

new System.Numerics.BigInteger(3622532400167701451L),

},
},
            new BigIntegernumericArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3495307635440353344L),

new System.Numerics.BigInteger(5391589561836892953L),

new System.Numerics.BigInteger(3441102365854252028L),

new System.Numerics.BigInteger(2626150340905278739L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8441613996978799219L),

new System.Numerics.BigInteger(8960699583459012666L),

new System.Numerics.BigInteger(4314456291256823662L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6715047144920513071L),

new System.Numerics.BigInteger(7574935394317115205L),

new System.Numerics.BigInteger(8295464779106680993L),

},
},
            new BigIntegernumericArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2735352598842400370L),

new System.Numerics.BigInteger(3055558607646337479L),

new System.Numerics.BigInteger(2481991639064598639L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4803579562012517340L),

new System.Numerics.BigInteger(3523565998108573135L),

new System.Numerics.BigInteger(4622197423342749049L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3156449232809952826L),

new System.Numerics.BigInteger(5582504788220735273L),

new System.Numerics.BigInteger(8474611981831463751L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2888390794241795069L),

new System.Numerics.BigInteger(4335482622910442097L),

new System.Numerics.BigInteger(1263686408050887836L),

new System.Numerics.BigInteger(4438746410800577549L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9023940419406507174L),

new System.Numerics.BigInteger(2446983455003733349L),

new System.Numerics.BigInteger(3844603389712399407L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(419538236124110111L),

new System.Numerics.BigInteger(4842091098945484690L),

new System.Numerics.BigInteger(7242256664499149805L),

new System.Numerics.BigInteger(29907387854556427L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1275909267761647888L),

new System.Numerics.BigInteger(6741193773688810309L),

new System.Numerics.BigInteger(6881226326763065359L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3724049951445627104L),

new System.Numerics.BigInteger(3858512384598464569L),

new System.Numerics.BigInteger(7320496287519340233L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7932163186684205314L),

new System.Numerics.BigInteger(4651480126434668619L),

new System.Numerics.BigInteger(5104785395361171180L),

new System.Numerics.BigInteger(3471112013012011586L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5135605600120547828L),

new System.Numerics.BigInteger(5748985565163527058L),

new System.Numerics.BigInteger(2264948690182629565L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(379696236978229030L),

new System.Numerics.BigInteger(5761866361746401123L),

new System.Numerics.BigInteger(7633810084652300913L),

new System.Numerics.BigInteger(1078814984988492773L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6956104855621922498L),

new System.Numerics.BigInteger(337393088627810146L),

new System.Numerics.BigInteger(406483133357154238L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(620460677768846759L),

new System.Numerics.BigInteger(7894043722513037919L),

new System.Numerics.BigInteger(6753521585601652114L),

},
},
            new BigIntegernumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5765027523309290954L),

new System.Numerics.BigInteger(6589441257383485204L),

new System.Numerics.BigInteger(431943804367541115L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5536672628433101350L),

new System.Numerics.BigInteger(6024203960062908942L),

new System.Numerics.BigInteger(6799335937609161489L),

new System.Numerics.BigInteger(5997675718600302111L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3373827569421133151L),

new System.Numerics.BigInteger(7063860104892560618L),

new System.Numerics.BigInteger(4518257827267969994L),

new System.Numerics.BigInteger(2617699204540526294L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3278778824917899648L),

new System.Numerics.BigInteger(4413698517651205558L),

new System.Numerics.BigInteger(182346656887226570L),

new System.Numerics.BigInteger(1809254527039122224L),

},
},
            new BigIntegernumericArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3165614008697253837L),

new System.Numerics.BigInteger(3327360521596437783L),

new System.Numerics.BigInteger(1586983352814282901L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3319318204357956081L),

new System.Numerics.BigInteger(7376510169182864293L),

new System.Numerics.BigInteger(6291522438932583286L),

new System.Numerics.BigInteger(4479895054453929635L),

},
},
            new BigIntegernumericArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1502216452762438464L),

new System.Numerics.BigInteger(6249549621647438611L),

new System.Numerics.BigInteger(7071783595248789131L),

new System.Numerics.BigInteger(1975584847783484296L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(417667139896169493L),

new System.Numerics.BigInteger(8682753568655838910L),

new System.Numerics.BigInteger(7842662637156439278L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3704060396978077080L),

new System.Numerics.BigInteger(5062013579801095970L),

new System.Numerics.BigInteger(9147668500495066636L),

},
},
            new BigIntegernumericArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8867672528234222335L),

new System.Numerics.BigInteger(5819195216902558705L),

new System.Numerics.BigInteger(6405651393261110903L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(549302626463539938L),

new System.Numerics.BigInteger(6268092404714902085L),

new System.Numerics.BigInteger(8621070752143485041L),

new System.Numerics.BigInteger(2718011924560370703L),

},
},
            new BigIntegernumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6679795153781972739L),

new System.Numerics.BigInteger(976600389987964115L),

new System.Numerics.BigInteger(1997591395733005132L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5352349678316980394L),

new System.Numerics.BigInteger(2468679688579142006L),

new System.Numerics.BigInteger(6282865397529179956L),

new System.Numerics.BigInteger(8360240510643364406L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8299662852587107489L),

new System.Numerics.BigInteger(149598162180809615L),

new System.Numerics.BigInteger(2492907569172496780L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6038508194652211204L),

new System.Numerics.BigInteger(7562484731299587194L),

new System.Numerics.BigInteger(7776175460343428144L),

},
},
            new BigIntegernumericArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1907510335118343970L),

new System.Numerics.BigInteger(7989173959288745148L),

new System.Numerics.BigInteger(145315230758115730L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6984706840175778417L),

new System.Numerics.BigInteger(7636027481653481625L),

new System.Numerics.BigInteger(5681163375800913195L),

new System.Numerics.BigInteger(1117698589040492566L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4448951282683699641L),

new System.Numerics.BigInteger(4699593699977490816L),

new System.Numerics.BigInteger(8507425832810992087L),

new System.Numerics.BigInteger(6638373671221174332L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7654740686834999465L),

new System.Numerics.BigInteger(5499102345367693732L),

new System.Numerics.BigInteger(3578429517457515221L),

new System.Numerics.BigInteger(5952377273469770711L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(560708457975734500L),

new System.Numerics.BigInteger(1374779180329907534L),

new System.Numerics.BigInteger(8996027453222439851L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7030385976050360427L),

new System.Numerics.BigInteger(189133213398393378L),

new System.Numerics.BigInteger(3904200681467637299L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2397122096441808499L),

new System.Numerics.BigInteger(1328222138493089669L),

new System.Numerics.BigInteger(4518579006645527542L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4696743280803791924L),

new System.Numerics.BigInteger(3127796150825039508L),

new System.Numerics.BigInteger(3949150594594692827L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3350337286560090867L),

new System.Numerics.BigInteger(816904449138023695L),

new System.Numerics.BigInteger(7638452565446608445L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3893293912354903837L),

new System.Numerics.BigInteger(79008605744949498L),

new System.Numerics.BigInteger(6489175094492871216L),

new System.Numerics.BigInteger(8067352911649979640L),

},
},
            new BigIntegernumericArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3694963384002138399L),

new System.Numerics.BigInteger(7360828385555640801L),

new System.Numerics.BigInteger(2387880913087031180L),

new System.Numerics.BigInteger(4380174358230662438L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8566726658581038142L),

new System.Numerics.BigInteger(7351769271634287429L),

new System.Numerics.BigInteger(1853460937104901999L),

},
},
            new BigIntegernumericArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(565086166175731995L),

new System.Numerics.BigInteger(8309204588607116542L),

new System.Numerics.BigInteger(7493612140032459306L),

new System.Numerics.BigInteger(3900794910792732288L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5281136692684739852L),

new System.Numerics.BigInteger(2321831806055882804L),

new System.Numerics.BigInteger(4898905399572064317L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3231651038299545524L),

new System.Numerics.BigInteger(2691498325475528040L),

new System.Numerics.BigInteger(8921737863670886596L),

new System.Numerics.BigInteger(4606992839957174143L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6783254471882862327L),

new System.Numerics.BigInteger(7525399544717593441L),

new System.Numerics.BigInteger(6412072803017031996L),

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

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

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
                        BigIntegernumericArray2M.AssertModel(models[29],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[30],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[31],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[32],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[33],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 121, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 59, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 157, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 85, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[34], false);
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
                await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 1, query1, 1, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 151, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[34], false);
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
                 ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 13, query1, 76, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 99, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        BigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);
                        BigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);
                        BigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);
                        BigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);
                        BigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);
                        BigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);
                        BigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);
                        BigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);
                        BigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);
                        BigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);
                        BigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);
                        BigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);
                        BigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);
                        BigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
                        BigIntegernumericArray2M.AssertModel(models[14],_testData[30], false);
                        BigIntegernumericArray2M.AssertModel(models[15],_testData[31], false);
                        BigIntegernumericArray2M.AssertModel(models[16],_testData[32], false);
                        BigIntegernumericArray2M.AssertModel(models[17],_testData[33], false);
                        BigIntegernumericArray2M.AssertModel(models[18],_testData[34], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                BigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);
                BigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);
                BigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);
                BigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);
                BigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);
                BigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);
                BigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);
                BigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);
                BigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);
                BigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);
                BigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);
                BigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);
                BigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);
                BigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);
                BigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);
                BigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);
                BigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);
                BigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);
                BigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);
                BigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);
                BigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);
                BigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);
                BigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);
                BigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
                BigIntegernumericArray2M.AssertModel(models[24],_testData[30], false);
                BigIntegernumericArray2M.AssertModel(models[25],_testData[31], false);
                BigIntegernumericArray2M.AssertModel(models[26],_testData[32], false);
                BigIntegernumericArray2M.AssertModel(models[27],_testData[33], false);
                BigIntegernumericArray2M.AssertModel(models[28],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((IBigIntegerListnumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((IBigIntegerListnumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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

        [Test, Order(13)]
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
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray2mi
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
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI), typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models1 = new List<BigIntegernumericArray2MI>();
                var models2 = new List<BigIntegernumericArray2MI>();
                await ((IBigIntegerListnumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MI>();
                var models2 = new List<BigIntegernumericArray2MI>();
                ((IBigIntegerListnumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)),
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
                var models = await ((IBigIntegerListnumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA), typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                await ((IBigIntegerListnumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray2MIWA>();
                var models2 = new List<BigIntegernumericArray2MIWA>();
                ((IBigIntegerListnumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray))]
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
                var models = await ((IBigIntegerListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerListnumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

