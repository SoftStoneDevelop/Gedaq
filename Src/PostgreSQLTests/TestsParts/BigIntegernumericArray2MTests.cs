

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
new System.Numerics.BigInteger(4408661342645562981L),

new System.Numerics.BigInteger(7950892138416677302L),

new System.Numerics.BigInteger(5728651590693324664L),

new System.Numerics.BigInteger(95975167004651927L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1844440544388141614L),

new System.Numerics.BigInteger(8055720576806940627L),

new System.Numerics.BigInteger(4815178898817871399L),

new System.Numerics.BigInteger(5727194980495052155L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3034627344044552405L),

new System.Numerics.BigInteger(832536463768139754L),

new System.Numerics.BigInteger(7039375947340955148L),

new System.Numerics.BigInteger(2341613984607818109L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7314521608059860825L),

new System.Numerics.BigInteger(776190385153788129L),

new System.Numerics.BigInteger(2834853791622338917L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7552420501358084874L),

new System.Numerics.BigInteger(5179022030624171006L),

new System.Numerics.BigInteger(8910034411204358199L),

new System.Numerics.BigInteger(2349998446604359755L),

},
},
            new BigIntegernumericArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(658816810406502470L),

new System.Numerics.BigInteger(340693611656146540L),

new System.Numerics.BigInteger(9030451056447769516L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4083320472942385971L),

new System.Numerics.BigInteger(6618604134136301515L),

new System.Numerics.BigInteger(2859714940427032741L),

new System.Numerics.BigInteger(2119812244158625872L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1301355832230314764L),

new System.Numerics.BigInteger(8935136690980569268L),

new System.Numerics.BigInteger(5997445713670619368L),

},
},
            new BigIntegernumericArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1924483764898602729L),

new System.Numerics.BigInteger(4621040054342141706L),

new System.Numerics.BigInteger(680865271683370121L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1757132501903258577L),

new System.Numerics.BigInteger(4998885684875514913L),

new System.Numerics.BigInteger(369829478589173600L),

},
},
            new BigIntegernumericArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6739538540054370748L),

new System.Numerics.BigInteger(2209541048136063989L),

new System.Numerics.BigInteger(132282579858120529L),

new System.Numerics.BigInteger(5561001031649315499L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5390558850407949383L),

new System.Numerics.BigInteger(7787606475224348407L),

new System.Numerics.BigInteger(3098325826585939053L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5142499310545177153L),

new System.Numerics.BigInteger(760713432178331233L),

new System.Numerics.BigInteger(7947371743367434486L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7489176352586875908L),

new System.Numerics.BigInteger(1968913400811622774L),

new System.Numerics.BigInteger(8560295556229820540L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5528128409978909713L),

new System.Numerics.BigInteger(6408625313644293230L),

new System.Numerics.BigInteger(5839703543051209162L),

new System.Numerics.BigInteger(6132064245116149745L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(475691401386856979L),

new System.Numerics.BigInteger(3604589710005772859L),

new System.Numerics.BigInteger(2565481228996699753L),

},
},
            new BigIntegernumericArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(753711789656758989L),

new System.Numerics.BigInteger(7997534763409690437L),

new System.Numerics.BigInteger(1700245858822033908L),

new System.Numerics.BigInteger(8859976513163867206L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3368391061271975386L),

new System.Numerics.BigInteger(3331662282631134955L),

new System.Numerics.BigInteger(6964024373643210139L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7216878636179215692L),

new System.Numerics.BigInteger(2698550939645971925L),

new System.Numerics.BigInteger(3216183655624634593L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8402396409862710921L),

new System.Numerics.BigInteger(4767452552656844023L),

new System.Numerics.BigInteger(5075390065407657626L),

},
},
            new BigIntegernumericArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4807488381365350773L),

new System.Numerics.BigInteger(5985131832911318066L),

new System.Numerics.BigInteger(3997513907562369247L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1473683098598637200L),

new System.Numerics.BigInteger(8758832883280583708L),

new System.Numerics.BigInteger(4076911416047409108L),

},
},
            new BigIntegernumericArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7711680482003636582L),

new System.Numerics.BigInteger(6891871015561747896L),

new System.Numerics.BigInteger(4975102345660332347L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7804571568060292063L),

new System.Numerics.BigInteger(2323326451006177721L),

new System.Numerics.BigInteger(8346532741846834060L),

new System.Numerics.BigInteger(8445933803408567181L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8330137992817846252L),

new System.Numerics.BigInteger(2547491872517000178L),

new System.Numerics.BigInteger(1745530192390736159L),

new System.Numerics.BigInteger(5204918730005239056L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4469432092711364265L),

new System.Numerics.BigInteger(7009835104753923498L),

new System.Numerics.BigInteger(6078464417004673727L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8559395769333282035L),

new System.Numerics.BigInteger(768214149851299498L),

new System.Numerics.BigInteger(6523334738890570366L),

},
},
            new BigIntegernumericArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1119128953554359843L),

new System.Numerics.BigInteger(7131242679143604732L),

new System.Numerics.BigInteger(4782689398245208524L),

new System.Numerics.BigInteger(6687481775982708109L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5728744568350835982L),

new System.Numerics.BigInteger(4117089800241013583L),

new System.Numerics.BigInteger(869595717867061122L),

new System.Numerics.BigInteger(8219497208094216415L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9047887685573448831L),

new System.Numerics.BigInteger(8244593794349803026L),

new System.Numerics.BigInteger(8418539797773533560L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4036810553290153790L),

new System.Numerics.BigInteger(7490336962023403483L),

new System.Numerics.BigInteger(6900046934262406035L),

new System.Numerics.BigInteger(902492987952035696L),

},
},
            new BigIntegernumericArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(712707319871106375L),

new System.Numerics.BigInteger(8202082757494582369L),

new System.Numerics.BigInteger(734532477013866971L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4503740959272993901L),

new System.Numerics.BigInteger(1095556021007307212L),

new System.Numerics.BigInteger(7296216179284595537L),

new System.Numerics.BigInteger(61394584050404139L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7693663445906904175L),

new System.Numerics.BigInteger(4281559474794164843L),

new System.Numerics.BigInteger(8005369529930081563L),

new System.Numerics.BigInteger(6594559940048945938L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8882543504162821818L),

new System.Numerics.BigInteger(6598638808618547923L),

new System.Numerics.BigInteger(9055593593495089631L),

},
},
            new BigIntegernumericArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8602751268669836982L),

new System.Numerics.BigInteger(131510169486214909L),

new System.Numerics.BigInteger(8067805130480035539L),

new System.Numerics.BigInteger(2729131714608315483L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1467338027627501426L),

new System.Numerics.BigInteger(4400718074410623736L),

new System.Numerics.BigInteger(3394641926013940918L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5603452855785579357L),

new System.Numerics.BigInteger(698458648670793957L),

new System.Numerics.BigInteger(8992590586735414757L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7531635603205138472L),

new System.Numerics.BigInteger(5217734424196005475L),

new System.Numerics.BigInteger(4078054569749867738L),

new System.Numerics.BigInteger(36662737525175399L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6234916579223737436L),

new System.Numerics.BigInteger(2318373542305140032L),

new System.Numerics.BigInteger(5403224674900583808L),

},
},
            new BigIntegernumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6224500847764317909L),

new System.Numerics.BigInteger(7942991966259871938L),

new System.Numerics.BigInteger(5442108721126584499L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8583358440842206622L),

new System.Numerics.BigInteger(5586760105529981467L),

new System.Numerics.BigInteger(7602080853297659832L),

new System.Numerics.BigInteger(6892578194373669031L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(202152901350790872L),

new System.Numerics.BigInteger(1834736961284774702L),

new System.Numerics.BigInteger(8703614140185393568L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8744083595539499348L),

new System.Numerics.BigInteger(4410149806303665823L),

new System.Numerics.BigInteger(4427348348788511547L),

},
},
    NullableValue = null,
},
            new BigIntegernumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8153952631963349524L),

new System.Numerics.BigInteger(1850005550552193348L),

new System.Numerics.BigInteger(3201474851029851779L),

new System.Numerics.BigInteger(363219841295317940L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6854863039799889000L),

new System.Numerics.BigInteger(312533136455420559L),

new System.Numerics.BigInteger(999499505514364327L),

},
},
            new BigIntegernumericArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3540078879784589064L),

new System.Numerics.BigInteger(7350182685419610455L),

new System.Numerics.BigInteger(4986486018113145790L),

new System.Numerics.BigInteger(7537653494502004699L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8626597561611324442L),

new System.Numerics.BigInteger(9160412227253521296L),

new System.Numerics.BigInteger(4268695458983041639L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2124276956641111119L),

new System.Numerics.BigInteger(1963842240625468710L),

new System.Numerics.BigInteger(4942939668476324272L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2114408465496758212L),

new System.Numerics.BigInteger(9048786427856329387L),

new System.Numerics.BigInteger(1247212201333686864L),

},
},
            new BigIntegernumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6230205466804276009L),

new System.Numerics.BigInteger(632958257730909756L),

new System.Numerics.BigInteger(1604955564740173485L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8907787865457718865L),

new System.Numerics.BigInteger(2739388944100743826L),

new System.Numerics.BigInteger(6491588193528157708L),

},
},
            new BigIntegernumericArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9174504293025904618L),

new System.Numerics.BigInteger(1461880644972132931L),

new System.Numerics.BigInteger(5096832679936497567L),

new System.Numerics.BigInteger(4851403737782027927L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1615482501623902845L),

new System.Numerics.BigInteger(6532457740921450798L),

new System.Numerics.BigInteger(363967007140173628L),

new System.Numerics.BigInteger(1224784778277163292L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1579465610306282918L),

new System.Numerics.BigInteger(1326623142089358066L),

new System.Numerics.BigInteger(4453120509721102198L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7883237860892606848L),

new System.Numerics.BigInteger(5023460634881061853L),

new System.Numerics.BigInteger(7836332086594422019L),

new System.Numerics.BigInteger(135746792052068798L),

},
},
            new BigIntegernumericArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2462610937193167831L),

new System.Numerics.BigInteger(217989534037313531L),

new System.Numerics.BigInteger(2459863023016144815L),

new System.Numerics.BigInteger(2546278265939919994L),

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
new System.Numerics.BigInteger(1277906884367834273L),

new System.Numerics.BigInteger(8737303848125175605L),

new System.Numerics.BigInteger(7574177191473151248L),

new System.Numerics.BigInteger(5252436296469800697L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1398602040009481409L),

new System.Numerics.BigInteger(6613971788405575969L),

new System.Numerics.BigInteger(7373364339133875692L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6305884968814463414L),

new System.Numerics.BigInteger(8041683897489164213L),

new System.Numerics.BigInteger(2886602147183976694L),

},
},
            new BigIntegernumericArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2034839878620274040L),

new System.Numerics.BigInteger(6544281998476905466L),

new System.Numerics.BigInteger(5459696778989800075L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1090849919663328233L),

new System.Numerics.BigInteger(1977700227735721687L),

new System.Numerics.BigInteger(2300669956672275502L),

},
},
            new BigIntegernumericArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6082109348529941820L),

new System.Numerics.BigInteger(1177351491583981525L),

new System.Numerics.BigInteger(273202603903810730L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7293073878316030311L),

new System.Numerics.BigInteger(8739225102273502090L),

new System.Numerics.BigInteger(1128465048981223861L),

new System.Numerics.BigInteger(4570338941525450113L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8826413037930484138L),

new System.Numerics.BigInteger(905345585775664630L),

new System.Numerics.BigInteger(2885264279779087657L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4700764864683244366L),

new System.Numerics.BigInteger(5405725548768897790L),

new System.Numerics.BigInteger(144907906828330159L),

new System.Numerics.BigInteger(2767864264403429256L),

},
},
            new BigIntegernumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3035473603167686974L),

new System.Numerics.BigInteger(1984269687928640694L),

new System.Numerics.BigInteger(845867454049832971L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6459093319535110301L),

new System.Numerics.BigInteger(6556845006139285256L),

new System.Numerics.BigInteger(2036774439151282234L),

},
},
            new BigIntegernumericArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(9133754456820492745L),

new System.Numerics.BigInteger(718717617989933249L),

new System.Numerics.BigInteger(4141861449447478403L),

},
    ModelInner = new BigIntegernumericArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5809207287783685327L),

new System.Numerics.BigInteger(7027872048798891762L),

new System.Numerics.BigInteger(1810654215987549579L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5076770723571922599L),

new System.Numerics.BigInteger(1953441848200608515L),

new System.Numerics.BigInteger(502434059245956427L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6315305587270738606L),

new System.Numerics.BigInteger(3224212328525720146L),

new System.Numerics.BigInteger(5697204683460715392L),

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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IBigIntegerListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IBigIntegerListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IBigIntegerListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[3], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[4], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[5], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[6], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[7], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[8], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[9], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[10], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[11], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[12], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[13], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[14], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[15], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[25],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[15], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[7], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[8], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[9], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[10], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[11], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[12], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[13], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[14], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[15], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
BigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
BigIntegernumericArray2M.AssertModel(models[0],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
BigIntegernumericArray2M.AssertModel(models[0],_testData[3], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[4], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[5], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[6], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[7], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[23],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[24],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[25],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
BigIntegernumericArray2M.AssertModel(models[0],_testData[6], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[7], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[5], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[6], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[7], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[8], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[9], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[10], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[11], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[12], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[13], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[14], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[15], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[23],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[7], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[8], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[9], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[10], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[11], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[12], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[13], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[14], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[15], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[18],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[19],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[20],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[21],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
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
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatBigIntegernumericArray2M.AssertModel(models[0],_testData[12], false);FlatBigIntegernumericArray2M.AssertModel(models[1],_testData[13], false);FlatBigIntegernumericArray2M.AssertModel(models[2],_testData[14], false);FlatBigIntegernumericArray2M.AssertModel(models[3],_testData[15], false);FlatBigIntegernumericArray2M.AssertModel(models[4],_testData[16], false);FlatBigIntegernumericArray2M.AssertModel(models[5],_testData[17], false);FlatBigIntegernumericArray2M.AssertModel(models[6],_testData[18], false);FlatBigIntegernumericArray2M.AssertModel(models[7],_testData[19], false);FlatBigIntegernumericArray2M.AssertModel(models[8],_testData[20], false);FlatBigIntegernumericArray2M.AssertModel(models[9],_testData[21], false);FlatBigIntegernumericArray2M.AssertModel(models[10],_testData[22], false);FlatBigIntegernumericArray2M.AssertModel(models[11],_testData[23], false);FlatBigIntegernumericArray2M.AssertModel(models[12],_testData[24], false);FlatBigIntegernumericArray2M.AssertModel(models[13],_testData[25], false);FlatBigIntegernumericArray2M.AssertModel(models[14],_testData[26], false);FlatBigIntegernumericArray2M.AssertModel(models[15],_testData[27], false);FlatBigIntegernumericArray2M.AssertModel(models[16],_testData[28], false);FlatBigIntegernumericArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericArray)this).DbConnectionSelectModelBatchAsync(connection, 74, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
BigIntegernumericArray2M.AssertModel(models[0],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
BigIntegernumericArray2M.AssertModel(models[0],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((IBigIntegerListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    BigIntegernumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericArray)this).DbConnectionSelectModelBatch(connection, 39, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
BigIntegernumericArray2M.AssertModel(models[0],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
BigIntegernumericArray2M.AssertModel(models[0],_testData[5], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[6], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[7], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[23],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[24],_testData[29], false);
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
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
BigIntegernumericArray2M.AssertModel(models[0],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
BigIntegernumericArray2M.AssertModel(models[0],_testData[1], false);BigIntegernumericArray2M.AssertModel(models[1],_testData[2], false);BigIntegernumericArray2M.AssertModel(models[2],_testData[3], false);BigIntegernumericArray2M.AssertModel(models[3],_testData[4], false);BigIntegernumericArray2M.AssertModel(models[4],_testData[5], false);BigIntegernumericArray2M.AssertModel(models[5],_testData[6], false);BigIntegernumericArray2M.AssertModel(models[6],_testData[7], false);BigIntegernumericArray2M.AssertModel(models[7],_testData[8], false);BigIntegernumericArray2M.AssertModel(models[8],_testData[9], false);BigIntegernumericArray2M.AssertModel(models[9],_testData[10], false);BigIntegernumericArray2M.AssertModel(models[10],_testData[11], false);BigIntegernumericArray2M.AssertModel(models[11],_testData[12], false);BigIntegernumericArray2M.AssertModel(models[12],_testData[13], false);BigIntegernumericArray2M.AssertModel(models[13],_testData[14], false);BigIntegernumericArray2M.AssertModel(models[14],_testData[15], false);BigIntegernumericArray2M.AssertModel(models[15],_testData[16], false);BigIntegernumericArray2M.AssertModel(models[16],_testData[17], false);BigIntegernumericArray2M.AssertModel(models[17],_testData[18], false);BigIntegernumericArray2M.AssertModel(models[18],_testData[19], false);BigIntegernumericArray2M.AssertModel(models[19],_testData[20], false);BigIntegernumericArray2M.AssertModel(models[20],_testData[21], false);BigIntegernumericArray2M.AssertModel(models[21],_testData[22], false);BigIntegernumericArray2M.AssertModel(models[22],_testData[23], false);BigIntegernumericArray2M.AssertModel(models[23],_testData[24], false);BigIntegernumericArray2M.AssertModel(models[24],_testData[25], false);BigIntegernumericArray2M.AssertModel(models[25],_testData[26], false);BigIntegernumericArray2M.AssertModel(models[26],_testData[27], false);BigIntegernumericArray2M.AssertModel(models[27],_testData[28], false);BigIntegernumericArray2M.AssertModel(models[28],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
        private void ImportModelInnerConfig()
        {
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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<BigIntegernumericArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IBigIntegerListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IBigIntegerListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IBigIntegerListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericArray)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}

